create PROCEDURE [dbo].[sp_APAdjustListGetByPara] 
 @ProID varchar(8), 
 @UserID varchar(10),   
 @AdjNbr varchar(10),
 @FromDate smalldatetime,   
 @ToDate smalldatetime 
 
AS  
  
SELECT BranchID,AdjNbr,AdjDate,AdjDesc,AdjAcct,AdjAmt,Rlsed,Note,FromDateTmp,ToDateTmp,VendIDTmp,Crtd_DateTime,Crtd_Prog,Crtd_User,LUpd_DateTime,LUpd_Prog,LUpd_User,master.dbo.fn_varbintohexstr(Version) Version 
FROM APAdjust
WHERE Crtd_Prog = @ProID  
AND Crtd_User like case when @UserID = 'ALL' then '%' else @UserID end  
AND AdjDate between @FromDate and @ToDate  
AND AdjNbr like '%'+@AdjNbr+'%'
  
