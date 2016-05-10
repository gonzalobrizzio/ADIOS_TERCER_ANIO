USE [GD1C2016] ;
GO

CREATE SCHEMA [ADIOS_TERCER_ANIO] AUTHORIZATION [gd]

-- -----------------------------------------------------
-- TABLA Funcionalidad
-- -----------------------------------------------------
CREATE  TABLE Funcionalidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Usuario
-- -----------------------------------------------------
CREATE  TABLE Usuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  usuario NVARCHAR(255) NOT NULL UNIQUE,
  contraseña NVARCHAR(255) NOT NULL ,
  mail NVARCHAR(255) NOT NULL UNIQUE,
  deleted INT DEFAULT 0 ,
  intentos INT DEFAULT 0
  )



-- -----------------------------------------------------
-- TABLA Rol
-- -----------------------------------------------------
CREATE  TABLE Rol (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
  deleted INT DEFAULT 0 ,
   )



-- -----------------------------------------------------
-- TABLA TipoDNI
-- -----------------------------------------------------
CREATE  TABLE TipoDNI (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NOT NULL ,
   )



-- -----------------------------------------------------
-- TABLA Localidad
-- -----------------------------------------------------
CREATE  TABLE Localidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcion NVARCHAR(255) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Persona
-- -----------------------------------------------------
CREATE  TABLE Persona (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NOT NULL ,
  apellido NVARCHAR(255) NOT NULL ,
  DNI DECIMAL(18,0) NOT NULL ,
  telefono INT NOT NULL ,
  direccion NVARCHAR(255) NOT NULL ,
  piso DECIMAL(18,0) NULL ,
  dpto NVARCHAR(50) NULL ,
  codigoPostal NVARCHAR(50) NOT NULL ,
  fechaNacimiento DATETIME NOT NULL ,
  fechaCreacion DATETIME NOT NULL ,
  Usuario_id INT REFERENCES usuario(id) ,
  TipoDNI_id INT REFERENCES TipoDNI(id) ,
  Localidad_id INT REFERENCES Localidad(id) ,
  direccion_numero DECIMAL(18,0) NULL ,
  )


-- -----------------------------------------------------
-- TABLA Empresa
-- -----------------------------------------------------
CREATE  TABLE Empresa (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  razonSocial NVARCHAR(255) NOT NULL ,
  telefono INT NULL ,
  direccion NVARCHAR(50) NULL ,
  dpto NVARCHAR(50) NULL ,
  codigoPostal NVARCHAR(50) NULL ,
  cuit NVARCHAR(50) NOT NULL ,
  contacto NVARCHAR(45) NULL ,
  rubro NVARCHAR(255) NULL ,
  Usuario_id INT REFERENCES usuario(id) ,
  Localidad_id INT REFERENCES Localidad(id) ,
  calificacionPromedio INT NULL ,
  fechaCreacion DATETIME NULL ,
  direccion_numero INT NULL ,
  )



-- -----------------------------------------------------
-- TABLA Estado
-- -----------------------------------------------------
CREATE  TABLE Estado (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(50) NOT NULL ,
  )



-- -----------------------------------------------------
-- TABLA Visibilidad
-- -----------------------------------------------------
CREATE  TABLE Visibilidad (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  codigo INT NULL ,
  descripcion NVARCHAR(255) NOT NULL ,
  precio INT NULL ,
  porcentaje INT NULL ,
  )



-- -----------------------------------------------------
-- TABLA Item
-- -----------------------------------------------------
CREATE  TABLE Item (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(255) NULL ,
  stock INT NULL ,
  precio DECIMAL(18,2) NULL ,
  cantidad INT NULL ,
  )



-- -----------------------------------------------------
-- TABLA Envio
-- -----------------------------------------------------
CREATE  TABLE Envio (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  precio DECIMAL(18,2) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Publicacion
-- -----------------------------------------------------
CREATE  TABLE Publicacion (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idEstado INT REFERENCES Estado(id) ,
  idVisibilidad INT REFERENCES Visibilidad(id) ,
  idPublicador INT REFERENCES Usuario(id) ,
  fechaInicio DATETIME NOT NULL ,
  fechaFin DATETIME NOT NULL ,
  descripcion NVARCHAR(255) NULL ,
  tienePreguntas INT NULL ,
  idtipo INT NOT NULL ,
  idRubro INT REFERENCES Rubro(id) ,
  idItem INT REFERENCES Item(id) ,
  idEnvio INT REFERENCES Envio(id) ,
  )



-- -----------------------------------------------------
-- TABLA Rubro
-- -----------------------------------------------------
CREATE  TABLE Rubro (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcionCorta NVARCHAR(50) NOT NULL ,
  descripcionLarga NVARCHAR(255) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Rubro_has_Publicacion
-- -----------------------------------------------------
--CREATE  TABLE Rubro_has_Publicacion (
--  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
--  idPublicacion INT NOT NULL ,
--  idRubro INT NOT NULL ,
--  INDEX fk_Rubro_has_Publicacion_Publicacion1_idx (idPublicacion ASC) ,
--  INDEX fk_Rubro_has_Publicacion_Rubro1_idx (idRubro ASC) ,
--   ,
--  CONSTRAINT fk_Rubro_has_Publicacion_Publicacion1
--    FOREIGN KEY (idPublicacion )
--    REFERENCES mydb.Publicacion (id )
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION,
--  CONSTRAINT fk_Rubro_has_Publicacion_Rubro1
--    FOREIGN KEY (idRubro )
--    REFERENCES mydb.Rubro (id )
--    ON DELETE NO ACTION
--    ON UPDATE NO ACTION)



-- -----------------------------------------------------
-- TABLA RolUsuario
-- -----------------------------------------------------
CREATE  TABLE RolUsuario (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idUsuario INT REFERENCES Usuario(id) ,
  idRol INT REFERENCES Rol(id) ,
  deleted INT NULL ,
  )



-- -----------------------------------------------------
-- TABLA FuncionalidadRol
-- -----------------------------------------------------
CREATE  TABLE FuncionalidadRol (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idRol INT REFERENCES Rol(id) ,
  idFuncionalidad INT REFERENCES Funcionalidad(id) ,
  )



-- -----------------------------------------------------
-- TABLA Compra
-- -----------------------------------------------------
CREATE  TABLE Compra (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idComprador INT REFERENCES Usuario(id) ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  fecha DATETIME NULL ,
  )



-- -----------------------------------------------------
-- TABLA Oferta
-- -----------------------------------------------------
CREATE  TABLE Oferta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  monto DECIMAL(18,2) NOT NULL ,
  idUsuario INT REFERENCES Usuario(id) ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  fecha DATETIME NULL ,
  )



-- -----------------------------------------------------
-- TABLA Calificacion
-- -----------------------------------------------------
CREATE  TABLE Calificacion (
  id INT NOT NULL ,
  idUsuarioCalificador INT NOT NULL ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  fecha DATETIME NULL ,
  valor INT NULL ,
  detalle NVARCHAR(45) NULL ,
  pendiente INT NULL ,
  )



-- -----------------------------------------------------
-- TABLA FormaDePago
-- -----------------------------------------------------
CREATE  TABLE FormaDePago (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  nombre NVARCHAR(50) NULL ,
   )



-- -----------------------------------------------------
-- TABLA Factura
-- -----------------------------------------------------
CREATE  TABLE Factura (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  fecha DATETIME NULL ,
  importeTotal DECIMAL(18,2) NULL ,
  idComprador INT REFERENCES Usuario(id) ,
  numero INT NULL ,
  idFormaDePago INT REFERENCES FormaDePago(id),
  idPublicacion INT REFERENCES Publicacion(id) ,
  )



-- -----------------------------------------------------
-- TABLA Pregunta
-- -----------------------------------------------------
CREATE  TABLE Pregunta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  pregunta NVARCHAR(255) NULL ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  idUsuarioPregunta INT REFERENCES Usuario(id) ,
  fecha DATETIME NULL ,
  )



-- -----------------------------------------------------
-- TABLA Respuesta
-- -----------------------------------------------------
CREATE  TABLE Respuesta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPregunta INT REFERENCES Pregunta(id) ,
  fecha DATETIME NULL ,
  respuesta NVARCHAR(255) NULL ,
  )

-- -----------------------------------------------------
-- PROCEDURES
-- -----------------------------------------------------

-- -----------------------------------------------------
-- VISTAS
-- -----------------------------------------------------

-- -----------------------------------------------------
-- TRIGGERS
-- -----------------------------------------------------


-- -----------------------------------------------------
-- MIGRACION
-- -----------------------------------------------------




-- -----------------------------------------------------
-- SCRIPT DE BORRADO
-- -----------------------------------------------------
--USE GD1C2016
--DROP TABLE [ADIOS_TERCER_ANIO].[RolUsuario];--DROP TABLE [ADIOS_TERCER_ANIO].[FuncionalidadRol];--DROP TABLE [ADIOS_TERCER_ANIO].[Funcionalidad];--DROP TABLE [ADIOS_TERCER_ANIO].[Rol];--DROP TABLE [ADIOS_TERCER_ANIO].[Persona];--DROP TABLE [ADIOS_TERCER_ANIO].[Empresa];--DROP TABLE [ADIOS_TERCER_ANIO].[TipoDNI];--DROP TABLE [ADIOS_TERCER_ANIO].[Localidad];--DROP TABLE [ADIOS_TERCER_ANIO].[Factura];--DROP TABLE [ADIOS_TERCER_ANIO].[FormaDePago];--DROP TABLE [ADIOS_TERCER_ANIO].[Respuesta];--DROP TABLE [ADIOS_TERCER_ANIO].[Pregunta];--DROP TABLE [ADIOS_TERCER_ANIO].[Compra];--DROP TABLE [ADIOS_TERCER_ANIO].[Calificacion];--DROP TABLE [ADIOS_TERCER_ANIO].[Oferta];--DROP TABLE [ADIOS_TERCER_ANIO].[Publicacion];--DROP TABLE [ADIOS_TERCER_ANIO].[Rubro];--DROP TABLE [ADIOS_TERCER_ANIO].[Envio];--DROP TABLE [ADIOS_TERCER_ANIO].[Estado];--DROP TABLE [ADIOS_TERCER_ANIO].[Item];--DROP TABLE [ADIOS_TERCER_ANIO].[Visibilidad];--DROP TABLE [ADIOS_TERCER_ANIO].[Usuario];--DROP SCHEMA ADIOS_TERCER_ANIO--

