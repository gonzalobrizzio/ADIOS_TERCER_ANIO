-------------------------------------------------------------
--SCRIPT DE BORRADO - HAY QUE AGREGAR CADA COSA QUE SE CREE--
-------------------------------------------------------------
--USE GD1C2016
--DROP TABLE [ADIOS_TERCER_ANIO].[RolUsuario];
--DROP TABLE [ADIOS_TERCER_ANIO].[FuncionalidadRol];
--DROP TABLE [ADIOS_TERCER_ANIO].[Funcionalidad];
--DROP TABLE [ADIOS_TERCER_ANIO].[Rol];
--DROP TABLE [ADIOS_TERCER_ANIO].[Persona];
--DROP TABLE [ADIOS_TERCER_ANIO].[Empresa];
--DROP TABLE [ADIOS_TERCER_ANIO].[TipoDocumento];
--DROP TABLE [ADIOS_TERCER_ANIO].[Localidad];
--DROP TABLE [ADIOS_TERCER_ANIO].[Respuesta];
--DROP TABLE [ADIOS_TERCER_ANIO].[Pregunta];
--DROP TABLE [ADIOS_TERCER_ANIO].[Calificacion];
--DROP TABLE [ADIOS_TERCER_ANIO].[Oferta];
--DROP TABLE [ADIOS_TERCER_ANIO].[Item];
--DROP TABLE [ADIOS_TERCER_ANIO].[Compra];
--DROP TABLE [ADIOS_TERCER_ANIO].[Factura];
--DROP TABLE [ADIOS_TERCER_ANIO].[Publicacion];
--DROP TABLE [ADIOS_TERCER_ANIO].[TipoPublicacion];
--DROP TABLE [ADIOS_TERCER_ANIO].[Rubro];
--DROP TABLE [ADIOS_TERCER_ANIO].[Estado];
--DROP TABLE [ADIOS_TERCER_ANIO].[Visibilidad];
--DROP TABLE [ADIOS_TERCER_ANIO].[Usuario];
--DROP PROCEDURE ADIOS_TERCER_ANIO.cargarDatosAdministrativos;
--DROP PROCEDURE ADIOS_TERCER_ANIO.generarUsuariosAdministrativos;
--DROP PROCEDURE ADIOS_TERCER_ANIO.generarUsuario;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarEmpresas;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarPersonas;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarVisibilidades;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarRubros;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarCalificaciones;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarPublicaciones;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarItems;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarFacturas;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarCompras;
--DROP PROCEDURE ADIOS_TERCER_ANIO.migrarOfertas;
--DROP PROCEDURE ADIOS_TERCER_ANIO.verHistoricoComprasUsuario;
--DROP PROCEDURE ADIOS_TERCER_ANIO.calcularCalificacionPromedio;
--DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerCompras;
--DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerFuncionalidades;
--DROP PROCEDURE ADIOS_TERCER_ANIO.cargarCalificacion;
--DROP PROCEDURE ADIOS_TERCER_ANIO.login;
--DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarRol;
--DROP PROCEDURE ADIOS_TERCER_ANIO.modificarFuncionalidadesRol;
--DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarEmpresa;
--DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarPersona;
--DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarUsuario;
--DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarRolUsuario;
--DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarPublicacion;
--DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarVisibilidad;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarEmpresa;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarPersona;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarUsuario;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarRol;
--DROP PROCEDURE ADIOS_TERCER_ANIO.modificarPassword;
--DROP PROCEDURE ADIOS_TERCER_ANIO.validarPassword;
--DROP PROCEDURE ADIOS_TERCER_ANIO.EditarPublicacion;
--DROP PROCEDURE ADIOS_TERCER_ANIO.PausarPublicacion;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ActivarPublicacion;
--DROP PROCEDURE ADIOS_TERCER_ANIO.FinalizarPublicacion;
--DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerTipoDeCompraConNPuntaje;
--DROP PROCEDURE ADIOS_TERCER_ANIO.cargarUltimasCalificaciones;
--DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerFacturasPaginaN;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarVisibilidad;
--DROP PROCEDURE ADIOS_TERCER_ANIO.FacturarCompraInmediata;
--DROP PROCEDURE ADIOS_TERCER_ANIO.FacturarSubasta;
--DROP PROCEDURE ADIOS_TERCER_ANIO.FinalizarSubasta;
--DROP PROCEDURE ADIOS_TERCER_ANIO.puedeComprar;
--DROP PROCEDURE ADIOS_TERCER_ANIO.vendedoresConMasProductosNoVendidosPorTrimestre;
--DROP PROCEDURE ADIOS_TERCER_ANIO.clientesConMasComprasPorTrimestreYRubro;
--DROP PROCEDURE ADIOS_TERCER_ANIO.vendedoresConMasFacturasPorTrimestreAnio;
--DROP PROCEDURE ADIOS_TERCER_ANIO.vendedoresConMayorMontoFacturadoPorTrimestreAnio;
--DROP PROCEDURE ADIOS_TERCER_ANIO.detallePublicacion;
--DROP PROCEDURE ADIOS_TERCER_ANIO.obtenerPregunta;
--DROP PROCEDURE ADIOS_TERCER_ANIO.NuevaPregunta;
--DROP PROCEDURE ADIOS_TERCER_ANIO.Comprar;
--DROP PROCEDURE ADIOS_TERCER_ANIO.Ofertar;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ObtenerUsuariosCliente;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ObtenerUsuariosEmpresa;
--DROP PROCEDURE ADIOS_TERCER_ANIO.ObtenerUsuarioGanador;
--DROP PROCEDURE ADIOS_TERCER_ANIO.FACTURAREMPRESA;
--DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdDeCuit;
--DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdDeDNI;
--DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo;
--DROP FUNCTION ADIOS_TERCER_ANIO.funcConvertirCalificacion;
--DROP SCHEMA ADIOS_TERCER_ANIO;


------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
-----------------CREACION DE TABLAS Y CARGA DE DATOS ADMINISTRATIVOS----------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
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
  precioEnvio DECIMAL(18,2) NULL DEFAULT 50,
  deleted INT DEFAULT 0,
   )

CREATE  TABLE Rubro (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  descripcionCorta NVARCHAR(50) NOT NULL ,
  descripcionLarga NVARCHAR(255) NULL ,
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
  primerPublicacion INT
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
  envio INT NULL
  )

CREATE  TABLE Oferta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  monto DECIMAL(18,2) NOT NULL ,
  fecha DATETIME NULL ,
  idUsuario INT REFERENCES Usuario(id) ,
  idPublicacion INT REFERENCES Publicacion(id) ,
  envio INT NULL
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
  nroDePregunta INT NULL
  )

CREATE  TABLE Respuesta (
  id INTEGER PRIMARY KEY NOT NULL IDENTITY ,
  idPregunta INT REFERENCES Pregunta(id) ,
  fecha DATETIME NULL ,
  respuesta NVARCHAR(255) NULL ,
  )
GO

------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
-----------------ACA VA TODO LO REFERIDO A LA MIGRACION DE DATOS--------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------

-------------------------------------------------------
-- PROCEDURES -----------------------------------------
-------------------------------------------------------

--SP PARA GENERAR USUARIOS
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[generarUsuariosAdministrativos]
AS BEGIN
	DECLARE @idUsuario int;
	DECLARE @idRol int;

	SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p WHERE p.usuario ='admin' and p.pass='e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Administrativo')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
	VALUES(@idRol,@idUsuario,0)
	
		SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p WHERE p.usuario ='admin' and p.pass='e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Empresa')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
	VALUES(@idRol,@idUsuario,0)

	SET @idUsuario = (SELECT p.id FROM ADIOS_TERCER_ANIO.Usuario p where p.usuario ='admin' and p.pass='e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7')
	SET @idRol = (SELECT id FROM ADIOS_TERCER_ANIO.Rol WHERE nombre = 'Cliente')
	INSERT INTO ADIOS_TERCER_ANIO.RolUsuario(idRol,idUsuario,deleted)
	VALUES(@idRol,@idUsuario,0)
END
GO

--SP PARA MIGRAR TODOS LAS EMPRESAS DE LA TABLA MAESTRA
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[cargarDatosAdministrativos]
AS BEGIN
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

	--password es "w23e" encriptado a SHA256
	INSERT INTO ADIOS_TERCER_ANIO.Usuario(usuario, pass, mail) VALUES ('admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 'gd@mailinator.com')

	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('ABM Visilidad'); --Only admin
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Comprar/Ofertar');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Consultar Facturas');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('ABM Usuario');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Generar Publicacion');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('ABM Rol');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Calificar Vendedor');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Historial de Compras y Subastas');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Listado Estadistico');
	INSERT INTO ADIOS_TERCER_ANIO.Funcionalidad VALUES ('Cambiar Contrasenia');

	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (1,1);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (1,3);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (1,4);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (1,6);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (2,2);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (2,5);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (2,3);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (2,8);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (2,7);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (3,3);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (3,5);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (1,9);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (1,10);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (2,10);
	INSERT INTO ADIOS_TERCER_ANIO.FuncionalidadRol(idRol, idFuncionalidad) Values (3,10);

	INSERT INTO ADIOS_TERCER_ANIO.TipoPublicacion(nombre) Values('Subasta');
	INSERT INTO ADIOS_TERCER_ANIO.TipoPublicacion(nombre) Values('Compra Inmediata');

	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('No Disponible')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Adrogué')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Burzaco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Claypole')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Don orione')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Glew')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José mármol ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Longchamps')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Malvinas argentinas ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ministro rivadavia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rafael calzada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San francisco solano ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San jose')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Abasto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Agronomía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Almagro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balvanera')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barracas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio norte')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Belgrano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Boedo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Caballito')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chacarita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coghlan')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colegiales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Constitucion')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Flores')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Floresta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La boca')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Liniers')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mataderos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Micro centro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Monserrat')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Monte castro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Nuñez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Nueva pompeya')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Palermo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Palermo viejo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Parque avellaneda')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Parque chacabuco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Parque patricios')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Paternal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Puerto madero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Recoleta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Retiro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Saavedra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San cristobal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San nicolas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San telmo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Velez sarsfield')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Versalles')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa crespo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa devoto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa general mitre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa lugano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa luro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa ortuzar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa pueyrredon')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa real')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa riachuelo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa santa rita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa soldati')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa urquiza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa del parque')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Ayacucho')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Ballester')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Barrio Para Jefes y Oficiales General San Martín')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Barrio Parque Figueroa Alcorta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Bernardo de Monteagudo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Billinghurst')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Chacabuco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ciudad del Libertador General San Martín')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Ciudad Jardín el Libertador')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Coronel José María Zapiola')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa General Antonio José de Sucre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa General Eugenio Necochea')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa General José Tomás Guido')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa General Juan Gregorio de Las Heras')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Godoy Cruz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Granaderos de San Martín')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Gregoria Matorras')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa José León Suárez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Juan Martín de Pueyrredón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Libertad')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Lynch')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Maipú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa María Irene de los Remedios de Escalada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Marqués Alejandro María de Aguado')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Parque San Lorenzo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa San Andrés')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Yapeyú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Área de Promoción El Triángulo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Grand Bourg')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ingeniero Adolfo Sourdeaux')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ingeniero Pablo Nogués')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Polvorines')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Malvinas Argentinas ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tortuguitas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa de Mayo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tierras Altas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Fernando')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Victoria')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Virreyes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Islas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Adelina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Boulogne')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Martínez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Acassuso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Isidro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Béccar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bella Vista')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Muñiz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Miguel')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa María')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tigre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Don Torcuato')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Pacheco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Talar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Benavídez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Dique Luján')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Nordelta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ricardo Rojas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rincón de Milberg')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Troncos del Talar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Delta de Tigre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carapachay')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Florida')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Florida Oeste')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Lucila')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Munro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Olivos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Vicente López')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Adelina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Martelli')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José C. Paz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Avellaneda')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Crucecita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Dock Sud')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gerli')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Piñeyro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sarandí')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Domínico')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Wilde')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Berazategui')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Hudson')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan María Gutiérrez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ranelagh')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sourigues')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pereyra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Plátanos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa España')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Centro Agrícola El Pato')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Nueve de Abril')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Canning')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Jagüel')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Luis Guillón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Monte Grande')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bosques')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Estanislao Severo Zeballos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Juan Bautista')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gobernador Julio A. Costa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ingeniero Juan Allan')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Brown')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa San Luis')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Santa Rosa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Vatteone')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Capilla')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gerli')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lanús Este')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lanús Oeste')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Monte Chingolo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Remedios de Escalada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Valentín Alsina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lomas de Zamora')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Banfield')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Temperley')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Llavallol')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Turdera')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Centenario')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Fiorito')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ingeniero Budge')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Albertina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San José')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bernal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Don Bosco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ezpeleta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Quilmes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Francisco Solano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa La Florida')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Hurlingham')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('William C. Morris')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Tesei')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ituzaingó')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Udaondo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Justo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ramos Mejía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Aldo Bonzi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rafael Castillo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ciudad Evita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('González Catán')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gregorio de Laferrere')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Tablada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lomas del Mirador')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Isidro Casanova')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tapiales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Veinte de Junio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Eduardo Madero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Luzuriaga')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Virrey del Pino')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Merlo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Antonio de Padua')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Libertad')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mariano Acosta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Parque San Martín')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pontevedra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Moreno')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Reja')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Francisco Álvarez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cuartel V')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Trujui')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Paso del Rey')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Morón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Castelar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Haedo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Palomar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Sarmiento')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Caseros')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Churruca')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ciudad Jardín Lomas del Palomar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ciudadela')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Libertador')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José Ingenieros')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Loma Hermosa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Martín Coronado')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Once de Septiembre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pablo Podestá')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Remedios de Escalada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sáenz Peña')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santos Lugares')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Bosch')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Raffo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Adolfo Gonzales Chaves')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('De la Garma')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan Eulogio Barra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Vásquez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carhué')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rivera')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Maza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Espartillar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Miguel Arcángel')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Esteban Agustín Gascón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Delfín Huergo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Pala')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Thames')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Yutuyaco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Alberti')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mechita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Ortiz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Plá')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coronel Seguí')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Grisolía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa María')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gobernador Ugarte')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arrecifes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Todd')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Viña')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ayacucho')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Udaquiola')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Constancia ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Solanet')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Azul')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chillar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cacharí')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Dieciséis de Julio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ariel')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bahía Blanca')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Daniel Cerri')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cabildo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Grünbein')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ingeniero White')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Bordeu')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Espora')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Harding Green')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Stella Maris')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Nueva')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rosendo López')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Agustín')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Pinos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Napaleofú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balcarce')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ramos Otero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Laguna La Brava')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Baradero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Alsina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Estación Ireneo Portela')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Coloma')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Benito Juárez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Cacique')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barker')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Estación López')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tedín Uriburu')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Berisso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Porteña')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Progreso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa San Carlos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio El Carmen Este')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Dolores')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Independencia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Corbalan')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Argüello')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Zula')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Banco Provincia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Nueva')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Universitario')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Talas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Palo Blanco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Banco Constructor')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Catorce')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa España')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Balandra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan B.Justo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Obrero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Santa Teresita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Carlos de Bolívar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Urdampilleta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pirovano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Hale')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan F. Ibarra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Paula')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mariano Unzué')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Lynch Pueyrredón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Paraje Vallimanca')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Paraje Villa Sanz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bragado')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Eduardo O Brien')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mechita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Comodoro Py')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Warnes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Irala')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Olascoaga')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Máximo Fernández')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Limpia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Asamblea')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Brandsen')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Jeppener')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Altamirano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gómez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Oliden')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Samborombón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Campana')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Alto Los Cardales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lomas del Río Luján')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ingeniero Rómulo Otamendi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cañuelas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Rosa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Alejandro Petión')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Máximo Paz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Uribelarrea')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Vicente Casares')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gobernador Udaondo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Taladro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Capitán Sarmiento')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Luisa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carlos Casares')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Smith')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bellocq')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Moctezuma')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cadret')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Hortensia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ordoqui')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mauricio Hirsch')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colonia Mauricio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Sofía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carlos Tejedor')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tres Algarrobos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colonia Seré')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Timote')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Curarú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carmen de Areco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tres Sargentos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pueblo Gouin')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Castelli')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Centro Guerrero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cerro de la Gloria')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chacabuco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rawson')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('O Higgins')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Castilla')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Ángeles')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chascomús')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chivilcoy')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Moquehuá')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gorostiaga')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Emilio Ayarza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Rica')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Sebastián')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Benítez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Henry Bell')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Indacochea')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Palemon Huergo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ramón Biaus')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pearson')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sarasa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Arbolito')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coronel Dorrego')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Oriente')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Perdido')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Aparicio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Román')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario Marisol')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Irene')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Faro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coronel Pringles')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Indio Rico')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lartigau')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Pensamiento')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Divisorio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Frapal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Punta Alta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa General Arias')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario Pehuen-Có')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa del Mar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bajo Hondo ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Puerto Rosales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arroyo Pareja')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Punta Ancla')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coronel Suárez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Huanguelén')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San José')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa María')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Trinidad')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Arcadia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pasman')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cura Malal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('D Orbigny')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cascada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Daireaux')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mouras')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arboledas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Copeta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Larga')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Andant')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Freyre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Clemente del Tuyú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Toninas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Costa Chica')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Teresita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar del Tuyú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Costa del Este')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Aguas Verdes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Lucila del Mar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Costa Azul')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Bernardo del Tuyú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar de Ajó')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Nueva Atlantis')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Punta Médanos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pinar del Sol')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Costa Esmeralda')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Dolores')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sevigne')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ensenada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Punta Lara')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Catella')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Dique Nº 1')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Isla Santiago Oeste')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Garín')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Belén de Escobar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ingeniero Maschwitz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Matheu')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Maquinista F. Savio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Capilla del Señor')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Cardales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pavón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arroyo de La Cruz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Parada Orlando')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Parada Robles')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Remanso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Etchegoyen')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Parada La Lata - La Loma')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Diego Gaynor')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gobernador Andonaegui')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chenaut')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ezeiza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tristán Suárez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Unión')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carlos Spegazzini')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Aeropuerto Internacional Ezeiza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Canning')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Florentino Ameghino')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Blaquier')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Porvenir')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Miramar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar del Sud')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Comandante Nicanor Otamendi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mechongué')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Centinela del Mar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Alvear')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Arenales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arribeños')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ascensión')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Estación Arenales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ferré')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Angelita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Trinidad')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Belgrano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Guido')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Labardén')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General La Madrid')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Colina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Líbano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Martinetas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pontaut')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lastra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Quilcó')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Las Heras')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villars')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Hornos ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Plomer')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Choza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lozano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Enrique Fynn')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Lavalle')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pavón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chacras de San Clemente')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Madariaga')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ranchos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Loma Verde')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Río Salado')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villanueva')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Alegre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Pinto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Germania')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Francia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colonia San Ricardo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Roth')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar del Plata')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Punta Mogotes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Quintas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Zorzales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Sosiego')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Estación Camet')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Angela')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('2 de Abril')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Adela')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Margaritas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Dorado')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colinas Verdes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Gloria de la Peregrina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sierra de los Padres')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Coyunco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Laguna de los Padres')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Paula')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Batán')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chapadmalal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Felix U. Camet')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Estación Chapadmalal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Acantilados')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Eduardo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Rodríguez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Toldos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Baigorrita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Zavalía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Emilio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Delfina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Villegas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Piedritas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Emilio V. Bunge')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coronel Charlone')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Banderaló')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cañada Seca')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Sauze')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Regina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Saboya')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Eleodora')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Massey')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pichincha')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Casbas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Guaminí')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Laguna Alsina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Victorino de la Plaza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Garré')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arroyo Venado')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Huanguelén')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Henderson')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Herrera Vegas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('María Lucila')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coraceros')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Junín')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Morse')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Agustín Roca')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Fortín Tiburcio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Saforcada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Agustina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Laplacette')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario Laguna de Gómez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Abasto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ángel Etcheverry')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arana')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arturo Seguí')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio El Carmen')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Gambier')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Las Malvinas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Las Quintas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('City Bell')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Retiro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Joaquín Gorina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José Hernández')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José Melchor Romero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Cumbre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Casco Urbano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lisandro Olmos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Hornos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Manuel B. Gonnet')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ringuelet')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Altos de San Lorenzo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tolosa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Transradio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Elisa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Elvira')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Garibaldi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Montoro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Parque Sicardi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Laprida')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pueblo San Jorge')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pueblo Nuevo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Flores')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pardo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Trigo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coronel Boerr')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Vedia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan Bautista Alberdi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Leandro N. Alem')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Alberdi Viejo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Dorado ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Fortín Acha ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lincoln')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Roberts')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pasteur')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Triunfo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arenaza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coronel Martínez de Hoz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bayauca')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Toscas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carlos Salas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bermúdez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lobería')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Manuel')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tamangueyú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Licenciado Matienzo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pieres ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arenas Verdes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Antonio Carboni')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Elvira')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José Santos Arévalo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lobos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Empalme Lobos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Chacras')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Salvador María')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Zapiola')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carlos Keen')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cortines')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José María Jáuregui')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Luján')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Olivera')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Open Door')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Torres')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Magdalena')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Mansilla')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Atalaya')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Vieytes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Roberto J. Payró')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Naranjos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Maipú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Armas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santo Domingo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Coronel Vidal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Pirán')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Armonía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar Chiquita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar de Cobo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Baliza ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Caleta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar de Cobo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Clara del Mar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Atlántida')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Camet Norte')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Frente Mar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Playa Dorada')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Clara del Mar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Elena')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Vivoratá')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Marcos Paz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Elías Romero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Rosa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lisandro de la Torre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Marta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Agote')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gowland')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mercedes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tomás Jofré')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Miguel del Monte')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Abbott')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Zenón Videla Dorna')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Monte Hermoso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario Sauce Grande')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Navarro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Moll')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Marianas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José Juan Almeyra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Necochea')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Quequén')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan Nepomuceno Fernández')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Nicanor Olivera')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Claraz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ramón Santamarina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lumb')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San José')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Negra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Grutas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario Los Ángeles')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario Costa Bonita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Energía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Nueve de Julio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Dudignac')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Alfredo Demarchi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Manuel B. Gonnet')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Patricios')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Aurora')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carlos María Naón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa General Fournier')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Morea')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Doce de Octubre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Marcelino Ugarte')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Norumbega')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santos Unzué')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sierras Bayas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Loma Negra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sierra Chica')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Hinojo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colonia Hinojo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colonia San Miguel')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Espigas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Recalde')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa La Serranía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Luisa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Blancagrande')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colonia Nievas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bahía San Blas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cardenal Cagliero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carmen de Patagones')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('José B. Casas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan A. Pradere')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Stroeder')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villalonga')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Pocitos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Balnearia 7 de Marzo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pehuajó')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan José Paso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mones Cazón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Francisco Madero')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Bernardo de Pehuajó')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Magdala')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Nueva Plata')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chiclana')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Capitán Castro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pellegrini')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('De Bary')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bocayuva')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pergamino')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Acevedo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Manuel Ocampo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Angélica')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan Anchorena')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Violeta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mariano H. Alfonzo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Guerrico')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rancagua')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pinzón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Fontezuela')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('J.A. de la Peña')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mariano Benítez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa San José')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pila')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Casalins')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Del Viso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Fátima')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Lonja')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lagomarsino')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Manzanares')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pilar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Presidente Derqui')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Astolfi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Manuel Alberti')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Rosa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Zelaya')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Montecarlo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pinamar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar de Ostende')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ostende')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Valeria del Mar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cariló')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Guernica')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Azopardo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Bordenave')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Darregueira')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Estela')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Felipe Solá')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('López Lecube')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Puan')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Germán')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tres Cuervos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Víboras')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Castelar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Durcudoy')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Iris')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Verónica')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pipinas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Punta del Indio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Álvarez Jonte')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Tahonas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Monte Veloz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ramallo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('El Paraíso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Bahamas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pérez Millán')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Simón Santiago Sánchez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Ramallo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa General Savio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rauch')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rauch')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('América')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('González Moreno')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Fortín Olavarría')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sansinena')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Roosevelt')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sundblad')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mira Pampa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Mauricio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rojas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Carabelas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Rafael Obligado')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Los Indios')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Manuel Pomar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Beba')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Parque Cecir')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Roberto Cano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sol de Mayo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Roque Pérez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Carlos Beguerie')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santiago Larre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Reforma')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan Tronconi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Paz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Paz chica')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Atucha')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pigüé')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Saavedra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Espartillar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Goyena')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arroyo Corto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Dufaur')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colonia San Martín')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Saladillo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Del Carril')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Polvaderas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cazón')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Álvarez de Toledo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan José Blaquier')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Salliqueló')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Quenumá')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Salto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Arroyo Dulce')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Inés Indart')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gahan')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Berdier')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Invencible')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Andrés de Giles')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Solís')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Ruiz')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Cucullú')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Azcuénaga')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Espil')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Franklin')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Antonio de Areco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Lía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Duggan')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Vagués')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Cayetano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ochandío')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario San Cayetano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Campos Salles')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Conesa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Erézcano')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Rojo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Emilia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Nicolás de los Arroyos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Campi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Canto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Esperanza')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Hermosa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Riccio')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Pedro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gobernador Castro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Santa Lucía')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Río Tala')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pueblo Doyle')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Obligado')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Vicente')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Alejandro Korn')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Domselaar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Suipacha')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Rivas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Román Báez')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tandil')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('María Ignacia')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gardey')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('De la Canal')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Desvío Aguirre')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tapalqué')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Altona')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Crotto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Eufemio Uballes')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Yerbas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Bernardo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Covello')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Velloso')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Paloma')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('General Conesa')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Roch')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tornquist')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Sierra de la Ventana')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Saldungaray')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Ventana')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Chasicó')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tres Picos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Serrana La Gruta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Trenque Lauquen')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Treinta de Agosto')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Beruti')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Girodias')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('La Carreta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tres Arroyos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Orense')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Claromecó')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Copetonas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Micaela Cascallares')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Francisco de Bellocq')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Reta')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Dunamar')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Mayol')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lin Calel')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario Orense')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrow')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Tres Lomas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ingeniero Thompson')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Veinticinco de Mayo')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Norberto de La Riestra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pedernales')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Del Valle')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Gobernador Ugarte')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Valdés')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('San Enrique')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Agustín Mosconi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Ernestina')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lucas Monteverde')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar Azul')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mar de las Pampas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Las Gaviotas')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Villa Gesell')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Pedro Luro')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Médanos')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Mayor Buratovich')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Hilario Ascasubi')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Juan Cousté')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Teniente Origone')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Colonia San Adolfo ')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Argerich')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Laguna Chasicó')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Balneario La chiquita')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Zárate')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Lima')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Barrio Saavedra')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Country Club El Casco')
	INSERT INTO ADIOS_TERCER_ANIO.Localidad(nombre) VALUES ('Escalada')
END
GO


--PROCEDIMIENTO PARA GENERAR USUARIO
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
										tieneEnvio,
										primerPublicacion
									)
	SELECT DISTINCT
		ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo(Publicacion_Cod)						AS id,
		Publicacion_Descripcion																			AS descripcion,
		Publicacion_Fecha																				AS fechaIni,
		Publicacion_Fecha_Venc																			AS fechaFin,
		0																								AS tienePreguntas, --NO VIENEN CON PREGUNTAS, por eso el cero
		(select id from ADIOS_TERCER_ANIO.TipoPublicacion where nombre like Publicacion_Tipo)			AS tipo,
		(SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = 'Finalizada' )							AS idEstado, --TODAS ESTAN FINALIZADAS PORQUE SON DEL 2015
		Publicacion_Precio																				AS precio,
		(SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE nombre = Publicacion_Visibilidad_Desc)		AS idVisibilidad,
		CASE 
			WHEN Publ_Empresa_Cuit IS NULL THEN ADIOS_TERCER_ANIO.funcObtenerIdDeDNI(Publ_Cli_Dni)
			ELSE ADIOS_TERCER_ANIO.funcObtenerIdDeCuit(Publ_Empresa_Cuit)
		END																								AS idUsuario,
		(SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = Publicacion_Rubro_Descripcion)	AS idRubro,
		Publicacion_Stock																				AS stock,
		1																								AS tienEnvio,
		1																								AS primerPublicacion
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
-- MIGRACION DE DATOS
-- -----------------------------------------------------

--CARGO LOS DATOS ADMINISTRATIVOS
EXEC [ADIOS_TERCER_ANIO].[cargarDatosAdministrativos];
GO

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

--GENERO LOS USUARIOS
EXEC [ADIOS_TERCER_ANIO].[generarUsuariosAdministrativos];
GO


--TRIGER PARA ACTUALIZAR LA CALIFICACION PROMEDIO
CREATE TRIGGER [ADIOS_TERCER_ANIO].[tg_actualizarCalificacionPromedio] ON ADIOS_TERCER_ANIO.Calificacion 
AFTER INSERT
AS
BEGIN 
 EXEC ADIOS_TERCER_ANIO.calcularCalificacionPromedio
END
GO

	

	
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
-----------------FIN DE LA MIGRACION DE DATOS, PROCEDURES PARA EL NEGOCIO-----------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------

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
	where RTRIM(LTRIM(@usuario)) = RTRIM(LTRIM(u.usuario)) AND u.deleted = 0
	
	IF(@uIntentos = 5)
	BEGIN
		UPDATE ADIOS_TERCER_ANIO.Usuario SET deleted = 1 WHERE usuario = @usuario
	END

	If (@uId is not null)
	Begin
		If (@uIntentos < 5)
		Begin
			If (@uPass = @pass)
				Begin
					set @idUsuario = @uId
					UPDATE ADIOS_TERCER_ANIO.Usuario SET intentos = 0 WHERE usuario = @usuario
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
	Select (SELECT usuario from ADIOS_TERCER_ANIO.Usuario where id = idPublicador) AS Usuario, p.descripcion, c.id, (select nombre as tipo from ADIOS_TERCER_ANIO.TipoPublicacion where id = p.idTipoPublicacion) AS Tipo_de_Publicacion from ADIOS_TERCER_ANIO.Publicacion p 
	inner join ADIOS_TERCER_ANIO.Compra c on c.idPublicacion = p.id
	inner join ADIOS_TERCER_ANIO.Calificacion calif on calif.idCompra = c.id 
	where c.idComprador = @idCalificador AND calif.pendiente = 1 order by c.fecha desc
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
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[AgregarPublicacion] (@descripcion NVARCHAR(255), @fechaInicio DATETIME, @fechaFin DATETIME,
														   @tienePreguntas INT, @tipo NVARCHAR(255), @estado NVARCHAR(255), @precio DECIMAL(18,2), 
														   @visibilidad NVARCHAR(255), @idPublicador INT, @rubro NVARCHAR(255), @stock INT, @envio INT,
														   @primerPublicacion INT)
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
												  tieneEnvio,
												  primerPublicacion)
		 VALUES (@descripcion, @fechaInicio, @fechaFin, @tienePreguntas, (select id from ADIOS_TERCER_ANIO.TipoPublicacion where nombre like @tipo), 
		 (SELECT id FROM ADIOS_TERCER_ANIO.Estado WHERE nombre = @estado), @precio,
	     (SELECT id FROM ADIOS_TERCER_ANIO.Visibilidad WHERE nombre = @visibilidad), @idPublicador, 
		 (SELECT id FROM ADIOS_TERCER_ANIO.Rubro WHERE descripcionCorta = @rubro), @stock, @envio, @primerPublicacion)
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
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[PausarPublicacion] (@idPublicacion INT)
AS
BEGIN
		UPDATE	ADIOS_TERCER_ANIO.Publicacion
		 SET idEstado = 3 WHERE id = @idPublicacion
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
			@cantidadDeComprasConEnvio int,
			@primerPublicacion int

	SELECT	@idTipoPublicacion = p.idTipoPublicacion,
			@idVisibilidad = p.idVisibilidad,
			@precioPubli = p.precio,
			@tieneEnvio = p.tieneEnvio,
			@primerPublicacion = p.primerPublicacion
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

	IF(@primerPublicacion = 0)
	BEGIN
		SET @costoVisibilidad = 0
	END
	ELSE
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
			@tieneEnvio int,
			@primerPublicacion int
	Select	@idTipoPublicacion = idTipoPublicacion,
			@idVisibilidad = idVisibilidad,
			@precioPubli = precio,
			@primerPublicacion = primerPublicacion
	From ADIOS_TERCER_ANIO.Publicacion
	Where id = @idPublicacion

	UPDATE ADIOS_TERCER_ANIO.Publicacion SET fechaFin = @fecha WHERE @idPublicacion = id

-----Calculo costo envio
	Declare @costoEnvio numeric(18,2);
	Select @costoEnvio = iif((@envio = 0), precioEnvio, 0) from ADIOS_TERCER_ANIO.TipoPublicacion where id = @idTipoPublicacion

-----Calculo costo vsibilidad
	Declare @costoVisibilidad numeric(18,2);
	
	IF(@primerPublicacion = 0)
	BEGIN
		SET @costoVisibilidad = 0
	END
	ELSE
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


--Vendedores con mayor cantidad de productos no vendidos, dicho listado debe
--filtrarse por grado de visibilidad de la publicación y por mes-año. Primero se deberá
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
						((pub.idVisibilidad = @idVisibilidad) OR (@idVisibilidad IS NULL))) publSinCompra
GROUP BY idUsuario, nombre
ORDER BY cantidad DESC
END
GO
--Clientes con mayor cantidad de productos comprados, por mes y por año, dentro de
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
		count(*)			AS cantidadCompras
FROM 			ADIOS_TERCER_ANIO.Compra com
	LEFT JOIN	ADIOS_TERCER_ANIO.Publicacion pub ON com.idPublicacion = pub.id
	LEFT JOIN	ADIOS_TERCER_ANIO.Persona per on per.idUsuario = com.idComprador
WHERE 
	((pub.idRubro = @idRubro) OR (@idRubro IS NULL))
	AND
	YEAR(pub.fechaFin) = @anio
	AND
	(MONTH(pub.fechaFin) = @mes1 OR MONTH(pub.fechaFin) = @mes2 OR MONTH(pub.fechaFin) = @mes3)
GROUP BY com.idComprador, nombre, documento, apellido
ORDER BY cantidadCompras DESC
END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.puedeComprar(@idUsuario INT, @puede INT OUTPUT)
AS
BEGIN
	declare @cantNoCalif int = (SELECT COUNT(calif.id) from ADIOS_TERCER_ANIO.Calificacion calif 
	inner join ADIOS_TERCER_ANIO.Compra compra on compra.id = calif.idCompra
	WHERE compra.idComprador = @idUsuario and calif.pendiente = 1 )
	SET @puede = iif((@cantNoCalif>3),0,1);
END
GO

--Vendedores con mayor cantidad de facturas dentro de un mes y año particular
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
				count (*)		AS cantidadDeFacturas
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
ORDER BY cantidadDeFacturas DESC
END
GO

--Vendedores con mayor monto facturado dentro de un mes y año particular.r
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

CREATE PROCEDURE ADIOS_TERCER_ANIO.Comprar(@idPublicacion INT, @fecha DATETIME, @cant INT, @idComprador INT, @envio INT, @monto INT)
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

	IF (@monto <= 0) 
	BEGIN
	THROW 4654562, 'La cantidad debe ser positiva', 1; 
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
	
	IF (@monto <= @precio ) 
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
CREATE PROCEDURE ADIOS_TERCER_ANIO.obtenerFacturasPaginaN(@idUsuario INT, @pagina INT, @idRol INT, @fechaDesde DATETIME, @fechaHasta DATETIME, @desdePrecio DECIMAL(18,2),
														  @hastaPrecio DECIMAL (18,2), @descripcion NVARCHAR(255), @destinatario NVARCHAR(255), @cant INT OUTPUT)
AS
BEGIN
	--DECLARE @idUsuario INT, @pagina INT, @idRol INT, @fechaDesde DATETIME, @fechaHasta DATETIME, @desdePrecio DECIMAL(18,2),
	--		@hastaPrecio DECIMAL (18,2), @descripcion NVARCHAR(255), @destinatario NVARCHAR(255), @cant int
	--SET @idUsuario = 3
	--SET @pagina = 0
	SET @cant = (select count(*) from ADIOS_TERCER_ANIO.Factura f
			inner join ADIOS_TERCER_ANIO.Publicacion p on p.id = f.idPublicacion
			--LEFT JOIN ADIOS_TERCER_ANIO.Item itm ON (f.id = itm.idFactura) 
			inner join ADIOS_TERCER_ANIO.Usuario u on u.id = p.idPublicador
			AND ((f.fecha BETWEEN @fechaDesde AND @fechaHasta) OR (@fechaDesde IS NULL and @fechaHasta IS NULL))
			AND ((f.importeTotal BETWEEN @desdePrecio AND @hastaPrecio) OR (@desdePrecio is null OR @desdePrecio = -1))
			--AND ((itm.nombre LIKE '%' + @descripcion + '%') OR (@descripcion is null OR @descripcion = '') )
			AND ((u.usuario LIKE '%' + @destinatario + '%') OR (@destinatario is null OR @destinatario = ''))
			where ((p.idPublicador = @idUsuario AND @idRol != 1) OR (@idRol = 1))) - @pagina * 10;
		
		WITH TablaP as (select TOP (@cant) f.numero AS Numero_de_Factura, f.importeTotal AS Importe, f.fecha AS Fecha, u.usuario AS Destinatario from ADIOS_TERCER_ANIO.Factura f
		inner join ADIOS_TERCER_ANIO.Publicacion p on p.id = f.idPublicacion
		--LEFT JOIN ADIOS_TERCER_ANIO.Item itm ON (f.id = itm.idFactura)
		inner join ADIOS_TERCER_ANIO.Usuario u on u.id = p.idPublicador
		WHERE ((p.idPublicador = @idUsuario AND @idRol != 1) OR (@idRol = 1)) 
		AND ((f.fecha BETWEEN @fechaDesde AND @fechaHasta) OR (@fechaDesde IS NULL and @fechaHasta IS NULL))
		AND ((f.importeTotal BETWEEN @desdePrecio AND @hastaPrecio) OR (@desdePrecio is null OR @desdePrecio = -1))
		--AND ((itm.nombre  LIKE '%' + @descripcion + '%') OR (@descripcion is null OR @descripcion = '') )
		AND ((u.usuario LIKE '%' + @destinatario + '%') OR (@destinatario is null OR @destinatario = ''))
		ORDER BY f.fecha ASC)
	SELECT top 10 * FROM TablaP ORDER by TablaP.Fecha desc
END
GO
CREATE PROCEDURE [ADIOS_TERCER_ANIO].[verHistoricoComprasUsuario](@userId INT, @pagina INT, @cant INT OUTPUT)
AS
BEGIN

		SET @cant =	(SELECT COUNT (*) FROM ADIOS_TERCER_ANIO.Usuario usu
						inner JOIN ADIOS_TERCER_ANIO.Publicacion pub ON usu.id = @userId
						inner JOIN ADIOS_TERCER_ANIO.Compra com ON com.idPublicacion = pub.id
						LEFT outer JOIN ADIOS_TERCER_ANIO.Oferta ofe ON ofe.idPublicacion = pub.id and com.id is null
						inner JOIN ADIOS_TERCER_ANIO.Calificacion cal ON com.id = cal.idCompra
						INNER JOIN ADIOS_TERCER_ANIO.TipoPublicacion tp on tp.id = pub.idTipoPublicacion
						where usu.id = com.idComprador or usu.id = ofe.idUsuario) - (@pagina * 10);

		WITH TablaP AS (SELECT TOP (@cant) pub.descripcion, iif(com.cantidad <> pub.stock, com.cantidad, pub.stock) as cantidad, com.fecha as fecha,
						iif(ofe.monto is not null, ofe.monto, pub.precio) as precio, cal.puntaje as calificacion, tp.nombre
						FROM ADIOS_TERCER_ANIO.Usuario usu
						inner JOIN ADIOS_TERCER_ANIO.Publicacion pub ON usu.id = @userId
						inner JOIN ADIOS_TERCER_ANIO.Compra com ON com.idPublicacion = pub.id
						LEFT outer JOIN ADIOS_TERCER_ANIO.Oferta ofe ON ofe.idPublicacion = pub.id and com.id is null
						inner JOIN ADIOS_TERCER_ANIO.Calificacion cal ON com.id = cal.idCompra
						INNER JOIN ADIOS_TERCER_ANIO.TipoPublicacion tp on tp.id = pub.idTipoPublicacion
						where usu.id = com.idComprador or usu.id = ofe.idUsuario
						ORDER BY com.fecha ASC)

	SELECT TOP 10 * FROM TablaP ORDER BY tablaP.fecha DESC
	
END
GO
CREATE PROCEDURE ADIOS_TERCER_ANIO.ObtenerUsuariosCliente(@nombre NVARCHAR(255), @apellido NVARCHAR(255), @doc DECIMAL(18,0), @mail NVARCHAR(255)) 
AS BEGIN
	SELECT u.id, u.usuario AS Usuario, u.mail AS Mail, iif(u.deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado, 
	e.nombre AS Nombre, e.apellido AS Apellido, e.documento AS Documento FROM ADIOS_TERCER_ANIO.Usuario u
	inner join ADIOS_TERCER_ANIO.RolUsuario ru on u.id = ru.idUsuario
	inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol
	inner join ADIOS_TERCER_ANIO.Persona e on u.id = e.idUsuario
	WHERE ru.idRol != 1
	AND ((e.nombre COLLATE Latin1_General_CI_AI LIKE '%' + @nombre + '%' COLLATE Latin1_General_CI_AI) OR (@nombre IS NULL OR @nombre = ''))
	AND ((e.apellido COLLATE Latin1_General_CI_AI LIKE '%' + @apellido + '%' COLLATE Latin1_General_CI_AI) OR (@apellido IS NULL OR @apellido = ''))
	AND ((e.documento LIKE @doc) OR (@doc IS NULL OR @doc = -1))
	AND ((u.mail COLLATE Latin1_General_CI_AI LIKE '%' + @mail + '%' COLLATE Latin1_General_CI_AI) OR (@mail IS NULL OR @mail = ''))
END
GO
CREATE PROCEDURE ADIOS_TERCER_ANIO.ObtenerFuncionalidades (@idRolActual INT)
AS BEGIN
			select fu.descripcion from ADIOS_TERCER_ANIO.FuncionalidadRol f
			INNER JOIN ADIOS_TERCER_ANIO.Funcionalidad fu ON fu.id = f.idFuncionalidad
			where f.idRol = @idRolActual AND f.deleted = 0
END
GO
CREATE PROCEDURE ADIOS_TERCER_ANIO.ObtenerUsuariosEmpresa(@cuit NVARCHAR(255), @razonSocial NVARCHAR(255), @mail NVARCHAR(255))
AS BEGIN
	SELECT u.id, u.usuario AS Usuario, u.mail AS Mail, iif(u.deleted = 0, 'Habilitado', 'Deshabilitado') AS Estado, 
	e.razonSocial AS Razon_Social, e.cuit AS CUIT FROM ADIOS_TERCER_ANIO.Usuario u 
	inner join ADIOS_TERCER_ANIO.RolUsuario ru on u.id = ru.idUsuario 
	inner join ADIOS_TERCER_ANIO.Rol r on r.id = ru.idRol 
	inner join ADIOS_TERCER_ANIO.Empresa e on u.id = e.idUsuario 
	WHERE ru.idRol != 1
	AND ((e.cuit COLLATE Latin1_General_CI_AI LIKE '%' + @cuit + '%' COLLATE Latin1_General_CI_AI) OR (@cuit IS NULL OR @cuit = ''))
	AND ((e.razonSocial COLLATE Latin1_General_CI_AI LIKE '%' + @razonSocial + '%' COLLATE Latin1_General_CI_AI) OR (@razonSocial IS NULL OR @razonSocial = ''))
	AND ((u.mail COLLATE Latin1_General_CI_AI LIKE '%' + @mail + '%' COLLATE Latin1_General_CI_AI) OR (@mail IS NULL OR @mail = ''))
END
GO

CREATE PROCEDURE ADIOS_TERCER_ANIO.ObtenerUsuarioGanador(@idPublicacion INT)
AS BEGIN
	SELECT usuario.usuario, usuario.id FROM ADIOS_TERCER_ANIO.Usuario usuario 
	inner join ADIOS_TERCER_ANIO.Oferta oferta on oferta.idUsuario = usuario.id
	where oferta.monto = (SELECT MAX(monto) FROM ADIOS_TERCER_ANIO.Oferta where idPublicacion = @idPublicacion) 
	and oferta.idPublicacion = @idPublicacion
END
GO