CREATE PROCEDURE [dbo].[sp_INReasonSave]
	@RsId varchar(10) ,
	@Descr nvarchar(30) ,
	@Crtd_Prog char(8) ,
	@Crtd_User char(10) ,
	@LUpd_DateTime datetime ,
	@LUpd_Prog char(8) ,
	@LUpd_User char(10) 
AS

declare @exist int
set @exist = (SELECT Count(*) FROM INReason WHERE RsID = @RsId)

If @exist = 0
BEGIN
INSERT INTO INReason
				(	RsID ,
					Descr ,
					Crtd_DateTime ,
					Crtd_Prog ,
					Crtd_User ,
					LUpd_DateTime ,
					LUpd_Prog ,
					LUpd_User 
				)
VALUES			(	@RsId ,
					@Descr ,
					GETDATE() ,
					@Crtd_Prog ,
					@Crtd_User ,
					@LUpd_DateTime ,
					@LUpd_Prog ,
					@LUpd_User 
				)
END
ELSE
BEGIN
	UPDATE INReason SET RsID =@RsId ,
					Descr =@Descr,					
					LUpd_DateTime =@LUpd_DateTime ,
					LUpd_Prog =@LUpd_Prog ,
					LUpd_User =@LUpd_User 
	WHERE RsID = @RsId
END