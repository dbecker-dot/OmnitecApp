

USE [datasam]
GO

/****** Object:  View [dbo].[vista_perfilenacceso]    Script Date: 30/12/2022 19:59:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  vista sucursales    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_sucursales]
AS
SELECT        T2.cuit, T2.razonsocial, T1.nombresucursal, T1.direccion, T3.localidad, T3.provincia, T3.pais, T1.observaciones, T1.hab, T1.idempresa, T1.idlocalidad, T3.idprovincia, T3.idpais, T1.idsucursal
FROM            dbo.sucursal AS T1 INNER JOIN
                         dbo.vista_empresas AS T2 ON T1.idempresa = T2.idempresa LEFT OUTER JOIN
                         dbo.vista_locale AS T3 ON T1.idlocalidad = T3.idlocalidad
GO


/****** Object:  Vista clientensucursal    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_clientensucursal]
AS
SELECT        T2.cuit, T2.razonsocial, T3.razonsocial AS empresa, T3.nombresucursal AS sucursal, T1.hab, T1.idcliente, T1.idsucursal, T1.idclientensucursal
FROM            dbo.clientensucursal AS T1 INNER JOIN
                         dbo.cliente AS T2 ON T1.idcliente = T2.idcliente INNER JOIN
                         dbo.vista_sucursales AS T3 ON T1.idsucursal = T3.idsucursal
GO

/****** Object:  Vista balanzas    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_balanzas]
AS
SELECT        T2.tipobalanza, T1.nombre, T1.puerto, T1.baudios, T1.dbits, T1.observaciones, T1.hab, (CASE WHEN T3.verificacion IS NOT NULL THEN T3.verificacion ELSE '' END) AS verificacion, (CASE WHEN T3.lot IS NOT NULL 
                         THEN T3.lot ELSE '' END) AS lot, (CASE WHEN T3.codaduana IS NOT NULL THEN T3.codaduana ELSE '' END) AS codaduana, (CASE WHEN T3.ns IS NOT NULL THEN T3.ns ELSE '' END) AS ns, 
                         (CASE WHEN T3.certificado IS NOT NULL THEN T3.certificado ELSE '' END) AS certificado, (CASE WHEN T3.fechavtocertificado IS NOT NULL THEN T3.fechavtocertificado ELSE '1900-01-01' END) AS fechavtocertificado, 
                         T1.idbalanza, T1.idtipobalanza, (CASE WHEN T3.idatbalanzas IS NOT NULL THEN T3.idatbalanzas ELSE 0 END) AS idatbalanzas, (CASE WHEN T4.modobalanza IS NOT NULL THEN T4.modobalanza ELSE '' END) 
                         AS modobalanza
FROM            dbo.balanzas AS T1 INNER JOIN
                         dbo.tipobalanza AS T2 ON T1.idtipobalanza = T2.idtipobalanza LEFT OUTER JOIN
                         dbo.datbalanzas AS T3 ON T1.idbalanza = T3.idbalanza AND T3.hab = 'SI' LEFT OUTER JOIN
                         dbo.vista_modobalanza AS T4 ON T1.idbalanza = T4.idbalanza
GO



/****** Object:  vista turnos    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_turnos]
AS
SELECT        T1.nroturno, T1.movint, T2.razonsocial, T2.nombresucursal, T1.fecha, T1.fechaplanif, T1.ingreso, T3.usuario AS ingresoturno, T4.razonsocial AS cliente, T5.cuit AS cuitransp, T5.nombre AS transportista, T6.nrodoc, 
                         T6.nombre AS chofer, T1.chasis, T1.acoplado, T1.observaciones, T1.estado, T1.egreso, T7.usuario AS egresoturno, T1.hab, T1.idturno, T1.idsucursal, T1.idcliente, T1.idtransportista, T1.idchofer, T6.nacionalidad
FROM            dbo.turno AS T1 INNER JOIN
                         dbo.vista_sucursales AS T2 ON T1.idsucursal = T2.idsucursal INNER JOIN
                         dbo.usuarios AS T3 ON T1.idusuarioing = T3.idusuario INNER JOIN
                         dbo.cliente AS T4 ON T1.idcliente = T4.idcliente INNER JOIN
                         dbo.proveedor AS T5 ON T1.idtransportista = T5.idproveedor INNER JOIN
                         dbo.vista_persona AS T6 ON T1.idchofer = T6.idpersona LEFT OUTER JOIN
                         dbo.usuarios AS T7 ON T1.idusuarioeg = T7.idusuario
GO


/****** Object:  vista acoplado    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_acoplado]
AS
SELECT        nrodoc, chofer, acoplado
FROM            dbo.vista_turnos
WHERE        (estado <> 'AN')
GROUP BY nrodoc, chofer, acoplado
GO

/****** Object:  vista chasis    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_chasis]
AS
SELECT        nrodoc, chofer, chasis
FROM            dbo.vista_turnos
WHERE        (estado <> 'AN')
GROUP BY nrodoc, chofer, chasis
GO


/****** Object:  vista movimientostock    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_movimientostock]
AS
SELECT        T2.fecha, T2.cliente, T2.tipocomprobante, T2.nrocomp, T2.contenedor, T2.servicio, T2.movimientostock, T2.producto, T2.umed, T3.deposito, T3.codigo, T3.tipo, T1.lote, T1.partida, T1.cant, T1.hab, T1.idmovimientostock, 
                         T1.idcomprobante, T1.ideposito, T2.idtipocomprobante, T2.idordendeservicio, T2.idcliente, T2.idturno, T2.idservicio, T2.idproducto
FROM            dbo.movimientostock AS T1 INNER JOIN
                         dbo.vista_comprobante AS T2 ON T1.idcomprobante = T2.idcomprobante LEFT OUTER JOIN
                         dbo.deposito AS T3 ON T1.ideposito = T3.ideposito
WHERE        (T2.hab = 'SI')
GO

/****** Object:  vista detallemovimientostock    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_detallemovimientostock]
AS
SELECT        fecha, cliente, tipocomprobante, nrocomp, contenedor, servicio, movimientostock, producto, umed, deposito, codigo, tipo, lote, partida, cant, hab, idmovimientostock, idcomprobante, ideposito, idtipocomprobante, 
                         idordendeservicio, idcliente, idturno, idservicio, idproducto
FROM            dbo.vista_movimientostock
GO

/****** Object:  vista ticketbalanza    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_ticketbalanza]
AS
SELECT        T2.nrocomp AS nroticket, T2.fecha, T1.tipopesada, T1.tipoticketbal, T3.tipobalanza, T3.nombre, T3.verificacion, T3.lot, T3.codaduana, T3.ns, T3.certificado, T3.fechavtocertificado, T2.idturno, T4.nroturno, T4.movint, T4.cuitransp, 
                         T4.transportista, T4.nrodoc, T4.chofer, T4.chasis, T4.acoplado, T2.idordendeservicio, T2.cuit, T2.cliente, T2.nrorefcliente, T2.docdga, T2.servicio, T2.movimientostock, T2.producto, T5.lote, T5.partida, T5.deposito, T5.cant, 
                         T2.umed, T5.ideposito, T5.idmovimientostock, T2.contenedor, T1.taracontenedor, T1.origendestino, T1.precintos, T1.idata, (CASE WHEN T1.idata <> 0 THEN T6.cuit ELSE '-' END) AS cuitata, 
                         (CASE WHEN T1.idata <> 0 THEN T6.nombre ELSE '-' END) AS ata, T2.observaciones, T7.usuario AS uspesoentrada, T1.pesoentrada, T1.modopesadaentrada, T1.fechahorapesadaentrada, T8.usuario AS uspesosalida, 
                         T1.pesosalida, T1.modopesadasalida, T1.fechahorapesadasalida, T1.estadoticket, (CASE WHEN T1.pesoentrada >= T1.pesosalida THEN T1.pesoentrada - T1.pesosalida ELSE T1.pesosalida - T1.pesoentrada END) AS neto, 
                         T1.merma, T1.idticketbalanza, T3.idbalanza, T2.idsucursal, T2.idcliente, T1.idusuariopesadaentrada, T1.idusuariopesadasalida, T2.idcomprobante
FROM            dbo.ticketbalanza AS T1 LEFT OUTER JOIN
                         dbo.vista_comprobante AS T2 ON T1.idcomprobante = T2.idcomprobante AND T2.idtipocomprobante = 1 LEFT OUTER JOIN
                         dbo.vista_balanzas AS T3 ON T1.idatbalanzas = T3.idatbalanzas LEFT OUTER JOIN
                         dbo.vista_turnos AS T4 ON T2.idturno = T4.idturno AND T1.idcomprobante = T2.idcomprobante LEFT OUTER JOIN
                         dbo.vista_detallemovimientostock AS T5 ON T2.idcomprobante = T5.idcomprobante AND T1.idcomprobante = T2.idcomprobante LEFT OUTER JOIN
                         dbo.proveedor AS T6 ON T1.idata = T6.idproveedor LEFT OUTER JOIN
                         dbo.usuarios AS T7 ON T1.idusuariopesadaentrada = T7.idusuario LEFT OUTER JOIN
                         dbo.usuarios AS T8 ON T1.idusuariopesadasalida = T8.idusuario
GO

/****** Object:  vista cantidadpesadasxturno    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_cantidadpesadasxturno]
AS
SELECT        idturno, COUNT(idticketbalanza) AS cantpesada
FROM            dbo.vista_ticketbalanza
GROUP BY idturno
GO


/****** Object:  vista datosticketbalanza    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_datosticketbalanza]
AS
SELECT        T1.nroticket, T1.fecha, T1.tipopesada, T1.tipoticketbal, T1.tipobalanza, T1.nombre, T1.verificacion, T1.lot, T1.codaduana, T1.ns, T1.certificado, T1.fechavtocertificado, T1.nroturno, T1.movint, T1.cuitransp, T1.transportista, 
                         T1.nrodoc, T1.chofer, T1.chasis, T1.acoplado, T1.idordendeservicio AS nrorden, T1.cuit AS cuitcliente, T1.cliente, T1.nrorefcliente, T1.docdga, T1.servicio, T1.movimientostock, T1.contenedor, T1.taracontenedor, T1.origendestino, 
                         T1.precintos, T1.idata, (CASE WHEN T1.idata = 0 THEN T1.cuit ELSE '-' END) AS cuitata, (CASE WHEN T1.nombre IS NOT NULL THEN T1.nombre ELSE '-' END) AS ata, T1.observaciones, T1.producto, 
                         (CASE WHEN T1.ideposito <> 0 THEN T1.deposito ELSE '-' END) AS deposito, T1.lote, T1.partida, T1.cant, T1.umed, T1.uspesoentrada, T1.pesoentrada, T1.modopesadaentrada, T1.fechahorapesadaentrada, T1.uspesosalida, 
                         T1.pesosalida, T1.modopesadasalida, T1.fechahorapesadasalida, (CASE WHEN T1.pesoentrada <= T1.pesosalida THEN T1.pesosalida - T1.pesoentrada ELSE T1.pesosalida - T1.pesoentrada END) AS neto, T1.estadoticket, 
                         T1.merma, T1.idticketbalanza, T3.nacionalidad, T3.nombresucursal, T3.idsucursal, T1.idturno
FROM            dbo.vista_ticketbalanza AS T1 LEFT OUTER JOIN
                         dbo.vista_turnos AS T3 ON T1.idturno = T3.idturno
GO

/****** Object:  Vista numeradorticketxbalanza   Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_numeradorticketxbalanza]
AS
SELECT        idbalanza, MAX(nroticket) AS ultimoticket
FROM            dbo.vista_ticketbalanza
GROUP BY idbalanza
GO


/****** Object:  vista entradaproductos    Script Date: 19/02/2023  ******/


CREATE VIEW [dbo].[vista_entradaproductos]
AS
SELECT        cliente, producto, umed, deposito, lote, partida, SUM(cant) AS cant, idproducto
FROM            dbo.vista_movimientostock AS T1
WHERE        (hab = 'SI') AND (movimientostock = 'E')
GROUP BY cliente, producto, umed, deposito, lote, partida, idproducto
GO

/****** Object:  vista salidaproductos    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_salidaproductos]
AS
SELECT        cliente, producto, umed, deposito, lote, partida, SUM(cant) AS cant, idproducto
FROM            dbo.vista_movimientostock AS T1
WHERE        (hab = 'SI') AND (movimientostock = 'S')
GROUP BY cliente, producto, umed, deposito, lote, partida, idproducto
GO

/****** Object:  vista ticketbalanzaAB    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_ticketbalanzaAB]
AS
SELECT        nroticket, tipopesada, tipoticketbal, nroturno, cliente, movint, transportista, chofer, chasis, idticketbalanza, idbalanza, idcliente, idturno
FROM            dbo.vista_ticketbalanza
WHERE        (estadoticket <> 'CE') AND (estadoticket <> 'AN')
GO

/****** Object:  vista ultimataraxturno    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_ultimataraxturno]
AS
SELECT        T1.idturno, (CASE WHEN T1.pesoentrada < T1.pesosalida THEN T1.pesoentrada - t1.taracontenedor ELSE T1.pesosalida - t1.taracontenedor END) AS tara
FROM            dbo.vista_ticketbalanza AS T1 INNER JOIN
                         dbo.vista_ultimoticketcerradoxturno AS T2 ON T1.idticketbalanza = T2.ultimoticket
WHERE        (T1.tipoticketbal <> 'CB') AND (T1.estadoticket = 'CE') AND (T1.pesoentrada > 0) AND (T1.pesosalida > 0)
GO

/****** Object:  vista stockproducto    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_stockproducto]
AS
SELECT        T1.cliente, T1.producto, T1.umed, T1.deposito, T1.codigo, T1.lote, T1.partida, (CASE WHEN T2.cant IS NULL THEN 0 ELSE T2.cant END) AS entradas, (CASE WHEN T3.cant IS NULL THEN 0 ELSE T3.cant END) AS salidas, 
                         (CASE WHEN T2.cant IS NULL THEN 0 ELSE T2.cant END) - (CASE WHEN T3.cant IS NULL THEN 0 ELSE T3.cant END) AS stock, T1.idproducto, T1.idcliente, T1.ideposito
FROM            dbo.vista_movimientostock AS T1 LEFT OUTER JOIN
                         dbo.vista_entradaproductos AS T2 ON T1.idproducto = T2.idproducto AND T1.deposito = T2.deposito AND T1.lote = T2.lote AND T1.partida = T2.partida LEFT OUTER JOIN
                         dbo.vista_salidaproductos AS T3 ON T1.idproducto = T3.idproducto AND T1.deposito = T3.deposito AND T1.lote = T3.lote AND T1.partida = T3.partida
WHERE        (T1.hab = 'SI')
GROUP BY T1.cliente, T1.producto, T1.umed, T1.deposito, T1.lote, T1.partida, T2.cant, T3.cant, T1.codigo, T1.idproducto, T1.idcliente, T1.ideposito
GO

/****** Object:  vista loteenstock    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_loteenstock]
AS
SELECT        idproducto, lote
FROM            dbo.vista_stockproducto
WHERE        (stock > 0) AND (lote <> '')
GROUP BY idproducto, lote
GO

/****** Object:  vista partidaenstock    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_partidaenstock]
AS
SELECT        idproducto, partida
FROM            dbo.vista_stockproducto
WHERE        (stock > 0) AND (partida <> '')
GROUP BY idproducto, partida
GO

/****** Object:  vista acoplado    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_acoplado]
AS
SELECT        nrodoc, chofer, acoplado
FROM            dbo.vista_turnos
WHERE        (estado <> 'AN')
GROUP BY nrodoc, chofer, acoplado
GO

/****** Object:  vista chasis    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_chasis]
AS
SELECT        nrodoc, chofer, chasis
FROM            dbo.vista_turnos
WHERE        (estado <> 'AN')
GROUP BY nrodoc, chofer, chasis
GO

/****** Object:  vista cantcompxturno    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_cantcompxturno]
AS
SELECT        idturno, COUNT(idcomprobante) AS cantcomp
FROM            dbo.comprobante
WHERE        (hab = 'SI')
GROUP BY idturno
GO

/****** Object:  vista dashboardTurnosxCliente    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_dashboardTurnosxCliente]
AS
SELECT        fecha, cliente, COUNT(idturno) AS cant
FROM            dbo.vista_turnos
WHERE        (estado <> 'AN')
GROUP BY fecha, cliente
GO

/****** Object:  vista dashboardTurnosxTransportista    Script Date: 19/02/2023  ******/

CREATE VIEW [dbo].[vista_dashboardTurnosxTransportista]
AS
SELECT        fecha, transportista, COUNT(idturno) AS cant
FROM            dbo.vista_turnos
WHERE        (estado <> 'AN')
GROUP BY fecha, transportista
GO

/****** Object:  vista planoperaciones    Script Date: 21/02/2023  ******/

CREATE VIEW [dbo].[vista_planoperaciones]
AS
SELECT        T1.fecha, T2.cliente, T2.nrorefcliente, T2.docdga, T2.servicio, T2.producto, T1.cantbultos, T2.umed, T1.cantkg, T1.cantcam, T1.cantcnt, T1.observaciones, T1.estado, T1.idordendeservicio, T1.idplanoperaciones
FROM            dbo.planoperaciones AS T1 INNER JOIN
                         dbo.vista_ordendeservicio AS T2 ON T1.idordendeservicio = T2.idordendeservicio
WHERE        (T1.estado <> 'AN')
GO

/****** Object:  vista planoperaciones    Script Date: 21/02/2023  ******/

CREATE VIEW [dbo].[vista_itemscontrolacceso]
AS
SELECT        itemcontrol, xvto, apempleado, apchofer, approveedor, apvisita, apvehiculo, hab, iditemscontrolacceso
FROM            dbo.itemscontrolacceso AS T1
GO

SELECT COUNT(*) as vistas from Information_Schema.Tables where TABLE_TYPE = 'VIEW'












