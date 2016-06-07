-------------------------------------------------------------
--SCRIPT DE BORRADO - HAY QUE AGREGAR CADA COSA QUE SE CREE--
-------------------------------------------------------------

USE GD1C2016
DROP TABLE [ADIOS_TERCER_ANIO].[RolUsuario];
DROP TABLE [ADIOS_TERCER_ANIO].[FuncionalidadRol];
DROP TABLE [ADIOS_TERCER_ANIO].[Funcionalidad];
DROP TABLE [ADIOS_TERCER_ANIO].[Rol];
DROP TABLE [ADIOS_TERCER_ANIO].[Persona];
DROP TABLE [ADIOS_TERCER_ANIO].[Empresa];
DROP TABLE [ADIOS_TERCER_ANIO].[TipoDocumento];
DROP TABLE [ADIOS_TERCER_ANIO].[Localidad];
DROP TABLE [ADIOS_TERCER_ANIO].[Respuesta];
DROP TABLE [ADIOS_TERCER_ANIO].[Pregunta];
DROP TABLE [ADIOS_TERCER_ANIO].[Calificacion];
DROP TABLE [ADIOS_TERCER_ANIO].[Oferta];
DROP TABLE [ADIOS_TERCER_ANIO].[Item];
DROP TABLE [ADIOS_TERCER_ANIO].[Compra];
DROP TABLE [ADIOS_TERCER_ANIO].[Factura];
DROP TABLE [ADIOS_TERCER_ANIO].[FormaDePago];
DROP TABLE [ADIOS_TERCER_ANIO].[Publicacion];
DROP TABLE [ADIOS_TERCER_ANIO].[Rubro];
DROP TABLE [ADIOS_TERCER_ANIO].[Envio];
DROP TABLE [ADIOS_TERCER_ANIO].[Estado];
DROP TABLE [ADIOS_TERCER_ANIO].[Visibilidad];
DROP TABLE [ADIOS_TERCER_ANIO].[Usuario];
DROP PROCEDURE ADIOS_TERCER_ANIO.generarUsuario;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarEmpresas;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarPersonas;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarVisibilidades;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarRubros;
DROP PROCEDURE ADIOS_TERCER_ANIO.generarUsuarioConIDRol;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarCalificaciones;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarPublicaciones;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarItems;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarFacturas;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarCompras;
DROP PROCEDURE ADIOS_TERCER_ANIO.migrarOfertas;
DROP PROCEDURE ADIOS_TERCER_ANIO.login;
DROP PROCEDURE ADIOS_TERCER_ANIO.AgregarRol;
DROP PROCEDURE ADIOS_TERCER_ANIO.modificarFuncionalidadesRol;
DROP PROCEDURE ADIOS_TERCER_ANIO.ModificarRol;
DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdDeCuit;
DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdDeDNI;
DROP FUNCTION ADIOS_TERCER_ANIO.funcObtenerIdPublicacionDesdeCodigoVIejo;
DROP SCHEMA ADIOS_TERCER_ANIO;
