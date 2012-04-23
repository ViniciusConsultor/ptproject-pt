USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_INDocDetSave]    Script Date: 04/20/2012 09:46:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INDocDetSave]
	@BranchID varchar(10) ,
	@DocNbr varchar(10) ,
	@Module varchar(2) ,
	@LineRef varchar(5) ,
	@TranType varchar(5) ,
	@TranDate smalldatetime ,
	@WhID varchar(10) ,
	@ToWhID varchar(10) ,
	@FreeItem bit ,
	@ProductID varchar(30) ,
	@TranDesc nvarchar(100) ,
	@LotID varchar(20) ,
	@INUnit nvarchar(15) ,
	@LineQty float ,
	@UnitCost float ,
	@TotalCost float ,
	@InvtMult smallint ,
	@ObjID varchar(30) ,
	@ShipperID varchar(15) ,
	@RsID varchar(6) ,
	@Rlsed smallint ,
	@SONbr varchar(15) ,
	@PONbr varchar(15) ,
	@Cnvfact float ,
	@UnitRate float ,
	@DetailQty float ,
	@Crtd_DateTime datetime ,
	@Crtd_Prog varchar(8) ,
	@Crtd_User varchar(10) ,
	@LUpd_DateTime datetime ,
	@LUpd_Prog varchar(8) ,
	@LUpd_User varchar(10),
	@Version varchar(18)
AS

declare @exist int
declare @kq smallint

set @exist = (SELECT Count(*) FROM INDocDet 
WHERE BranchID = @BranchID AND DocNbr = @DocNbr AND Module = @Module AND LineRef = @LineRef)

If @exist = 0
BEGIN
INSERT INTO INDocDet
				(	BranchID ,
					DocNbr ,
					Module ,
					LineRef ,
					TranType ,
					TranDate ,
					WhID ,
					ToWhID ,
					FreeItem ,
					ProductID ,
					TranDesc ,
					LotID ,
					INUnit ,
					LineQty ,
					UnitCost ,
					TotalCost ,
					InvtMult ,
					ObjID ,
					ShipperID ,
					RsID ,
					Rlsed ,
					SONbr ,
					PONbr ,
					Cnvfact ,
					UnitRate ,
					DetailQty ,
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
					@LineRef ,
					@TranType ,
					@TranDate ,
					@WhID ,
					@ToWhID ,
					@FreeItem ,
					@ProductID ,
					@TranDesc ,
					@LotID ,
					@INUnit ,
					@LineQty ,
					@UnitCost ,
					@TotalCost ,
					@InvtMult ,
					@ObjID ,
					@ShipperID ,
					@RsID ,
					@Rlsed ,
					@SONbr ,
					@PONbr ,
					@Cnvfact ,
					@UnitRate ,
					@DetailQty ,
					GETDATE() ,
					@Crtd_Prog ,
					@Crtd_User ,
					@LUpd_DateTime ,
					@LUpd_Prog ,
					@LUpd_User 
				)
	SET @kq = 1				
END
ELSE
BEGIN	
	set @exist = (SELECT Count(*) FROM INDocDet 
	WHERE BranchID = @BranchID AND DocNbr = @DocNbr AND Module = @Module 
	AND LineRef = @LineRef AND master.dbo.fn_varbintohexstr(Version) = @Version)
	If @exist = 0 SET @kq = 0
	ELSE
	BEGIN
		UPDATE INDocDet SET BranchID =@BranchID ,
							DocNbr =@DocNbr ,
							Module =@Module ,
							LineRef =@LineRef ,
							TranType =@TranType ,
							TranDate =@TranDate ,
							WhID =@WhID ,
							ToWhID =@ToWhID ,
							FreeItem =@FreeItem ,
							ProductID =@ProductID ,
							TranDesc =@TranDesc ,
							LotID =@LotID ,
							INUnit =@INUnit ,
							LineQty =@LineQty ,
							UnitCost =@UnitCost ,
							TotalCost =@TotalCost ,
							InvtMult =@InvtMult ,
							ObjID =@ObjID ,
							ShipperID =@ShipperID ,
							RsID =@RsID ,
							Rlsed =@Rlsed ,
							SONbr =@SONbr ,
							PONbr =@PONbr ,
							Cnvfact =@Cnvfact ,
							UnitRate =@UnitRate ,
							DetailQty =@DetailQty ,
							LUpd_DateTime =@LUpd_DateTime ,
							LUpd_Prog =@LUpd_Prog ,
							LUpd_User =@LUpd_User  
		WHERE BranchID = @BranchID AND DocNbr = @DocNbr AND Module = @Module AND LineRef = @LineRef
		SET @kq = 2
	END
END
RETURN @kq