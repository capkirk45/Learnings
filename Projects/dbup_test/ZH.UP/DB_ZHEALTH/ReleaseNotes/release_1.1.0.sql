/*
Schema / Data Change Types
	1. Execute the DDL with checks for existence of object (note:  test table and column are used, below)
	2. Execute and data update/insert/deletes here, assuming the requisite schema changes are in place

Change Log:
1.1 Column change from BalloonDilation to PostStentBalloonDilation on table dbo.ProcedureStent
	(***Note:   This change does not follow the normal additive approach, but is allowable
	because the table is new and contains no data.  Essentially this is a fix
	to a table that did not exist in the previous version. *** )

2.1. Updated set of dbo.ActionHandler data to support CaseImport
2.2. Updated set of dbo.SystemConfiguration data to support CaseImport
*/
