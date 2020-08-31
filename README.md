--Esse foi o Banco de Dados utilizado para realizar testes.

USE [locadora]
GO

/****** Object:  Table [dbo].[tbCliente]    Script Date: 31/08/2020 01:58:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbCliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [locadora]
GO

/****** Object:  Table [dbo].[tbFilme]    Script Date: 31/08/2020 01:59:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbFilme](
	[idFilme] [int] IDENTITY(1,1) NOT NULL,
	[sitStatus] [bit] NOT NULL,
	[nmFilme] [varchar](100) NOT NULL,
	[retirado] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idFilme] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [locadora]
GO

/****** Object:  Table [dbo].[tbSituacao]    Script Date: 31/08/2020 01:59:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbSituacao](
	[idFilme] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[Devolucao] [datetime] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbSituacao]  WITH CHECK ADD  CONSTRAINT [FK_tbCliente_tbSituacao] FOREIGN KEY([idCliente])
REFERENCES [dbo].[tbCliente] ([idCliente])
GO

ALTER TABLE [dbo].[tbSituacao] CHECK CONSTRAINT [FK_tbCliente_tbSituacao]
GO

ALTER TABLE [dbo].[tbSituacao]  WITH CHECK ADD  CONSTRAINT [FK_tbFilme_tbSituacao] FOREIGN KEY([idFilme])
REFERENCES [dbo].[tbFilme] ([idFilme])
GO

ALTER TABLE [dbo].[tbSituacao] CHECK CONSTRAINT [FK_tbFilme_tbSituacao]
GO

