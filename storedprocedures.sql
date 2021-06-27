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

	INSERT INTO [dbo].[Bitacoras]
           ([userId]
           ,[message],
		   [creationDate])
     VALUES
           (@userId
           ,@message,
		   GETDATE())

END


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