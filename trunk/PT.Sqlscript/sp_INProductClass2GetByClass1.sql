USE [PT]
GO
/****** Object:  StoredProcedure [dbo].[sp_INProductClass2GetByClass1]    Script Date: 02/09/2012 22:18:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INProductClass2GetByClass1]
	@VendID varchar(15),
	@ClassID1 varchar(10)
AS

SELECT	*
FROM INProductClass2 WHERE VendID = @VendID AND ClassID1 = @ClassID1