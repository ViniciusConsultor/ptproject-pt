USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_APDocSave]    Script Date: 04/22/2012 09:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_APDocSave]	
	@BranchID varchar(10) ,
	@DocNbr varchar(10) ,
	@DocType varchar(2) ,
	@DocDesc nvarchar(100) ,
	@DocAcct varchar(6) ,
	@VendID varchar(15) ,
	@DocBal float ,
	@OrigDocAmt float ,
	@DocDate smalldatetime ,
	@PONbr varchar(10) ,
	@InvcNbr varchar(15) ,
	@InvcNote varchar(10) ,
	@Rlsed smallint ,
	@TaxId varchar(10) ,
	@PreTaxAmt float ,
	@TaxAmt float ,
	@TimeLmtID varchar(20) ,
	@DueDate smalldatetime ,
	@Note nvarchar(100) ,
	@Crtd_DateTime smalldatetime ,
	@Crtd_Prog varchar(8) ,
	@Crtd_User varchar(10) ,
	@LUpd_DateTime smalldatetime ,
	@LUpd_Prog varchar(8) ,
	@LUpd_User varchar(10) ,
	@Version varchar(18)

AS
	declare @exist int
	declare @kq smallint
	set @exist = (SELECT Count(*) FROM APDoc WHERE BranchID = @BranchID AND DocNbr = @DocNbr )

If @exist = 0
	BEGIN
		INSERT INTO APDoc( BranchID ,
							DocNbr ,
							DocType ,
							DocDesc ,
							DocAcct ,
							VendID ,
							DocBal ,
							OrigDocAmt ,
							DocDate ,
							PONbr ,
							InvcNbr ,
							InvcNote ,
							Rlsed ,
							TaxId ,
							PreTaxAmt ,
							TaxAmt ,
							TimeLmtID ,
							DueDate ,
							Note ,
							Crtd_DateTime ,
							Crtd_Prog ,
							Crtd_User ,
							LUpd_DateTime ,
							LUpd_Prog ,
							LUpd_User )
		VALUES(	@BranchID ,
				@DocNbr ,
				@DocType ,
				@DocDesc ,
				@DocAcct ,
				@VendID ,
				@DocBal ,
				@OrigDocAmt ,
				@DocDate ,
				@PONbr ,
				@InvcNbr ,
				@InvcNote ,
				@Rlsed ,
				@TaxId ,
				@PreTaxAmt ,
				@TaxAmt ,
				@TimeLmtID ,
				@DueDate ,
				@Note ,
				@Crtd_DateTime ,
				@Crtd_Prog ,
				@Crtd_User ,
				@LUpd_DateTime ,
				@LUpd_Prog ,
				@LUpd_User )
		SET @kq = 1	
	END
ELSE
	BEGIN
		set @exist = (SELECT Count(*) FROM APDoc WHERE BranchID = @BranchID AND DocNbr = @DocNbr 
						AND master.dbo.fn_varbintohexstr(Version) = @Version)
		If @exist = 0 SET @kq = 0
		ELSE
			BEGIN
			UPDATE APDoc SET BranchID =@BranchID ,
								DocNbr =@DocNbr ,
								DocType =@DocType ,
								DocDesc =@DocDesc ,
								DocAcct =@DocAcct ,
								VendID =@VendID ,
								DocBal =@DocBal ,
								OrigDocAmt =@OrigDocAmt ,
								DocDate =@DocDate ,
								PONbr =@PONbr ,
								InvcNbr =@InvcNbr ,
								InvcNote =@InvcNote ,
								Rlsed =@Rlsed ,
								TaxId =@TaxId ,
								PreTaxAmt =@PreTaxAmt ,
								TaxAmt =@TaxAmt ,
								TimeLmtID =@TimeLmtID ,
								DueDate =@DueDate ,
								Note =@Note ,
								Crtd_DateTime =@Crtd_DateTime ,
								Crtd_Prog =@Crtd_Prog ,
								Crtd_User =@Crtd_User ,
								LUpd_DateTime =@LUpd_DateTime ,
								LUpd_Prog =@LUpd_Prog ,
								LUpd_User =@LUpd_User 
			WHERE BranchID = @BranchID AND DocNbr = @DocNbr 
			SET @kq = 1
		END
	END
select @kq
