

USE [datasam]
GO

/****** Object:  View [dbo].[vista_perfilenacceso]    Script Date: 30/12/2022 19:59:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/****** Object:  Vista locale    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_locale]
AS
SELECT        T1.pais, T2.provincia, T3.localidad, T1.idpais, T2.idprovincia, T3.idlocalidad
FROM            dbo.pais AS T1 LEFT OUTER JOIN
                         dbo.provincia AS T2 ON T1.idpais = T2.idpais LEFT OUTER JOIN
                         dbo.localidad AS T3 ON T3.idprovincia = T2.idprovincia
GO

/****** Object:  Vista locale    Script Date: 19/02/2023  ******/


CREATE VIEW [dbo].[vista_modobalanza]
AS
SELECT        idbalanza, modobalanza, MAX(fechacambiomodo) AS fechacambiomodo
FROM            dbo.modobalanza
WHERE        (hab = 'SI')
GROUP BY idbalanza, modobalanza
GO

/****** Object:  Vista modoperaturnoactivo  Script Date: 19/02/2023  ******/


CREATE VIEW [dbo].[vista_modoperaturnoactivo]
AS
SELECT        modoperaturno, idmodoperaturno
FROM            dbo.modoperaturno
WHERE        (hab = 'SI')
GO

/****** Object:  Vista depositos    Script Date: 19/02/2023  ******/


CREATE VIEW [dbo].[vista_depositos]
AS
SELECT        T2.razonsocial AS empresa, T2.nombresucursal AS sucursal, T1.codigo, T1.deposito, T1.tipo, T1.cantcalles, T1.cantposiciones, T1.hab, T1.ideposito, T1.idsucursal
FROM            dbo.deposito AS T1 LEFT OUTER JOIN
                         dbo.vista_sucursales AS T2 ON T1.idsucursal = T2.idsucursal
GO

/****** Object:  Vista docdgaxordenesactivascliente    Script Date: 19/02/2023  ******/


CREATE VIEW [dbo].[vista_docdgaxordenesactivascliente]
AS
SELECT        docdga, idcliente
FROM            dbo.ordendeservicio
GROUP BY docdga, idcliente
GO

/****** Object:  Vista nrorefclientexordenesactivascliente   Script Date: 19/02/2023  ******/


CREATE VIEW [dbo].[vista_nrorefclientexordenesactivascliente]
AS
SELECT        nrorefcliente, idcliente
FROM            dbo.ordendeservicio
WHERE        (activa = 'SI')
GROUP BY nrorefcliente, idcliente
GO

/****** Object:  Vista numeradorcomprobantexsucursaltipo   Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_numeradorcomprobantexsucursaltipo]
AS
SELECT        idsucursal, idtipocomprobante, MAX(nrocomp) AS ultimocomp
FROM            dbo.comprobante
GROUP BY idsucursal, idtipocomprobante
GO

/****** Object:  Vista numeradoroperacionxsucursal   Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_numeradoroperacionxsucursal]
AS
SELECT        idsucursal, MAX(nrop) AS ultimaop
FROM            dbo.operacion
GROUP BY idsucursal
GO

/****** Object:  Vista numeradorturnoxsucursal    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_numeradorturnoxsucursal]
AS
SELECT        idsucursal, MAX(nroturno) AS ultimoturno
FROM            dbo.turno
GROUP BY idsucursal
GO


/****** Object:  Vista perfilenacceso    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_perfilenacceso]
AS
SELECT        T1.idperfilenacceso, T1.idperfil, T2.perfil, T3.acceso, T1.idacceso, T1.hab
FROM            dbo.perfilenacceso AS T1 LEFT OUTER JOIN
                         dbo.perfil AS T2 ON T1.idperfil = T2.idperfil LEFT OUTER JOIN
                         dbo.acceso AS T3 ON T1.idacceso = T3.idacceso
GO

/****** Object:  Vista cuitempresa    Script Date: 26/02/2023  ******/

CREATE VIEW [dbo].[vista_cuitempresa]
AS
SELECT        cuit, razonsocial, idcuitempresa
FROM            dbo.cuitempresa
WHERE        (hab = 'SI')
GO

/****** Object:  Vista persona    Script Date: 26/02/2023  ******/

CREATE VIEW [dbo].[vista_persona]
AS
SELECT        T3.cuit, T3.razonsocial, T1.nrodoc, T1.nombre, T1.email, (CASE WHEN T1.idnacionalidad = 0 THEN '-' ELSE T2.nacionalidad END) AS nacionalidad, T1.empleado, T1.chofer, T1.proveedor, T1.visita, T1.hab, T1.idpersona, 
                         T1.idnacionalidad, T1.idcuitempresa
FROM            dbo.persona AS T1 LEFT OUTER JOIN
                         dbo.nacionalidad AS T2 ON T1.idnacionalidad = T2.idnacionalidad LEFT OUTER JOIN
                         dbo.cuitempresa AS T3 ON T1.idcuitempresa = T3.idcuitempresa
GO

/****** Object:  Vista productos    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_productos]
AS
SELECT        T2.razonsocial AS cliente, T1.codcliente, T1.producto, T3.umed, T1.tstkxpeso, T1.tstkxcantidad, T1.movesxlote, T1.movesxpartida, T1.hab, T1.idproducto, T1.idcliente, T1.idumed
FROM            dbo.producto AS T1 INNER JOIN
                         dbo.cliente AS T2 ON T1.idcliente = T2.idcliente INNER JOIN
                         dbo.umed AS T3 ON T1.idumed = T3.idumed
GO

/****** Object:  Vista proveedor    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_proveedor]
AS
SELECT        cuit, nombre, email, contratista, transportista, ATA, hab, idproveedor
FROM            dbo.proveedor
GO

/****** Object:  Vista clientes    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_operativo]
AS
SELECT        T1.idoperativo, T2.tipoperativo, T1.fecha, T1.desde, T1.hasta, T1.descripcion, T1.observaciones, T1.hab
FROM            dbo.operativo AS T1 INNER JOIN
                         dbo.tipoperativo AS T2 ON T1.idtipoperativo = T2.idtipoperativo
GO

/****** Object:  Vista servicios    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_servicios]
AS
SELECT        servicio, hab, idservicio
FROM            dbo.servicios
GO

/****** Object:  Vista ultimoticketcerradoxturno    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_ultimoticketcerradoxturno]
AS
SELECT        T2.idturno, MAX(T1.idticketbalanza) AS ultimoticket
FROM            dbo.ticketbalanza AS T1 LEFT OUTER JOIN
                         dbo.comprobante AS T2 ON T1.idcomprobante = T2.idcomprobante
WHERE        (T1.estadoticket = 'CE')
GROUP BY T2.idturno
GO

/****** Object:  Vista umed    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_umed]
AS
SELECT        umed, hab, idumed
FROM            dbo.umed
GO

/****** Object:  Vista usuarios    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_usuarios]
AS
SELECT        T1.nombre, T1.usuario, T1.email, T2.perfil, T1.diasexpirapassword, T1.feultimocambiopassword, T1.feultimoingreso, DATEDIFF(DAY, T1.feultimocambiopassword, GETDATE()) AS diascambiopassword, T1.hab, T1.idperfil, 
                         T1.idusuario
FROM            dbo.usuarios AS T1 LEFT OUTER JOIN
                         dbo.perfil AS T2 ON T1.idperfil = T2.idperfil
GO

/****** Object:  Vista clientes    Script Date: 19/02/2023  ******/


CREATE VIEW [dbo].[vista_clientes]
AS
SELECT        T1.logo, T1.cuit, T1.razonsocial, T1.direccion, T2.pais, T2.provincia, T2.localidad, T1.observaciones, T1.hab, T1.idlocalidad, T1.idcliente
FROM            dbo.cliente AS T1 LEFT OUTER JOIN
                         dbo.vista_locale AS T2 ON T1.idlocalidad = T2.idlocalidad
GO


/****** Object:  vista empresa    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_empresas]
AS
SELECT        T1.logo, T1.cuit, T1.razonsocial, T1.direccion, T2.pais, T2.provincia, T2.localidad, T1.observaciones, T1.hab, T2.idpais, T2.idprovincia, T1.idlocalidad, T1.idempresa
FROM            dbo.empresa AS T1 LEFT OUTER JOIN
                         dbo.vista_locale AS T2 ON T1.idlocalidad = T2.idlocalidad
GO

/****** Object:  vista ordendeservicio    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_ordendeservicio]
AS
SELECT        T1.idordendeservicio, T1.fecha, T2.cuit, T2.razonsocial AS cliente, T1.nrorefcliente, T1.docdga, T3.servicio, T1.movimientostock, T4.producto, T4.umed, T1.cant, T1.kg, T1.observaciones, T1.activa AS estorden, T1.idservicio, 
                         T1.idproducto, T1.idcliente, T1.idsucursal
FROM            dbo.ordendeservicio AS T1 INNER JOIN
                         dbo.vista_clientes AS T2 ON T1.idcliente = T2.idcliente INNER JOIN
                         dbo.servicios AS T3 ON T1.idservicio = T3.idservicio LEFT OUTER JOIN
                         dbo.vista_productos AS T4 ON T1.idproducto = T4.idproducto
GO


/****** Object:  vista comprobante    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_comprobante]
AS
SELECT        T1.fecha, T3.cliente, T1.nrocomp, T2.tipocomprobante, T3.servicio, T4.contenedor, T3.producto, T3.umed, T4.observaciones, T1.hab, T3.movimientostock, T1.idcomprobante, T1.idsucursal, T1.idtipocomprobante, 
                         T1.idordendeservicio, T3.idcliente, T1.idturno, T3.idservicio, T3.idproducto, T3.cuit, T3.nrorefcliente, T3.docdga
FROM            dbo.comprobante AS T1 INNER JOIN
                         dbo.tipocomprobante AS T2 ON T1.idtipocomprobante = T2.idtipocomprobante LEFT OUTER JOIN
                         dbo.vista_ordendeservicio AS T3 ON T1.idordendeservicio = T3.idordendeservicio LEFT OUTER JOIN
                         dbo.datacomprobante AS T4 ON T1.idcomprobante = T4.idcomprobante
