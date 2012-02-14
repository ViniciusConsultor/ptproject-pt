USE [PT.Manager]
GO

/****** Object:  StoredProcedure [dbo].[sp_ProductGetByProductID]    Script Date: 02/13/2012 23:02:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_ProductGetByProductID]
	@ProductID varchar(30)
AS

SELECT	*
FROM INProduct WHERE ProductID = @ProductID
GO

