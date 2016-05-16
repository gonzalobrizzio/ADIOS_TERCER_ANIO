USE [GD1C2016] ;
GO

CREATE SCHEMA [ADIOS_TERCER_ANIO] AUTHORIZATION [gd]

-- -----------------------------------------------------
-- TABLA Funcionalidad
-- -----------------------------------------------------
CREATE  TABLE Funcionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NULL ,
  )



-- -----------------------------------------------------
-- TABLA Usuario
-- -----------------------------------------------------
CREATE  TABLE Usuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  usuario NVARCHAR(255) NOT NULL UNIQUE,
  pass NVARCHAR(255) NULL ,
  mail NVARCHAR(255) NOT NULL UNIQUE,
  deleted INT DEFAULT 0 ,
  intentos INT DEFAULT 0 ,
  )



-- -----------------------------------------------------
-- TABLA Rol
-- -----------------------------------------------------
CREATE  TABLE Rol (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
  deleted INT DEFAULT 0 ,
   )



-- -----------------------------------------------------
-- TABLA TipoDocumento
-- -----------------------------------------------------
CREATE  TABLE TipoDocumento (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NOT NULL ,
   )



-- -----------------------------------------------------
-- TABLA Localidad
-- -----------------------------------------------------
CREATE  TABLE Localidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Persona
-- -----------------------------------------------------
CREATE  TABLE Persona (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NOT NULL ,
  apellido NVARCHAR(255) NOT NULL ,
  documento DECIMAL(18,0) NOT NULL ,
  idTipoDocumento INT REFERENCES TipoDocumento(id) ,
  telefono NVARCHAR(20) NULL ,
  direccion NVARCHAR(255) NOT NULL ,
  direccion_numero DECIMAL(18,0) NULL ,
  piso DECIMAL(18,0) NULL ,
  dpto NVARCHAR(50) NULL ,
  codigoPostal NVARCHAR(50) NOT NULL ,
  fechaNacimiento DATETIME NOT NULL ,
  fechaCreacion DATETIME NOT NULL ,
  idUsuario INT REFERENCES usuario(id) ,
  idLocalidad INT REFERENCES Localidad(id) NULL,
  )


-- -----------------------------------------------------
-- TABLA Empresa
-- -----------------------------------------------------
CREATE  TABLE Empresa (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  razonSocial NVARCHAR(255) NOT NULL ,
  telefono NVARCHAR(20) NULL ,
  direccion NVARCHAR(50) NULL ,
  direccion_numero INT NULL ,
  dpto NVARCHAR(50) NULL ,
  codigoPostal NVARCHAR(50) NULL ,
  cuit NVARCHAR(50) NOT NULL UNIQUE,
  contacto NVARCHAR(45) NULL ,
  idRubro INT REFERENCES Rubro(id) NULL,
  idUsuario INT REFERENCES Usuario(id) ,
  idLocalidad INT REFERENCES Localidad(id) NULL,
  calificacionPromedio INT NULL DEFAULT 0,
  fechaCreacion DATETIME NULL ,
  )



-- -----------------------------------------------------
-- TABLA Estado
-- -----------------------------------------------------
CREATE  TABLE Estado (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(50) NOT NULL ,
  )



-- -----------------------------------------------------
-- TABLA Visibilidad
-- -----------------------------------------------------
CREATE  TABLE Visibilidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  codigo INT NULL ,
  descripcion NVARCHAR(255) NOT NULL ,
  precio numeric(18,2) NULL ,
  porcentaje numeric(18,2) NULL ,
  )



-- -----------------------------------------------------
-- TABLA Item
-- -----------------------------------------------------
CREATE  TABLE Item (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
  stock INT NULL ,
  precio DECIMAL(18,2) NULL ,
  cantidad INT NULL ,
  )



-- -----------------------------------------------------
-- TABLA Envio
-- -----------------------------------------------------
CREATE  TABLE Envio (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  precio DECIMAL(18,2) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Publicacion
-- -----------------------------------------------------
CREATE  TABLE Publicacion (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idEstado INT REFERENCES Estado(id) ,
  idVisibilidad INT REFERENCES Visibilidad(id) ,
  idPublicador INT REFERENCES Usuario(id) ,
  fechaInicio DATETIME NOT NULL ,
  fechaFin DATETIME NOT NULL ,
  descripcion NVARCHAR(255) NULL ,
  tienePreguntas INT NULL ,
  idtipo INT NOT NULL ,
  idRubro INT REFERENCES Rubro(id) ,
  idItem INT REFERENCES Item(id) ,
  idEnvio INT REFERENCES Envio(id) ,
  )



-- -----------------------------------------------------
-- TABLA Rubro
-- -----------------------------------------------------
CREATE  TABLE Rubro (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcionCorta NVARCHAR(50) NOT NULL ,
  descripcionLarga NVARCHAR(255) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Rubro_has_Publicacion
-- -----------------------------------------------------
--CREATE  TABLE Rubro_has_Publicacion (
--  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
--  idPublicacion INT NOT NULL ,
--  idRubro INT NOT NULL ,
--  INDEX fk_Rubro_has_Publicacion_Publicacion1_idx (idPublicacion ASC) ,
--  INDEX fk_Rubro_has_Publicacion_Rubro1_idx (idRubro ASC) ,
--   ,
--  CONSTRAINT fk_Rubro_has_Publicacion_Publicacion1
--    FOREIGN KEY (idPublicacion )
--    REFERENCES mydb.Publicacion (id )
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION,
--  CONSTRAINT fk_Rubro_has_Publicacion_Rubro1
--    FOREIGN KEY (idRubro )
--    REFERENCES mydb.Rubro (id )
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- TABLA RolUsuario
-- -----------------------------------------------------
CREATE  TABLE RolUsuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idUsuario INT REFERENCES Usuario(id) ,
  idRol INT REFERENCES Rol(id) ,
  deleted INT NULL ,
  )



-- -----------------------------------------------------
-- TABLA FuncionalidadRol
-- -----------------------------------------------------
CREATE  TABLE FuncionalidadRol (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES Rol(id) ,
  idFuncionalidad INT REFERENCES Funcionalidad(id) ,
  )



-- -----------------------------------------------------
-- TABLA Compra
-- -----------------------------------------------------
CREATE  TABLE Compra (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idComprador INT REFERENCES Usuario(id) ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  fecha DATETIME NULL ,
  )



-- -----------------------------------------------------
-- TABLA Oferta
-- -----------------------------------------------------
CREATE  TABLE Oferta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  monto DECIMAL(18,2) NOT NULL ,
  idUsuario INT REFERENCES Usuario(id) ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  fecha DATETIME NULL ,
  )



-- -----------------------------------------------------
-- TABLA Calificacion
-- -----------------------------------------------------
CREATE  TABLE Calificacion (
  id INT NOT NULL ,
  idUsuarioCalificador INT NOT NULL ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  fecha DATETIME NULL ,
  valor INT NULL ,
  detalle NVARCHAR(45) NULL ,
  pendiente INT NULL ,
  )



-- -----------------------------------------------------
-- TABLA FormaDePago
-- -----------------------------------------------------
CREATE  TABLE FormaDePago (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(50) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Factura
-- -----------------------------------------------------
CREATE  TABLE Factura (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  fecha DATETIME NULL ,
  importeTotal DECIMAL(18,2) NULL ,
  idComprador INT REFERENCES Usuario(id) ,
  numero INT NULL ,
  idFormaDePago INT REFERENCES FormaDePago(id),
  idPublicacion INT REFERENCES Publicacion(id) ,
  )



-- -----------------------------------------------------
-- TABLA Pregunta
-- -----------------------------------------------------
CREATE  TABLE Pregunta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  pregunta NVARCHAR(255) NULL ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  idUsuarioPregunta INT REFERENCES Usuario(id) ,
  fecha DATETIME NULL ,
  )



-- -----------------------------------------------------
-- TABLA Respuesta
-- -----------------------------------------------------
CREATE  TABLE Respuesta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPregunta INT REFERENCES Pregunta(id) ,
  fecha DATETIME NULL ,
  respuesta NVARCHAR(255) NULL ,
  )
GO

-- -----------------------------------------------------
-- PROCEDURES
-- -----------------------------------------------------

--SP PARA CREAR LOS DATOS ADMINISTRATIVOS
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[generarDatosAdministrativos]
AS BEGIN
	--TIPOS DE DOCUMENTO
	set nocount on;
	set xact_abort on;

	INSERT INTO ADIOS_TERCER_ANIO.TipoDocumento(descripcion) VALUES ('DNI')
	INSERT INTO ADIOS_TERCER_ANIO.TipoDocumento(descripcion) VALUES ('CI')
	INSERT INTO ADIOS_TERCER_ANIO.TipoDocumento(descripcion) VALUES ('LE')
	INSERT INTO ADIOS_TERCER_ANIO.TipoDocumento(descripcion) VALUES ('LC')

	--ROLES
	INSERT INTO ADIOS_TERCER_ANIO.Rol(nombre) VALUES ('Administrativo')
	INSERT INTO ADIOS_TERCER_ANIO.Rol(nombre) VALUES ('Cliente')
	INSERT INTO ADIOS_TERCER_ANIO.Rol(nombre) VALUES ('Empresa')

	--ESTADOS
	INSERT INTO ADIOS_TERCER_ANIO.Estado(nombre) VALUES ('Borrador')
	INSERT INTO ADIOS_TERCER_ANIO.Estado(nombre) VALUES ('Activa')
	INSERT INTO ADIOS_TERCER_ANIO.Estado(nombre) VALUES ('Pausada')
	INSERT INTO ADIOS_TERCER_ANIO.Estado(nombre) VALUES ('Finalizada')

	--FORMAS DE PAGO
	INSERT INTO ADIOS_TERCER_ANIO.FormaDePago(nombre) VALUES ('Efectivo')
	INSERT INTO ADIOS_TERCER_ANIO.FormaDePago(nombre) VALUES ('Tarjeta de Credito')


END
GO


-- SP PARA GENERAR E INSERTAR EL USUARIO EN LA TABLA DE USUARIOS
-- RECIBE EL USUARIO, UN PASSWORD Y EL MAIL PARA INSERTARLO
-- DEVUELVE EL ID USADO PARA PODER USARLO COMO FK
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[generarUsuario](@usuario NVARCHAR(255),@password NVARCHAR(255), @mail NVARCHAR(255),@ultimoID INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	-- INSERTO EL NUEVO USUARIO
	INSERT INTO ADIOS_TERCER_ANIO.Usuario(usuario,pass, mail) 
	VALUES (@usuario,@password,@mail)
	
	-- OBTENGO EL ULTIMO ID 
	SELECT @ultimoID = SCOPE_IDENTITY();
	
	RETURN
	
END
GO

--SP PARA MIGRAR TODOS LAS PERSONAS DE LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarPersonas]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUsuario INT,
			@nombre NVARCHAR(255),
			@apellido NVARCHAR(255),
			@documento NUMERIC(18,0),
			@fechaNac DATETIME,
			@mail NVARCHAR(255),
			@direccion NVARCHAR(255),
			@direccion_numero NUMERIC(18,0),
			@piso NUMERIC(18,0),
			@dpto NVARCHAR(255),
			@codigoPostal NVARCHAR(255)
	DECLARE cur CURSOR FOR

	SELECT DISTINCT 
		Cli_Nombre,
		Cli_Apeliido,
		Cli_Dni,
		Cli_Fecha_Nac,
		Cli_Mail,
		Cli_Dom_Calle,
		Cli_Nro_Calle,
		Cli_Piso,
		Cli_Depto,
		Cli_Cod_Postal
	FROM 
		gd_esquema.Maestra
	WHERE
		Cli_Dni IS NOT NULL

	OPEN cur
	FETCH NEXT FROM cur
		INTO 
		@nombre,
		@apellido,
		@documento,
		@fechaNac,
		@mail,
		@direccion,
		@direccion_numero,
		@piso,
		@dpto,
		@codigoPostal

	WHILE(@@FETCH_STATUS = 0)
		BEGIN
			-- INSERTO TODOS LOS USUARIOS EN LA TABLA DE USUARIOS
			EXECUTE ADIOS_TERCER_ANIO.generarUsuario @documento,NULL,@mail,@ultimoID = @idUsuario OUTPUT;
			DECLARE @idRol int;
			SET @idRol = (select id from ADIOS_TERCER_ANIO.Rol where nombre = 'Cliente')
			INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario)
			VALUES(@idRol, @idUsuario)
			
			INSERT INTO ADIOS_TERCER_ANIO.Persona(
				nombre,
				apellido,
				documento,
				idTipoDocumento,
				direccion,
				direccion_numero,
				piso,
				dpto,
				codigoPostal,
				fechaNacimiento,
				fechaCreacion,
				idUsuario)
			VALUES (
				@nombre,
				@apellido,
				@documento,
				(select id from ADIOS_TERCER_ANIO.TipoDocumento where descripcion = 'DNI'),
				@direccion,
				@direccion_numero,
				@piso,
				@dpto,
				@codigoPostal,
				@fechaNac,
				GETDATE(),
				@idUsuario)
			
				
		FETCH NEXT FROM cur
		INTO 
			@nombre,
			@apellido,
			@documento,
			@fechaNac,
			@mail,
			@direccion,
			@direccion_numero,
			@piso,
			@dpto,
			@codigoPostal
		END
	CLOSE cur 
	DEALLOCATE cur
		
END
GO

--SP PARA MIGRAR TODOS LAS EMPRESAS DE LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarEmpresas]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idUsuario INT,
			@razonSocial NVARCHAR(255) ,
			@telefono INT,
			@direccion NVARCHAR(50),
			@direccion_numero  INT,
			@piso NUMERIC(18,0),
			@dpto NVARCHAR(50) ,
			@codigoPostal NVARCHAR(50) ,
			@cuit NVARCHAR(50) ,
			@contacto NVARCHAR(45) ,
			@rubro NVARCHAR(255),
			@fechaCreacion DATETIME,
			@mail NVARCHAR(255)
	DECLARE cur CURSOR FOR
	SELECT DISTINCT 
		Publ_Empresa_Razon_Social,
		Publ_Empresa_Cuit,
		Publ_Empresa_Fecha_Creacion,
		Publ_Empresa_Mail,
		Publ_Empresa_Dom_Calle,
		Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso,
		Publ_Empresa_Depto,
		Publ_Empresa_Cod_Postal
	FROM 
		gd_esquema.Maestra
	WHERE
		Publ_Empresa_Cuit IS NOT NULL
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@razonSocial,
		@cuit,
		@fechaCreacion,
		@mail,
		@direccion,
		@direccion_numero,
		@piso,
		@dpto,
		@codigoPostal
	WHILE(@@FETCH_STATUS = 0)
		BEGIN
			-- INSERTO TODOS LOS USUARIOS EN LA TABLA DE USUARIOS
			EXECUTE ADIOS_TERCER_ANIO.generarUsuario @cuit, NULL, @mail, @ultimoID = @idUsuario OUTPUT;
			DECLARE @idRol int;
			SET @idRol = (select id from ADIOS_TERCER_ANIO.Rol where nombre = 'Empresa')
			INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario)
			VALUES(@idRol,@idUsuario)
			
			INSERT INTO ADIOS_TERCER_ANIO.Empresa(
				razonSocial,
				telefono ,
				direccion,
				direccion_numero,
				dpto,
				codigoPostal,
				cuit,
				contacto,
				idUsuario,
				fechaCreacion)
			VALUES (
				@razonSocial,
				@telefono,
				@direccion,
				@direccion_numero,
				@dpto,
				@codigoPostal,
				@cuit,
				@contacto,
				@idUsuario,
				@fechaCreacion)
			
				
		FETCH NEXT FROM cur
		INTO 
			@razonSocial,
			@cuit,
			@fechaCreacion,
			@mail,
			@direccion,
			@direccion_numero,
			@piso,
			@dpto,
			@codigoPostal
		END
	CLOSE cur 
DEALLOCATE cur
		
END
GO

--SP PARA MIGRAR TODOS LAS VISIBILIDADES DE LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarVisibilidades]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@codigo INT,
			@descripcion NVARCHAR(255),
			@precio numeric(18,2),
			@porcentaje numeric(18,2)
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Publicacion_Visibilidad_Cod, 
		Publicacion_Visibilidad_Desc, 
		Publicacion_Visibilidad_Precio,
		Publicacion_Visibilidad_Porcentaje
	FROM gd_esquema.Maestra	
	
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@codigo,
		@descripcion,
		@precio,
		@porcentaje
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		INSERT INTO ADIOS_TERCER_ANIO.Visibilidad(codigo, descripcion, precio, porcentaje)
		VALUES (@codigo, @descripcion, @precio, @porcentaje)

		FETCH NEXT FROM cur
		INTO 
			@codigo,
			@descripcion,
			@precio,
			@porcentaje
	END
	CLOSE cur 
	DEALLOCATE cur
END
GO


--SP PARA MIGRAR LOS RUBROS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarRubros]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@descCorta NVARCHAR(50),
			@descLarga NVARCHAR(255)
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Publicacion_Rubro_Descripcion
	FROM gd_esquema.Maestra	
	
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@descCorta
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		INSERT INTO ADIOS_TERCER_ANIO.Rubro(descripcionCorta, descripcionLarga)
		VALUES (@descCorta, NULL)

		FETCH NEXT FROM cur
		INTO 
			@descCorta
	END
	CLOSE cur 
	DEALLOCATE cur
END
GO

--Lo empiezo pero no está terminado--
--SP PARA MIGRAR LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarFacturas]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@fecha			DATETIME,
			@importeTotal	decimal(18,2),
			@idComprador	INT,
			@numero			INT,
			@idFormaDePago	INT,
			@idPublicacion	INT
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Factura_Fecha,
		Factura_Total,
		Factura_Nro
	FROM gd_esquema.Maestra	
	
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@fecha,
		@importeTotal,
		@numero
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		SET @idFormaDePago = (SELECT nombre FROM ADIOS_TERCER_ANIO.FormaDePago WHERE (SELECT Forma_Pago_Desc FROM gd_esquema.Maestra) = 'Tarjeta de credito' 
		or (SELECT Forma_Pago_Desc FROM gd_esquema.Maestra) = 'Efectivo')
		--SET @idComprador = SELECT id FROM ADIOS_TERCER_ANIO.Compra WHERE
		--SET @idPublicacion = SELECT id FROM ADIOS_TERCER_ANIO.Publicacion WHERE 
		INSERT INTO 
		ADIOS_TERCER_ANIO.Factura(fecha,
		 importeTotal,
		 numero)
		VALUES (@fecha,
		 @importeTotal, 
		 @numero)

		FETCH NEXT FROM cur
		INTO 
			@fecha,
			@importeTotal,
			@numero
	END
	CLOSE cur 
	DEALLOCATE cur
END
GO

--SP PARA MIGRAR LOS ITEMS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarItems]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@nombre				NVARCHAR(255),
			@stock				INT,
			@precio				DECIMAL(18,2),
			@cantidad			INT
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Publicacion_Descripcion,	
		Publicacion_Stock,
		Item_Factura_Monto,
		Item_Factura_Cantidad
	FROM gd_esquema.Maestra	
	
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@nombre,
		@stock,
		@precio,
		@cantidad
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		INSERT INTO 
		ADIOS_TERCER_ANIO.Item(nombre,
		stock,
		precio,
		cantidad)
		VALUES (@nombre,
		 @stock, 
		 @precio,
		 @cantidad)

		FETCH NEXT FROM cur
		INTO 
			@nombre,
			@stock, 
			@precio,
			@cantidad
	END
	CLOSE cur 
	DEALLOCATE cur
END
GO

--SP PARA MIGRAR LAS CALIFICACIONES QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarCalificaciones]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@id						INT,
			@idUsuarioCalificador	INT,
			@idPublicacion			INT,
			@fecha					DATETIME,
			@valor					INT,
			@detalle				NVARCHAR(45),
			@pendiente				INT
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Calificacion_Codigo,	
		Publicacion_Fecha_Venc,
		Calificacion_Cant_Estrellas,
		Calificacion_Descripcion
	FROM gd_esquema.Maestra	
	
	OPEN cur
	FETCH NEXT FROM cur
	INTO 
			@id,
			@fecha,
			@valor,
			@detalle
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		-- SET @id 
		SET @idUsuarioCalificador = (SELECT id FROM ADIOS_TERCER_ANIO.Usuario WHERE (SELECT Publ_Cli_Dni from gd_esquema.Maestra) = usuario or (SELECT Publ_Empresa_Cuit from gd_esquema.Maestra) = usuario )
		SET @pendiente = 1
		
		INSERT INTO 
		ADIOS_TERCER_ANIO.Calificaciones(idPublicacion,	
		fecha,
		valor,
		detalle)
		VALUES (@idPublicacion,
		 @fecha, 
		 @valor,
		 @detalle)

		FETCH NEXT FROM cur
		INTO @idPublicacion,
		 @fecha, 
		 @valor,
		 @detalle
	END
	CLOSE cur 
	DEALLOCATE cur
END
GO


--SP PARA MIGRAR LAS PUBLICACIONES QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarPublicaciones]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE 
			@id 			INT,
			@idEstado 		INT,
			@idVisibilidad 	INT,
			@idPublicador	INT,
			@fechaInicio 	DATETIME,
			@fechaFin		DATETIME,
			@descripcion	NVARCHAR(255),	
			@tienePreguntas	INT,
			@idtipo			INT,
			@idRubro 		INT,
			@idItem			INT,
			@idEnvio		INT	
	DECLARE cur CURSOR FOR
	
	SELECT DISTINCT
		Publicacion_Cod,
		Publicacion_Estado,
		Publicacion_Visibilidad_Cod,
		Publicacion_Fecha,
		Publicacion_Fecha_Venc,
		Publicacion_Descripcion,
		Publicacion_Tipo
	FROM gd_esquema.Maestra
	WHERE (Publicacion_Fecha_Venc is NOT NULL) AND (Publicacion_Fecha is NOT NULL) 	


	OPEN cur
	FETCH NEXT FROM cur
	INTO 
		@id,
		@fechaInicio,
		@fechaFin,
		@descripcion,
		@idTipo
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		SET @idRubro = (SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE (descripcionCorta = (SELECT Publicacion_Rubro_Descripcion FROM gd_esquema.Maestra)))
		SET @idPublicador = (SELECT id FROM ADIOS_TERCER_ANIO.Usuario WHERE (SELECT Publ_Cli_Dni from gd_esquema.Maestra) = usuario or (SELECT Publ_Empresa_Cuit from gd_esquema.Maestra) = usuario )
		SET @idItem = (SELECT id FROM ADIOS_TERCER_ANIO.Item WHERE (nombre = (SELECT Publicacion_Descripcion FROM gd_esquema.Maestra)))
		--SET @idEnvio = (SELECT id FROM ADIOS_TERCER_ANIO.Envio WHERE (precio = ( FALTA ESTE QUE DEMIAN LO VA A VER, TENGO DUDAS SOBRE EL ITEM IGUAL
		SET @idEstado = (SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE (nombre = 'Activa'))
		SET @idVisibilidad = (SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE ( codigo = (SELECT Publicacion_Visibilidad_Cod FROM gd_esquema.Maestra)))
		INSERT INTO ADIOS_TERCER_ANIO.Publicacion(
		id,
		fechaInicio,
		fechaFin,
		descripcion,
		idtipo)
		VALUES (@id,
		@fechaInicio,
		@fechaFin,
		@descripcion,
		@idtipo)

		FETCH NEXT FROM cur
		INTO 
			@id,
			@fechaInicio,
			@fechaFin,
			@descripcion,
			@idTipo
	END
	CLOSE cur 
	DEALLOCATE cur
END
GO
-- -----------------------------------------------------
-- VISTAS
-- -----------------------------------------------------

-- -----------------------------------------------------
-- TRIGGERS
-- -----------------------------------------------------


-- -----------------------------------------------------
-- MIGRACION
-- -----------------------------------------------------

--CARGO LOS DATOS ADMINISTRATIVOS
EXEC [ADIOS_TERCER_ANIO].[generarDatosAdministrativos];

--MIGRO LAS VISIBILIDADES QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarVisibilidades];

--MIGRO LAS CALIFICACIONES QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarCalificaciones];

--MIGRO LOS RUBROS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarRubros];

--MIGRO TODAS LAS PERSONAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarPersonas];

--MIGRO TODAS LAS EMPRESAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarEmpresas];

--MIGRO TODAS LAS PUBLICACIONES DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarPublicaciones];

--MIGRO LOS ITEMS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarItems];

--MIGRO LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarFacturas];

--Visibilidad, Rubro, Persona, Empresa, Publicaciones, Usuario
--Calificacion--, Compra, Envio, Oferta, Pregunta, Respuesta, --Factura--

-- -----------------------------------------------------
-- SCRIPT DE BORRADO - HAY QUE AGREGAR CADA COSA QUE SE CREE
-- -----------------------------------------------------
--USE GD1C2016
--DROP TABLE [ADIOS_TERCER_ANIO].[RolUsuario];
--DROP TABLE [ADIOS_TERCER_ANIO].[FuncionalidadRol];
--DROP TABLE [ADIOS_TERCER_ANIO].[Funcionalidad];
--DROP TABLE [ADIOS_TERCER_ANIO].[Rol];
--DROP TABLE [ADIOS_TERCER_ANIO].[Persona];
--DROP TABLE [ADIOS_TERCER_ANIO].[Empresa];
--DROP TABLE [ADIOS_TERCER_ANIO].[TipoDocumento];
--DROP TABLE [ADIOS_TERCER_ANIO].[Localidad];
--DROP TABLE [ADIOS_TERCER_ANIO].[Factura];
--DROP TABLE [ADIOS_TERCER_ANIO].[FormaDePago];
--DROP TABLE [ADIOS_TERCER_ANIO].[Respuesta];
--DROP TABLE [ADIOS_TERCER_ANIO].[Pregunta];
--DROP TABLE [ADIOS_TERCER_ANIO].[Compra];
--DROP TABLE [ADIOS_TERCER_ANIO].[Calificacion];
--DROP TABLE [ADIOS_TERCER_ANIO].[Oferta];
--DROP TABLE [ADIOS_TERCER_ANIO].[Publicacion];
--DROP TABLE [ADIOS_TERCER_ANIO].[Rubro];
--DROP TABLE [ADIOS_TERCER_ANIO].[Envio];
--DROP TABLE [ADIOS_TERCER_ANIO].[Estado];
--DROP TABLE [ADIOS_TERCER_ANIO].[Item];
--DROP TABLE [ADIOS_TERCER_ANIO].[Visibilidad];
--DROP TABLE [ADIOS_TERCER_ANIO].[Usuario];
--DROP PROCEDURE ADIOS_TERCER_ANIO.generarDatosAdministrativos;
--DROP PROCEDURE ADIOS_TERCER_ANIO.generarUsuario;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarPersonas;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarEmpresas;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarVisibilidades;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarRubros;
--DROP SCHEMA ADIOS_TERCER_ANIO
