USE [PT.Manager]
GO

/****** Object:  StoredProcedure [dbo].[sp_UnitSave]    Script Date: 02/13/2012 23:02:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- Batch submitted through debugger: SQLQuery2.sql|7|0|C:\Users\LTPhuoc\AppData\Local\Temp\~vs9489.sql
CREATE PROCEDURE [dbo].[sp_UnitSave]
	@Unit nvarchar(15) ,
	@Crtd_DateTime datetime ,
	@Crtd_Prog varchar(8) ,
	@Crtd_User varchar(10) ,	
	@LUpd_DateTime datetime ,
	@LUpd_Prog char(8) ,
	@LUpd_User char(10) 
	
AS

declare @exist int
set @exist = (SELECT Count(*) FROM INUnit WHERE Unit = @Unit)

If @exist = 0
BEGIN
INSERT INTO INUnit
				(	Unit
				  ,Crtd_DateTime
				  ,Crtd_Prog
				  ,Crtd_User
				  ,LUpd_DateTime
				  ,LUpd_Prog
				  ,LUpd_User 
				)
VALUES			(	@Unit,
					@Crtd_DateTime ,
					@Crtd_Prog ,
					@Crtd_User ,
					@LUpd_DateTime ,
					@LUpd_Prog ,
					@LUpd_User 
				)
END
ELSE
BEGIN
	UPDATE INUnit SET Unit =@Unit ,					
					LUpd_DateTime =@LUpd_DateTime ,
					LUpd_Prog =@LUpd_Prog ,
					LUpd_User =@LUpd_User 
	WHERE Unit = @Unit
END
GO

