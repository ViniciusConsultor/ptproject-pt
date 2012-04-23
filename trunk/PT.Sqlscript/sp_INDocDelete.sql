USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_INDocDelete]    Script Date: 04/20/2012 09:45:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INDocDelete]
	@BranchID VARCHAR(10),
	@DocNbr VARCHAR(10),
	@Module VARCHAR(2)
AS
DELETE FROM INDoc
WHERE BranchID = @BranchID 
AND DocNbr = @DocNbr
AND Module = @Module
