USE [LifeHelper]
GO
/****** Object:  Table [dbo].[My_week]    Script Date: 2018-05-05 16:49:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[My_week](
	[Subject] [nvarchar](50) NULL,
	[Day of the week] [nvarchar](50) NULL,
	[Time] [time](7) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'Chemistry           ', N'Monday    ', CAST(N'09:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'English             ', N'Monday    ', CAST(N'11:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'Maths               ', N'Tuesday   ', CAST(N'13:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'Physics', N'Tuesday', CAST(N'15:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'Biology             ', N'Tuesday   ', CAST(N'17:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'Informatics         ', N'Wednesday ', CAST(N'11:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'History             ', N'Wednesday ', CAST(N'13:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'Genetics            ', N'Wednesday ', CAST(N'15:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'Molecular Dynamics  ', N'Friday    ', CAST(N'09:00:00' AS Time))
INSERT [dbo].[My_week] ([Subject], [Day of the week], [Time]) VALUES (N'Biophysics', N'Friday', CAST(N'13:00:00' AS Time))
