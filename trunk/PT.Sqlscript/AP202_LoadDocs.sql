USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[AP202_LoadDocs]    Script Date: 05/09/2012 10:58:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[AP202_LoadDocs] --'MD', 'APCC000037','',0,'2012-01-01','2012-06-01'
@BranchID varchar (10) = '',
@AdjNbr varchar(10) = '',
@VendID varchar (15) = '',    
@Rlsed bit,        
@FromDate SmallDateTime,           
@ToDate SmallDateTime

AS              
             
If @AdjNbr = ''    --LOAD LUOI BAN DAU                 
 BEGIN              
  SELECT convert(bit,0) chk,d.DocNbr,d.InvcNbr,0 Payment,d.DocType,d.DocDate ,d.DocBal,d.VendID,o.Name VendName,d.DocDesc,d.PONbr  
  FROM APDoc d           
  LEFT JOIN SIObject o on d.VendID = o.ObjID and o.ObjType = 'VE'
  WHERE d.Rlsed = 1 AND d.DocBal >0 AND d.DocType = 'TN'   
  AND d.DocNbr not in (SELECT NDocNbr FROM APAdjustDet WHERE Rlsed = 0)  
  AND d.VendID like case when @VendID = '' then '%' else @VendID end  
  AND d.DocDate BETWEEN @FromDate AND @ToDate  
  ORDER BY d.DocDate , d.InvcNbr     
 END          
ELSE  
 IF @Rlsed = 0   -- CHUNG TU CHUA CAP NHAT      
	 BEGIN          
	  SELECT convert(bit,0) chk,d.DocNbr,d.InvcNbr,jd.AdjAmt Payment,d.DocType,d.DocDate,DocBal = d.DocBal -jd.AdjAmt ,d.VendID,o.Name VendName,d.DocDesc   
	  FROM APDoc d 
	  INNER JOIN APAdjustDet jd on d.BranchID = jd.BranchID and d.DocNbr = jd.NDocNbr and jd.Rlsed = 0          
	  LEFT JOIN SIObject o on d.VendID = o.ObjID and o.ObjType = 'VE'  
	  WHERE d.Rlsed = 1 AND d.DocBal >0 AND d.DocType = 'TN'   
	  AND d.VendID like case when @VendID = '' then '%' else @VendID end  
	  AND d.BranchID = @BranchID AND jd.AdjNbr = @AdjNbr 
	  UNION ALL 
	  --SELECT convert(bit,0) chk,d.DocNbr,d.InvcNbr,'' Payment,d.DocBal,d.VendID,o.Name VendName,d.DocDesc   
	  SELECT convert(bit,0) chk,d.DocNbr,d.InvcNbr,'' Payment,d.DocType,d.DocDate,d.DocBal,d.VendID,o.Name VendName,d.DocDesc   
	  FROM APDoc d           
	  LEFT JOIN SIObject o on d.VendID = o.ObjID and o.ObjType = 'VE'
	  WHERE d.Rlsed = 1 AND d.DocBal >0 AND d.DocType = 'TN'   
	  AND d.DocNbr not in (SELECT NDocNbr FROM APAdjustDet WHERE Rlsed = 0)  
	  AND d.VendID like case when @VendID = '' then '%' else @VendID end  
	  AND d.DocDate BETWEEN @FromDate AND @ToDate  
	 END 
 ELSE  -- CHUNG TU DA CAP NHAT HOAC HUY
	 BEGIN
	  --SELECT chkAll = convert(bit,case when d.DocBal = jd.AdjAmt then 1 else  0 end )
	  --		,d.DocNbr,d.InvcNbr,jd.AdjAmt Payment,d.DocType,d.DocBal,d.VendID,o.Name VendName,d.DocDesc   
	  SELECT convert(bit,case when d.DocBal = jd.AdjAmt then 1 else  0 end ) chk,
			d.DocNbr,d.InvcNbr,jd.AdjAmt Payment,d.DocType,DocBal = d.DocBal -jd.AdjAmt,d.VendID,o.Name VendName,d.DocDesc   
	  FROM APDoc d 
	  INNER JOIN APAdjustDet jd on d.BranchID = jd.BranchID and d.DocNbr = jd.NDocNbr and jd.Rlsed <> 0          
	  LEFT JOIN SIObject o on d.VendID = o.ObjID and o.ObjType = 'VE'  
	  WHERE d.Rlsed = 1 AND d.DocBal >0 AND d.DocType = 'TN'   
	  AND d.VendID like case when @VendID = '' then '%' else @VendID end  
	  AND d.BranchID = @BranchID AND jd.AdjNbr = @AdjNbr 
	 END

     
