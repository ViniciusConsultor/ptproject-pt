USE [PT]
GO
/****** Object:  StoredProcedure [dbo].[sp_INProductClass2Save]    Script Date: 02/09/2012 22:18:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INProductClass2Save]
	@VendID varchar(15) ,
	@ClassID1 varchar(10) ,
	@ClassID2 varchar(10) ,
	@Descr nvarchar(50) ,
	@DfltTaxID varchar(10) ,
	@DfltWhID varchar(10) ,
	@POUnit nvarchar(15) ,
	@SOUnit nvarchar(15) ,
	@INUnit nvarchar(15) ,	
	@Crtd_DateTime datetime ,
	@Crtd_Prog varchar(8) ,
	@Crtd_User varchar(10) ,
	@LUpd_DateTime datetime ,
	@LUpd_Prog varchar(8) ,
	@LUpd_User varchar(10) 
AS

declare @exist int
set @exist = (SELECT Count(*) FROM INProductClass2 WHERE VendID = @ClassID1 AND ClassID1 = @ClassID1 and ClassID2 = @ClassID2)

If @exist = 0
BEGIN
INSERT INTO INProductClass2
				(	VendID ,
					ClassID1 ,
					ClassID2,
					Descr ,
					DfltTaxID ,
					DfltWhID ,
					POUnit ,
					SOUnit ,
					INUnit ,
					Crtd_DateTime ,
					Crtd_Prog ,
					Crtd_User ,
					LUpd_DateTime ,
					LUpd_Prog ,
					LUpd_User 
 				)
VALUES			(	@VendID ,
					@ClassID1 ,
					@ClassID2,
					@Descr ,
					@DfltTaxID ,
					@DfltWhID ,
					@POUnit ,
					@SOUnit ,
					@INUnit ,
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
	UPDATE INProductClass2 SET VendID =@VendID ,
							ClassID1 =@ClassID1 ,
							ClassID2 =@ClassID2 ,
							Descr =@Descr ,
							DfltTaxID =@DfltTaxID ,
							DfltWhID =@DfltWhID ,
							POUnit =@POUnit ,
							SOUnit =@SOUnit ,
							INUnit =@INUnit ,
							LUpd_DateTime =@LUpd_DateTime ,
							LUpd_Prog =@LUpd_Prog ,
							LUpd_User =@LUpd_User 
	WHERE VendID = @VendID AND ClassID1 = @ClassID1 AND ClassID2 = @ClassID2
END