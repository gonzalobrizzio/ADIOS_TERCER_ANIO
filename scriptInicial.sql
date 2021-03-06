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
			INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
			VALUES(@idRol, @idUsuario,0)
			
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
				idUsuario,
				calificacionPromedio)
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
				@idUsuario,
				0)
			
				
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
			INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario, deleted)
			VALUES(@idRol,@idUsuario,0)
			
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
							duracionDias, 
							nombre, 
							precio, 
							porcentaje
							)
	SELECT DISTINCT
		7 as duracionDias,							--TODAS EN LA MAESTRA SON DE 7 DIAS (CHEQUEADO CON DATEDIFF(dat, Publicacion_Fecha, Publicacion_Fecha_Venc)  
		Publicacion_Visibilidad_Desc, 
		Publicacion_Visibilidad_Precio,
		Publicacion_Visibilidad_Porcentaje
	FROM gd_esquema.Maestra
	ORDER BY Publicacion_Visibilidad_Porcentaje

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

	INSERT INTO ADIOS_TERCER_ANIO.Factura(numero, importeTotal, fecha, idPublicacion)
	SELECT DISTINCT
		Factura_Nro																				AS numero,
		Factura_Total																			AS importeTotal,
		Factura_Fecha																			AS fecha,
		ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo(Publicacion_Cod)				AS idPublicacion
	FROM 
		gd_esquema.Maestra
	WHERE
		Factura_Nro IS NOT NULL
END
GO

--SP PARA MIGRAR LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
--OK SUPER CHEQUEADO 11/06/2016 (NO MODIFICAR, borrar linea para entrega)
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarCompras]
AS BEGIN
	set nocount on;
	set xact_abort on;
	INSERT INTO ADIOS_TERCER_ANIO.Compra (idComprador, idPublicacion, fecha, cantidad, envio)
	SELECT DISTINCT -- EL DISTINCT ES PORQUE HAY COMPRAS REPETIDAS DE MISMA CANTDAD AL MISMO INSTANTE EN LA MISMA FECHA, LAS ASUMO COMO DUPLICADA POR ERROR
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni)											AS idComprador,
		ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo(Publicacion_Cod)				AS idPublicacion,
		Compra_Fecha																			AS fecha,
		Compra_Cantidad																			AS cantidad,
		1																						AS envio
	FROM gd_esquema.MAESTRA
	WHERE 
		Compra_Cantidad IS NOT NULL
	AND 
		Calificacion_Codigo IS NULL	
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
	INSERT INTO ADIOS_TERCER_ANIO.Oferta (monto, fecha, idUsuario, idPublicacion, envio)
	SELECT 
		Oferta_Monto																			AS monto,
		Oferta_Fecha																			AS fecha,
		ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni)											AS idComprador, 
		ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo(Publicacion_Cod)				AS idPublicacion,
		1																						AS envio
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

		INSERT INTO ADIOS_TERCER_ANIO.Item(nombre, precio, cantidad, idFactura)
			SELECT 
				CASE 
					WHEN Item_Factura_Monto = Publicacion_Visibilidad_Precio THEN 'Costo Publicacion '+Publicacion_Visibilidad_Desc
					ELSE 'Comision Publicacion '+Publicacion_Visibilidad_Desc
				END																						AS nombre,
				Item_Factura_Monto																		AS precio,
				Item_Factura_Cantidad																	AS cantidad,
				(SELECT id FROM ADIOS_TERCER_ANIO.Factura f WHERE f.numero = Factura_Nro)				AS idFactura
			FROM 
				gd_esquema.Maestra
			WHERE
				Item_Factura_Monto IS NOT NULL				
END
GO

--SP PARA MIGRAR LAS CALIFICACIONES QUE HAY EN LA TABLA MAESTRA
--OK SUPER CHEQUEADO 11/06/2016 (NO MODIFICAR, borrar linea para entrega)
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarCalificaciones]
AS BEGIN
	set nocount on;
	set xact_abort on;

	INSERT INTO 
		ADIOS_TERCER_ANIO.Calificacion(idCompra, fecha, puntaje, detalle, pendiente)
	SELECT DISTINCT --EL DISTINCT VA PARA ELIMINAR LAS CALIFICACIONES IGUALES DE LAS COMPRAS QUE ESTABAN DOS VECES AL MISMO INSTANTE Y POR LA MISMA CANTIDAD DE PRODUCTOS
		(select id from ADIOS_TERCER_ANIO.Compra c where (c.idPublicacion = 
															ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo(Publicacion_Cod)
															and ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Cli_Dni) = c.idComprador 
															and m.Compra_Fecha = c.fecha)
															and m.Compra_Cantidad = c.cantidad)	AS idCompra,
		Compra_Fecha																AS fecha,
		ADIOS_TERCER_ANIO.funcConvertirCalificacion(Calificacion_Cant_Estrellas)	AS puntaje,
		Calificacion_Descripcion													AS detalle,
		0																			AS pendiente
	FROM gd_esquema.Maestra m
	WHERE Calificacion_Codigo IS NOT NULL
	
	--ELIMINO LAS CALIFICACIONES DUPLICADAS QUE ARRASTRO DE HABER TENIDO COMPRAS DUPLICADAS
	DELETE FROM ADIOS_TERCER_ANIO.Calificacion
	WHERE id IN(
		SELECT MIN(id)
		FROM ADIOS_TERCER_ANIO.Calificacion
		WHERE idCompra IN (
			SELECT idCompra
			FROM ADIOS_TERCER_ANIO.Calificacion
			GROUP BY idCompra
			HAVING count( idCompra ) > 1
		)
		GROUP BY idCompra
	)


END
GO



--SP PARA MIGRAR LAS PUBLICACIONES DE EMPRESAS/CLIENTES QUE HAY EN LA TABLA MAESTRA
--OK SUPER CHEQUEADO 11/06/2016 (NO MODIFICAR, borrar linea para entrega)
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[migrarPublicaciones]
AS BEGIN
	set nocount on;
	set xact_abort on;
	SET IDENTITY_INSERT ADIOS_TERCER_ANIO.Publicacion ON

	INSERT INTO ADIOS_TERCER_ANIO.Publicacion(
										id,
										descripcion,
										fechaInicio,
										fechaFin,
										tienePreguntas,
										idTipoPublicacion,
										idEstado,
										precio,
										idVisibilidad,
										idPublicador,
										idRubro,
										stock,
										tieneEnvio
									)
	SELECT DISTINCT
		ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo(Publicacion_Cod)						AS id,
		Publicacion_Descripcion																			AS descripcion,
		Publicacion_Fecha																				AS fechaIni,
		Publicacion_Fecha_Venc																			AS fechaFin,
		0																								AS tienePreguntas, --NO VIENEN CON PREGUNTAS, por eso el cero
		(select id from ADIOS_TERCER_ANIO.TipoPublicacion where nombre like Publicacion_Tipo)			AS tipo,
		4																								AS idEstado, --TODAS ESTAN FINALIZADAS PORQUE SON DEL 2015
		Publicacion_Precio																				AS precio,
		(SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE nombre = Publicacion_Visibilidad_Desc)		AS idVisibilidad,
		CASE 
			WHEN Publ_Empresa_Cuit IS NULL THEN ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Publ_Cli_Dni)
			ELSE ADIOS_TERCER_ANIO.funcObtenerIdDeCuit(Publ_Empresa_Cuit)
		END																								AS idUsuario,
		(SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = Publicacion_Rubro_Descripcion)	AS idRubro,
		Publicacion_Stock																				AS stock,
		1
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
		AND
			Oferta_Fecha IS NULL
	ORDER BY id DESC

	SET IDENTITY_INSERT ADIOS_TERCER_ANIO.Publicacion OFF
END
GO

--ACTUALIZO EL VALOR DE LAS CALIFICACIONES PROMEDIO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[calcularCalificacionPromedio]
AS BEGIN
	set nocount on;
	set xact_abort on;
	DECLARE @idPersona INT,
			@promedioPer INT,
			@idEmpresa INT,
			@promedioEmp INT

	---CURSOR PARA LAS PERSONAS
	DECLARE cur CURSOR FOR
	SELECT	per.id					AS persona, 
			AVG(cal.puntaje)		AS califPromedio
	FROM ADIOS_TERCER_ANIO.Usuario usu
		LEFT JOIN ADIOS_TERCER_ANIO.Persona per ON usu.id = per.idUsuario
		LEFT JOIN ADIOS_TERCER_ANIO.Publicacion pub ON per.id = pub.idPublicador
		LEFT JOIN ADIOS_TERCER_ANIO.Compra com on com.idPublicacion = pub.id
		LEFT JOIN ADIOS_TERCER_ANIO.Calificacion cal ON com.id = cal.idCompra
		WHERE pub.id IS NOT NULL
		GROUP BY per.id
		ORDER BY per.id
	
	---CURSOR PARA LAS EMPRESAS
	DECLARE cur2 CURSOR FOR
	SELECT	emp.id					AS empresa, 
			AVG(cal.puntaje)		AS califPromedio
	FROM ADIOS_TERCER_ANIO.Usuario usu
		LEFT JOIN ADIOS_TERCER_ANIO.Empresa emp ON usu.id = emp.idUsuario
		LEFT JOIN ADIOS_TERCER_ANIO.Publicacion pub ON emp.id = pub.idPublicador
		LEFT JOIN ADIOS_TERCER_ANIO.Compra com on com.idPublicacion = pub.id
		LEFT JOIN ADIOS_TERCER_ANIO.Calificacion cal ON com.id = cal.idCompra
		WHERE pub.id IS NOT NULL
		GROUP BY emp.id
		ORDER BY emp.id

	OPEN cur
	FETCH NEXT FROM cur
		INTO 
		@idPersona,
		@promedioPer 
	WHILE(@@FETCH_STATUS = 0)
		BEGIN		
			UPDATE ADIOS_TERCER_ANIO.Persona SET calificacionPromedio = @promedioPer WHERE id = @idPersona
		FETCH NEXT FROM cur
		INTO 
		@idPersona,
		@promedioPer 
		END
	-----------------------------------
	
	OPEN cur2
	FETCH NEXT FROM cur2
		INTO 
		@idEmpresa,
		@promedioEmp 
	WHILE(@@FETCH_STATUS = 0)
		BEGIN		
			UPDATE ADIOS_TERCER_ANIO.Empresa SET calificacionPromedio = @promedioEmp WHERE id = @idEmpresa
		FETCH NEXT FROM cur2
		INTO 
		@idEmpresa,
		@promedioEmp 
		END
	
	CLOSE cur 
	CLOSE cur2
	DEALLOCATE cur
	DEALLOCATE cur2	
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

CREATE FUNCTION [ADIOS_TERCER_ANIO].[funcObtenerIdPublicacionDesdeCodigoVIejo](@Publicacion_Cod NUMERIC(18,0))
RETURNS INTEGER
AS
BEGIN
	--REEMPLAZA
	-- SELECT id FROM ADIOS_TERCER_ANIO.Publicacion p WHERE p.codAnterior = Publicacion_Cod
	-- PARA ELIMINAR LA COLUMNA DE MAS
	DECLARE @retorno NUMERIC(18,0)
	
	SET @retorno = @Publicacion_Cod - 12352

	RETURN @retorno;
END
GO

-- 	FUNC PARA CONVERTIR LA CALIFICACION ANTERIOR, EN LA NUEVA
CREATE FUNCTION [ADIOS_TERCER_ANIO].[funcConvertirCalificacion](@valorViejo NUMERIC(18,0))
RETURNS NUMERIC (18,0)
AS BEGIN
	DECLARE @retorno NUMERIC(18,0)
	
	SET @retorno = 1;
	
	IF @valorViejo >= 1 AND @valorViejo <= 2 	SET @retorno = 1;
	IF @valorViejo >= 3 AND @valorViejo <= 4 	SET @retorno = 2;
	IF @valorViejo >= 5 AND @valorViejo <= 6 	SET @retorno = 3;
	IF @valorViejo >= 7 AND @valorViejo <= 8 	SET @retorno = 4;
	IF @valorViejo >= 9 AND @valorViejo <= 10	SET @retorno = 5;
	
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
GO

--MIGRO LOS RUBROS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarRubros];
GO

--MIGRO TODAS LAS PERSONAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarPersonas];
GO

--MIGRO TODAS LAS EMPRESAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarEmpresas];
GO

--MIGRO TODAS LAS PUBLICACIONES DE EMPRESAS DE LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarPublicaciones];
GO

--MIGRO LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarCompras];
GO

--MIGRO LAS COMPRAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarOfertas];
GO
--MIGRO LAS  QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarCalificaciones];
GO

--MIGRO LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarFacturas];
GO

--MIGRO LOS ITEMS QUE TIENEN LAS FACTURAS QUE HAY EN LA TABLA MAESTRA
EXEC [ADIOS_TERCER_ANIO].[migrarItems];
GO
--CALCULO LOS PROMEDIOS DE LO MIGRADO
EXEC [ADIOS_TERCER_ANIO].[calcularCalificacionPromedio];
GO

--TRIGER PARA ACTUALIZAR LA CALIFICACION PROMEDIO
CREATE TRIGGER [ADIOS_TERCER_ANIO].[tg_actualizarCalificacionPromedio] ON ADIOS_TERCER_ANIO.Calificacion 
AFTER INSERT
AS
BEGIN 
 EXEC ADIOS_TERCER_ANIO.calcularCalificacionPromedio
END
GO

	DECLARE @idUsuario int;
	DECLARE @idRol int;

	SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p where p.usuario ='gd' and p.pass='2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Cliente')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
	VALUES(@idRol,@idUsuario,0)

	SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p WHERE p.usuario ='admin' and p.pass='2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Administrativo')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
	VALUES(@idRol,@idUsuario,0)
	
		SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p WHERE p.usuario ='admin' and p.pass='2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Empresa')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
	VALUES(@idRol,@idUsuario,0)

	SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p where p.usuario ='admin' and p.pass='2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Cliente')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
	VALUES(@idRol,@idUsuario,0)