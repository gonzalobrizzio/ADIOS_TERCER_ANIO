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
	where RTRIM(LTRIM(@usuario)) = RTRIM(LTRIM(u.usuario))

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
					THROW 50002, 'Contraseña Invalida', 1; 
				End
		End
		Else THROW 50003, 'Intentos Agotados', 1; 
	End;
	Else THROW 50001, 'No existe el usuario', 1; 
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
	if (@idFXR is not null and @borrar = 1)
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
	Select (SELECT usuario from ADIOS_TERCER_ANIO.Usuario where id = idPublicador) AS Usuario, p.descripcion, c.id, p.tipo from ADIOS_TERCER_ANIO.Publicacion p 
	inner join ADIOS_TERCER_ANIO.Compra c on c.idPublicacion = p.id
	where c.idComprador = @idCalificador order by c.fecha desc
END

GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[cargarCalificacion] (@idCompra int, @puntaje int, @fecha datetime, @detalle nvarchar(255))
AS
BEGIN
		IF (@puntaje IS null)
		THROW 50004, 'No ingresó puntaje',1;

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

	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO ADIOS_TERCER_ANIO.Usuario(usuario,pass, mail, deleted) VALUES (@usuario,@password,@mail, 0)
		SET @ultimoID = @@IDENTITY;
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'El usuario que intenta agregar no es valido', 1; 
	END CATCH
	COMMIT TRANSACTION	
END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.AgregarRolUsuario ( @rol NVARCHAR(255),@id INT )
AS BEGIN
	set nocount on;
	set xact_abort on;

	IF(@rol IS NULL)
		THROW 50004, 'Necesita seleccionar un rol', 1;

	BEGIN TRANSACTION
	BEGIN TRY
		DECLARE @idRol INT;
		Select @idRol = id from ADIOS_TERCER_ANIO.Rol r where r.nombre = @rol;
		IF(@idRol IS not NULL)
		bEGIN
			INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idUsuario, idRol, deleted) VALUES(@id, @idRol,0)
		End 
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se ha podido asignar un rol al usuario', 1; 
	END CATCH
	COMMIT TRANSACTION
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
													   @rubro NVARCHAR(255))
AS
BEGIN

	BEGIN TRANSACTION
	BEGIN TRY
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
		    @id, (SELECT id FROM ADIOS_TERCER_ANIO.Localidad WHERE nombre = @localidad), @calificacionPromedio, GETDATE())
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se puede agregar al usuario de tipo Empresa', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ModificarEmpresa] (@razonSocial NVARCHAR(255) ,  @id INT , @telefono NVARCHAR(20), 
														 @direccion DECIMAL(18,0), @calle NVARCHAR(255), @piso DECIMAL(18,0), @depto NVARCHAR(50), @localidad NVARCHAR(255),
														 @codigoPostal NVARCHAR(50), @ciudad NVARCHAR(255), @cuit NVARCHAR(50) , @contacto NVARCHAR(45), 
														 @rubro NVARCHAR(255))
AS
BEGIN
	BEGIN TRANSACTION
			BEGIN TRY
		UPDATE ADIOS_TERCER_ANIO.Empresa
		SET razonSocial = @razonSocial, telefono = @telefono, direccion = @calle, direccion_numero = @direccion, piso = @piso, dpto = @depto,
			idLocalidad= (SELECT id FROM ADIOS_TERCER_ANIO.Localidad WHERE nombre = @localidad), codigoPostal = @codigoPostal, cuit = @cuit, contacto = @contacto,
			idRubro = (SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = @rubro) WHERE id = @id
			END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION;
			THROW 50004, 'No se puede agregar el cliente', 1; 
		END CATCH
	COMMIT TRANSACTION
	
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarPersona] (@nombre NVARCHAR(255) ,  @apellido NVARCHAR(255) , @documento decimal(18,0), @tipoDeDocumento NVARCHAR(255),@telefono NVARCHAR(255), 
													   @direccion decimal(18,0), @calle NVARCHAR(255), @piso decimal(18,0), @depto NVARCHAR(50), @localidad NVARCHAR(255),
													   @codigoPostal NVARCHAR(50), @id INT , @fechaNac DATETIME)
AS
BEGIN

	BEGIN TRANSACTION
	BEGIN TRY
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
			@telefono, @calle,@direccion,@piso,@depto,@codigoPostal, @fechaNac ,GETDATE() , @id, (SELECT id FROM Localidad WHERE nombre like @localidad), 0)
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se puede agregar el cliente', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ModificarPersona] (@nombre NVARCHAR(255) ,  @apellido NVARCHAR(255) , @documento decimal(18,0), @tipoDeDocumento NVARCHAR(255),@telefono NVARCHAR(255), 
													   @direccion decimal(18,0), @calle NVARCHAR(255), @piso decimal(18,0), @depto NVARCHAR(50), @localidad NVARCHAR(255),
													   @codigoPostal NVARCHAR(50), @id INT , @fechaNac DATETIME)
AS
BEGIN

	BEGIN TRANSACTION
	BEGIN TRY
	UPDATE ADIOS_TERCER_ANIO.Persona
	SET nombre = @nombre, apellido = @apellido, idTipoDocumento = (SELECT id FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE descripcion = @tipoDeDocumento),
				 telefono = @telefono,direccion_numero = @direccion, direccion = @calle, piso = @piso, dpto = @depto, codigoPostal = @codigoPostal, 
				 fechaNacimiento = @fechaNac, idLocalidad = (SELECT id FROM Localidad WHERE nombre = @localidad) WHERE @id = idUsuario
	 
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se puede modificar a la persona', 1; 
	END CATCH
	COMMIT TRANSACTION
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
	--declare @idCalificador int = 17;
	Select TOP 5 calif.fecha, calif.puntaje, calif.detalle from ADIOS_TERCER_ANIO.Calificacion calif 
	inner join ADIOS_TERCER_ANIO.Compra compra on compra.id = calif.idCompra
	inner join ADIOS_TERCER_ANIO.Publicacion publicacion on compra.idPublicacion = publicacion.id
	inner join ADIOS_TERCER_ANIO.Usuario usr on usr.id = publicacion.idPublicador
	where compra.idComprador = @idCalificador and pendiente = 0 
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
	where compra.idComprador = @idCalificador and pendiente = 0 and publicacion.tipo = @tipo and calif.puntaje = @puntaje)
END

GO 
CREATE PROCEDURE ADIOS_TERCER_ANIO.obtenerPublicacionesPaginaN(@idUsuario INT, @pagina INT)
AS
BEGIN
	--declare @idUsuario int = 17;
	--declare @pagina INT = 235;

	DECLARE @cant int = (select count(*) from ADIOS_TERCER_ANIO.Publicacion where publicacion.idPublicador != @idUsuario) - @pagina * 20;
	
	WITH TablaP as (select TOP (@cant) publicacion.descripcion, publicacion.fechaFin, publicacion.tipo, publicacion.precio, publicacion.id, visib.porcentaje, publicacion.fechaInicio from ADIOS_TERCER_ANIO.Publicacion publicacion
	inner join ADIOS_TERCER_ANIO.Visibilidad visib on publicacion.idVisibilidad = visib.id
	where publicacion.idPublicador != @idUsuario and stock > 0 and publicacion.idEstado = 2 ORDER BY visib.porcentaje asc, publicacion.fechaInicio ASC)

	SELECT top 20 * FROM TablaP ORDER by TablaP.porcentaje desc, TablaP.fechaInicio desc
END

GO 

<<<<<<< HEAD
--#FIX
--ROMPE PORQUE LE SACAMOS EL idVendedor a la factura
--OJO que habría que usar el id de factura en lugar del numero de factura
--CREATE PROCEDURE ADIOS_TERCER_ANIO.obtenerFacturasPaginaN(@idUsuario INT, @pagina INT)
--AS
--BEGIN
--
--	DECLARE @cant int = (select count(*) from ADIOS_TERCER_ANIO.Factura where idVendedor = @idUsuario);
--	
=======
--CREATE PROCEDURE ADIOS_TERCER_ANIO.obtenerFacturasPaginaN(@idUsuario INT, @pagina INT)
--AS
--BEGIN

--	DECLARE @cant int = (select count(*) from ADIOS_TERCER_ANIO.Factura where idVendedor = @idUsuario);
	
>>>>>>> 72ae5fd77dfc947f6dd73dbee86fb2f963b67648
--	WITH TablaP as (select TOP (@cant) factura.numero ,  usr.usuario, factura.importeTotal, factura.fecha, forma.nombre from ADIOS_TERCER_ANIO.Factura factura
--	inner join ADIOS_TERCER_ANIO.FormaDePago forma on factura.idFormaDePago = forma.id
--	inner join ADIOS_TERCER_ANIO.Usuario usr on factura.idVendedor = usr.id
--	where factura.idVendedor = @idUsuario)
<<<<<<< HEAD
--
=======

>>>>>>> 72ae5fd77dfc947f6dd73dbee86fb2f963b67648
--	SELECT top 5 * FROM TablaP ORDER by TablaP.numero desc, TablaP.importeTotal desc
--END
--GO 


--HAY QUE VER LO DE LOS ENVIOS Y FECHAS
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarPublicacion] (@descripcion NVARCHAR(255), @fechaInicio DATETIME, @fechaFin DATETIME,
														   @tienePreguntas INT, @tipo NVARCHAR(255), @estado NVARCHAR(255), @precio DECIMAL(18,2), 
														   @visibilidad NVARCHAR(255), @idPublicador INT, @rubro NVARCHAR(255), @stock INT, @envio INT)
AS
BEGIN
		INSERT INTO ADIOS_TERCER_ANIO.Publicacion(descripcion, 
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
												  idEnvio)
		 VALUES (@descripcion, @fechaInicio, @fechaFin, @tienePreguntas, @tipo, (SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = @estado), @precio,
	     (SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE descripcion = @visibilidad), @idPublicador, 
		 (SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = @rubro), @stock, NULL)
END
GO

--PARA VER EL HISTORICO DE COMPRAS DE UN USUARIO X
--EJ de ejecucion: EXEC [ADIOS_TERCER_ANIO].[verHistoricoComprasUsuario] @userId = 14
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[verHistoricoComprasUsuario](@userId INT)
AS
BEGIN
SELECT	pub.id, pub.descripcion, pub.precio, com.fecha, com.cantidad, cal.puntaje, cal.pendiente
	 FROM ADIOS_TERCER_ANIO.Usuario usu
		LEFT JOIN ADIOS_TERCER_ANIO.Persona per ON usu.id = per.idUsuario
		LEFT JOIN ADIOS_TERCER_ANIO.Compra com ON usu.id = com.idComprador
		LEFT JOIN ADIOS_TERCER_ANIO.Publicacion pub ON com.idPublicacion = pub.id
		LEFT JOIN ADIOS_TERCER_ANIO.Calificacion cal ON com.id = cal.idCompra
	WHERE usu.id = @userId AND pub.id IS NOT NULL
END
GO

--PARA VER EL HISTORICO DE OFERTAS DE UN USUARIO X
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[verHistoricoOfertasUsuario](@userId INT)
AS
BEGIN
	SELECT	pub.id, pub.descripcion, ofe.fecha, ofe.monto
	 FROM ADIOS_TERCER_ANIO.Usuario usu
		LEFT JOIN ADIOS_TERCER_ANIO.Persona per ON usu.id = per.idUsuario
		LEFT JOIN ADIOS_TERCER_ANIO.Oferta ofe ON usu.id = ofe.idUsuario
		LEFT JOIN ADIOS_TERCER_ANIO.Publicacion pub ON ofe.idPublicacion = pub.id
	WHERE usu.id = @userId AND pub.id IS NOT NULL
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[EditarPublicacion] (@descripcion NVARCHAR(255), @fechaInicio DATETIME, @fechaFin DATETIME,
														   @tienePreguntas INT, @tipo NVARCHAR(255), @estado NVARCHAR(255), @precio DECIMAL(18,2), 
														   @visibilidad NVARCHAR(255), @idPublicacion INT, @rubro NVARCHAR(255), @stock INT, @envio INT)
AS
BEGIN
		UPDATE	ADIOS_TERCER_ANIO.Publicacion
		 SET descripcion = @descripcion, fechaInicio = @fechaInicio, fechaFin = @fechaFin, tienePreguntas = @tienePreguntas, 
		 tipo = @tipo, idEstado = (SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = @estado), precio = @precio,
	     idVisibilidad = (SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE descripcion = @visibilidad), 
		 idRubro = (SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = @rubro),stock = @stock WHERE id = @idPublicacion
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
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[PausarPublicacion] (@idPublicacion INT)
AS
BEGIN
		UPDATE	ADIOS_TERCER_ANIO.Publicacion
		 SET idEstado = 3 WHERE id = @idPublicacion
END
GO

UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0;
UPDATE ADIOS_TERCER_ANIO.RolUsuario SET deleted = 0;


SELECT * FROM ADIOS_TERCER_ANIO.Publicacion