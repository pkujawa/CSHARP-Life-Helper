USE [LifeHelper]
GO
/****** Object:  Table [dbo].[DutyDetails]    Script Date: 2018-05-05 16:48:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DutyDetails](
	[Subject] [nvarchar](50) NULL,
	[Duty] [nvarchar](50) NULL,
	[Details] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'Chemistry           ', N'homework            ', N'38/5,6; 39/2')
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'English             ', N'essay               ', N'details: page 12 in coursebook')
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'Maths               ', N'homework            ', N'12/5a,b,c; 13/6')
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'Physics', N'test', NULL)
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'Biology             ', N'-', N'-')
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'Informatics         ', N'project', N'website')
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'History             ', N'-', N'-')
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'Genetics            ', N'-', N'-')
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'Molecular Dynamics  ', N'test', N'Holy Mass at 6:00')
INSERT [dbo].[DutyDetails] ([Subject], [Duty], [Details]) VALUES (N'Biophysics', N'project', N'Beer with Maczek and Jan while pretending to make the project')
