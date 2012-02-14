USE [PT.Manager]
GO

/****** Object:  StoredProcedure [dbo].[sp_ProductSave]    Script Date: 02/13/2012 23:02:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_ProductSave]
	@ProductID varchar(30) ,
	@Descr nvarchar(100) ,
	@ClassID2 varchar(10) ,
	@ClassID1 varchar(10) ,
	@VendID varchar(15) ,
	@Status bit ,
	@FromUnit nvarchar(15) ,
	@ToUnit nvarchar(15) ,
	@Cnvfact float ,
	@POFromUnitPrice float ,
	@POToUnitPrice float ,
	@POPriEffDate datetime ,
	@SOFromUnitPrice float ,
	@SOToUnitPrice float ,
	@SOPriEffDate datetime ,
	@POUnit nvarchar(15) ,
	@SOUnit nvarchar(15) ,
	@INUnit nvarchar(15) ,
	@Color nvarchar(20) ,
	@DfltWhID varchar(10) ,
	@Picture varchar(30) ,
	@Size nvarchar(10) ,
	@Volume float ,
	@Weight float ,
	@Style nvarchar(10) ,
	@TaxID varchar(10) ,
	@Crtd_DateTime datetime ,
	@Crtd_Prog varchar(8) ,
	@Crtd_User varchar(10) ,
	@LUpd_DateTime datetime ,
	@LUpd_Prog varchar(8) ,
	@LUpd_User varchar(10) 

	
AS

declare @exist int
set @exist = (SELECT Count(*) FROM INProduct WHERE ProductID = @ProductID)

If @exist = 0
BEGIN
INSERT INTO INProduct
				(	ProductID ,
					Descr ,
					ClassID2 ,
					ClassID1 ,
					VendID ,
					Status ,
					FromUnit ,
					ToUnit ,
					Cnvfact ,
					POFromUnitPrice ,
					POToUnitPrice ,
					POPriEffDate ,
					SOFromUnitPrice ,
					SOToUnitPrice ,
					SOPriEffDate ,
					POUnit ,
					SOUnit ,
					INUnit ,
					Color ,
					DfltWhID ,
					Picture ,
					Size ,
					Volume ,
					Weight ,
					Style ,
					TaxID ,
					Crtd_DateTime ,
					Crtd_Prog ,
					Crtd_User ,
					LUpd_DateTime ,
					LUpd_Prog ,
					LUpd_User 

				)
VALUES			(	@ProductID ,
					@Descr ,
					@ClassID2 ,
					@ClassID1 ,
					@VendID ,
					@Status ,
					@FromUnit ,
					@ToUnit ,
					@Cnvfact ,
					@POFromUnitPrice ,
					@POToUnitPrice ,
					@POPriEffDate ,
					@SOFromUnitPrice ,
					@SOToUnitPrice ,
					@SOPriEffDate ,
					@POUnit ,
					@SOUnit ,
					@INUnit ,
					@Color ,
					@DfltWhID ,
					@Picture ,
					@Size ,
					@Volume ,
					@Weight ,
					@Style ,
					@TaxID ,
					@Crtd_DateTime ,
					@Crtd_Prog ,
					@Crtd_User ,
					@LUpd_DateTime ,
					@LUpd_Prog ,
					@LUpd_User 
				)
END
ELSE
BEGIN
	UPDATE INProduct SET Descr =@Descr ,
						ClassID2 =@ClassID2 ,
						ClassID1 =@ClassID1 ,
						VendID =@VendID ,
						Status =@Status ,
						FromUnit =@FromUnit ,
						ToUnit =@ToUnit ,
						Cnvfact =@Cnvfact ,
						POFromUnitPrice =@POFromUnitPrice ,
						POToUnitPrice =@POToUnitPrice ,
						POPriEffDate =@POPriEffDate ,
						SOFromUnitPrice =@SOFromUnitPrice ,
						SOToUnitPrice =@SOToUnitPrice ,
						SOPriEffDate =@SOPriEffDate ,
						POUnit =@POUnit ,
						SOUnit =@SOUnit ,
						INUnit =@INUnit ,
						Color =@Color ,
						DfltWhID =@DfltWhID ,
						Picture =@Picture ,
						Size =@Size ,
						Volume =@Volume ,
						Weight =@Weight ,
						Style =@Style ,
						TaxID =@TaxID ,
						LUpd_DateTime =@LUpd_DateTime ,
						LUpd_Prog =@LUpd_Prog ,
						LUpd_User =@LUpd_User 
	WHERE ProductID = @ProductID
END
GO

