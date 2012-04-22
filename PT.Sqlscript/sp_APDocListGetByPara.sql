USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_APDocListGetByPara]    Script Date: 04/22/2012 09:37:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_APDocListGetByPara]  
 @ProID varchar (8),  
 @UserID varchar(10),   
 @DocType nvarchar(2),
 @FromDate smalldatetime,   
 @ToDate smalldatetime ,
 @DocNbr varchar(10), 
 @InvcNbr varchar (15) 
AS  
  
SELECT BranchID,DocNbr,DocType,DocDesc,DocAcct,VendID,DocBal,OrigDocAmt,DocDate,PONbr,InvcNbr,InvcNote,Rlsed,TaxId,PreTaxAmt,TaxAmt,TimeLmtID,DueDate,Note,Crtd_DateTime,Crtd_Prog,Crtd_User,LUpd_DateTime,LUpd_Prog,LUpd_User,master.dbo.fn_varbintohexstr(Version) Version 
FROM APDoc 
WHERE Crtd_Prog = @ProID  
AND Crtd_User like case when @UserID = 'ALL' then '%' else @UserID end  
AND DocDate between @FromDate and @ToDate  
AND DocNbr like '%'+@DocNbr+'%'
AND InvcNbr like '%'+@InvcNbr+'%'
AND DocType = @DocType
  
