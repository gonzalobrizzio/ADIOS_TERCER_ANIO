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
  usuario NVARCHAR(255) NOT NULL UNIQUE,
  pass NVARCHAR(255) NULL ,
  mail NVARCHAR(255) NOT NULL UNIQUE,
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
  )

CREATE  TABLE Empresa (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  razonSocial NVARCHAR(255) NOT NULL ,
  telefono NVARCHAR(20) NULL ,
  direccion NVARCHAR(50) NULL ,
  direccion_numero INT NULL ,
  piso numeric(18,0) NULL,
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

CREATE  TABLE Estado (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(50) NOT NULL ,
  )

CREATE  TABLE Visibilidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  codigo INT NULL ,
  descripcion NVARCHAR(255) NOT NULL ,
  precio numeric(18,2) NULL ,
  porcentaje numeric(18,2) NULL ,
  )

CREATE  TABLE Item (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
  precio DECIMAL(18,2) NULL ,
  cantidad INT NULL ,
  )

CREATE  TABLE Envio (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  precio DECIMAL(18,2) NULL ,
   )

CREATE  TABLE Publicacion (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY,
  descripcion NVARCHAR(255) NULL ,
  fechaInicio DATETIME NOT NULL ,
  fechaFin DATETIME NOT NULL ,
  tienePreguntas INT NULL ,
  tipo NVARCHAR(255) ,
  idEstado INT REFERENCES Estado(id) ,
  precio NUMERIC(18,2),
  idVisibilidad INT REFERENCES Visibilidad(id) ,
  idPublicador INT REFERENCES Usuario(id) ,
  idRubro INT REFERENCES Rubro(id) ,
  stock INT NULL ,
  idItem INT REFERENCES Item(id) ,
  idEnvio INT REFERENCES Envio(id) ,
  codAnterior INT NULL,
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

CREATE  TABLE FuncionalidadRol (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES Rol(id) ,
  idFuncionalidad INT REFERENCES Funcionalidad(id) ,
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
  idUsuario INT REFERENCES Usuario(id) ,
  idUsuarioCalificador INT REFERENCES Usuario(id) ,
  idCompra INT REFERENCES Compra(id) ,
  fecha DATETIME NULL ,
  puntaje INT NULL ,
  detalle NVARCHAR(45) NULL ,
  pendiente INT NULL ,
  )

CREATE  TABLE FormaDePago (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(50) NULL ,
   )

CREATE  TABLE Factura (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  fecha DATETIME NULL ,
  importeTotal DECIMAL(18,2) NULL ,
  idComprador INT REFERENCES Usuario(id) ,
  numero INT NULL ,
  idFormaDePago INT REFERENCES FormaDePago(id),
  idPublicacion INT REFERENCES Publicacion(id) ,
  )

CREATE  TABLE Pregunta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  pregunta NVARCHAR(255) NULL ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  idUsuarioPregunta INT REFERENCES Usuario(id) ,
  fecha DATETIME NULL ,
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

	INSERT INTO ADIOS_TERCER_ANIO.FormaDePago (
					nombre)
	SELECT DISTINCT Forma_Pago_Desc	
	FROM gd_esquema.Maestra
	WHERE Forma_Pago_Desc is not null

	INSERT INTO ADIOS_TERCER_ANIO.FormaDePago(nombre) VALUES ('No especificado')
END