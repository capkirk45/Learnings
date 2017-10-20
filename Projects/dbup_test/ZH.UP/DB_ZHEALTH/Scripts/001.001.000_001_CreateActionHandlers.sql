--NOTE: DO NOT add a using statement for a specific database as we need to support the ability to apply the same script to multiple target databases.
TRUNCATE TABLE [dbo].[ActionHandler]

--------------------------------------------------------------------------------------------------------------
--Documentation Engine Client Output Pipeline
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ZDEClient', 'IZDEVirtualDictationHandler', 'VirtualDictation', 'ZH.Documentation.Handlers.ZDEVirtualDictationHandler', 'Execute', 1.0, 1, 'A29A90C4-BC2C-4BAB-BC45-CD3C375161C5', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

--------------------------------------------------------------------------------------------------------------
--Virtual Dictation Engine
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ZVDictEngine', 'IZVDETransformCaseHandler', 'TransformCase', 'ZH.Documentation.Handlers.ZVDETransformCaseHandler', 'Apply', 1.0, 1, NEWID(), GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM') 

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ZVDictEngine', 'IZVDEFlatDictationHandler', 'FlatDictation', 'ZH.Documentation.Handlers.ZVDEFlatDictationHandler', 'Apply', 2.0, 1, NEWID(), GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM') 

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ZVDictEngine', 'IZVDENestedDictationHandler', 'NestedDictation', 'ZH.Documentation.Handlers.ZVDENestedDictationHandler', 'Apply', 3.0, 1, NEWID(), GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM') 

--------------------------------------------------------------------------------------------------------------
--Meditech Outbound Case Submission Pipeline
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechOutboundCaseSubmissionPipeline', 'IPLNProcessCaseSubmittedStatusHandler', 'ProcessCaseSubmittedStatus', 'ZH.Documentation.Handlers.ProcessCaseSubmittedStatusHandler', 'Execute', 1.0, 1, '{466036FF-BD60-410F-9180-BE4B3F89389D}', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechOutboundCaseSubmissionPipeline', 'IPLNMeditechPDFReportFileStoreRetrievalHandler', 'MeditechPDFReportFileStoreRetrievalHandler', 'ZH.Documentation.Handlers.MeditechPDFReportFileStoreRetrievalHandler', 'Execute', 2.0, 1, '{BEBEF852-C8B7-4CA8-851C-5F3F0FAE6A67}', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechOutboundCaseSubmissionPipeline', 'IPLNPDFToTIFConversionHandler', 'PDFToTIFConversionHandler', 'ZH.Documentation.Handlers.PDFToTIFConversionHandler', 'Execute', 3.0, 1, '{9B4679BC-5E4A-4EC8-BD39-00979C041D22}', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechOutboundCaseSubmissionPipeline', 'IPLNMeditechTriggerRPTMessageHandler', 'MeditechTriggerRPTMessage', 'ZH.Documentation.Handlers.MeditechTriggerRPTMessageHandler', 'Execute', 4.0, 1, '{BDE8D72A-47BB-4148-9060-0D478C820C9B}', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechOutboundCaseSubmissionPipeline', 'IPLNMeditechTriggerDFTMessageHandler', 'MeditechTriggerDFTMessage', 'ZH.Documentation.Handlers.MeditechTriggerDFTMessageHandler', 'Execute', 5.0, 1, '{4EA41E69-E16D-463C-9A59-AC7A7CF10257}', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')


--------------------------------------------------------------------------------------------------------------
--Meditech Outbound Addendum Pipeline
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechOutboundAddendumPipeline', 'IPLNMeditechPDFReportFileStoreRetrievalHandler', 'MeditechPDFReportFileStoreRetrievalHandler', 'ZH.Documentation.Handlers.MeditechPDFReportFileStoreRetrievalHandler', 'Execute', 1.0, 1, '{2A5BA3EC-79A9-41CA-BD21-53F2C69E52ED}', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechOutboundAddendumPipeline', 'IPLNPDFToTIFConversionHandler', 'PDFToTIFConversionHandler', 'ZH.Documentation.Handlers.PDFToTIFConversionHandler', 'Execute', 2.0, 1, '{C83F5844-E2FE-44D6-9974-7E99C0585AB7}', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechOutboundAddendumPipeline', 'IPLNMeditechTriggerRPTMessageHandler', 'MeditechTriggerRPTMessage', 'ZH.Documentation.Handlers.MeditechTriggerRPTMessageHandler', 'Execute', 3.0, 1, '{AFD181D8-BFF1-46F2-A2BB-EC60C1228598}', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')


--------------------------------------------------------------------------------------------------------------
--Meditech Audit Report Pipeline 
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('MeditechAuditReportPipeline', 'IPLNMeditechAuditReportHandler', 'AuditReport', 'ZH.Documentation.Handlers.MeditechAuditReportHandler', 'Execute', 1.0, 1, 'CBF80CA5-7555-4552-AD5F-16C55033246A', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

--------------------------------------------------------------------------------------------------------------
--Compliance Validation Pipeline 
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ComplianceValidationPipeline', 'IPLNCathSupplyValidationHandler', 'CathSupplyValidation', 'ZH.Domain.Handlers.CathSupplyValidationHandler', 'Execute', 1.0, 1, '554E4E7B-EA1C-428C-8190-475C0E98EBA7', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ComplianceValidationPipeline', 'IPLNHeartCathValidationHandler', 'HeartCathValidation', 'ZH.Domain.Handlers.HeartCathValidationHandler', 'Execute', 2.0, 1, '29391312-82C9-4C6D-A0F8-ABABBAB3B6EA', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ComplianceValidationPipeline', 'IPLNCodeEngineInputValidationHandler', 'CodeEngineInputValidation', 'ZH.Domain.Handlers.CodeEngineInputValidationHandler', 'Execute', 3.0, 1, '200419C6-68CD-4B0B-B442-DC24E1C95823', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ComplianceValidationPipeline', 'IPLNCodeEngineOutputValidationHandler', 'CodeEngineOutputValidation', 'ZH.Domain.Handlers.CodeEngineOutputValidationHandler', 'Execute', 4.0, 1, '86DCE356-F9CA-49C4-9B16-00DB03C291D4', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ComplianceValidationPipeline', 'IPLNDocumentationOutputValidationHandler', 'CodeEngineOutputValidation', 'ZH.Domain.Handlers.DocumentationOutputValidationHandler', 'Execute', 5.0, 1, 'E9A0E558-9674-4DAC-B001-701976632754', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

--------------------------------------------------------------------------------------------------------------
--Export Case for Obfuscation Pipeline 
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ExportCasePipeline', 'IPLNInitializeObfuscationHandler', 'InitializeObfuscationHandler', 'ZAPI.Handlers.InitializeObfuscationHandler', 'Execute', 1.0, 1, 'F6C3E544-8F1A-4FDC-A614-D77A2375C582', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ExportCasePipeline', 'IPLNExportCaseDTOFileHandler', 'ExportCaseDTOFileHandler', 'ZAPI.Handlers.ExportCaseDTOFileHandler', 'Execute', 2.0, 1, 'DB802322-5340-4668-9CA5-F5F08E94FC3D', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ExportCasePipeline', 'IPLNExportCaseADTMessageFileHandler', 'ExportCaseADTMessageFileHandler', 'ZAPI.Handlers.ExportCaseADTMessageFileHandler', 'Execute', 3.0, 1, '5AB9ABB2-37A2-45F4-9DA9-E51D2E6EDF3F', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ExportCasePipeline', 'IPLNExportCaseORMMessageFileHandler', 'ExportCaseORMMessageFileHandler', 'ZAPI.Handlers.ExportCaseORMMessageFileHandler', 'Execute', 4.0, 1, '0E5C880F-CCD6-4F41-B65D-23961AFF7ACA', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ExportCasePipeline', 'IPLNExportCaseMergeFileHandler', 'ExportCaseMergeFileHandler', 'ZAPI.Handlers.ExportCaseMergeFileHandler', 'Execute', 5.0, 1, '9A75F974-F446-410F-86A1-7F23A728750B', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ExportCasePipeline', 'IPLNExportCaseLogsHandler', 'ExportCaseLogsHandler', 'ZAPI.Handlers.ExportCaseLogsHandler', 'Execute', 6.0, 1, '42A1DAAD-4DF4-4DA4-84FF-DDB58D481D3D', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ExportCasePipeline', 'IPLNExportCaseCERFileHandler', 'ExportCaseCERFileHandler', 'ZAPI.Handlers.ExportCaseCERFileHandler', 'Execute', 7.0, 1, 'F65A69EA-4362-4441-BE69-249AF9BDA1B2', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

--------------------------------------------------------------------------------------------------------------
--Post Actions for Case Submission to Compliance(REQUIRESREVIEW)
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('PostComplianceSubmissionPipeline', 'IPLNGenerateCaseOutputActionHandler', 'GenerateCaseOutputActionHandler', 'ZH.Coding.Handlers.GenerateCaseOutputActionHandler', 'Execute', 1.0, 1, 'D0AF1B60-D81C-4A2E-A21B-9BDC8BDA6B33', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('PostComplianceSubmissionPipeline', 'IPLNGenerateVirtualDicationActionHandler', 'GenerateVirtualDicationActionHandler', 'ZH.Documentation.Handlers.GenerateVirtualDicationActionHandler', 'Execute', 2.0, 1, '2B7EE4A4-7A68-47AA-BD01-93067C2220A7', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('PostComplianceSubmissionPipeline', 'IPLNGenerateFlagsActionHandler', 'GenerateFlagsActionHandler', 'ZH.Domain.Handlers.GenerateFlagsActionHandler', 'Execute', 3.0, 1, 'A609CC12-DA9C-48EF-B9C3-295EDBC533DE', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

--------------------------------------------------------------------------------------------------------------
--Import an Obfusacted Case Pipeline
--------------------------------------------------------------------------------------------------------------
INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ImportCasePipeline', 'IPLNImportCaseValidationHandler', 'ImportCaseValidationHandler', 'ZAPI.Handlers.ImportCaseValidationHandler', 'Execute', 1.0, 1, '1FD2D086-F21A-4A99-843C-E3F18B9594AB', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ImportCasePipeline', 'IPLNImportCaseHL7MessageFileHandler', 'ImportCaseHL7MessageFileHandler', 'ZAPI.Handlers.ImportCaseHL7MessageFileHandler', 'Execute', 2.0, 1, '6F087AF4-3686-475A-AE0A-AFCE7342F593', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ImportCasePipeline', 'IPLNImportCaseMergeFileHandler', 'ImportCaseMergeFileHandler', 'ZAPI.Handlers.ImportCaseMergeFileHandler', 'Execute', 3.0, 1, '94F450B0-B323-498C-83AD-1BEFE4025E89', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')

INSERT INTO [dbo].[ActionHandler]([Class], [Type],[Name],[HandlerType],[HandlerMethod],[Sequence],[IsActive],[GlobalId],[Created],[CreatedBy],[LastModified],[LastModifiedBy])
VALUES ('ImportCasePipeline', 'IPLNImportCaseDTOFileHandler', 'ImportCaseDTOFileHandler', 'ZAPI.Handlers.ImportCaseDTOFileHandler', 'Execute', 4.0, 1, '71286786-DFF6-4B07-8715-B6DD9712E4DF', GETDATE(), 'SYSTEM', GETDATE(), 'SYSTEM')
