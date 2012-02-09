USE [PT]
GO
/****** Object:  StoredProcedure [dbo].[sp_INProductClass2Delete]    Script Date: 02/09/2012 22:18:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INProductClass2Delete]
	@VendID varchar(15) ,
	@ClassID1 varchar(10) ,
	@ClassID2 varchar(10) 
AS

DELETE FROM INProductClass2
WHERE VendID = @VendID AND ClassID1 = @ClassID1 AND ClassID2 = @ClassID2
