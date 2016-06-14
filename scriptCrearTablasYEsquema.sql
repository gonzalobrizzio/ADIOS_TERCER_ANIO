--Script crear tablas
USE [GD1C2016] ;
GO

CREATE SCHEMA [ADIOS_TERCER_ANIO] AUTHORIZATION [gd]

CREATE  TABLE Funcionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NULL ,
  )

CREATE  TABLE Usuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  usuario NVARCHAR(255) NOT NULL,
  pass NVARCHAR(255) NULL ,
  mail NVARCHAR(255) NOT NULL,
  deleted INT DEFAULT 0 ,
  intentos INT DEFAULT 0 ,
  )

  
CREATE  TABLE Rol (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
  deleted INT DEFAULT 0 ,
   )

CREATE  TABLE TipoDocumento (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NOT NULL ,
   )

CREATE  TABLE Localidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
   )

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
  calificacionPromedio INT NULL DEFAULT 0,
  )

CREATE  TABLE Empresa (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  razonSocial NVARCHAR(255) NOT NULL ,
  telefono NVARCHAR(20) NULL ,
  direccion NVARCHAR(50) NULL ,
  direccion_numero DECIMAL(18,0) NULL ,
  piso DECIMAL(18,0) NULL,
  dpto NVARCHAR(50) NULL ,
  codigoPostal NVARCHAR(50) NULL ,
  cuit NVARCHAR(50) NOT NULL,
  contacto NVARCHAR(45) NULL ,
  idRubro INT REFERENCES Rubro(id) NULL,
  idUsuario INT REFERENCES Usuario(id) ,
  idLocalidad INT REFERENCES Localidad(id) NULL,
  calificacionPromedio INT NULL DEFAULT 0,
  fechaCreacion DATETIME NULL ,
  )

CREATE  TABLE Estado (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(50) NOT NULL ,
  )

CREATE  TABLE Visibilidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NOT NULL ,
  duracionDias INT NULL ,
  precio DECIMAL(18,2) NULL ,
  porcentaje DECIMAL(18,2) NULL ,
  deleted INT DEFAULT 0,
  )

CREATE  TABLE TipoPublicacion (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  nombre NVARCHAR(255) NOT NULL,
  envioDisponible INT DEFAULT 0,
  precioEnvio DECIMAL(18,2) NULL DEFAULT NULL ,
  deleted INT DEFAULT 0,
   )

CREATE  TABLE Publicacion (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  descripcion NVARCHAR(255) NULL ,
  fechaInicio DATETIME NULL ,
  fechaFin DATETIME NULL ,
  tienePreguntas INT NULL ,
  idTipoPublicacion INT REFERENCES TipoPublicacion(id),
  idEstado INT REFERENCES Estado(id) ,
  precio DECIMAL(18,2),
  idVisibilidad INT REFERENCES Visibilidad(id) ,
  idPublicador INT REFERENCES Usuario(id) ,
  idRubro INT REFERENCES Rubro(id) ,
  stock INT NULL ,
  tieneEnvio INT DEFAULT 1,
  )

CREATE  TABLE Rubro (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcionCorta NVARCHAR(50) NOT NULL ,
  descripcionLarga NVARCHAR(255) NULL ,
   )

CREATE  TABLE RolUsuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idUsuario INT REFERENCES Usuario(id) ,
  idRol INT REFERENCES Rol(id) ,
  deleted INT NULL ,
  )
  
CREATE  TABLE  FuncionalidadRol (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES Rol(id) ,
  idFuncionalidad INT REFERENCES Funcionalidad(id) ,
  deleted INT DEFAULT 0
  )

CREATE  TABLE Compra (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idComprador INT REFERENCES Usuario(id) ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  fecha DATETIME NULL ,
  cantidad INT NULL,
  )

CREATE  TABLE Oferta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  monto DECIMAL(18,2) NOT NULL ,
  fecha DATETIME NULL ,
  idUsuario INT REFERENCES Usuario(id) ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  )

CREATE  TABLE Calificacion (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  idCompra INT REFERENCES Compra(id) ,
  fecha DATETIME NULL ,
  puntaje INT DEFAULT 0 ,
  detalle NVARCHAR(45) NULL ,
  pendiente INT DEFAULT 1,
  )

CREATE  TABLE Factura (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  numero INT NULL ,
  importeTotal DECIMAL(18,2) NULL ,
  fecha DATETIME NULL ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  )

CREATE  TABLE Item (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
  precio DECIMAL(18,2) NULL ,
  cantidad INT NULL ,
  idFactura INT REFERENCES Factura(id) ,
  )


CREATE  TABLE Pregunta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  pregunta NVARCHAR(255) NULL ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  idUsuarioPregunta INT REFERENCES Usuario(id) ,
  fecha DATETIME NULL ,
  contestada INT Default 1,
  )

CREATE  TABLE Respuesta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPregunta INT REFERENCES Pregunta(id) ,
  fecha DATETIME NULL ,
  respuesta NVARCHAR(255) NULL ,
  )
GO
BEGIN
	set nocount on;
	set xact_abort on;

	INSERT INTO ADIOS_TERCER_ANIO.TipoDocumento(descripcion) VALUES ('DNI')
	INSERT INTO ADIOS_TERCER_ANIO.TipoDocumento(descripcion) VALUES ('CI')
	INSERT INTO ADIOS_TERCER_ANIO.TipoDocumento(descripcion) VALUES ('LE')
	INSERT INTO ADIOS_TERCER_ANIO.TipoDocumento(descripcion) VALUES ('LC')

	INSERT INTO ADIOS_TERCER_ANIO.Rol(nombre) VALUES ('Administrativo')
	INSERT INTO ADIOS_TERCER_ANIO.Rol(nombre) VALUES ('Cliente')
	INSERT INTO ADIOS_TERCER_ANIO.Rol(nombre) VALUES ('Empresa')

	INSERT INTO ADIOS_TERCER_ANIO.Estado(nombre) VALUES ('Borrador')
	INSERT INTO ADIOS_TERCER_ANIO.Estado(nombre) VALUES ('Activa')
	INSERT INTO ADIOS_TERCER_ANIO.Estado(nombre) VALUES ('Pausada')
	INSERT INTO ADIOS_TERCER_ANIO.Estado(nombre) VALUES ('Finalizada')

	--password es "gd" encriptado a SHA256
	INSERT INTO ADIOS_TERCER_ANIO.Usuario(usuario, pass, mail) VALUES ('admin', '2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f', 'gd@mailinator.com')
	INSERT INTO ADIOS_TERCER_ANIO.Usuario(usuario, pass, mail) VALUES ('gd', '2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f', 'gd2@mailinator.com')

	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('ABM Visilidad'); --Only admin
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Comprar/Ofertar');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Consultar Facturas');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('ABM Usuario');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Generar Publicacion');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('ABM Rol');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Calificar Vendedor');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Historial de Compras y Subastas');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Listado Estadistico');

	INSERT INTO ADIOS_TERCER_ANIO.TipoPublicacion(nombre) Values('Subasta');
	INSERT INTO ADIOS_TERCER_ANIO.TipoPublicacion(nombre) Values('Compra Inmediata');

	DECLARE @idUsuario int;
	DECLARE @idRol int;

	SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p where p.usuario ='gd' and p.pass='2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Cliente')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario)
	VALUES(@idRol,@idUsuario)

	SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p WHERE p.usuario ='admin' and p.pass='2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Administrativo')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario)
	VALUES(@idRol,@idUsuario)
	
	SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p where p.usuario ='admin' and p.pass='2b88144311832d59ef138600c90be12a821c7cf01a9dc56a925893325c0af99f')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Cliente')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario)
	VALUES(@idRol,@idUsuario)
END