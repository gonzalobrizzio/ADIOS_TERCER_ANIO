USE GD1C2016
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[login] (@usuario NVARCHAR(255), @pass NVARCHAR(255), @idUsuario int output)
AS
BEGIN
	--Para probar el sp: (descomentar y setear valores)
	Declare @uPass NVARCHAR(255),
			@uId int,
			@uIntentos int;
	--Declare	@usuario NVARCHAR(255),
	--		@pass NVARCHAR(255),
	--		@idUsuario int;
	--set @usuario = 'gd';
	--set @pass = 'gd';
	Select
		@uId = u.id,
		@uPass = u.pass,
		@uIntentos = u.intentos
	from ADIOS_TERCER_ANIO.Usuario u
	where RTRIM(LTRIM(@usuario)) = RTRIM(LTRIM(u.usuario)) AND  u.deleted = 0

	If (@uId is not null)
	Begin
		If (@uIntentos < 5)
		Begin
			If (@uPass = @pass)
				Begin
					set @idUsuario = @uId
					RETURN
				End
			Else
				Begin
					update ADIOS_TERCER_ANIO.Usuario
					Set intentos = intentos + 1
					Where id = @uId;
					THROW 50002, 'Contrase�a Invalida', 1; 
				End
		End
		Else THROW 50003, 'Intentos Agotados', 1; 
	End;
	Else THROW 50001, 'El usuario est� deshabilitado', 1; 
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ModificarRol] (@nombre NVARCHAR(255), @id int)
AS
BEGIN
	if (@nombre <> '')
	begin
		BEGIN TRANSACTIOn
		BEGIN TRY
		UPDATE ADIOS_TERCER_ANIO.Rol set nombre = @nombre where id = @id
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION;
			THROW 50004, 'No se pudo actualizar', 1; 
		END CATCH
		COMMIT TRANSACTION
	end
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarRol] (@nombre NVARCHAR(255), @id int output)
AS
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
	INSERT INTO ADIOS_TERCER_ANIO.Rol(nombre) VALUES (@nombre)
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No existe el usuario', 1; 
	END CATCH
	COMMIT TRANSACTION
	SET @ID = @@IDENTITY
	RETURN @ID
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[modificarFuncionalidadesRol] (@idRol int, @idFunc int, @borrar int)
AS
BEGIN
	Declare @idFXR int = null;
	select @idFXR = id from ADIOS_TERCER_ANIO.FuncionalidadRol where idRol = @idRol and idFuncionalidad = @idFunc
	if(@idFXR is null and @borrar = 0)
	begin
		BEGIN TRANSACTION
		BEGIN TRY
			INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idFuncionalidad, idRol, deleted) VALUES (@idFunc, @idRol, @borrar)
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION;
			THROW 50004, 'Error', 1; 
		END CATCH
		COMMIT TRANSACTION
	end
	if (@idFXR is not null)
	begin
		BEGIN TRANSACTION
		BEGIN TRY
			UPDATE ADIOS_TERCER_ANIO.FuncionalidadRol SET deleted = @borrar where id = @idFXR
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION;
			THROW 50004, 'Error', 1; 
		END CATCH
		COMMIT TRANSACTION
	end
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[obtenerCompras] (@idCalificador int)
AS
BEGIN
	Select (SELECT usuario from ADIOS_TERCER_ANIO.Usuario where id = idPublicador) AS Usuario, p.descripcion, c.id, (select nombre as tipo from ADIOS_TERCER_ANIO.TipoPublicacion where id = p.idTipoPublicacion) from ADIOS_TERCER_ANIO.Publicacion p 
	inner join ADIOS_TERCER_ANIO.Compra c on c.idPublicacion = p.id
	inner join ADIOS_TERCER_ANIO.Calificacion calif on calif.idCompra = c.id 
	where c.idComprador = @idCalificador AND calif.pendiente = 1 order by c.fecha desc
END

GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[cargarCalificacion] (@idCompra int, @puntaje int, @fecha datetime, @detalle nvarchar(255))
AS
BEGIN
		IF (@puntaje IS null)
		THROW 50004, 'No ingres� puntaje',1;

		BEGIN TRANSACTION
		BEGIN TRY
			UPDATE ADIOS_TERCER_ANIO.Calificacion SET puntaje = @puntaje, fecha = @fecha, detalle = @detalle, pendiente = 0 where idCompra = @idCompra
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION;
			THROW 50004, 'Error al guardar la calificacion', 1; 
		END CATCH
		COMMIT TRANSACTION


END
GO
CREATE PROCEDURE ADIOS_TERCER_ANIO.AgregarUsuario (@usuario NVARCHAR(255),@password NVARCHAR(255), @mail NVARCHAR(255),@ultimoID INT OUTPUT)
AS BEGIN
	set nocount on;
	set xact_abort on;

		
	IF (@mail IS NULL OR (@mail NOT LIKE '%@%' OR @mail NOT LIKE '%.com%') OR @mail = '')
		THROW 50004, 'Mail invalido',1;

	IF(@usuario IS NULL)
		THROW 50004, 'Necesita ingresar un usuario', 1;

		INSERT INTO ADIOS_TERCER_ANIO.Usuario(usuario,pass, mail, deleted) VALUES (@usuario,@password,@mail, 0)
		SET @ultimoID = @@IDENTITY;
END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.AgregarRolUsuario ( @rol NVARCHAR(255),@id INT )
AS BEGIN
	set nocount on;
	set xact_abort on;

		DECLARE @idRol INT;
		Select @idRol = id from ADIOS_TERCER_ANIO.Rol r where r.nombre = @rol;
		IF(@idRol IS not NULL)
		bEGIN
			INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idUsuario, idRol, deleted) VALUES(@id, @idRol,0)
		End 

END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.ModificarUsuario (@usuario NVARCHAR(255), @mail NVARCHAR(255), @password NVARCHAR(255), @id INT)
AS BEGIN
	set nocount on;
	set xact_abort on;

		
	IF (@mail IS NULL OR (@mail NOT LIKE '%@%' OR @mail NOT LIKE '%.com%'))
		THROW 50004, 'Mail invalido',1;

	BEGIN TRANSACTION
	BEGIN TRY
	UPDATE ADIOS_TERCER_ANIO.Usuario SET mail = @mail, usuario = @usuario, pass = @password WHERE @id = id
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'El usuario no se ha podido modificar', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarEmpresa] (@razonSocial NVARCHAR(255) ,  @id INT , @telefono NVARCHAR(20), 
													   @direccion DECIMAL(18,0), @calle NVARCHAR(255), @piso DECIMAL(18,0), @depto NVARCHAR(50), @localidad NVARCHAR(255),
													   @codigoPostal NVARCHAR(50), @ciudad NVARCHAR(255), @cuit NVARCHAR(50) , @contacto NVARCHAR(45), 
													   @rubro NVARCHAR(255), @fechaCreacion DATETIME)
AS
BEGIN
	DECLARE @calificacionPromedio INT
	SET @calificacionPromedio = 0

	INSERT INTO ADIOS_TERCER_ANIO.Empresa(razonSocial,
										  telefono,
										  direccion,
										  direccion_numero,
										  piso,
										  dpto,
										  codigoPostal,
										  cuit,
										  contacto,
										  idRubro,
										  idUsuario,
										  idLocalidad,
										  calificacionPromedio,
										  fechaCreacion) 
	VALUES (@razonSocial,@telefono,@calle,@direccion,@piso,@depto,@codigoPostal,@cuit,@contacto,(SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = @rubro),
		    @id, (SELECT id FROM ADIOS_TERCER_ANIO.Localidad WHERE nombre = @localidad), @calificacionPromedio, @fechaCreacion)
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ModificarEmpresa] (@razonSocial NVARCHAR(255) ,  @id INT , @telefono NVARCHAR(20), 
														 @direccion DECIMAL(18,0), @calle NVARCHAR(255), @piso DECIMAL(18,0), @depto NVARCHAR(50), @localidad NVARCHAR(255),
														 @codigoPostal NVARCHAR(50), @ciudad NVARCHAR(255), @cuit NVARCHAR(50) , @contacto NVARCHAR(45), 
														 @rubro NVARCHAR(255))
AS
BEGIN
		UPDATE ADIOS_TERCER_ANIO.Empresa
		SET razonSocial = @razonSocial, telefono = @telefono, direccion = @calle, direccion_numero = @direccion, piso = @piso, dpto = @depto,
			idLocalidad= (SELECT id FROM ADIOS_TERCER_ANIO.Localidad WHERE nombre = @localidad), codigoPostal = @codigoPostal, cuit = @cuit, contacto = @contacto,
			idRubro = (SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = @rubro) WHERE @id = idUsuario
	
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarPersona] (@nombre NVARCHAR(255) ,  @apellido NVARCHAR(255) , @documento decimal(18,0), @tipoDeDocumento NVARCHAR(255),@telefono NVARCHAR(255), 
													   @direccion decimal(18,0), @calle NVARCHAR(255), @piso decimal(18,0), @depto NVARCHAR(50), @localidad NVARCHAR(255),
													   @codigoPostal NVARCHAR(50), @id INT , @fechaNac DATETIME, @fechaCreacion DATETIME)
AS
BEGIN

	INSERT INTO ADIOS_TERCER_ANIO.Persona(nombre,
										  apellido,
										  documento,
										  idTipoDocumento,
										  telefono,
										  direccion,
										  direccion_numero,
										  piso,
										  dpto,
										  codigoPostal,
										  fechaNacimiento,
										  fechaCreacion,
										  idUsuario,
										  idLocalidad,
										  calificacionPromedio) 
	VALUES (@nombre,@apellido,@documento, (SELECT id FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE descripcion like @tipoDeDocumento),
			@telefono, @calle,@direccion,@piso,@depto,@codigoPostal, @fechaNac , @fechaCreacion, @id, (SELECT id FROM Localidad WHERE nombre like @localidad), 0)
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ModificarPersona] (@nombre NVARCHAR(255) ,  @apellido NVARCHAR(255) , @documento decimal(18,0), @tipoDeDocumento NVARCHAR(255),@telefono NVARCHAR(255), 
													   @direccion decimal(18,0), @calle NVARCHAR(255), @piso decimal(18,0), @depto NVARCHAR(50), @localidad NVARCHAR(255),
													   @codigoPostal NVARCHAR(50), @id INT , @fechaNac DATETIME)
AS
BEGIN

	UPDATE ADIOS_TERCER_ANIO.Persona
	SET nombre = @nombre, apellido = @apellido, idTipoDocumento = (SELECT id FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE descripcion = @tipoDeDocumento),
				 telefono = @telefono,direccion_numero = @direccion, direccion = @calle, piso = @piso, dpto = @depto, codigoPostal = @codigoPostal, 
				 fechaNacimiento = @fechaNac, idLocalidad = (SELECT id FROM Localidad WHERE nombre = @localidad) WHERE @id = idUsuario
END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.validarPassword(@usuario NVARCHAR(255), @password NVARCHAR(255))
AS
BEGIN
SELECT u.id FROM ADIOS_TERCER_ANIO.Usuario u WHERE u.usuario=@usuario AND u.pass=@password
END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.modificarPassword(@usuario NVARCHAR(255), @password NVARCHAR(255))
AS
BEGIN
UPDATE ADIOS_TERCER_ANIO.Usuario  SET pass=@password WHERE usuario=@usuario
END

GO 
CREATE PROCEDURE ADIOS_TERCER_ANIO.cargarUltimasCalificaciones(@idCalificador INT)
AS
BEGIN
--	declare @idCalificador int = 17;
	Select TOP 5 calif.fecha, calif.puntaje, calif.detalle from ADIOS_TERCER_ANIO.Calificacion calif 
	inner join ADIOS_TERCER_ANIO.Compra compra on compra.id = calif.idCompra
	inner join ADIOS_TERCER_ANIO.Publicacion publicacion on compra.idPublicacion = publicacion.id
	inner join ADIOS_TERCER_ANIO.Usuario usr on usr.id = publicacion.idPublicador
	where compra.idComprador = @idCalificador and pendiente = 0 ORDER BY calif.fecha DESC 
END

GO 
CREATE PROCEDURE ADIOS_TERCER_ANIO.obtenerTipoDeCompraConNPuntaje(@puntaje INT, @tipo NVARCHAR(255), @idCalificador INT, @cant INT OUTPUT)
AS
BEGIN
	
--	declare @idCalificador int = 17;
--	declare @tipo NVARCHAR(255) = 'Subasta';
--	declare @puntaje INT = 2;
	SET @cant = (select COUNT(*) from ADIOS_TERCER_ANIO.Calificacion calif 
	inner join ADIOS_TERCER_ANIO.Compra compra on compra.id = calif.idCompra
	inner join ADIOS_TERCER_ANIO.Publicacion publicacion on compra.idPublicacion = publicacion.id
	inner join ADIOS_TERCER_ANIO.TipoPublicacion tp on tp.id = publicacion.idTipoPublicacion
	where compra.idComprador = @idCalificador and pendiente = 0 and tp.nombre like @tipo and calif.puntaje = @puntaje)
END

GO 
CREATE PROCEDURE ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN(@idUsuario INT, @pagina INT)
AS
BEGIN
--	declare @idUsuario int = 7;
--	declare @pagina INT = 3;

	DECLARE @cant int = (select count(*) from ADIOS_TERCER_ANIO.Publicacion 
			where publicacion.idPublicador != @idUsuario) - @pagina * 20;
	IF (@cant > 0)
	BEGIN
	WITH TablaP as (select TOP (@cant) publicacion.descripcion, publicacion.fechaFin, (select nombre from ADIOS_TERCER_ANIO.TipoPublicacion where id = publicacion.idTipoPublicacion) as tipo,
					publicacion.precio, publicacion.id, visib.porcentaje, publicacion.fechaInicio,publicacion.stock, iif(publicacion.tieneEnvio = 0, 'SI', 'NO') AS envio from ADIOS_TERCER_ANIO.Publicacion publicacion
	inner join ADIOS_TERCER_ANIO.Visibilidad visib on publicacion.idVisibilidad = visib.id
	where publicacion.idPublicador != @idUsuario and stock > 0 and (publicacion.idEstado = 2 OR publicacion.idEstado = 3)
	ORDER BY visib.porcentaje asc, publicacion.fechaInicio ASC)

	SELECT top 20 * FROM TablaP ORDER by TablaP.porcentaje desc, TablaP.fechaInicio desc
	END
	ELSE
		THROW 50004, 'No hay m�s paginas para ver!', 1; 
END
GO 

CREATE PROCEDURE ADIOS_TERCER_ANIO.obtenerFacturasPaginaN(@idUsuario INT, @pagina INT, @idRol INT)
AS
BEGIN

	DECLARE @cant int = (select count(*) from ADIOS_TERCER_ANIO.Factura f
			inner join ADIOS_TERCER_ANIO.Publicacion p on p.id = f.idPublicacion
			where p.idPublicador = @idUsuario) - @pagina * 10;
	IF (@cant > 0)
	BEGIN
		WITH TablaP as (select TOP (@cant) f.numero, f.importeTotal, f.fecha, u.usuario as Nombre from ADIOS_TERCER_ANIO.Factura f
		inner join ADIOS_TERCER_ANIO.Publicacion p on p.id = f.idPublicacion
		inner join ADIOS_TERCER_ANIO.Usuario u on u.id = p.idPublicador
		WHERE @idUsuario = P.idPublicador
		ORDER BY f.fecha ASC)
		SELECT top 10 * FROM TablaP ORDER by TablaP.fecha desc

	END
	ELSE
		THROW 50004, 'No hay m�s paginas para ver!', 1; 
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarPublicacion] (@descripcion NVARCHAR(255), @fechaInicio DATETIME, @fechaFin DATETIME,
														   @tienePreguntas INT, @tipo NVARCHAR(255), @estado NVARCHAR(255), @precio DECIMAL(18,2), 
														   @visibilidad NVARCHAR(255), @idPublicador INT, @rubro NVARCHAR(255), @stock INT, @envio INT)
AS
BEGIN
		INSERT INTO ADIOS_TERCER_ANIO.Publicacion(descripcion, 
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
												  tieneEnvio)
		 VALUES (@descripcion, @fechaInicio, @fechaFin, @tienePreguntas, (select id from ADIOS_TERCER_ANIO.TipoPublicacion where nombre like @tipo), 
		 (SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = @estado), @precio,
	     (SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE nombre = @visibilidad), @idPublicador, 
		 (SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = @rubro), @stock, @envio)
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[verHistoricoComprasUsuario](@userId INT)
AS
BEGIN
SELECT	pub.descripcion, iif(com.cantidad <> pub.stock, com.cantidad, pub.stock) as cantidad, com.fecha,
		iif(ofe.monto is not null, ofe.monto, pub.precio) as precio, cal.puntaje as calificacion, tp.nombre
	 FROM ADIOS_TERCER_ANIO.Usuario usu
		inner JOIN ADIOS_TERCER_ANIO.Publicacion pub ON usu.id = @userId
		inner JOIN ADIOS_TERCER_ANIO.Compra com ON com.idPublicacion = pub.id
		LEFT outer JOIN ADIOS_TERCER_ANIO.Oferta ofe ON ofe.idPublicacion = pub.id and com.id is null
		inner JOIN ADIOS_TERCER_ANIO.Calificacion cal ON com.id = cal.idCompra
		INNER JOIN ADIOS_TERCER_ANIO.TipoPublicacion tp on tp.id = pub.idTipoPublicacion
	where usu.id = com.idComprador or usu.id = ofe.idUsuario
	group by 
	pub.id, pub.descripcion, iif(com.cantidad <> pub.stock, com.cantidad, pub.stock), com.fecha,
		iif(ofe.monto is not null, ofe.monto, pub.precio), cal.puntaje, tp.nombre
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarVisibilidad] (@nombre NVARCHAR(255),
														   @duracion int output,
														   @precio Decimal(18,2),
														   @porcentaje Decimal(18,2))
AS
BEGIN
	if(@nombre is null or @nombre like '')
	begin
		THROW 50004, 'Debe ingresar un nombre', 1; 
	end
	BEGIN TRANSACTION
	BEGIN TRY
	INSERT INTO ADIOS_TERCER_ANIO.Visibilidad(nombre, duracionDias, precio, porcentaje, deleted) 
	VALUES (@nombre, @duracion, @precio, @porcentaje, 0)
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se pudo crear la visibilidad', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ModificarVisibilidad] (@id int,
														   @nombre NVARCHAR(255),
														   @duracion int output,
														   @precio Decimal(18,2),
														   @porcentaje Decimal(18,2))
AS
BEGIN
	if(@nombre is null or @nombre like '')
	begin
		THROW 50004, 'Debe ingresar un nombre', 1; 
	end
	BEGIN TRANSACTION
	BEGIN TRY
	UPDATE ADIOS_TERCER_ANIO.Visibilidad
	SET
		nombre = @nombre, 
		duracionDias = @duracion, 
		precio = @precio, 
		porcentaje = @porcentaje
	where id = @id
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se pudo modificar la visibilidad', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[FacturarCompraInmediata] (@idPublicacion INT, @fecha DATETIME)
AS
BEGIN
	DECLARE @idTipoPublicacion int,
			@idVisibilidad int,
			@precioPubli numeric(18,2),
			@tieneEnvio int,
			@cantidadTotal int,
			@cantidadDeComprasConEnvio int
	SELECT	@idTipoPublicacion = p.idTipoPublicacion,
			@idVisibilidad = p.idVisibilidad,
			@precioPubli = p.precio,
			@tieneEnvio = p.tieneEnvio
	FROM ADIOS_TERCER_ANIO.Publicacion p
	WHERE @idPublicacion = p.id

	UPDATE ADIOS_TERCER_ANIO.Publicacion set idEstado = 4, fechaFin = @fecha
	WHERE id = @idPublicacion

	SELECT @cantidadTotal = SUM(cantidad), @cantidadDeComprasConEnvio = SUM(iif(envio = 0, 1, 0)) FROM ADIOS_TERCER_ANIO.Compra WHERE idPublicacion = @idPublicacion

	IF(@cantidadTotal IS NULL)
	BEGIN
		SET @cantidadTotal = 0
	END

	IF(@cantidadDeComprasConEnvio IS NULL)
	BEGIN
		SET @cantidadDeComprasConEnvio = 0
	END

	Declare @costoEnvio numeric(18,2);
	Select @costoEnvio = iif(@tieneEnvio = 0, precioEnvio * @cantidadDeComprasConEnvio, 0) from ADIOS_TERCER_ANIO.TipoPublicacion where id = @idTipoPublicacion

-----Calculo costo vsibilidad
	Declare @costoVisibilidad numeric(18,2);
	Select @costoVisibilidad = (iif(precio is not null, precio, 0)) from ADIOS_TERCER_ANIO.Visibilidad where id = @idVisibilidad

----Calculo costo
	Declare @comision numeric(18,2);
	Select @comision = ((@precioPubli * @cantidadTotal) * porcentaje) from ADIOS_TERCER_ANIO.Visibilidad where id = @idVisibilidad
						
-----creo factura
	Declare @idFactura INT;
	Declare @importeTotalFactura numeric(18,2);
	set @importeTotalFactura = @costoEnvio + @costoVisibilidad + @comision;
	INSERT INTO ADIOS_TERCER_ANIO.Factura(numero, importeTotal, fecha, idPublicacion)
	VALUES (
		(select MAX(numero) from ADIOS_TERCER_ANIO.Factura) + 1,
		@importeTotalFactura,
		@fecha,
		@idPublicacion
	)
	set @idFactura = @@IDENTITY;
-----creo item envio
	if(@costoEnvio <> 0)
	begin
		Insert into ADIOS_TERCER_ANIO.Item(nombre, precio, cantidad, idFactura)
		Values('Envio', @costoEnvio, 1, @idFactura)
	end
-----creo item comision
	if(@comision <> 0)
	begin
		Insert into ADIOS_TERCER_ANIO.Item(nombre, precio, cantidad, idFactura)
		Values('Comision', @comision, 1, @idFactura)
	end
-----creo item costo visibilidad
	if(@costoVisibilidad <> 0)
	begin
		Insert into ADIOS_TERCER_ANIO.Item(nombre, precio, cantidad, idFactura)
		Values('Valor Publicacion', @costoVisibilidad, 1, @idFactura)
	end
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[FacturarSubasta](@idPublicacion INT, @cantidadCompra INT, @fecha DATETIME, @envio INT)
AS
BEGIN
	Declare @idTipoPublicacion int,
			@idVisibilidad int,
			@precioPubli numeric(18,2),
			@tieneEnvio int;
	Select	@idTipoPublicacion = idTipoPublicacion,
			@idVisibilidad = idVisibilidad,
			@precioPubli = precio
	From ADIOS_TERCER_ANIO.Publicacion
	Where id = @idPublicacion

	UPDATE ADIOS_TERCER_ANIO.Publicacion SET fechaFin = @fecha WHERE @idPublicacion = id

-----Calculo costo envio
	Declare @costoEnvio numeric(18,2);
	Select @costoEnvio = iif((@envio = 0), precioEnvio, 0) from ADIOS_TERCER_ANIO.TipoPublicacion where id = @idTipoPublicacion

-----Calculo costo vsibilidad
	Declare @costoVisibilidad numeric(18,2);
	Select @costoVisibilidad = (iif(precio is not null, precio, 0)) from ADIOS_TERCER_ANIO.Visibilidad where id = @idVisibilidad

----Calculo costo
	Declare @comision numeric(18,2);
	Select @comision = ((@precioPubli * @cantidadCompra)* v.porcentaje) from ADIOS_TERCER_ANIO.Visibilidad v where id = @idVisibilidad
	
-----creo factura
	Declare @idFactura INT;
	Declare @importeTotalFactura numeric(18,2);
	set @importeTotalFactura = @costoEnvio + @costoVisibilidad + @comision;
	INSERT INTO ADIOS_TERCER_ANIO.Factura(numero, importeTotal, fecha, idPublicacion)
	VALUES (
		(select MAX(numero) from ADIOS_TERCER_ANIO.Factura) + 1,
		@importeTotalFactura,
		@fecha,
		@idPublicacion
	)
	set @idFactura = @@IDENTITY;
-----creo item envio
	if(@costoEnvio <> 0)
	begin
		Insert into ADIOS_TERCER_ANIO.Item(nombre, precio, cantidad, idFactura)
		Values('Envio', @costoEnvio, 1, @idFactura)
	end
-----creo item comision
	if(@comision <> 0)
	begin
		Insert into ADIOS_TERCER_ANIO.Item(nombre, precio, cantidad, idFactura)
		Values('Comision', @comision, 1, @idFactura)
	end
-----creo item costo visibilidad
	if(@costoVisibilidad <> 0)
	begin
		Insert into ADIOS_TERCER_ANIO.Item(nombre, precio, cantidad, idFactura)
		Values('Valor Publicacion', @costoVisibilidad, 1, @idFactura)
	end
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[FinalizarSubasta] (@idPublicacion INT, @fecha DATETIME)
AS
BEGIN
		update ADIOS_TERCER_ANIO.Publicacion set idEstado = 4 where id = @idPublicacion
		declare @cantidad int;
		declare @envio int
		select @cantidad = stock from ADIOS_TERCER_ANIO.Publicacion where id = @idPublicacion
		------------------Inserto la compra con la mayor oferta
		Declare @maxMonto numeric(18,2);
		(select @maxMonto = monto,@envio=envio from ADIOS_TERCER_ANIO.Oferta where idPublicacion = @idPublicacion AND monto = (SELECT MAX(monto) from ADIOS_TERCER_ANIO.Oferta));
		

		if(@maxMonto IS NOT NULL)
		BEGIN
		update ADIOS_TERCER_ANIO.Publicacion set precio = @maxMonto where id = @idPublicacion
		Insert into ADIOS_TERCER_ANIO.Compra (idComprador, idPublicacion, fecha, cantidad, envio)
		values ((select idUsuario from ADIOS_TERCER_ANIO.Oferta where idPublicacion = @idPublicacion and monto = @maxMonto), @idPublicacion, @fecha, @cantidad, @envio)

		INSERT INTO ADIOS_TERCER_ANIO.Calificacion(idCompra, pendiente)
		VALUES ((SELECT SCOPE_IDENTITY()), 1)
		END
		ELSE
			SET @cantidad = 0
		
		IF(@envio IS NULL)
		BEGIN
			SET @envio = 1
		END

		exec [ADIOS_TERCER_ANIO].[FacturarSubasta] @idPublicacion, @cantidad, @fecha, @envio 
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[EditarPublicacion] (@descripcion NVARCHAR(255), @fechaInicio DATETIME, @fechaFin DATETIME,
														   @tienePreguntas INT, @tipo NVARCHAR(255), @estado NVARCHAR(255), @precio DECIMAL(18,2), 
														   @visibilidad NVARCHAR(255), @idPublicacion INT, @rubro NVARCHAR(255), @stock INT, @envio INT)
AS
BEGIN
		UPDATE	ADIOS_TERCER_ANIO.Publicacion
		 SET descripcion = @descripcion, fechaInicio = @fechaInicio, fechaFin = @fechaFin, tienePreguntas = @tienePreguntas, 
		 idTipoPublicacion = (select id from ADIOS_TERCER_ANIO.TipoPublicacion where nombre like @tipo), idEstado = (SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = @estado), precio = @precio,
	     idVisibilidad = (SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE nombre = @visibilidad), 
		 idRubro = (SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = @rubro),stock = @stock,
		 tieneEnvio = @envio
		 WHERE id = @idPublicacion
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ActivarPublicacion] (@idPublicacion INT, @fechaInicio DATETIME, @fechaFin DATETIME)
AS
BEGIN
		UPDATE	ADIOS_TERCER_ANIO.Publicacion
		 SET idEstado = 2, fechaInicio = @fechaInicio, fechaFin = @fechaFin WHERE id = @idPublicacion
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[FinalizarPublicacion] (@idPublicacion INT, @fechaFin DATETIME)
AS
BEGIN

		UPDATE	ADIOS_TERCER_ANIO.Publicacion
		 SET idEstado = 4, fechaFin = @fechaFin WHERE id = @idPublicacion

		 DECLARE @tipoDePublicacion INT
		 SET @tipoDePublicacion = (SELECT idTipoPublicacion FROM ADIOS_TERCER_ANIO.Publicacion WHERE id = @idPublicacion)

		 IF( @tipoDePublicacion = 1)
		 BEGIN 
			EXEC [ADIOS_TERCER_ANIO].[FinalizarSubasta] @idPublicacion, @fechaFin
		 END
		 ELSE
			EXEC [ADIOS_TERCER_ANIO].[FacturarCompraInmediata] @idPublicacion, @fechaFin
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[PausarPublicacion] (@idPublicacion INT)
AS
BEGIN
		UPDATE	ADIOS_TERCER_ANIO.Publicacion
		 SET idEstado = 3 WHERE id = @idPublicacion
END
GO
--Vendedores con mayor cantidad de productos no vendidos, dicho listado debe
--filtrarse por grado de visibilidad de la publicaci�n y por mes-a�o. Primero se deber�
--ordenar por fecha y luego por visibilidad.
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[vendedoresConMasProductosNoVendidosPorTrimestre] (@trimestre INT, @anio INT, @idVisibilidad INT)
AS
BEGIN

DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT

IF @trimestre = 1 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @trimestre = 2
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @trimestre = 3
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @trimestre = 4
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5 idUsuario, count(*) AS cantidad, nombre FROM (SELECT per.idUsuario, usu.usuario, per.nombre, pub.descripcion, pub.fechaFin, idVisibilidad 
					FROM ADIOS_TERCER_ANIO.Publicacion pub
					LEFT JOIN (	SELECT idUsuario, nombre FROM ADIOS_TERCER_ANIO.Persona
								UNION
								SELECT idUsuario, razonSocial FROM ADIOS_TERCER_ANIO.Empresa) as per ON per.idUsuario = pub.idPublicador
					LEFT JOIN ADIOS_TERCER_ANIO.Usuario usu ON per.idUsuario = usu.id
				WHERE	pub.id NOT IN(SELECT com.idPublicacion FROM ADIOS_TERCER_ANIO.Compra com) 
						AND 
						pub.idEstado = (select id from ADIOS_TERCER_ANIO.Estado e where e.nombre LIKE 'Finalizada')
						AND
						(MONTH(pub.fechaFin) = @mes1 OR MONTH(pub.fechaFin) = @mes2 OR MONTH(pub.fechaFin) = @mes3)
						AND
						YEAR(pub.fechaFin) = @anio
						AND
						pub.idVisibilidad = @idVisibilidad) publSinCompra
GROUP BY idUsuario, nombre
ORDER BY cantidad DESC
END
GO

--Clientes con mayor cantidad de productos comprados, por mes y por a�o, dentro de
--un rubro particular
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[clientesConMasComprasPorTrimestreYRubro] (@trimestre INT, @anio INT, @idRubro INT)
AS
BEGIN

DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT

IF @trimestre = 1 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @trimestre = 2
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @trimestre = 3
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @trimestre = 4
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5 
		com.idComprador		AS idUsuario,
		per.documento		AS documento,
		per.nombre			AS nombre,
		per.apellido		AS apellido,
		count(*)			AS cantidad_de_compras
FROM 			ADIOS_TERCER_ANIO.Compra com
	LEFT JOIN	ADIOS_TERCER_ANIO.Publicacion pub ON com.idPublicacion = pub.id
	LEFT JOIN	ADIOS_TERCER_ANIO.Persona per on per.idUsuario = com.idComprador
WHERE 
	pub.idRubro = @idRubro
	AND
	YEAR(pub.fechaFin) = @anio
	AND
	(MONTH(pub.fechaFin) = @mes1 OR MONTH(pub.fechaFin) = @mes2 OR MONTH(pub.fechaFin) = @mes3)
GROUP BY com.idComprador, nombre, documento, apellido
ORDER BY cantidad_de_compras DESC
END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.puedeComprar(@idUsuario INT, @puede INT OUTPUT)
AS
BEGIN
	declare @cantNoCalif int = (SELECT COUNT(*) from ADIOS_TERCER_ANIO.Calificacion calif 
	inner join ADIOS_TERCER_ANIO.Compra compra on compra.id = calif.idCompra
	WHERE compra.idComprador = @idUsuario and pendiente = 1 )
	SET @puede = iif((@cantNoCalif>3),0,1);
END
GO

--Vendedores con mayor cantidad de facturas dentro de un mes y a�o particular
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[vendedoresConMasFacturasPorTrimestreAnio] (@trimestre INT, @anio INT)
AS
BEGIN

DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT

IF @trimestre = 1 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @trimestre = 2
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @trimestre = 3
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @trimestre = 4
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5	per.idUsuario	AS idUsuario,
				usu.usuario		AS usuario,
				per.apellido	AS nombre,
				count (*)		AS cantidad_de_facturas
FROM				ADIOS_TERCER_ANIO.Factura fac
		LEFT JOIN	ADIOS_TERCER_ANIO.Publicacion pub ON fac.idPublicacion = pub.id
		LEFT JOIN  (SELECT idUsuario, apellido FROM ADIOS_TERCER_ANIO.Persona
					UNION
					SELECT idUsuario, razonSocial FROM ADIOS_TERCER_ANIO.Empresa) AS per ON per.idUsuario = pub.idPublicador
		LEFT JOIN	ADIOS_TERCER_ANIO.Usuario usu ON pub.idPublicador = usu.id
WHERE	(MONTH(fac.fecha) = @mes1 OR MONTH(fac.fecha) = @mes2 OR MONTH(fac.fecha) = @mes3)
		AND
		YEAR(fac.fecha) = @anio
GROUP BY per.idUsuario, per.apellido, usuario
ORDER BY cantidad_de_facturas DESC
END
GO

--Vendedores con mayor monto facturado dentro de un mes y a�o particular.r
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[vendedoresConMayorMontoFacturadoPorTrimestreAnio] (@trimestre INT, @anio INT)
AS
BEGIN
DECLARE @mes1 INT
DECLARE @mes2 INT
DECLARE @mes3 INT

IF @trimestre = 1 
BEGIN
	SET @mes1 = 1
	SET @mes2 = 2 
	SET @mes3 = 3
END
IF @trimestre = 2
BEGIN
	SET @mes1 = 4
	SET @mes2 = 5 
	SET @mes3 = 6
END
IF @trimestre = 3
BEGIN
	SET @mes1 = 7
	SET @mes2 = 8 
	SET @mes3 = 9
END
IF @trimestre = 4
BEGIN
	SET @mes1 = 10
	SET @mes2 = 11
	SET @mes3 = 12
END

SELECT TOP 5	per.idUsuario			AS idUsuario,
				usu.usuario				AS usuario,
				per.apellido			AS nombre,
				SUM(fac.importeTotal)	AS montoFacturado
FROM				ADIOS_TERCER_ANIO.Factura fac
		LEFT JOIN	ADIOS_TERCER_ANIO.Publicacion pub ON fac.idPublicacion = pub.id
		LEFT JOIN  (SELECT idUsuario, apellido FROM ADIOS_TERCER_ANIO.Persona
					UNION
					SELECT idUsuario, razonSocial FROM ADIOS_TERCER_ANIO.Empresa) AS per ON per.idUsuario = pub.idPublicador
		LEFT JOIN	ADIOS_TERCER_ANIO.Usuario usu ON pub.idPublicador = usu.id
WHERE	
		(MONTH(fac.fecha) = @mes1 OR MONTH(fac.fecha) = @mes2 OR MONTH(fac.fecha) = @mes3)	
		AND
		YEAR(fac.fecha) = @anio
GROUP BY per.idUsuario, per.apellido, usuario
ORDER BY montoFacturado DESC
END
GO

GO 
CREATE PROCEDURE ADIOS_TERCER_ANIO.detallePublicacion(@idPublicacion INT)
AS
BEGIN
	select publicacion.descripcion, publicacion.fechaInicio, publicacion.fechaFin,  tipo.nombre as tipoPublicacion, publicacion.precio, 
	visib.nombre, usr.usuario, rubro.descripcionCorta, publicacion.stock, publicacion.tieneEnvio as tieneEnvio, publicacion.tienePreguntas as tienePreguntas,
	iif(rol.idRol = 2,(SELECT calificacionPromedio FROM ADIOS_TERCER_ANIO.Persona WHERE idUsuario = usr.id),(SELECT calificacionPromedio FROM ADIOS_TERCER_ANIO.Empresa WHERE idUsuario = usr.id))
	as calificacionPromedio, publicacion.idEstado FROM ADIOS_TERCER_ANIO.Publicacion publicacion
	inner join ADIOS_TERCER_ANIO.Visibilidad visib on publicacion.idVisibilidad = visib.id
	inner join ADIOS_TERCER_ANIO.TipoPublicacion tipo on publicacion.idTipoPublicacion = tipo.id 
	inner join ADIOS_TERCER_ANIO.Usuario usr on publicacion.idPublicador = usr.id 
	inner join ADIOS_TERCER_ANIO.Rubro rubro on publicacion.idRubro = rubro.id
	inner join ADIOS_TERCER_ANIO.RolUsuario rol on usr.id = rol.idUsuario
	where publicacion.id = @idPublicacion 
END
GO 
CREATE PROCEDURE ADIOS_TERCER_ANIO.obtenerPregunta(@idPublicacion INT, @nroPreg INT)
AS
BEGIN
	select preg.pregunta, rta.respuesta from ADIOS_TERCER_ANIO.Pregunta preg
	inner join ADIOS_TERCER_ANIO.Publicacion publi on preg.idPublicacion = publi.id
	inner join ADIOS_TERCER_ANIO.Respuesta rta on preg.id = rta.idPregunta
	where publi.id = @idPublicacion AND preg.nroDePregunta = @nroPreg
END
GO 

CREATE PROCEDURE ADIOS_TERCER_ANIO.NuevaPregunta (@idPublicacion INT, @fecha DATETIME, @pregunta NVARCHAR(255), @idUsuario INT)
AS
BEGIN
	DECLARE @nroDePregunta INT
	SET @nroDePregunta = (SELECT COUNT (*) FROM ADIOS_TERCER_ANIO.Pregunta p inner join ADIOS_TERCER_ANIO.Publicacion pu on p.idPublicacion = pu.id WHERE pu.id = @idPublicacion) 

	IF(@nroDePregunta IS NULL)
	BEGIN
		SET @nroDePregunta = 0
	END
	INSERT INTO ADIOS_TERCER_ANIO.Pregunta(pregunta, idPublicacion, idUsuarioPregunta, fecha, contestada, nroDePregunta)
	VALUES (@pregunta,@idPublicacion,@idUsuario,@fecha,0, @nroDePregunta) 

END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.Comprar(@idPublicacion INT, @fecha DATETIME, @cant INT, @idComprador INT, @envio INT)
AS
BEGIN
--	declare @idPublicacion int = 52798
--	declare @fecha DATETIME = GETDATE()
--	declare @cant int = 1
--	declare @idComprador int = 7

	declare @stock int = (SELECT stock from ADIOS_TERCER_ANIO.Publicacion where id = @idPublicacion)
	IF (@stock - @cant < 0) 
	BEGIN
	THROW 46545623, 'No hay stock suficiente', 1; 
	END 

	BEGIN TRANSACTION
	BEGIN TRY

		INSERT INTO ADIOS_TERCER_ANIO.Compra(cantidad, fecha, idComprador, idPublicacion, envio)
		VALUES (@cant, @fecha, @idComprador, @idPublicacion, @envio) 

		INSERT INTO ADIOS_TERCER_ANIO.Calificacion(idCompra, pendiente)
		VALUES ((SELECT SCOPE_IDENTITY()), 1)

		IF (@stock - @cant = 0) 
		BEGIN
			update ADIOS_TERCER_ANIO.Publicacion set idEstado = 4 where id = @idPublicacion
			EXEC ADIOS_TERCER_ANIO.FacturarCompraInmediata @idPublicacion, @fecha
		END 

		update ADIOS_TERCER_ANIO.Publicacion set stock = @stock - @cant where id = @idPublicacion

	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 586577, 'No se pudo realizar la compra', 1; 
	END CATCH
	COMMIT TRANSACTION

END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.Ofertar(@idPublicacion INT, @fecha DATETIME, @monto DECIMAL(18,2), @idUsuario INT, @envio INT)
AS
BEGIN
--	declare @idPublicacion int = 52798
--	declare @fecha DATETIME = GETDATE()
	declare @precio int = (SELECT precio from ADIOS_TERCER_ANIO.Publicacion WHERE id = @idPublicacion)
	
	IF (@monto <= @precio) 
	BEGIN
	THROW 4654562, 'La oferta debe ser mayor a las ofertas anteriores', 1; 
	END 

	BEGIN TRANSACTION
	BEGIN TRY

		INSERT INTO ADIOS_TERCER_ANIO.Oferta(monto, fecha, idUsuario, idPublicacion, envio)
		VALUES (@monto, @fecha, @idUsuario, @idPublicacion, @envio) 

		update ADIOS_TERCER_ANIO.Publicacion set precio = @monto where id = @idPublicacion

	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 586577, 'No se pudo realizar la oferta', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO



--UPDATE ADIOS_TERCER_ANIO.Compra set idComprador = 1 where idComprador = 17

--select * from ADIOS_TERCER_ANIO.Funcionalidad
--select * from ADIOS_TERCER_ANIO.Funcionalidad
--select * from ADIOS_TERCER_ANIO.Rol
--select * from ADIOS_TERCER_ANIO.FuncionalidadRol


SELECT * FROM ADIOS_TERCER_ANIO.Publicacion