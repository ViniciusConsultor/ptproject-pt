USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_APAdjustDetListGetByPara]    Script Date: 05/09/2012 10:59:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_APAdjustDetListGetByPara] 
 @AdjNbr varchar(10)
AS    
SELECT BranchID,AdjNbr,NDocNbr,AdjDate,AdjAcct,AdjAmt,Rlsed
FROM APAdjustDet
WHERE AdjNbr = @AdjNbr