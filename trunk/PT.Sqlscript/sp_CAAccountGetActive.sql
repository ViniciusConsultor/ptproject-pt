USE [PT.Manager]
GO
/****** Object:  StoredProcedure [dbo].[sp_CAAccountGetActive]    Script Date: 04/22/2012 09:38:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_CAAccountGetActive]    
AS    
SELECT * FROM CAAccount    
WHERE Active = 1