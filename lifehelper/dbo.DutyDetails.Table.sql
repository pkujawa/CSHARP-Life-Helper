USE [LifeHelper]
GO
/****** Object:  Table [dbo].[DutyDetails]    Script Date: 2018-05-04 00:44:44 ******/
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
