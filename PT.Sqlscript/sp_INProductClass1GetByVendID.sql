USE [PT]
GO
/****** Object:  StoredProcedure [dbo].[sp_INProductClass1GetByVendID]    Script Date: 02/09/2012 22:17:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INProductClass1GetByVendID]
	@VendID varchar(15)	
AS

SELECT	*
FROM INProductClass1 WHERE VendID = @VendID 