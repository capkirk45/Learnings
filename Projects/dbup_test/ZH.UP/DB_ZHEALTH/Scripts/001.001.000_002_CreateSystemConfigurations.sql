TRUNCATE TABLE [dbo].[SystemConfiguration]


INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT '*','*','ActiveConfigurationFilterKey','HCA'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','LOCAL','ReportInterfacePDFOutputPathTemplate','C:\workspaces\temp\{FACILITY_CODE}\PDF'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TEST','ReportInterfacePDFOutputPathTemplate','C:\Interface\{FACILITY_CODE}\PDF'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TESTHCA','ReportInterfacePDFOutputPathTemplate','E:\ZHealth\{FACILITY_CODE}\PDF'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO','ReportInterfacePDFOutputPathTemplate','C:\Interface\{FACILITY_CODE}\PDF'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO2','ReportInterfacePDFOutputPathTemplate','C:\Interface\{FACILITY_CODE}\PDF'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','PRODUCTION','ReportInterfacePDFOutputPathTemplate','E:\ZHealth\{FACILITY_CODE}\PDF'

--------------------------------------------
--Set the CaseAuditReportOutputPathTemplate setting per environment
--------------------------------------------
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','LOCAL','CaseAuditReportOutputPathTemplate','C:\workspaces\temp\{FACILITY_CODE}\Audit'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TEST','CaseAuditReportOutputPathTemplate','C:\Interface\{FACILITY_CODE}\Audit'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TESTHCA','CaseAuditReportOutputPathTemplate','E:\ZHealth\{FACILITY_CODE}\Audit'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO','CaseAuditReportOutputPathTemplate','C:\Interface\{FACILITY_CODE}\Audit'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO2','CaseAuditReportOutputPathTemplate','C:\Interface\{FACILITY_CODE}\Audit'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','PRODUCTION','CaseAuditReportOutputPathTemplate','E:\ZHealth\{FACILITY_CODE}\Audit'


--------------------------------------------
--Set the case report file format setting per environment
--------------------------------------------
INSERT INTO [dbo].[SystemConfiguration]([FilterKey], [Environment], [Key], [Value])
SELECT 'HCA','LOCAL', 'CaseReportFileFormatTemplate', '.tif'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey], [Environment], [Key], [Value])
SELECT 'HCA','TEST', 'CaseReportFileFormatTemplate', '.tif'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey], [Environment], [Key], [Value])
SELECT 'HCA','TESTHCA', 'CaseReportFileFormatTemplate', '.tif'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey], [Environment], [Key], [Value])
SELECT 'HCA','DEMO', 'CaseReportFileFormatTemplate', '???'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey], [Environment], [Key], [Value])
SELECT 'HCA','DEMO2', 'CaseReportFileFormatTemplate', '???'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey], [Environment], [Key], [Value])
SELECT 'HCA','PRODUCTION', 'CaseReportFileFormatTemplate', '.tif'

--------------------------------------------
--Set the ZINTHL7 host name
--------------------------------------------
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','LOCAL','ZINTHL7_Hostname','127.0.0.1'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TEST','ZINTHL7_Hostname','127.0.0.1'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TESTHCA','ZINTHL7_Hostname','127.0.0.1'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO','ZINTHL7_Hostname','127.0.0.1'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO2','ZINTHL7_Hostname','127.0.0.1'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','PRODUCTION','ZINTHL7_Hostname','127.0.0.1'


--------------------------------------------
--Set the adt trigger incoming port
--------------------------------------------
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','LOCAL','ADT_IncomingPort','18100'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TEST','ADT_IncomingPort','18100'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TESTHCA','ADT_IncomingPort','18100'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO','ADT_IncomingPort','18100'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO2','ADT_IncomingPort','18100'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','PRODUCTION','ADT_IncomingPort','18100'


--------------------------------------------
--Set the oru trigger incoming port
--------------------------------------------
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','LOCAL','ORU_IncomingPort','18200'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TEST','ORU_IncomingPort','18200'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TESTHCA','ORU_IncomingPort','18200'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO','ORU_IncomingPort','18200'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO2','ORU_IncomingPort','18200'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','PRODUCTION','ORU_IncomingPort','18200'


--------------------------------------------
--Set the dft trigger incoming port
--------------------------------------------
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','LOCAL','DFT_TriggerIncomingPort','18300'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TEST','DFT_TriggerIncomingPort','18300'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TESTHCA','DFT_TriggerIncomingPort','18300'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO','DFT_TriggerIncomingPort','18300'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO2','DFT_TriggerIncomingPort','18300'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','PRODUCTION','DFT_TriggerIncomingPort','18300'


--------------------------------------------
--Set the rpt trigger incoming port
--------------------------------------------
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','LOCAL','RPT_TriggerIncomingPort','18400'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TEST','RPT_TriggerIncomingPort','18400'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TESTHCA','RPT_TriggerIncomingPort','18400'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO','RPT_TriggerIncomingPort','18400'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO2','RPT_TriggerIncomingPort','18400'
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','PRODUCTION','RPT_TriggerIncomingPort','18400'


--------------------------------------------
--Set the ZINT uri
--------------------------------------------
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','LOCAL','ZINT_FileIntegrationEndpoint','https://localhost:44306/' 
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TEST','ZINT_FileIntegrationEndpoint','https://pzint.corp.comefind.me/' 
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','TESTHCA','ZINT_FileIntegrationEndpoint','https://cwdvwtzint.hca.corpad.net' 
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO','ZINT_FileIntegrationEndpoint','???' 
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','DEMO2','ZINT_FileIntegrationEndpoint','???' 
--
INSERT INTO [dbo].[SystemConfiguration]([FilterKey],[Environment],[Key],[Value])
SELECT 'HCA','PRODUCTION','ZINT_FileIntegrationEndpoint','https://cwdvwpzint.hca.corpad.net/' 

