CREATE PROCEDURE [dbo].[sp_INDocSave]
	@BranchID varchar(10) ,
	@DocNbr varchar(10) ,
	@Module varchar(2) ,
	@TranType varchar(5) ,
	@TotQty float ,
	@WhID varchar(10) ,
	@ToWhID varchar(10) ,
	@TotAmt float ,
	@DocDate smalldatetime ,
	@DocDescr nvarchar(100) ,
	@RsID varchar(10) ,
	@Rlsed smallint ,
	@Note nvarchar(200) ,
	@Crtd_DateTime datetime ,
	@Crtd_Prog varchar(8) ,
	@Crtd_User varchar(10) ,
	@LUpd_DateTime datetime ,
	@LUpd_Prog varchar(8) ,
	@LUpd_User varchar(10) 
AS

declare @exist int
set @exist = (SELECT Count(*) FROM INDoc WHERE BranchID = @BranchID AND DocNbr = @DocNbr AND Module = @Module )

If @exist = 0
BEGIN
INSERT INTO INDoc
				(	BranchID ,
					DocNbr ,
					Module ,
					TranType ,
					TotQty ,
					WhID ,
					ToWhID ,
					TotAmt ,
					DocDate ,
					DocDescr ,
					RsID ,
					Rlsed ,
					Note ,
					Crtd_DateTime ,
					Crtd_Prog ,
					Crtd_User ,
					LUpd_DateTime ,
					LUpd_Prog ,
					LUpd_User 
 				)
VALUES			(	@BranchID ,
					@DocNbr ,
					@Module ,
					@TranType ,
					@TotQty ,
					@WhID ,
					@ToWhID ,
					@TotAmt ,
					@DocDate ,
					@DocDescr ,
					@RsID ,
					@Rlsed ,
					@Note ,
					GETDATE() ,
					@Crtd_Prog ,
					@Crtd_User ,
					@LUpd_DateTime ,
					@LUpd_Prog ,
					@LUpd_User 
				)
END
ELSE
BEGIN
	UPDATE INDoc SET BranchID =@BranchID ,
					DocNbr =@DocNbr ,
					Module =@Module ,
					TranType =@TranType ,
					TotQty =@TotQty ,
					WhID =@WhID ,
					ToWhID =@ToWhID ,
					TotAmt =@TotAmt ,
					DocDate =@DocDate ,
					DocDescr =@DocDescr ,
					RsID =@RsID ,
					Rlsed =@Rlsed ,
					Note =@Note ,
					LUpd_DateTime =@LUpd_DateTime ,
					LUpd_Prog =@LUpd_Prog ,
					LUpd_User =@LUpd_User 
	WHERE BranchID = @BranchID AND DocNbr = @DocNbr AND Module = @Module 
END