-------------------------------------------------------
-- PROCEDURES -----------------------------------------
-------------------------------------------------------

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[generarUsuario](@usuario NVARCHAR(255),@password NVARCHAR(255), @mail NVARCHAR(255),@ultimoID INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO ADIOS_TERCER_ANIO.Usuario(usuario,pass, mail) VALUES (@usuario,@password,@mail)
	SELECT @ultimoID = SCOPE_IDENTITY();
	RETURN
END
GO



--SP PARA MIGRAR TODOS LAS EMPRESAS DE LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarEmpresas]
AS 

--SP PARA MIGRAR TODOS LAS VISIBILIDADES DE LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarVisibilidades]
AS BEGIN
	set nocount on;
	set xact_abort on;

	INSERT INTO ADIOS_TERCER_ANIO.Visibilidad(
							codigo, 
							descripcion, 
							precio, 
							porcentaje
							)
	SELECT DISTINCT
		Publicacion_Visibilidad_Cod, 
		Publicacion_Visibilidad_Desc, 
		Publicacion_Visibilidad_Precio,
		Publicacion_Visibilidad_Porcentaje
	FROM gd_esquema.Maestra	

END
GO


--SP PARA MIGRAR LOS RUBROS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarRubros]
AS BEGIN
	set nocount on;
	set xact_abort on;

	INSERT INTO ADIOS_TERCER_ANIO.Rubro(
								descripcionCorta, 
								descripcionLarga
								)
	SELECT DISTINCT
		Publicacion_Rubro_Descripcion,
		Publicacion_Rubro_Descripcion
	FROM gd_esquema.Maestra	
END
GO

--Lo empiezo pero no está terminado--
--SP PARA MIGRAR LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarFacturas]
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO ADIOS_TERCER_ANIO.Factura(fecha, importeTotal, idComprador, numero, idFormaDePago, idPublicacion)
	SELECT 
		Factura_Fecha AS fecha,
		Factura_Total AS importeTotal,
		case
			when (Publ_Cli_Dni is not null) then ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Publ_Cli_Dni)
			when (Cli_Dni is not null) then ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni)
			else NULL
		END
		AS idComprador,
		Factura_Nro AS numero,
		(select id from ADIOS_TERCER_ANIO.FormaDePago where nombre like Forma_Pago_Desc) AS idFormaDePago,
		(select id from Publicacion p where p.codAnterior = Publicacion_Cod)

	FROM gd_esquema.Maestra	
	WHERE	Factura_Total IS NOT NULL
			AND
			Factura_Fecha IS NOT NULL
			and
			Publ_Cli_Dni is not null
	

		
END
GO

--SP PARA MIGRAR LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarCompras]
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO ADIOS_TERCER_ANIO.Compra (idComprador, idPublicacion, fecha)
	SELECT 
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni)	AS idComprador,
		(select id from Publicacion p where p.codAnterior = Publicacion_Cod),
		Compra_Fecha				AS fecha
	FROM gd_esquema.MAESTRA
	WHERE 
		Compra_Fecha IS NOT NULL
	AND 
		Compra_Cantidad IS NOT NULL	
	AND	
		Calificacion_Codigo IS NULL

END
GO

--SP PARA MIGRAR LAS OFERTAS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarOfertas]
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO ADIOS_TERCER_ANIO.Oferta (monto, fecha, idUsuario, idPublicacion)
	SELECT 
		Oferta_Monto				AS monto,
		Oferta_Fecha				AS fecha,
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni)	AS idComprador, 
		(select id from Publicacion p where p.codAnterior = Publicacion_Cod)
	FROM gd_esquema.MAESTRA
	WHERE 
		Oferta_Monto IS NOT NULL
	AND 
		Oferta_Fecha IS NOT NULL	
END
GO


--SP PARA MIGRAR LOS ITEMS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarItems]
AS BEGIN
	set nocount on;
	set xact_abort on;

		INSERT INTO ADIOS_TERCER_ANIO.Item(nombre, stock, precio, cantidad)
		SELECT 
			Publicacion_Descripcion			AS nombre,
			Publicacion_Stock				AS stock,
			Item_Factura_Monto				AS precio,
			Item_Factura_Cantidad			AS cantidad
		FROM gd_esquema.Maestra	
		WHERE
			Item_Factura_Monto IS NOT NULL
		AND
			Item_Factura_Cantidad IS NOT NULL

END
GO

--SP PARA MIGRAR LAS CALIFICACIONES QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarCalificaciones]
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO 
		ADIOS_TERCER_ANIO.Calificacion(idUsuario ,idUsuarioCalificador, idPublicacion, fecha, puntaje, detalle, pendiente)
	SELECT	
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni),
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni),
		(select id from Publicacion p where p.codAnterior = Publicacion_Cod),
		Publicacion_Fecha_Venc,
		Calificacion_Cant_Estrellas,
		Calificacion_Descripcion,
		1
	FROM gd_esquema.Maestra	
		
END
GO


--SP PARA MIGRAR LAS PUBLICACIONES DE EMPRESAS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarPublicacionesEmpresas]
AS BEGIN
	set nocount on;
	set xact_abort on;

	INSERT INTO ADIOS_TERCER_ANIO.Publicacion(
										descripcion,
										fechaInicio,
										fechaFin,
										tienePreguntas,
										tipo,
										idEstado,
										idVisibilidad,
										idPublicador,
										idRubro,
										idItem,
										idEnvio,
										codAnterior
									)
	SELECT DISTINCT
		Publicacion_Descripcion			AS descripcion,
		Publicacion_Fecha				AS fechaIni,
		Publicacion_Fecha_Venc			AS fechaFin,
		NULL							AS tienePreguntas, --NO VIENEN CON PREGUNTAS
		Publicacion_Tipo				AS tipo,
		(SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = Publicacion_Estado)	AS idEstado,
		(SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE codigo = Publicacion_Visibilidad_Cod)	AS idVisibilidad,
		ADIOS_TERCER_ANIO.funcObtenerIdDeCuit(Publ_Empresa_Cuit) AS idPublicador,
		(SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = Publicacion_Rubro_Descripcion)	AS idRubro,
		NULL 							AS idItem, --TODO traer 
		NULL							AS idEnvio, --TODO traer 
		Publicacion_Cod
	FROM 
		gd_esquema.Maestra
	WHERE 
		Publ_Empresa_Cuit IS NOT NULL
		and
		Publicacion_Cod is not null
END
GO


--SP PARA MIGRAR LAS PUBLICACIONES DE EMPRESAS QUE HAY EN LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarPublicacionesPersonas]
AS BEGIN
	set nocount on;
	set xact_abort on;

	INSERT INTO ADIOS_TERCER_ANIO.Publicacion(
										descripcion,
										fechaInicio,
										fechaFin,
										tienePreguntas,
										tipo,
										idEstado,
										idVisibilidad,
										idPublicador,
										idRubro,
										idItem,
										idEnvio,
										codAnterior
									)
	SELECT DISTINCT
		Publicacion_Descripcion			AS descripcion,
		Publicacion_Fecha				AS fechaIni,
		Publicacion_Fecha_Venc			AS fechaFin,
		NULL							AS tienePreguntas, --NO VIENEN CON PREGUNTAS
		Publicacion_Tipo				AS tipo,
		(SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = 'Finalizada' )	AS idEstado,
		(SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE codigo = Publicacion_Visibilidad_Cod)	AS idVisibilidad,
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Publ_Cli_Dni) AS idPublicador,
		(SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = Publicacion_Rubro_Descripcion)	AS idRubro,
		NULL 							AS idItem, --TODO traer 
		NULL							AS idEnvio, --TODO traer 
		Publicacion_Cod
	FROM 
		gd_esquema.Maestra
	WHERE 
		Publ_Cli_Dni IS NOT NULL
		and
		Publicacion_Cod is not null
END
GO
-- -----------------------------------------------------
-- FUNCIONES
-- -----------------------------------------------------

-- FUNCION PARA SACAR EL idUsuario del CUIT
CREATE FUNCTION [ADIOS_TERCER_ANIO].[funcObtenerIdDeCuit](@cuit NVARCHAR(255))
RETURNS INTEGER
AS
BEGIN
	DECLARE @retorno INTEGER
	SELECT
		@retorno = idUsuario
	FROM 
		ADIOS_TERCER_ANIO.Empresa
	WHERE
		cuit = @cuit
		
	RETURN @retorno;
END
GO

-- FUNCION PARA SACAR EL idUsuario del DNI
CREATE FUNCTION [ADIOS_TERCER_ANIO].[funcObtenerIdDeDNI](@dni DECIMAL(18,0))
RETURNS INTEGER
AS
BEGIN
	DECLARE @retorno INTEGER
	SELECT
		@retorno = idUsuario
	FROM 
		ADIOS_TERCER_ANIO.Persona
	WHERE
		documento = @dni
		
	RETURN @retorno;
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

--SP PARA MIGRAR TODOS LAS PERSONAS DE LA TABLA MAESTRA
BEGIN
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



--MIGRO LAS VISIBILIDADES QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarVisibilidades];

--MIGRO LOS RUBROS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarRubros];

----MIGRO TODAS LAS PERSONAS DE LA TABLA MAESTRA
--EXEC [ADIOS_TERCER_ANIO].[migrarPersonas];

--MIGRO TODAS LAS EMPRESAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarEmpresas];

--MIGRO TODAS LAS PUBLICACIONES DE EMPRESAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarPublicacionesEmpresas];

--MIGRO TODAS LAS PUBLICACIONES DE EMPRESAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarPublicacionesPersonas];

--MIGRO LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarCompras];

--MIGRO LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarOfertas];

--MIGRO LAS CALIFICACIONES QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarCalificaciones];

--MIGRO LOS ITEMS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarItems];

--MIGRO LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarFacturas];

--Visibilidad, Rubro, Persona, Empresa, Publicaciones, Usuario
--Calificacion--, Compra, Envio, Oferta, Pregunta, Respuesta, --Factura--

