CREATE TABLE [dbo].[SAMessage](
	[MsID] [varchar](50) NOT NULL,
	[Language1] [nvarchar](200) NULL,
	[Language2] [nvarchar](200) NULL,
	[Language3] [nvarchar](200) NULL,
	[Descr] [nvarchar](200) NULL,
 CONSTRAINT [PK_SAMessage] PRIMARY KEY CLUSTERED 
(
	[MsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

INSERT INTO SAMessage(MsID, Language1, Language2, Language3, Descr) VALUES(N'001', N'Hãy nhập', N'Please input', N'', N'Language + Label (Warning)')
INSERT INTO SAMessage(MsID, Language1, Language2, Language3, Descr) VALUES(N'002', N'đã được sử dụng, không được phép xóa', N'is used, can not delete', N'', N'Label  + Language (Stop)')
INSERT INTO SAMessage(MsID, Language1, Language2, Language3, Descr) VALUES(N'003', N'đã được xử lý ở', N'is processed in', N'', N'DocNbr1 + Language + DocNbr2 (Stop)')
INSERT INTO SAMessage(MsID, Language1, Language2, Language3, Descr) VALUES(N'004', N'Hãy chọn dòng cần xóa', N'Please select rows to delete', N'', N'Language')





