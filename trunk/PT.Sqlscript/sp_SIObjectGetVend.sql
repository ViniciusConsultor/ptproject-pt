USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_SIObjectGetVend]    Script Date: 04/22/2012 09:39:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_SIObjectGetVend]      
AS    
SELECT ObjID, Name FROM SIObject  
WHERE ObjType = 'VE'
AND Status = 1