-------------------------------------------------------
-- PROCEDURES -----------------------------------------
-------------------------------------------------------
USE [GD1C2016] ;
GO

--PROCEDIMIENTO PARA GENERAR USUARIO
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[generarUsuario](@usuario NVARCHAR(255),@password NVARCHAR(255), @mail NVARCHAR(255),@ultimoID INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO ADIOS_TERCER_ANIO.Usuario(usuario,pass, mail, deleted) VALUES (@usuario,@password,@mail, 0)
	SELECT @ultimoID = SCOPE_IDENTITY();
	RETURN
END
GO

--SP PARA MIGRAR TODOS LAS PERSONAS DE LA TABLA MAESTRA
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
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
			-- INSERTO TODOS LOS USUARIOS EN LA TABLA DE USUARIOS || el pass es "gd"
			EXECUTE ADIOS_TERCER_ANIO.generarUsuario @documento,'2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f',@mail,@ultimoID = @idUsuario OUTPUT;
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
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
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
			-- INSERTO TODOS LOS USUARIOS EN LA TABLA DE USUARIOS || el pass es GD
			EXECUTE ADIOS_TERCER_ANIO.generarUsuario @cuit, '2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f', @mail, @ultimoID = @idUsuario OUTPUT;
			DECLARE @idRol int;
			SET @idRol = (select id from ADIOS_TERCER_ANIO.Rol where nombre = 'Empresa')
			INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario)
			VALUES(@idRol,@idUsuario)
			
			INSERT INTO ADIOS_TERCER_ANIO.Empresa(
				razonSocial,
				telefono ,
				direccion,
				direccion_numero,
				piso,
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
				@piso,
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
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
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
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
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


--SP PARA MIGRAR LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarFacturas]
AS BEGIN
	set nocount on;
	set xact_abort on;

	INSERT INTO ADIOS_TERCER_ANIO.Factura(numero, importeTotal, fecha, idVendedor, idFormaDePago, idPublicacion)
	SELECT DISTINCT
		Factura_Nro																				AS numero,
		Factura_Total																			AS importeTotal,
		Factura_Fecha																			AS fecha,
		CASE 
			WHEN Publ_Empresa_Cuit IS NULL THEN ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Publ_Cli_Dni)
			ELSE ADIOS_TERCER_ANIO.funcObtenerIdDeCuit(Publ_Empresa_Cuit)
		END																						AS idVendedor,
		(SELECT id FROM ADIOS_TERCER_ANIO.FormaDePago WHERE nombre LIKE Forma_Pago_Desc)		AS idFormaDePago,
		(SELECT id FROM ADIOS_TERCER_ANIO.Publicacion p WHERE p.codAnterior = Publicacion_Cod)	AS idPublicacion
	FROM 
		gd_esquema.Maestra
	WHERE
		Factura_Nro IS NOT NULL
END
GO

--SP PARA MIGRAR LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarCompras]
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO ADIOS_TERCER_ANIO.Compra (idComprador, idPublicacion, fecha, cantidad, calificacionCodigo)
	SELECT 
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni)											AS idComprador,
		(select id from ADIOS_TERCER_ANIO.Publicacion p where p.codAnterior = Publicacion_Cod)	AS idPublicacion,
		Compra_Fecha																			AS fecha,
		Compra_Cantidad																			AS cantidad,
		Calificacion_Codigo																		AS calificacionCodigo
	FROM gd_esquema.MAESTRA
	WHERE 
		Compra_Fecha IS NOT NULL
	AND 
		Compra_Cantidad IS NOT NULL	
	AND	
		Calificacion_Codigo IS NOT NULL
	AND
		Cli_Dni IS NOT NULL
	AND 
		((Publ_Cli_Dni is not null AND Publ_Empresa_Cuit IS NULL)
		OR
		(Publ_Cli_Dni is null AND Publ_Empresa_Cuit IS NOT NULL))
END
GO

--SP PARA MIGRAR LAS OFERTAS QUE HAY EN LA TABLA MAESTRA
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarOfertas]
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO ADIOS_TERCER_ANIO.Oferta (monto, fecha, idUsuario, idPublicacion)
	SELECT 
		Oferta_Monto																			AS monto,
		Oferta_Fecha																			AS fecha,
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni)											AS idComprador, 
		(SELECT id FROM ADIOS_TERCER_ANIO.Publicacion p WHERE p.codAnterior = Publicacion_Cod)	AS idPublicacion
	FROM gd_esquema.MAESTRA
	WHERE 
		Oferta_Monto IS NOT NULL
	AND 
		Oferta_Fecha IS NOT NULL	
	AND
		((Publ_Cli_Dni is not null AND Publ_Empresa_Cuit IS NULL)
		OR
		(Publ_Cli_Dni is null AND Publ_Empresa_Cuit IS NOT NULL))
END
GO


--SP PARA MIGRAR LOS ITEMS QUE HAY EN LA TABLA MAESTRA
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarItems]
AS BEGIN
	set nocount on;
	set xact_abort on;

		INSERT INTO ADIOS_TERCER_ANIO.Item(nombre, precio, cantidad, idPublicacion)
			SELECT 
				CASE 
					WHEN Item_Factura_Monto = Publicacion_Visibilidad_Precio THEN 'Costo Publicacion '+Publicacion_Visibilidad_Desc
					WHEN Item_Factura_Cantidad = Publicacion_Precio * Publicacion_Visibilidad_Porcentaje THEN 'Comision Publiacacion '+Publicacion_Visibilidad_Desc
					ELSE 'Costo de envio'
				END																						AS nombre,
				Item_Factura_Monto																		AS precio,
				Item_Factura_Cantidad																	AS cantidad,
				(SELECT id FROM ADIOS_TERCER_ANIO.Publicacion p WHERE p.codAnterior = Publicacion_Cod)	AS idPublicacion
			FROM 
				gd_esquema.Maestra
			WHERE
				Item_Factura_Monto IS NOT NULL				
END
GO

--SP PARA MIGRAR LAS CALIFICACIONES QUE HAY EN LA TABLA MAESTRA
--TODO: Revisar que funcione bien al 05/06/2016
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarCalificaciones]
AS BEGIN
	set nocount on;
	set xact_abort on;

	INSERT INTO 
		ADIOS_TERCER_ANIO.Calificacion(idCompra, fecha, puntaje, detalle, pendiente)
	SELECT DISTINCT	
		tablaCompra.id,
		Compra_Fecha,
		Calificacion_Cant_Estrellas,
		Calificacion_Descripcion,
		CASE
			WHEN (Calificacion_Cant_Estrellas is not null) THEN 0 ELSE 1
		END
	FROM gd_esquema.Maestra, ADIOS_TERCER_ANIO.Compra tablaCompra
	WHERE Calificacion_Codigo = tablaCompra.calificacionCodigo
END
GO



--SP PARA MIGRAR LAS PUBLICACIONES DE EMPRESAS/CLIENTES QUE HAY EN LA TABLA MAESTRA
--TODO: NOK 05/06/2016 LA MIGRACION DE PUBLICACIONES ESTA OK SUPERCHEQUEADA, FALTA VER EL TEMA DEL ENVIO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarPublicaciones]
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
										precio,
										idVisibilidad,
										idPublicador,
										idRubro,
										stock,
										idEnvio,
										codAnterior
									)
	SELECT DISTINCT
		Publicacion_Descripcion																			AS descripcion,
		Publicacion_Fecha																				AS fechaIni,
		Publicacion_Fecha_Venc																			AS fechaFin,
		0																								AS tienePreguntas, --NO VIENEN CON PREGUNTAS, por eso el cero
		Publicacion_Tipo																				AS tipo,
		(SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = 'Activa' )								AS idEstado, --El cambio de estado se tiene que hacer en C#
		Publicacion_Precio																				AS precio,
		(SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE codigo = Publicacion_Visibilidad_Cod)		AS idVisibilidad,
		CASE 
			WHEN Publ_Empresa_Cuit IS NULL THEN ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Publ_Cli_Dni)
			ELSE ADIOS_TERCER_ANIO.funcObtenerIdDeCuit(Publ_Empresa_Cuit)
		END																								AS idUsuario,
		(SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = Publicacion_Rubro_Descripcion)	AS idRubro,
		Publicacion_Stock																				AS stock,
		NULL																							AS idEnvio, --TODO definir si se usa o se borra
		Publicacion_Cod																					AS idPublicacion
	FROM 
		gd_esquema.Maestra
	WHERE 
			((Publ_Empresa_Cuit IS NOT NULL AND Publ_Cli_Dni IS NULL) OR ( Publ_Empresa_Cuit IS NULL AND Publ_Cli_Dni IS NOT NULL))
		AND
			Publicacion_Cod is not null
		AND 
			Calificacion_Codigo IS NULL
		AND 
			Factura_Nro IS NULL 
		AND 
			Compra_Cantidad IS NULL
END
GO

-- -----------------------------------------------------
-- FUNCIONES
-- -----------------------------------------------------

-- FUNCION PARA SACAR EL idUsuario del CUIT
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
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
--OK SUPER CHEQUEADO 05/06/2016 (NO MODIFICAR, borrar linea para entrega)
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

--MIGRO LAS VISIBILIDADES QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarVisibilidades];

--MIGRO LOS RUBROS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarRubros];

--MIGRO TODAS LAS PERSONAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarPersonas];

--MIGRO TODAS LAS EMPRESAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarEmpresas];

--MIGRO TODAS LAS PUBLICACIONES DE EMPRESAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarPublicaciones];

--MIGRO LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarCompras];

--MIGRO LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarOfertas];

--MIGRO LAS CALIFICACIONES QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarCalificaciones];

--MIGRO LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarFacturas];

--MIGRO LOS ITEMS QUE TIENEN LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarItems];



