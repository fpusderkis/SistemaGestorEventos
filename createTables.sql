USE [sgedb]
GO

/****** Object:  Table [dbo].[Bitacora]    Script Date: 30/5/2021 15:37:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bitacora](
	[userId] [uniqueidentifier] NULL,
	[message] [varchar](1000) NULL,
	[creationDate] [datetime] NOT NULL
) ON [PRIMARY]
GO

