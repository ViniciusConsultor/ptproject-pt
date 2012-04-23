USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_APDocListGetByPara]    Script Date: 04/23/2012 15:20:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_APDocGetVersion]  
 @BranchID varchar(10),   
 @DocNbr varchar(10)
AS    
SELECT BranchID,DocNbr,DocType,DocDesc,DocAcct,VendID,DocBal,OrigDocAmt,DocDate,PONbr,InvcNbr,InvcNote,Rlsed,TaxId,PreTaxAmt,TaxAmt,TimeLmtID,DueDate,Note,Crtd_DateTime,Crtd_Prog,Crtd_User,LUpd_DateTime,LUpd_Prog,LUpd_User,master.dbo.fn_varbintohexstr(Version) Version 
FROM APDoc 
WHERE DocNbr = @DocNbr
AND BranchID = @BranchID
  
