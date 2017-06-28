USE [AspNetCoreToDo]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 6/28/2017 13:24:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] NULL,
	[Name] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 6/28/2017 13:24:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[IsComplete] [bit] NULL,
	[CategoryId] [int] NULL
) ON [PRIMARY]

GO
