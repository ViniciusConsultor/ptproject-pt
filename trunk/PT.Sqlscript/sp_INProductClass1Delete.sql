USE [PT]
GO
/****** Object:  StoredProcedure [dbo].[sp_INProductClass1Delete]    Script Date: 02/09/2012 22:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INProductClass1Delete]
	@VendID varchar(15) ,
	@ClassID1 varchar(10) 
AS

DELETE FROM INProductClass1
WHERE VendID = @VendID AND ClassID1 = @ClassID1
