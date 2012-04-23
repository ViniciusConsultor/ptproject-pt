USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_INDocDetGetByDoc]    Script Date: 04/20/2012 09:45:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INDocDetGetByDoc]    
 @BranchID varchar (10),    
 @DocNbr varchar(10),  
 @Module varchar(2)    
AS    
SELECT BranchID,DocNbr,Module,LineRef,TranType,TranDate,WhID,ToWhID,FreeItem,ProductID,TranDesc,LotID,INUnit,LineQty,UnitCost,TotalCost,InvtMult,ObjID,ShipperID,RsID,Rlsed,SONbr,PONbr,Cnvfact,UnitRate,DetailQty,Crtd_DateTime,Crtd_Prog,Crtd_User,LUpd_DateTime,LUpd_Prog,LUpd_User,master.dbo.fn_varbintohexstr(Version) Version FROM INDocDet    
WHERE BranchID = @BranchID    
AND DocNbr = @DocNbr    
AND Module = @Module  