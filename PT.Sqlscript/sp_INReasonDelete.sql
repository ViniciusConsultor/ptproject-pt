CREATE PROCEDURE [dbo].[sp_INReasonDelete]
	@RsId varchar(10) 
AS

DELETE FROM INReason WHERE RsID = @RsId