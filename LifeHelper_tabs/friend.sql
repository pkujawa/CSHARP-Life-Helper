USE [LifeHelper]
GO
/****** Object:  Table [dbo].[Imaginary_Friend]    Script Date: 2018-05-05 16:49:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Imaginary_Friend](
	[Type of advice] [nvarchar](max) NULL,
	[Advices used] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
