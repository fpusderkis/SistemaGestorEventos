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


USE [sgedb]
GO

/****** Object:  StoredProcedure [dbo].[sp_Usuario_Upsert]    Script Date: 17/7/2022 17:28:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Event_Upsert]
	-- Add the parameters for the stored procedure here
	@Id int OUTPUT, 
	@Title varchar(100),
	@Description varchar(1000),
	@MinBudget numeric(18,2),
	@MaxBudget numeric(18,2),
	@Guess int,
	@EventType varchar(50),
	@EventRoomId int,
	@EventRoomDetails varchar(300),
	@EventRoomPrice numeric(18,2),
	@CustomerId int,
    @UserId uniqueidentifier,
    @SpecialRequest varchar(1000),
    @Status varchar(50),
    @DateFrom datetime,
    @DateTo datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	  BEGIN TRAN
 
		IF @Id is not null 
		BEGIN
			UPDATE [dbo].[Events]
			   SET [Title] = @Title
				  ,[Description] = @Description
				  ,[MinBudget] = @MinBudget
				  ,[MaxBudget] = @MaxBudget
				  ,[Guess] = @Guess
				  ,[EventType] = @EventType
				  ,[EventRoomId] = @EventRoomId
				  ,[EventRoomDetails] = @EventRoomDetails
				  ,[EventRoomPrice] = @EventRoomPrice
				  ,[CustomerId] = @CustomerId
				  ,[LastUpdatedAt] = CURRENT_TIMESTAMP 
				  ,[LastUpdatedBy] = @UserId
				  ,[SpecialRequest] = @SpecialRequest
				  ,[Status] = @Status
				  ,[DateFrom] = @DateFrom
				  ,[DateTo] = @DateTo
			 WHERE Id = @Id;
			 
		END
		ELSE 
		BEGIN
			INSERT INTO [dbo].[Events]
				   ([Title]
				   ,[Description]
				   ,[MinBudget]
				   ,[MaxBudget]
				   ,[Guess]
				   ,[EventType]
				   ,[EventRoomId]
				   ,[EventRoomDetails]
				   ,[EventRoomPrice]
				   ,[CustomerId]
				   ,[CreatedAt]
				   ,[LastUpdatedAt]
				   ,[LastUpdatedBy]
				   ,[CreatedBy]
				   ,[SpecialRequest]
				   ,[Status]
				   ,[DateFrom]
				   ,[DateTo])
			 VALUES
				   (@Title
				   ,@Description
				   ,@MinBudget
				   ,@MaxBudget
				   ,@Guess
				   ,@EventType
				   ,@EventRoomId
				   ,@EventRoomDetails
				   ,@EventRoomPrice
				   ,@CustomerId
				   ,SYSDATETIME()
				   ,NULL -- [LastUpdatedAt]
				   ,NULL -- [LastUpdatedBy]
				   ,@UserId
				   ,@SpecialRequest
				   ,@Status
				   ,@DateFrom
				   ,@DateTo);

		    SELECT @Id = SCOPE_IDENTITY();
			END
 
 
	  COMMIT
END
GO



CREATE PROCEDURE [dbo].[sp_AditionalService_Upsert]
	-- Add the parameters for the stored procedure here
	@Id int OUTPUT, 
	@ServiceId int,
	@EventId int,
	@Quantity numeric(18,2),
	@Price numeric(18,2),
	@Description varchar(500)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	  BEGIN TRAN
 
		IF @Id is not null 
		BEGIN
			UPDATE [dbo].[AditionalServices]
			   SET [ServiceId] = @ServiceId
				  ,[EventId] = @EventId
				  ,[Quantity] = @Quantity
				  ,[Description] = @Description
				  ,[Price] = @Price
				  ,[UpdatedAt] = CURRENT_TIMESTAMP
			 WHERE Id = @Id;

			 
		END
		ELSE 
		BEGIN
			
			INSERT INTO [dbo].[AditionalServices]
			   ([ServiceId]
			   ,[EventId]
			   ,[Quantity]
			   ,[Description]
			   ,[Price]
			   ,[CreatedAt]
			   )
			VALUES
			   (
			   @ServiceId
			   ,@EventId
			   ,@Quantity
			   ,@Description
			   ,@Price
			   ,CURRENT_TIMESTAMP
			   );

		    SELECT @Id = SCOPE_IDENTITY();
		END
 
			
	  COMMIT
END

GO

CREATE PROCEDURE [dbo].[sp_Payment_Upsert]
	-- Add the parameters for the stored procedure here
	@Id int OUTPUT, 
	@EventId int,
	@Type varchar(20),
	@Amount numeric(18,2),
	@PaymentDate datetime,
	@ConciliationKey varchar(50),
	@Status bit,
	@UserId uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	  BEGIN TRAN
 
		IF @Id is not null 
		BEGIN
			UPDATE [dbo].[Payments]
			   SET [EventId] = @EventId
				  ,[Type] = @Type
				  ,[Amount] = @Amount
				  ,[PaymentDate] = @PaymentDate
				  ,[ConciliationKey] = @ConciliationKey
				  ,[Status] = @Status
				  ,[ModifiedAt] = CURRENT_TIMESTAMP
				  ,[ModifiedBy] = @UserId
			 WHERE Id = @Id
		END
		ELSE 
		BEGIN

			INSERT INTO [dbo].[Payments]
					   ([EventId]
					   ,[Type]
					   ,[Amount]
					   ,[PaymentDate]
					   ,[ConciliationKey]
					   ,[Status]
					   ,[CreatedAt]
					   ,[CreatedBy]
					   )
				 VALUES
					   (@EventId
					   ,@Type
					   ,@Amount
					   ,@PaymentDate
					   ,@ConciliationKey
					   ,@Status
					   ,CURRENT_TIMESTAMP
					   ,@UserId
					   )

		    SELECT @Id = SCOPE_IDENTITY();
		END
 
			
	  COMMIT
END