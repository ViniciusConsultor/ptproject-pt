CREATE PROCEDURE [dbo].[sp_INDocDelete]
	@BranchID VARCHAR(10),
	@DocNbr VARCHAR(10),
	@Module VARCHAR(2)
AS
DELETE FROM INDoc
WHERE BranchID = @BranchID 
AND DocNbr = @DocNbr
AND Module = @Module
