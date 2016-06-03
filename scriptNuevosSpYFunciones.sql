USE GD1C2016
GO
CREATE PROCEDURE login (@usuario NVARCHAR(255), @pass NVARCHAR(255), @idUsuario int output)
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

UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 0;
UPDATE ADIOS_TERCER_ANIO.RolUsuario SET deleted = 0;

SELECT usuario FROM ADIOS_TERCER_ANIO.Usuario