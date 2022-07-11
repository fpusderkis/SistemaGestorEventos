USE sgedb;
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE sp_GuardarBitacora 
	-- Add the parameters for the stored procedure here
	@userId uniqueidentifier, 
	@message varchar(500)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	INSERT INTO [dbo].[Bitacora]
           ([userId]
           ,[message],
		   [creationDate])
     VALUES
           (@userId
           ,@message,
		   GETDATE())

END
GO

/**
USUARIO
*/
CREATE PROCEDURE sp_Usuario_Crear
	@Id uniqueidentifier, 
	@Username varchar(50),
	@Password varchar(50),
	@Idioma varchar(5)
AS
BEGIN
	SET NOCOUNT ON;	

   INSERT INTO [dbo].[usuarios]
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
/**
TRADUCCIONES
*/
CREATE PROCEDURE sp_Traducciones_Upsert
	@idioma varchar(5), 
	@clave varchar(255),
	@valor varchar(500)
AS
BEGIN
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

USE [sgedb]
GO

/****** Object:  StoredProcedure [dbo].[sp_Usuario_Upsert]    Script Date: 10/7/2022 20:32:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Customer_Upsert]
	-- Add the parameters for the stored procedure here
	@Id int, 
	@Name varchar(100),
	@LastName varchar(100),
	@Mail varchar(500),
	@Phone varchar(500),
	@Address varchar(500),
	@ZipCode varchar(10),
	@TaxPayerId varchar(50),
	@GeneratedId int OUTPUT

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	  BEGIN TRAN
 
		IF EXISTS ( SELECT * FROM dbo.[Customers] WITH (UPDLOCK) WHERE Id = @Id)
		BEGIN
			UPDATE [dbo].[Customers]
			   SET [Name] = @Name
				  ,[LastName] = @LastName
				  ,[Mail] = @Mail
				  ,[Phone] = @Phone
				  ,[Address] = @Address
				  ,[ZipCode] = @ZipCode
				  ,[TaxPayerId] = @TaxPayerId
			 WHERE Id = @Id;
			SET @GeneratedId = @Id;
		COMMIT
		END
		ELSE 
		BEGIN
		  	INSERT INTO [dbo].[Customers]
			   ([Name]
			   ,[LastName]
			   ,[Mail]
			   ,[Phone]
			   ,[Address]
			   ,[ZipCode]
			   ,[TaxPayerId])
			 VALUES
				   (@Name
				   ,@LastName
				   ,@Mail
				   ,@Phone
				   ,@Address
				   ,@ZipCode
				   ,@TaxPayerId);
			COMMIT
			SET @GeneratedId = @@IDENTITY
			END
END
GO


