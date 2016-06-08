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
	Select (SELECT usuario from ADIOS_TERCER_ANIO.Usuario where id = idPublicador) AS Usuario, p.descripcion, c.id from ADIOS_TERCER_ANIO.Publicacion p 
	inner join ADIOS_TERCER_ANIO.Compra c on c.idPublicacion = p.id
	where c.idComprador = @idCalificador;
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[cargarCalificacion] (@idCompra int, @puntaje int, @fecha datetime, @detalle nvarchar(255))
AS
BEGIN
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

		
	IF (@mail IS NULL OR (@mail NOT LIKE '%@%' OR @mail NOT LIKE '%.com%'))
		THROW 50004, 'Mail invalido',1;

	IF(@password IS NULL)
		THROW 50004, 'Necesita ingresar una contraseña', 1;

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
	RETURN @ultimoID

	
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
		SET @idRol = (select id from ADIOS_TERCER_ANIO.Rol where nombre = @rol)
		INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
		VALUES(@idRol, @id,0)
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'El rol no se ha agregado correctamente', 1; 
	END CATCH
	COMMIT TRANSACTION

END
GO


CREATE PROCEDURE ADIOS_TERCER_ANIO.ModificarUsuario (@usuario NVARCHAR(255),@password NVARCHAR(255), @mail NVARCHAR(255),@id INT)
AS BEGIN
	set nocount on;
	set xact_abort on;

		
	IF (@mail IS NULL OR (@mail NOT LIKE '%@%' OR @mail NOT LIKE '%.com%'))
		THROW 50004, 'Mail invalido',1;

	IF(@password IS NULL)
		THROW 50004, 'Necesita ingresar una contraseña', 1;

	IF(@usuario IS NULL)
		THROW 50004, 'Necesita ingresar un usuario', 1;

	BEGIN TRANSACTION
	BEGIN TRY
	UPDATE ADIOS_TERCER_ANIO.Usuario SET mail = @mail, pass = @password, usuario = @usuario WHERE @id = id
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'El usuario que intenta agregar no es valido', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarEmpresa] (@razonSocial NVARCHAR(255) ,  @id INT , @telefono NVARCHAR(255), 
													   @direccion INT, @calle NVARCHAR(255), @piso INT, @depto NVARCHAR(50), @localidad NVARCHAR(255),
													   @codigoPostal NVARCHAR(50), @ciudad NVARCHAR(255), @cuit NVARCHAR(50) , @contacto NVARCHAR(45), 
													   @rubro NVARCHAR(255))
AS
BEGIN

	IF(@razonSocial IS NULL OR @cuit IS NULL)
		THROW 50004, 'CUIT / RAZON SOCIAL invalido/a',1;

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
	VALUES (@razonSocial,@telefono,@calle,@direccion,@piso,@depto,@codigoPostal,@cuit,@contacto,(SELECT id FROM Rubro WHERE descripcionCorta = @rubro),
		    @id, (SELECT id FROM Localidad WHERE nombre = @localidad), @calificacionPromedio, GETDATE())
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se puede agregar al usuario', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ModificarEmpresa] (@razonSocial NVARCHAR(255) ,  @id INT , @telefono NVARCHAR(255), 
													     @direccion INT, @calle NVARCHAR(255), @piso NUMERIC(18,0), @depto NVARCHAR(50), @localidad NVARCHAR(255),
													     @codigoPostal NVARCHAR(50), @ciudad NVARCHAR(255), @cuit NVARCHAR(50) , @contacto NVARCHAR(45), 
													     @rubro NVARCHAR(255))
AS
BEGIN

	IF(@razonSocial IS NULL OR @cuit IS NULL)
		THROW 50004, 'CUIT / RAZON SOCIAL invalido/a',1;

	BEGIN TRANSACTION
	BEGIN TRY
	
	--Me falta verificar usuario sin repetir, y demás cosas
	--TODO
	UPDATE ADIOS_TERCER_ANIO.Empresa
	SET razonSocial = @razonSocial, telefono = @telefono,direccion_numero = @calle, direccion = @direccion, piso = @piso,
	    dpto = @depto, codigoPostal = @codigoPostal, cuit = @cuit, contacto = @contacto, idRubro = (SELECT id FROM Rubro WHERE descripcionCorta = @rubro),
	    idLocalidad = (SELECT id FROM Localidad WHERE nombre = @localidad) WHERE id = @id
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se puede modificar la empresa', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarPersona] (@nombre NVARCHAR(255) ,  @apellido INT , @documento INT, @tipoDeDocumento NVARCHAR(255),@telefono NVARCHAR(255), 
													   @direccion INT, @calle NVARCHAR(255), @piso INT, @depto NVARCHAR(50), @localidad NVARCHAR(255),
													   @codigoPostal NVARCHAR(50), @id INT , @fechaNac DATETIME)
AS
BEGIN
	IF (@nombre IS NULL )
		THROW 50004, 'Nombre invalido',1;

	IF(@apellido IS NULL)
		THROW 50004, 'Necesita ingresar una contraseña', 1;

	IF(@documento IS NULL)
		THROW 50004, 'Necesita ingresar un usuario', 1;

	IF(@direccion IS NULL)
		THROW 50004, 'Necesita seleccionar un rol', 1;
	IF(@fechaNac IS NULL)
		THROW 50004, 'Necesita indicar una fecha de nacimiento', 1;
	IF(@codigoPostal IS NULL)
		THROW 50004, 'Necesita indicar un código postal',1;

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
										  idLocalidad) 
	VALUES (@nombre,@apellido,@documento, (SELECT id FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE descripcion = @tipoDeDocumento),
			@telefono, @calle,@direccion,@piso,@depto,@codigoPostal, @fechaNac ,GETDATE() , @id, (SELECT id FROM Localidad WHERE nombre = @localidad))
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se puede agregar el cliente', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [ADIOS_TERCER_ANIO].[ModificarPersona] (@nombre NVARCHAR(255) ,  @apellido INT , @documento INT, @tipoDeDocumento NVARCHAR(255),@telefono NVARCHAR(255), 
													   @direccion INT, @calle NVARCHAR(255), @piso INT, @depto NVARCHAR(50), @localidad NVARCHAR(255),
													   @codigoPostal NVARCHAR(50), @id INT , @fechaNac DATETIME)
AS
BEGIN
	IF (@nombre IS NULL )
		THROW 50004, 'Nombre invalido',1;

	IF(@apellido IS NULL)
		THROW 50004, 'Necesita ingresar una contraseña', 1;

	IF(@documento IS NULL)
		THROW 50004, 'Necesita ingresar un usuario', 1;

	IF(@direccion IS NULL)
		THROW 50004, 'Necesita seleccionar un rol', 1;
	IF(@fechaNac IS NULL)
		THROW 50004, 'Necesita indicar una fecha de nacimiento', 1;
	IF(@codigoPostal IS NULL)
		THROW 50004, 'Necesita indicar un código postal',1;

		
	--Me falta verificar usuario sin repetir, y demás cosas
	--TODO

	BEGIN TRANSACTION
	BEGIN TRY
	UPDATE ADIOS_TERCER_ANIO.Persona
	SET nombre = @nombre, apellido = @apellido, idTipoDocumento = (SELECT id FROM ADIOS_TERCER_ANIO.TipoDocumento WHERE descripcion = @tipoDeDocumento),
				 telefono = @telefono,direccion_numero = @calle, direccion = @direccion, piso = @piso, dpto = @depto, codigoPostal = @codigoPostal, 
				 fechaNacimiento = @fechaNac, idLocalidad = (SELECT id FROM Localidad WHERE nombre = @localidad) WHERE id = idUsuario
	 
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION;
		THROW 50004, 'No se puede agregar al usuario', 1; 
	END CATCH
	COMMIT TRANSACTION
END
GO

UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0;
UPDATE ADIOS_TERCER_ANIO.RolUsuario SET deleted = 0;

SELECT * FROM ADIOS_TERCER_ANIO.Calificacion order by pendiente
SELECT * FROM ADIOS_TERCER_ANIO.Usuario
SELECT * FROM ADIOS_TERCER_ANIO.Rol
SELECT * FROM ADIOS_TERCER_ANIO.RolUsuario
