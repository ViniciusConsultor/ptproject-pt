USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_INDocDetDelete]    Script Date: 04/20/2012 09:45:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INDocDetDelete]
	@BranchID VARCHAR(10),
	@DocNbr VARCHAR(10),
	@Module VARCHAR(2),
	@Lineref VARCHAR(5)
AS
DELETE FROM INDocDet
WHERE BranchID = @BranchID 
AND DocNbr = @DocNbr
AND Module = @Module
AND LineRef = @Lineref
