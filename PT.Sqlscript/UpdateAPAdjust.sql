USE [PT.Manager]
GO
/****** Object:  Trigger [dbo].[UpdateAPAdjust]    Script Date: 05/09/2012 10:58:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery4.sql|0|0|C:\Users\LTPHUOC\AppData\Local\Temp\~vsE028.sql
ALTER TRIGGER [dbo].[UpdateAPAdjust] 
ON [dbo].[APAdjust] 
FOR UPDATE
AS
DECLARE @BranchID varchar(10)
DECLARE @AdjNbr varchar(10)
DECLARE @Rlsed smallint

IF UPDATE (Rlsed)
BEGIN
	DECLARE Adjust_CURSOR CURSOR FOR 	
	SELECT BranchID, AdjNbr	,Rlsed
	FROM inserted

	OPEN Adjust_CURSOR
	FETCH NEXT FROM Adjust_CURSOR 
	INTO  @BranchID, @AdjNbr,@Rlsed
	WHILE (@@FETCH_STATUS = 0)
	BEGIN	
		
			UPDATE APAdjustDet SET Rlsed = @Rlsed
			WHERE BranchID = @BranchID AND AdjNbr = @AdjNbr
		
		FETCH NEXT FROM Adjust_CURSOR 
		INTO  @BranchID, @AdjNbr ,@Rlsed
		
	END
	CLOSE Adjust_CURSOR
	DEALLOCATE Adjust_CURSOR	
END
