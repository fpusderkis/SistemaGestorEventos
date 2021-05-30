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