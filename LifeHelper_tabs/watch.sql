USE [LifeHelper]
GO
/****** Object:  Table [dbo].[To_Watch]    Script Date: 2018-05-05 16:50:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[To_Watch](
	[Films/TV series to watch] [nvarchar](50) NULL,
	[Recommended by] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'The Mentalist', N'Dominik')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'House of Cards                ', N'Filmweb                       ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'Hannibal                      ', N'Natalia                       ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'True Detective                ', N'Filmweb                       ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'Secret Life of snails         ', N'???                           ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'The world is gonna roll me    ', N'Somebody once told me         ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'Breaking Bad                  ', N'Filmweb                       ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'Narcos                        ', N'Filmweb                       ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'Sherlock BBC                  ', N'Marta                         ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'How I met your mother         ', N'Dominik                       ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'Moana                         ', N'Ola                           ')
INSERT [dbo].[To_Watch] ([Films/TV series to watch], [Recommended by]) VALUES (N'Britannia', N'Mateusz')
