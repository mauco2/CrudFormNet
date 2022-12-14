USE [cursocrud]
GO
/****** Object:  Table [dbo].[tabla]    Script Date: 15/08/2022 06:08:51 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tabla](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varbinary](50) NULL,
	[correo] [varbinary](50) NULL,
	[fechanacimiento] [datetime] NULL,
	[nombre1] [varchar](50) NULL,
	[correo1] [varchar](50) NULL,
 CONSTRAINT [PK_tabla] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
