USE [sgedb]
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuario_Crear]    Script Date: 26/9/2021 17:48:36 ******/
DROP PROCEDURE [dbo].[sp_Usuario_Crear]
GO
/****** Object:  StoredProcedure [dbo].[sp_Traducciones_Upsert]    Script Date: 26/9/2021 17:48:36 ******/
DROP PROCEDURE [dbo].[sp_Traducciones_Upsert]
GO
/****** Object:  StoredProcedure [dbo].[sp_Idioma_Upsert]    Script Date: 26/9/2021 17:48:36 ******/
DROP PROCEDURE [dbo].[sp_Idioma_Upsert]
GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarBitacora]    Script Date: 26/9/2021 17:48:36 ******/
DROP PROCEDURE [dbo].[sp_GuardarBitacora]
GO
ALTER TABLE [dbo].[usuarios_permisos] DROP CONSTRAINT [FK_usuarios_permisos_usuarios]
GO
ALTER TABLE [dbo].[usuarios_permisos] DROP CONSTRAINT [FK_usuarios_permisos_permiso]
GO
ALTER TABLE [dbo].[permiso_permiso] DROP CONSTRAINT [FK_permiso_permiso_permiso1]
GO
ALTER TABLE [dbo].[permiso_permiso] DROP CONSTRAINT [FK_permiso_permiso_permiso]
GO
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 26/9/2021 17:48:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuarios_permisos]') AND type in (N'U'))
DROP TABLE [dbo].[usuarios_permisos]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 26/9/2021 17:48:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[Traducciones]    Script Date: 26/9/2021 17:48:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Traducciones]') AND type in (N'U'))
DROP TABLE [dbo].[Traducciones]
GO
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 26/9/2021 17:48:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[permiso_permiso]') AND type in (N'U'))
DROP TABLE [dbo].[permiso_permiso]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 26/9/2021 17:48:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[permiso]') AND type in (N'U'))
DROP TABLE [dbo].[permiso]
GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 26/9/2021 17:48:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Idiomas]') AND type in (N'U'))
DROP TABLE [dbo].[Idiomas]
GO
/****** Object:  Table [dbo].[Bitacoras]    Script Date: 26/9/2021 17:48:36 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bitacoras]') AND type in (N'U'))
DROP TABLE [dbo].[Bitacoras]
GO
/****** Object:  Table [dbo].[Bitacoras]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacoras](
	[userId] [uniqueidentifier] NULL,
	[message] [varchar](1000) NULL,
	[creationDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idiomas]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idiomas](
	[Id] [varchar](5) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Idiomas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[nombre] [varchar](100) NULL,
	[id] [uniqueidentifier] NOT NULL,
	[permiso] [varchar](50) NULL,
 CONSTRAINT [PK_permiso_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_padre] [uniqueidentifier] NULL,
	[id_permiso_hijo] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traducciones]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traducciones](
	[clave] [varchar](255) NOT NULL,
	[idioma] [varchar](5) NOT NULL,
	[valor] [varchar](500) NULL,
 CONSTRAINT [PK_Traducciones] PRIMARY KEY CLUSTERED 
(
	[clave] ASC,
	[idioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [sgedb]
GO

/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/5/2022 01:01:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO

/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/5/2022 01:01:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuarios](
	[Id] [uniqueidentifier] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[idioma] [varchar](5) NOT NULL,
	[FailCount] [int] NULL,
	[LastLogin] [datetime] NULL,
	[expired] [tinyint] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_permisos](
	[id_usuario] [uniqueidentifier] NOT NULL,
	[id_permiso] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_usuarios_permisos] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_permiso_permiso] FOREIGN KEY([id_permiso_padre])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[permiso_permiso] CHECK CONSTRAINT [FK_permiso_permiso_permiso]
GO
ALTER TABLE [dbo].[permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_permiso_permiso_permiso1] FOREIGN KEY([id_permiso_hijo])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[permiso_permiso] CHECK CONSTRAINT [FK_permiso_permiso_permiso1]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_permiso] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[permiso] ([id])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_permiso]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([Id])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_usuarios]
GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarBitacora]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GuardarBitacora] 
	-- Add the parameters for the stored procedure here
	@userId uniqueidentifier, 
	@message varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	INSERT INTO [dbo].[Bitacoras]
           ([userId]
           ,[message],
		   [creationDate])
     VALUES
           (@userId
           ,@message,
		   GETDATE())

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Idioma_Upsert]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Idioma_Upsert]
	-- Add the parameters for the stored procedure here
	@idioma varchar(5), 
	@descripcion varchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	  BEGIN TRAN
 
		IF EXISTS ( SELECT * FROM dbo.Idiomas WITH (UPDLOCK) WHERE id = @idioma)
 
		  UPDATE dbo.Idiomas
			 SET Id = @idioma, Descripcion = @descripcion
		   WHERE id = @idioma;
 
		ELSE 
 
		  INSERT dbo.Idiomas( Id, Descripcion)
		  VALUES ( @idioma,@descripcion);
 
	  COMMIT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Traducciones_Upsert]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_Traducciones_Upsert]
	-- Add the parameters for the stored procedure here
	@idioma varchar(5), 
	@clave varchar(255),
	@valor varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	  BEGIN TRAN
 
		IF EXISTS ( SELECT * FROM dbo.Traducciones WITH (UPDLOCK) WHERE idioma = @idioma AND clave = @clave)
 
		  UPDATE dbo.Traducciones
			 SET valor = @valor
		   WHERE idioma = @idioma AND clave = @clave;
 
		ELSE 
 
		  INSERT dbo.Traducciones ( idioma, clave, valor )
		  VALUES ( @idioma, @clave,@valor );
 
	  COMMIT
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuario_Crear]    Script Date: 26/9/2021 17:48:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Usuario_Crear]
	-- Add the parameters for the stored procedure here
	@Id uniqueidentifier, 
	@Username varchar(50),
	@Password varchar(50),
	@Idioma varchar(5)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	

   INSERT INTO [dbo].[Usuarios]
           ([Id]
           ,[username]
           ,[password]
           ,[idioma])
     VALUES
           (@Id,
           @Username,
           @Password,
           @Idioma);

END
GO

USE [sgedb]
GO
/****** Object:  StoredProcedure [dbo].[sp_Usuario_Upsert]    Script Date: 16/5/2022 15:58:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_Usuario_Upsert]
	-- Add the parameters for the stored procedure here
	@Id uniqueidentifier, 
	@Username varchar(50),
	@Password varchar(250),
	@Idioma varchar(5),
	@FailCount int,
	@LastLogin datetime,
	@expired tinyint,
	@checkdigit int,
	@lastname varchar(250),
	@name varchar(250)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	  BEGIN TRAN
 
		IF EXISTS ( SELECT * FROM dbo.[Usuarios] WITH (UPDLOCK) WHERE id = @Id)
		UPDATE [dbo].[Usuarios]
		   SET
			  [username] = @username
			  ,[password] = @password
			  ,[Language] = @idioma
			  ,[FailCount] = @failcount
			  ,[LastLogin] = @lastlogin
			  ,[expired] = @expired
			  ,[checkdigit] = @checkdigit
			  ,[Lastname] = @lastname
			  ,[Name] = @name
		 WHERE Id = @Id;
	
		ELSE 
 
		  	INSERT INTO [dbo].[Usuarios]
				   ([Id]
				   ,[username]
				   ,[password]
				   ,[Language]
				   ,[FailCount]
				   ,[LastLogin]
				   ,[expired]
				   ,[checkdigit]
				   ,[Lastname]
				   ,[Name])
			 VALUES
				   (@id
				   ,@username
				   ,@password
				   ,@idioma
				   ,@FailCount
				   ,@LastLogin
				   ,@expired
				   ,@checkdigit
				   ,@lastname
				   ,@name)
 
 
	  COMMIT
END
