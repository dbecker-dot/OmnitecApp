

USE [datasam]
GO

/****** Object:  View [dbo].[vista_perfilenacceso]    Script Date: 30/12/2022 19:59:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Borrado de Tablas    Script Date: 27/01/2023  ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[acceso]') AND type in (N'U'))
DROP TABLE [dbo].[acceso]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[balanzas]') AND type in (N'U'))
DROP TABLE [dbo].[balanzas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cliente]') AND type in (N'U'))
DROP TABLE [dbo].[cliente]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[clientensucursal]') AND type in (N'U'))
DROP TABLE [dbo].[clientensucursal]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[comprobante]') AND type in (N'U'))
DROP TABLE [dbo].[comprobante]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[cuitempresa]') AND type in (N'U'))
DROP TABLE [dbo].[cuitempresa]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[datacomprobante]') AND type in (N'U'))
DROP TABLE [dbo].[datacomprobante]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[datbalanzas]') AND type in (N'U'))
DROP TABLE [dbo].[datbalanzas]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[deposito]') AND type in (N'U'))
DROP TABLE [dbo].[deposito]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[empresa]') AND type in (N'U'))
DROP TABLE [dbo].[empresa]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[itemscontrolacceso]') AND type in (N'U'))
DROP TABLE [dbo].[itemscontrolacceso]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[localidad]') AND type in (N'U'))
DROP TABLE [dbo].[localidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modobalanza]') AND type in (N'U'))
DROP TABLE [dbo].[modobalanza]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modoperaturno]') AND type in (N'U'))
DROP TABLE [dbo].[modoperaturno]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modobalanza]') AND type in (N'U'))
DROP TABLE [dbo].[modobalanza]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modoperaturno]') AND type in (N'U'))
DROP TABLE [dbo].[modoperaturno]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[movimientostock]') AND type in (N'U'))
DROP TABLE [dbo].[movimientostock]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[nacionalidad]') AND type in (N'U'))
DROP TABLE [dbo].[nacionalidad]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[operacion]') AND type in (N'U'))
DROP TABLE [dbo].[operacion]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[operativo]') AND type in (N'U'))
DROP TABLE [dbo].[operativo]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ordendeservicio]') AND type in (N'U'))
DROP TABLE [dbo].[ordendeservicio]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[pais]') AND type in (N'U'))
DROP TABLE [dbo].[pais]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[perfil]') AND type in (N'U'))
DROP TABLE [dbo].[perfil]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[perfilenacceso]') AND type in (N'U'))
DROP TABLE [dbo].[perfilenacceso]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[persona]') AND type in (N'U'))
DROP TABLE [dbo].[persona]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[planoperaciones]') AND type in (N'U'))
DROP TABLE [dbo].[planoperaciones]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[producto]') AND type in (N'U'))
DROP TABLE [dbo].[producto]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proveedor]') AND type in (N'U'))
DROP TABLE [dbo].[proveedor]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[provincia]') AND type in (N'U'))
DROP TABLE [dbo].[provincia]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[relproveedorpersona]') AND type in (N'U'))
DROP TABLE [dbo].[relproveedorpersona]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[servicios]') AND type in (N'U'))
DROP TABLE [dbo].[servicios]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sucursal]') AND type in (N'U'))
DROP TABLE [dbo].[sucursal]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sucursalapp]') AND type in (N'U'))
DROP TABLE [dbo].[sucursalapp]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ticketbalanza]') AND type in (N'U'))
DROP TABLE [dbo].[ticketbalanza]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipobalanza]') AND type in (N'U'))
DROP TABLE [dbo].[tipobalanza]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipocomprobante]') AND type in (N'U'))
DROP TABLE [dbo].[tipocomprobante]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipoperativo]') AND type in (N'U'))
DROP TABLE [dbo].[tipoperativo]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[turno]') AND type in (N'U'))
DROP TABLE [dbo].[turno]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[umed]') AND type in (N'U'))
DROP TABLE [dbo].[umed]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[usuarios]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vehiculos]') AND type in (N'U'))
DROP TABLE [dbo].[vehiculos]
GO

/****** Borrado de Vistas    Script Date: 19/02/2023  ******/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_acoplado]') AND type in (N'V'))
DROP VIEW [dbo].[vista_acoplado]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_balanzas]') AND type in (N'V'))
DROP VIEW [dbo].[vista_balanzas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_cantcompxturno]') AND type in (N'V'))
DROP VIEW [dbo].[vista_cantcompxturno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_cantidadpesadasxturno]') AND type in (N'V'))
DROP VIEW [dbo].[vista_cantidadpesadasxturno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_chasis]') AND type in (N'V'))
DROP VIEW [dbo].[vista_chasis]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_clientensucursal]') AND type in (N'V'))
DROP VIEW [dbo].[vista_clientensucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_clientes]') AND type in (N'V'))
DROP VIEW [dbo].[vista_clientes]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_comprobante]') AND type in (N'V'))
DROP VIEW [dbo].[vista_comprobante]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_cuitempresa]') AND type in (N'V'))
DROP VIEW [dbo].[vista_cuitempresa]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_dashboardTurnosxCliente]') AND type in (N'V'))
DROP VIEW [dbo].[vista_dashboardTurnosxCliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_dashboardTurnosxTransportista]') AND type in (N'V'))
DROP VIEW [dbo].[vista_dashboardTurnosxTransportista]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_datosticketbalanza]') AND type in (N'V'))
DROP VIEW [dbo].[vista_datosticketbalanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_depositos]') AND type in (N'V'))
DROP VIEW [dbo].[vista_depositos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_detallemovimientostock]') AND type in (N'V'))
DROP VIEW [dbo].[vista_detallemovimientostock]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_docdgaxordenesactivascliente]') AND type in (N'V'))
DROP VIEW [dbo].[vista_docdgaxordenesactivascliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_empresas]') AND type in (N'V'))
DROP VIEW [dbo].[vista_empresas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_entradaproductos]') AND type in (N'V'))
DROP VIEW [dbo].[vista_entradaproductos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_itemscontrolacceso]') AND type in (N'V'))
DROP VIEW [dbo].[vista_itemscontrolacceso]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_locale]') AND type in (N'V'))
DROP VIEW [dbo].[vista_locale]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_loteenstock]') AND type in (N'V'))
DROP VIEW [dbo].[vista_loteenstock]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_modobalanza]') AND type in (N'V'))
DROP VIEW [dbo].[vista_modobalanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_modoperaturnoactivo]') AND type in (N'V'))
DROP VIEW [dbo].[vista_modoperaturnoactivo]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_movimientostock]') AND type in (N'V'))
DROP VIEW [dbo].[vista_movimientostock]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_nrorefclientexordenesactivascliente]') AND type in (N'V'))
DROP VIEW [dbo].[vista_nrorefclientexordenesactivascliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_numeradorcomprobantexsucursaltipo]') AND type in (N'V'))
DROP VIEW [dbo].[vista_numeradorcomprobantexsucursaltipo]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_numeradoroperacionxsucursal]') AND type in (N'V'))
DROP VIEW [dbo].[vista_numeradoroperacionxsucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_numeradorticketxbalanza]') AND type in (N'V'))
DROP VIEW [dbo].[vista_numeradorticketxbalanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_numeradorturnoxsucursal]') AND type in (N'V'))
DROP VIEW [dbo].[vista_numeradorturnoxsucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_operaciones]') AND type in (N'V'))
DROP VIEW [dbo].[vista_operaciones]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_operativo]') AND type in (N'V'))
DROP VIEW [dbo].[vista_operativo]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_ordendeservicio]') AND type in (N'V'))
DROP VIEW [dbo].[vista_ordendeservicio]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_partidaenstock]') AND type in (N'V'))
DROP VIEW [dbo].[vista_partidaenstock]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_perfilenacceso]') AND type in (N'V'))
DROP VIEW [dbo].[vista_perfilenacceso]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_persona]') AND type in (N'V'))
DROP VIEW [dbo].[vista_persona]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_planoperaciones]') AND type in (N'V'))
DROP VIEW [dbo].[vista_planoperaciones]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_productos]') AND type in (N'V'))
DROP VIEW [dbo].[vista_productos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_proveedor]') AND type in (N'V'))
DROP VIEW [dbo].[vista_proveedor]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_salidaproductos]') AND type in (N'V'))
DROP VIEW [dbo].[vista_salidaproductos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_servicios]') AND type in (N'V'))
DROP VIEW [dbo].[vista_servicios]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_stockproducto]') AND type in (N'V'))
DROP VIEW [dbo].[vista_stockproducto]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_sucursales]') AND type in (N'V'))
DROP VIEW [dbo].[vista_sucursales]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_ticketbalanza]') AND type in (N'V'))
DROP VIEW [dbo].[vista_ticketbalanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_ticketbalanzaAB]') AND type in (N'V'))
DROP VIEW [dbo].[vista_ticketbalanzaAB]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_turnos]') AND type in (N'V'))
DROP VIEW [dbo].[vista_turnos]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_ultimataraxturno]') AND type in (N'V'))
DROP VIEW [dbo].[vista_ultimataraxturno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_ultimoticketcerradoxturno]') AND type in (N'V'))
DROP VIEW [dbo].[vista_ultimoticketcerradoxturno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_umed]') AND type in (N'V'))
DROP VIEW [dbo].[vista_umed]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vista_usuarios]') AND type in (N'V'))
DROP VIEW [dbo].[vista_usuarios]
GO

/****** Object:  Borrado de StoredProcedure    Script Date: 19/02/2023 23:03:49 ******/

SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_abrir_ticketbalanza]') AND type in (N'P')

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_abrir_ticketbalanza]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_abrir_ticketbalanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_activar_modoperaturno_CACAD]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_activar_modoperaturno_CACAD]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_activar_modoperaturno_CACAU]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_activar_modoperaturno_CACAU]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_activar_modoperaturno_CAE]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_activar_modoperaturno_CAE]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_activar_modoperaturno_SCA]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_activar_modoperaturno_SCA]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_actualizar_iniciosesionusuarios]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_actualizar_iniciosesionusuarios]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_anular_datbalanzas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_anular_datbalanzas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_anular_ticketbalanza]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_anular_ticketbalanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_anular_turno]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_anular_turno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_asignar_nroturno]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_asignar_nroturno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_asignar_ordendeservicioencomprobante]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_asignar_ordendeservicioencomprobante]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_choferxnombredoc]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_choferxnombredoc]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_comprobantesxfechas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_comprobantesxfechas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_contratistaxtiponombrecuit]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_contratistaxtiponombrecuit]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_movimientostockxfechas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_movimientostockxfechas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_movimientostockxmovstkfechas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_movimientostockxmovstkfechas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_ordendeservicioxnrorefclidocdga]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_ordendeservicioxnrorefclidocdga]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_personaxnombredoc]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_personaxnombredoc]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_planoperacionesxfecha]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_planoperacionesxfecha]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_check_plandeoperaciones]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_check_plandeoperaciones]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_anular_planoperaciones]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_anular_planoperaciones]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_proveedoresxtiponombrecuit]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_proveedoresxtiponombrecuit]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_ticketsbalanzacerradosxfechas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_ticketsbalanzacerradosxfechas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_ticketsbalanzacerradosxfechascliente]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_ticketsbalanzacerradosxfechascliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_buscar_transportistaxtiponombrecuit]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_buscar_transportistaxtiponombrecuit]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_acceso]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_acceso]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_balanza]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_balanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_cliente]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_cliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_clientensucursal]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_clientensucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_comprobante]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_comprobante]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_datacomprobante]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_datacomprobante]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_datbalanzas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_datbalanzas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_deposito]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_deposito]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_empresa]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_empresa]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_itemscontrolacceso]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_itemscontrolacceso]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_localidad]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_localidad]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_modobalanza]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_modobalanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_movimientostock]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_movimientostock]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_operacion]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_operacion]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_operativo]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_operativo]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_ordendeservicio]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_ordendeservicio]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_pais]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_pais]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_perfil]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_perfil]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_perfilenacceso]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_perfilenacceso]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_persona]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_persona]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_plandeoperaciones]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_plandeoperaciones]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_producto]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_producto]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_proveedor]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_proveedor]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_provincia]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_provincia]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_servicio]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_servicio]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_sucursal]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_sucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_sucursalapp]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_sucursalapp]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_turno]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_turno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_umed]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_umed]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_insertar_usuarios]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_insertar_usuarios]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_anularecuperamovimientostock]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_anularecuperamovimientostock]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_balanza]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_balanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_cliente]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_cliente]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_clientensuc]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_clientensuc]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_comprobante]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_comprobante]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_deposito]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_deposito]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_empresa]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_empresa]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_estadoperfil]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_estadoperfil]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_estadoperfilenacceso]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_estadoperfilenacceso]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_estadoservicio]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_estadoservicio]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_itemscontrolacceso]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_itemscontrolacceso]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_movimientostock]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_movimientostock]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_ordendeservicio]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_ordendeservicio]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_persona]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_persona]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_personachofer]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_personachofer]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_producto]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_producto]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_proveedor]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_proveedor]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_sucursal]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_sucursal]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_sucursalapp]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_sucursalapp]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_ticketbalanza]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_ticketbalanza]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_ticketbalanzapesoentrada]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_ticketbalanzapesoentrada]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_ticketbalanzapesosalida]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_ticketbalanzapesosalida]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_turno]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_turno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_umed]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_umed]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_modificar_usuarios]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_modificar_usuarios]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_salida_turno]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_salida_turno]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_total_turnosxfechas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_total_turnosxfechas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_total_Camionesxfechas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_total_Camionesxfechas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_total_Estadoturnosxfechas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_total_Estadoturnosxfechas]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[proc_total_MovInternoxfechas]') AND type in (N'P'))
DROP PROCEDURE [dbo].[proc_total_MovInternoxfechas]
GO

SELECT COUNT(*) as cant from Information_Schema.Tables