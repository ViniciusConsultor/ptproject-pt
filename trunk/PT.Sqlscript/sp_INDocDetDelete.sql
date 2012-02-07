CREATE PROCEDURE [dbo].[sp_INDocDetDelete]
	@BranchID VARCHAR(10),
	@DocNbr VARCHAR(10),
	@Module VARCHAR(2),
	@Lineref VARCHAR(3)
AS
DELETE FROM INDocDet
WHERE BranchID = @BranchID 
AND DocNbr = @DocNbr
AND Module = @Module
AND LineRef = @Lineref
