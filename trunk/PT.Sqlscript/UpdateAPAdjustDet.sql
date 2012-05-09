USE [PT.Manager]
GO
/****** Object:  Trigger [dbo].[UpdateAPAdjustDet]    Script Date: 05/09/2012 09:00:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[UpdateAPAdjustDet] 
ON [dbo].[APAdjustDet] 
FOR UPDATE
AS
DECLARE @BranchID varchar(10)
DECLARE @AdjNbr varchar(10)
DECLARE @LineRef varchar(10)
DECLARE @AdjAmt float
DECLARE @Rlsed smallint
DECLARE @VendId varchar(15)
DECLARE @NDocNbr varchar(10)
DECLARE @ADocNbr varchar(10)

IF UPDATE (Rlsed)
BEGIN
	DECLARE AdjustDet_CURSOR CURSOR FOR 	
	SELECT BranchID, AdjNbr, LineRef, AdjAmt, VendID, NDocNbr,ADocNbr	
	FROM DELETED

	OPEN AdjustDet_CURSOR
	FETCH NEXT FROM AdjustDet_CURSOR 
	INTO  @BranchID, @AdjNbr, @LineRef, @AdjAmt, @VendID, @NDocNbr,@ADocNbr	
	WHILE (@@FETCH_STATUS = 0)
	BEGIN	
		SELECT @Rlsed = Rlsed FROM INSERTED
		-- UPDATE CHUNG TU NO
		IF @Rlsed <> 0 AND EXISTS (SELECT * FROM APDoc WHERE BranchID = @BranchID AND DocNbr = @NDocNbr AND Rlsed = 1)
		BEGIN
			UPDATE APDoc SET DocBal = CASE WHEN @Rlsed = 1 THEN DocBal - @AdjAmt ELSE DocBal + @AdjAmt END
			WHERE BranchID = @BranchID AND DocNbr = @NDocNbr AND VendID = @VendID
		END
		
		-- UPDATE CHUNG TU GIAM NO
		IF @Rlsed <> 0 AND EXISTS (SELECT * FROM APDoc WHERE BranchID = @BranchID AND DocNbr = @ADocNbr AND Rlsed = 1)
		BEGIN
			UPDATE APDoc SET DocBal = CASE WHEN @Rlsed = 1 THEN DocBal - @AdjAmt ELSE DocBal + @AdjAmt END
			WHERE BranchID = @BranchID AND DocNbr = @ADocNbr AND VendID = @VendID
		END
		
		FETCH NEXT FROM AdjustDet_CURSOR 
		INTO  @BranchID, @AdjNbr, @LineRef, @AdjAmt, @VendID, @NDocNbr,@ADocNbr		
	END
	CLOSE AdjustDet_CURSOR
	DEALLOCATE AdjustDet_CURSOR	
END
