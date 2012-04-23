USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_INDocListGetByPara]    Script Date: 04/20/2012 09:46:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_INDocListGetByPara]  
 @ProID varchar (8),  
 @UserID varchar(10),  
 @TranType varchar(5),  
 @FromDate smalldatetime,  
 @ToDate smalldatetime  
AS  
  
SELECT BranchID,DocNbr,DocDate,DocDescr,Module,TranType,WhID,ToWhID,TotQty,TotAmt,RsID,Rlsed,Note,Crtd_DateTime,Crtd_Prog,Crtd_User,LUpd_DateTime,LUpd_Prog,LUpd_User,master.dbo.fn_varbintohexstr(Version) Version FROM INDoc 
WHERE Crtd_Prog = @ProID  
AND Crtd_User = case when @UserID = 'ALL' then '%' else @UserID end  
AND DocDate between @FromDate and @ToDate  
AND TranType like case when (@TranType = 'AL' OR @TranType='') then '%' else @TranType end  
  