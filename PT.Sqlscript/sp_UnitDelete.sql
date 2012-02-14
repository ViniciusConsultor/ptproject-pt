USE [PT.Manager]
GO

/****** Object:  StoredProcedure [dbo].[sp_UnitDelete]    Script Date: 02/13/2012 23:01:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_UnitDelete]
	@Unit nvarchar(15) 
AS

DELETE FROM INUnit WHERE Unit = @Unit
GO

