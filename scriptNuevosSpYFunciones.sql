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



UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0;
UPDATE ADIOS_TERCER_ANIO.RolUsuario SET deleted = 0;


CREATE PROCEDURE [ADIOS_TERCER_ANIO].[generarUsuarioConIDRol](@usuario NVARCHAR(255),@password NVARCHAR(255), @mail NVARCHAR(255),@ultimoID INT OUTPUT, @rol NVARCHAR(255))
AS BEGIN
	set nocount on;
	set xact_abort on;
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

	DECLARE @idRol INT;
	SET @idRol = (select id from ADIOS_TERCER_ANIO.Rol where nombre = @rol)
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
	VALUES(@idRol, @ultimoID,0)
END
GO
