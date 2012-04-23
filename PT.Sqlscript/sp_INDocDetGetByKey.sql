USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_INDocDetGetByKey]    Script Date: 04/20/2012 09:45:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INDocDetGetByKey]    
 @BranchID VARCHAR(10),    
 @DocNbr VARCHAR(10),    
 @Module VARCHAR(2)    
AS    
SELECT BranchID,DocNbr,DocDate,DocDescr,Module,TranType,WhID,ToWhID,TotQty,TotAmt,RsID,Rlsed,Note,Crtd_DateTime,Crtd_Prog,Crtd_User,LUpd_DateTime,LUpd_Prog,LUpd_User,master.dbo.fn_varbintohexstr(Version) Version FROM INDoc  
WHERE BranchID = @BranchID     
AND DocNbr = @DocNbr    
AND Module = @Module 