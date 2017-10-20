--/* Notes

--Process:  
--  1. Version and previous version values are checked for each release and checked against SystemVersionHistory table in each database. 
--  2. *** Developer Input Here - Execute the DDL with checks for existence of object (note:  test table and column are used, below)
--  3. *** Developer Input Here - Execute and data update/insert/deletes here, assuming the requisite schema changes are in place
--  4. Update the SystemVersionHistory to the new version.

--To use this script, open the PowerShell file (same release folder) in PowerShell ISE and run.  
--When finished, look at the dbo.Log table in DB_ZHEALTH for results.  If all SeverityType entries are 'Low', then it executed successfully


--Change Log:
--  2.1. Column change from BalloonDilation to PostStentBalloonDilation on table dbo.ProcedureStent
--		(***Note:   This change does not follow the normal additive approach, but is allowable
--					because the table is new and contains no data.  Essentially this is a fix
--					to a table that did not exist in the previous version. *** )

--  3.1. Updated set of dbo.ActionHandler data to support CaseImport
--  3.2. Updated set of dbo.SystemConfiguration data to support CaseImport
--*/
 
 
---------------------------------------------------------------------
--User Custom Variables
---------------------------------------------------------------------
DECLARE @cID UNIQUEIDENTIFIER, @database VARCHAR(50), @logDesc VARCHAR(200);
SET @cID = NewID();
SET @database = 'DB_ZHEALTH';

USE DB_ZHEALTH;	--NOTE:  Using the variable @database didn't set which database is used.  Needed this call to actually set it correctly

--1a. *******SET THE FOLLOWING VALUES ACCURATELY*****************
--THESE VARIABLES REPRESENTS THE RELEASE SCRIPT'S VERSION, OR THE PREVIOUS VERSION.  BOTH REPRESENT VALID RELEASE VALUES.
--THE VALUE SHOULD MATCH THE VERSION OF THE FILE/FOLDER STRUCTURE
DECLARE @version VARCHAR(20), @prevVersion VARCHAR(20);
SET @prevVersion = '1.0.0';
SET @version = '1.1.0';
--***********************************************************
----------------------------------------------------------------------

--1b. Check Release versions
SET @logDesc = 'Checking database release version for ' + @database;
EXEC dbo.procAddLog @cID, '*', 'zh!db', 'Low', 'HCA', @logDesc, 'SYSTEM';

	      

IF EXISTS (SELECT * FROM DB_ZHEALTH.DBO.SystemVersionHistory WHERE [Version] = @prevVersion) OR 
			EXISTS (SELECT [Version] FROM DB_ZHEALTH.DBO.SystemVersionHistory WHERE [Version] = @version)
BEGIN	
 SET @logDesc = 'A valid database release version was found.  Beginning database upgrade release process.' + @database;
 EXEC dbo.procAddLog @cID, '*', 'zh!db', 'Low', 'HCA', @logDesc , 'SYSTEM';
END
ELSE
BEGIN
  SET @logDesc = 'A valid database release version WAS NOT found.  Aborting database release process.' + @database;
  EXEC dbo.procAddLog @cID, '*', 'zh!db', 'Low', 'HCA', @logDesc, 'SYSTEM';
  RETURN;
END


--2. **************************************ADD DDL CHANGES HERE************************************************************************
BEGIN TRY;



  BEGIN TRAN; --//***NOTE:  XP_cmdshell does not work from within a transaction.  If other script files will be used to push data updates
  --				        then a transaction can't be used.  If that's unacceptable, then the data inside that script must be included in this file


  --Table DDL Changes
	--None

  --Column DDL changes

    --Change 2.1 - Update the ProcedureStent.PostStentBalloonDilation column
	IF NOT EXISTS (SELECT 1 FROM INFORMATION_SCHEMA.columns WHERE TABLE_NAME = 'ProcedureStent' AND COLUMN_NAME = 'PostStentBalloonDilation')
	BEGIN
		SET @logDesc = 'Updating column name to PostStentBalloon Dilation on table [dbo].[ProcedureStent].' + @database;
		EXEC dbo.procAddLog @cID, '*', 'zh!db', 'Low', 'HCA', @logDesc, 'SYSTEM';

		EXEC sp_RENAME 'dbo.ProcedureStent.BalloonDilation', 'PostStentBalloonDilation', 'COLUMN';

		SET @logDesc = 'Completed .. Updating column name to PostStentBalloonDilation Dilation on table [dbo].[ProcedureStent].' + @database;
		EXEC dbo.procAddLog @cID, '*', 'zh!db', 'Low', 'HCA', @logDesc, 'SYSTEM';
	END

  --Constraint DDL changes
  --Index DDL changes

  

  --***************************************END OF DDL CHANGES SECTION*******************************************************************
  
 
----Section 3. **************************************ADD DATA CHANGES HERE************************************************************************


	--------------------------------------------
	--Change 3.1 - Truncating and re-adding new ActionHandlers 9/12/2016 STS.  Uses SQLCMD :r scripting variable
	--------------------------------------------
	TRUNCATE TABLE [dbo].[ActionHandler];
	:r "c:\workspaces\zerver\ZCore\DB_ZHEALTH\Scripts\Data\dbo.ActionHandler.sql"
	--EXEC xp_cmdshell 'sqlcmd -s localhost -d DB_ZHEALTH -i c:\workspaces\zerver\ZCore\DB_ZHEALTH\Scripts\Data\dbo.ActionHandler.sql'
	--------------------------------------------
	
	--Change 3.2 - Truncating and re-adding new config values to SystemConfiguration 9/12/2016 STS.  Uses SQLCMD :r scripting variable
	--------------------------------------------
	TRUNCATE TABLE [dbo].[SystemConfiguration];
	:r "c:\workspaces\zerver\ZCore\DB_ZHEALTH\Scripts\Data\dbo.SystemConfiguration.sql"	
	--EXEC xp_cmdshell 'sqlcmd -s localhost -d DB_ZHEALTH -i c:\workspaces\zerver\ZCore\DB_ZHEALTH\Scripts\Data\dbo.SystemConfiguration.sql'

		
--  --***************************************END OF DATA CHANGES SECTION*******************************************************************

 
  
--Section 4. Assuming no exceptions/errors, the DDL changes for this release are in place, and the dbo.SystemVersionHistory can be iterated.
  --This assumes the @version has not already been added to the table.  We don't want the @version added multiple times if the process is re-run.
  IF NOT EXISTS (SELECT [Version] FROM DB_ZHEALTH.DBO.SystemVersionHistory WHERE [Version] = @version)
  BEGIN
    DECLARE @name VARCHAR(50), @desc VARCHAR(2000), @curDate DATETIME;
    SET @name = 'release ' + @version + ' of ' + @database;
    SET @desc = 'release ' + @version + ' of ' + @database + '.  This was a system executed process to upgrade the database without effecting the state of the database up to this point in time.';
    SET @curDate = GETDATE();
    
	SET @logDesc = 'Creating a new entry into the SystemVersionHistory table for version ' + @version;
	EXEC dbo.procAddLog @cID, '*', 'zh!db', 'Low', 'HCA', @logDesc, 'SYSTEM';

    EXEC dbo.procAddSystemVersionHistory @name, @curDate, @desc, @version, null, @curDate, 'SYSTEM';
	
	SET @logDesc = 'Completed new entry into the SystemVersionHistory table for version ' + @version;
	EXEC dbo.procAddLog @cID, '*', 'zh!db', 'Low', 'HCA', @logDesc, 'SYSTEM';
  END

  
  COMMIT TRAN;
  
END TRY

BEGIN CATCH;
	  ROLLBACK TRAN;
	  
	  DECLARE @errorNum INT, @errorMsgFull VARCHAR(MAX), @errorMsg VARCHAR(MAX), @xState INT, @errorLine SMALLINT; 
	  SELECT @errorNum = ERROR_NUMBER(), @errorMsg = ERROR_MESSAGE(), @xState = XACT_STATE(), @errorLine = ERROR_LINE();
	  
	  --Note:  The RAISEERROR is not working with Powershell calling execution
	  --RAISERROR ('Error raised during database release process for DB_ZHEALTH: %d: %s', 16, 1, @errorNum, @errorMsg); 
	  
	  --Log the error
	  SELECT @errorMsgFull = 'Error raised during database release process (version:' + @version + ') for ' + @database + '.  This release process will be aborted.  Fix the error and attempt to re-run this process.  Details: ' +
	  'Error Num: ' + CAST(@errorNum AS VARCHAR) + ' Error Ln: ' + CAST(@errorLine AS VARCHAR) + ' Error Msg: ' + @errorMsg;
		
	  EXEC dbo.procAddLog @cID, '*', 'zh!db', 'High', 'HCA', @errorMsgFull, 'SYSTEM';
	  RETURN;

END CATCH;
GO





