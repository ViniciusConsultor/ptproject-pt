USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAll]    Script Date: 02/25/2012 09:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[sp_GetAll]
	@TableName varchar(100)
AS
BEGIN

IF @TableName = 'SIBranch' SELECT * FROM SIBranch
IF @TableName = 'SAUser' SELECT * FROM SAUser
IF @TableName = 'APAdjust' SELECT * FROM APAdjust
IF @TableName = 'APAdjustDet' SELECT * FROM APAdjustDet
IF @TableName = 'APDoc' SELECT * FROM APDoc
IF @TableName = 'APVendor' SELECT * FROM APVendor
IF @TableName = 'ARAdjust' SELECT * FROM ARAdjust
IF @TableName = 'ARAdjustDet' SELECT * FROM ARAdjustDet
IF @TableName = 'ARCustomer' SELECT * FROM ARCustomer
IF @TableName = 'ARDoc' SELECT * FROM ARDoc
IF @TableName = 'ARStaff' SELECT * FROM ARStaff
IF @TableName = 'CAAccount' SELECT * FROM CAAccount
IF @TableName = 'CADoc' SELECT * FROM CADoc
IF @TableName = 'CADocDet' SELECT * FROM CADocDet
IF @TableName = 'CATypeList' SELECT * FROM CATypeList
IF @TableName = 'INDoc' SELECT * FROM INDoc
IF @TableName = 'INDocDet' SELECT * FROM INDocDet
IF @TableName = 'INProduct' SELECT * FROM INProduct
IF @TableName = 'INProductClass1' SELECT * FROM INProductClass1
IF @TableName = 'INProductClass2' SELECT * FROM INProductClass2
IF @TableName = 'INProductStatus' SELECT * FROM INProductStatus
IF @TableName = 'INReason' SELECT * FROM INReason
IF @TableName = 'INUnit' SELECT * FROM INUnit
IF @TableName = 'INWarehouse' SELECT * FROM INWarehouse
IF @TableName = 'POOrder' SELECT * FROM POOrder
IF @TableName = 'POOrderDet' SELECT * FROM POOrderDet
IF @TableName = 'POPrice' SELECT * FROM POPrice
IF @TableName = 'RPRun' SELECT * FROM RPRun
IF @TableName = 'RPRunPara' SELECT * FROM RPRunPara
IF @TableName = 'RPSetup' SELECT * FROM RPSetup
IF @TableName = 'SALanguage' SELECT * FROM SALanguage
IF @TableName = 'SAMenu' SELECT * FROM SAMenu
IF @TableName = 'SOOrder' SELECT * FROM SOOrder
IF @TableName = 'SOOrderDet' SELECT * FROM SOOrderDet
IF @TableName = 'SAMessage' SELECT * FROM SAMessage
IF @TableName = 'SITax' SELECT * FROM SITax

END
