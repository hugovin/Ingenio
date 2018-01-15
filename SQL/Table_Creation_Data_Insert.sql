SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ingenio](
	[CategoryId] [int] NOT NULL,
	[ParentCategoryId] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Keywords] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Ingenio] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Ingenio] ([CategoryId], [ParentCategoryId], [Name], [Keywords]) VALUES (100, -1, N'Business', N'Money')
GO
INSERT [dbo].[Ingenio] ([CategoryId], [ParentCategoryId], [Name], [Keywords]) VALUES (101, 100, N'Accounting', N'Taxes')
GO
INSERT [dbo].[Ingenio] ([CategoryId], [ParentCategoryId], [Name], [Keywords]) VALUES (102, 100, N'Taxation', N'')
GO
INSERT [dbo].[Ingenio] ([CategoryId], [ParentCategoryId], [Name], [Keywords]) VALUES (103, 101, N'Corporate Tax', N'')
GO
INSERT [dbo].[Ingenio] ([CategoryId], [ParentCategoryId], [Name], [Keywords]) VALUES (109, 101, N'Small Business Tax', N'')
GO
INSERT [dbo].[Ingenio] ([CategoryId], [ParentCategoryId], [Name], [Keywords]) VALUES (200, -1, N'Tutoring', N'Teaching')
GO
INSERT [dbo].[Ingenio] ([CategoryId], [ParentCategoryId], [Name], [Keywords]) VALUES (201, 200, N'Computer', N'')
GO
INSERT [dbo].[Ingenio] ([CategoryId], [ParentCategoryId], [Name], [Keywords]) VALUES (202, 201, N'Operating System', N'')
GO
