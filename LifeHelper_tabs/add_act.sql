USE [LifeHelper]
GO
/****** Object:  Table [dbo].[Additional_activities]    Script Date: 2018-05-05 16:45:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Additional_activities](
	[Day of the week] [nvarchar](50) NULL,
	[Additional activity] [nvarchar](50) NULL,
	[Details] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Monday', N'cinema', N'Avengers with Marta')
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Wednesday', N'beer', N'18:00 ')
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Thursday', N'C# course', N'19:00 - [never enough </3]')
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Friday', N'meeting', N'sushi with girls at 19:00')
INSERT [dbo].[Additional_activities] ([Day of the week], [Additional activity], [Details]) VALUES (N'Saturday', N'Food Trucks', N'Asian food with Maczek')
