USE [PT.Manager]
GO

/****** Object:  StoredProcedure [dbo].[sp_ProductDelete]    Script Date: 02/13/2012 23:02:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_ProductDelete]
	@ProductID nvarchar(15) 
AS

DELETE FROM INProduct WHERE ProductID = @ProductID
GO

