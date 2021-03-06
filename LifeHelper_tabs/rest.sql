USE [LifeHelper]
GO
/****** Object:  Table [dbo].[Calories]    Script Date: 2018-05-05 16:46:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calories](
	[Day of the week] [nvarchar](50) NULL,
	[Form of sport] [nvarchar](50) NULL,
	[Time of exercising [min]]] [int] NULL,
	[Calories burnt] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DutyDetails]    Script Date: 2018-05-05 16:46:22 ******/
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
/****** Object:  Table [dbo].[Imaginary_Friend]    Script Date: 2018-05-05 16:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Imaginary_Friend](
	[Type of advice] [nvarchar](max) NULL,
	[Advices used] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[My_week]    Script Date: 2018-05-05 16:46:22 ******/
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
/****** Object:  Table [dbo].[Plan_of_action]    Script Date: 2018-05-05 16:46:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plan_of_action](
	[Subject] [nvarchar](50) NULL,
	[Duty] [nvarchar](50) NULL,
	[Deadline] [nvarchar](50) NULL,
	[How long will it take? [min]]] [int] NULL
) ON [PRIMARY]
GO
