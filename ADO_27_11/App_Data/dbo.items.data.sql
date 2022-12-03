SET IDENTITY_INSERT [dbo].[items] ON
INSERT INTO [dbo].[items] ([Id], [ItemName], [Price], [DateInStore]) VALUES (2, N'Hat', CAST(44.0000 AS Money), N'2002-02-02')
INSERT INTO [dbo].[items] ([Id], [ItemName], [Price], [DateInStore]) VALUES (3, N'Shirt', CAST(33.0000 AS Money), N'2002-01-01')
INSERT INTO [dbo].[items] ([Id], [ItemName], [Price], [DateInStore]) VALUES (4, N'Socks', CAST(1111.0000 AS Money), N'2005-05-05')
SET IDENTITY_INSERT [dbo].[items] OFF
