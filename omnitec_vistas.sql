-- creacion de vistas

USE [omnitec]
GO

/****** Object:  View [dbo].[vista_analisis]    Script Date: 08/12/2020 19:30  ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vista_cabanalisisorden]
AS
SELECT        T1.fecha, T1.nromuestra, T3.lote,  T2.estadomuestra, T1.obsrecha, T1.idestadomuestra, T1.idorden, T1.idcabanalisisorden, 
                         T3.idtipo,T3.idcliente
FROM            dbo.cabanalisisorden AS T1 INNER JOIN
                         dbo.estadomuestra AS T2 ON T1.idestadomuestra = T2.idestadomuestra INNER JOIN
                         dbo.vista_ordenes AS T3 ON T1.idorden = T3.idorden
GO


CREATE VIEW [dbo].[vista_analisis]
AS
SELECT        T1.fecha, T1.nromuestra, T1.lote,  T1.estadomuestra, T1.obsrecha, T2.valor AS brot, T3.valor AS hela, T4.valor AS insec, T5.valor AS mohoint, 
                         T6.valor AS ard, T7.valor AS pod, T8.valor AS mohoext, T9.valor AS man, T10.valor AS suc, T11.valor AS chu, T12.valor AS cext, T13.valor AS hum, T14.valor AS par, 
                         T15.valor AS queb, T16.valor AS ent, T1.idorden, T1.idcabanalisisorden, T1.idtipo, T1.idcliente
FROM            dbo.vista_cabanalisisorden AS T1 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T2 ON T1.idcabanalisisorden = T2.idcabanalisisorden AND T2.iditemanalisis = 1 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T3 ON T1.idcabanalisisorden = T3.idcabanalisisorden AND T3.iditemanalisis = 2 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T4 ON T1.idcabanalisisorden = T4.idcabanalisisorden AND T4.iditemanalisis = 3 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T5 ON T1.idcabanalisisorden = T5.idcabanalisisorden AND T5.iditemanalisis = 4 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T6 ON T1.idcabanalisisorden = T6.idcabanalisisorden AND T6.iditemanalisis = 5 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T7 ON T1.idcabanalisisorden = T7.idcabanalisisorden AND T7.iditemanalisis = 6 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T8 ON T1.idcabanalisisorden = T8.idcabanalisisorden AND T8.iditemanalisis = 7 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T9 ON T1.idcabanalisisorden = T9.idcabanalisisorden AND T9.iditemanalisis = 8 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T10 ON T1.idcabanalisisorden = T10.idcabanalisisorden AND T10.iditemanalisis = 9 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T11 ON T1.idcabanalisisorden = T11.idcabanalisisorden AND T11.iditemanalisis = 10 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T12 ON T1.idcabanalisisorden = T12.idcabanalisisorden AND T12.iditemanalisis = 11 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T13 ON T1.idcabanalisisorden = T13.idcabanalisisorden AND T13.iditemanalisis = 12 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T14 ON T1.idcabanalisisorden = T14.idcabanalisisorden AND T14.iditemanalisis = 13 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T15 ON T1.idcabanalisisorden = T15.idcabanalisisorden AND T15.iditemanalisis = 14 LEFT OUTER JOIN
                         dbo.detanalisisorden AS T16 ON T1.idcabanalisisorden = T16.idcabanalisisorden AND T16.iditemanalisis = 15
GO


CREATE VIEW [dbo].[vista_estadoproductos]
AS
SELECT        ep.estadoprod, COUNT(d.idetalleproducto) AS cant, SUM(d.kg) AS kg, d.idorden, ep.idestadoprod
FROM            dbo.estadoprod AS ep LEFT OUTER JOIN
                         dbo.detalleproducto AS d ON ep.idestadoprod = d.idestadoprod
GROUP BY ep.estadoprod, d.idorden, ep.idestadoprod
GO

CREATE VIEW [dbo].[vista_cantproductosorden]
AS
SELECT        idorden, COUNT(idetalleproducto) AS cant, SUM(kg) AS kg, idordenasoc
FROM            dbo.vista_detalleproducto
GROUP BY idorden, idordenasoc
GO


CREATE VIEW [dbo].[vista_ordenes]
AS
SELECT        T1.idorden, T8.tipo,T18.cosecha, T1.nrorden, T1.lote, T1.fecha, T2.cuit, T2.cliente, (CASE WHEN T7.comprobante IS NULL THEN '' ELSE T7.comprobante END) AS comprobante, T19.cant, 
                         (CASE WHEN T9.cant IS NULL THEN 0 ELSE T9.cant END) AS cpend, (CASE WHEN T10.cant IS NULL THEN 0 ELSE T10.cant END) AS ces, 
                         (CASE WHEN T11.cant IS NULL THEN 0 ELSE T11.cant END) AS cdev, (CASE WHEN T12.cant IS NULL THEN 0 ELSE T12.cant END) AS cproc, 
                         (CASE WHEN T13.cant IS NULL THEN 0 ELSE T13.cant END) AS can, (CASE WHEN T14.cant IS NULL THEN 0 ELSE T14.cant END) AS cres, 
                         (CASE WHEN T15.cant IS NULL THEN 0 ELSE T15.cant END) AS cdan, (CASE WHEN T16.cant IS NULL THEN 0 ELSE T16.cant END) AS cdes, 
                         (CASE WHEN T7.dnichofer IS NULL THEN '' ELSE T7.dnichofer END) AS dnichofer, (CASE WHEN T7.chofer IS NULL THEN '' ELSE T7.chofer END) AS chofer, 
                         (CASE WHEN T7.chasis IS NULL THEN '' ELSE T7.chasis END) AS chasis, (CASE WHEN T7.acoplado IS NULL THEN '' ELSE T7.acoplado END) AS acoplado, 
                         T1.observaciones, T1.idcliente, T3.statusorden, (CASE WHEN T1.idusuariocierre = 0 THEN DATEDIFF(day, T1.fecha, GETDATE()) ELSE DATEDIFF(day, T1.fecha, 
                         T1.fechacierre) END) AS diasab, T4.nombre AS registro, T1.fechahorareg, T17.usuario AS cerro, T1.fechacierre, T1.fechahoracierre, T2.codcliente, T1.idstatusorden, 
                         T5.nombre AS modifico, T6.nombre AS anulo, T1.fechahoramodif, T1.fechahoranul, T1.nroref, T1.idtipo,T1.idcosecha, T8.codtipo, T1.idusuariocierre, T1.idusuarioanul
FROM            dbo.ordenes AS T1 INNER JOIN
                         dbo.clientes AS T2 ON T1.idcliente = T2.idcliente INNER JOIN
                         dbo.tiporden AS T8 ON T1.idtipo = T8.idtipo INNER JOIN
                         dbo.statusorden AS T3 ON T1.idstatusorden = T3.idstatusorden LEFT OUTER JOIN
                         dbo.datostransporteorden AS T7 ON T1.idorden = T7.idorden INNER JOIN
                         dbo.usuarios AS T4 ON T1.idusuarioreg = T4.idusuario LEFT OUTER JOIN
                         dbo.usuarios AS T5 ON T1.idusuariomodif = T5.idusuario LEFT OUTER JOIN
                         dbo.usuarios AS T6 ON T1.idusuarioanul = T6.idusuario LEFT OUTER JOIN
                         dbo.vista_estadoproductos AS T9 ON T1.idorden = T9.idorden AND T9.idestadoprod = 1 LEFT OUTER JOIN
                         dbo.vista_estadoproductos AS T10 ON T1.idorden = T10.idorden AND T10.idestadoprod = 2 LEFT OUTER JOIN
                         dbo.vista_estadoproductos AS T11 ON T1.idorden = T11.idorden AND T11.idestadoprod = 3 LEFT OUTER JOIN
                         dbo.vista_estadoproductos AS T12 ON T1.idorden = T12.idorden AND T12.idestadoprod = 4 LEFT OUTER JOIN
                         dbo.vista_estadoproductos AS T13 ON T1.idorden = T13.idorden AND T13.idestadoprod = 5 LEFT OUTER JOIN
                         dbo.vista_estadoproductos AS T14 ON T1.idorden = T14.idorden AND T14.idestadoprod = 6 LEFT OUTER JOIN
                         dbo.vista_estadoproductos AS T15 ON T1.idorden = T15.idorden AND T15.idestadoprod = 7 LEFT OUTER JOIN
                         dbo.vista_estadoproductos AS T16 ON T1.idorden = T16.idorden AND T16.idestadoprod = 8 LEFT OUTER JOIN
                         dbo.usuarios AS T17 ON T1.idusuariocierre = T17.idusuario LEFT OUTER JOIN
                         dbo.cosecha AS T18 ON T1.idcosecha = T18.idcosecha LEFT OUTER JOIN
                         dbo.vista_cantproductosorden AS T19 ON T1.idorden = T19.idorden or T1.idorden = T19.idordenasoc
GO



CREATE VIEW [dbo].[vista_asocorden]
AS
SELECT        T2.fecha, T2.tipo, T2.lote, T2.cliente, T1.cant, T1.idorden, T1.idordenasoc, T1.idasocorden, T2.idtipo
FROM            dbo.asocorden AS T1 INNER JOIN
                         dbo.vista_ordenes AS T2 ON T1.idordenasoc = T2.idorden
WHERE        (T1.idusuarioanul = 0)
GO

CREATE VIEW [dbo].[vista_reservaubicacionesclientes]
AS
SELECT        c.cliente, r.idubicacion, r.idcliente, r.idresubiccli
FROM            dbo.reservaubicacionesclientes AS r INNER JOIN
                         dbo.clientes AS c ON r.idcliente = c.idcliente
WHERE        (r.hab = 'SI')
GO


CREATE VIEW [dbo].[vista_ubicaciones]
AS
SELECT        T1.deposito, T1.codeposito, T2.bloque, T2.rackpasillo, T2.pos, T2.alt, T2.capacidad, T2.codubicacion, T1.hab AS estdep, T2.hab AS estubic, T2.ideposito, 
                         T2.idubicacion, T3.cliente, T3.idcliente, T3.idresubiccli
FROM            dbo.depositos AS T1 INNER JOIN
                         dbo.ubicaciones AS T2 ON T1.ideposito = T2.ideposito LEFT OUTER JOIN
                         dbo.vista_reservaubicacionesclientes AS T3 ON T2.idubicacion = T3.idubicacion
GO

CREATE VIEW [dbo].[vista_cantubicdepo]
AS
SELECT        deposito, codeposito, bloque, COUNT(idubicacion) AS cant, capacidad * COUNT(idubicacion) AS captotal, ideposito
FROM            dbo.vista_ubicaciones
GROUP BY deposito, codeposito, bloque, ideposito, capacidad
GO

CREATE VIEW [dbo].[vista_depositos]
AS
SELECT        TOP (100) PERCENT T1.deposito, T1.codeposito, SUM(T2.cant) AS posiciones, SUM(T2.captotal) AS capacidad, T1.hab, T1.ideposito
FROM            dbo.depositos AS T1 LEFT OUTER JOIN
                         dbo.vista_cantubicdepo AS T2 ON T1.ideposito = T2.ideposito
GROUP BY T1.deposito, T1.codeposito, T1.hab, T1.ideposito
ORDER BY capacidad DESC
GO

CREATE VIEW [dbo].[vista_detanalisisorden]
AS
SELECT        it.itemanalisis, da.valor, da.est, da.iditemanalisis, it.idgrupoanalisis, da.idetanalisisorden, da.idcabanalisisorden
FROM            dbo.detanalisisorden AS da INNER JOIN
                         dbo.itemanalisis AS it ON da.iditemanalisis = it.iditemanalisis
GO

CREATE VIEW [dbo].[vista_detalleproducto]
AS
SELECT        T1.fechaingstk, T4.grano, T5.tipoproducto,T1.nrobulto, T1.codigo, T1.kg, T3.codubicacion AS ubicacion, T3.deposito, T3.bloque, T3.rackpasillo, T3.pos, T2.estadoprod, 
                         T1.fechaegrestk, (CASE WHEN T1.fechaegrestk = '01/01/1900' THEN DATEDIFF(day, T1.fechaingstk, GETDATE()) ELSE DATEDIFF(day, T1.fechaingstk, 
                         T1.fechaegrestk) END) AS diastk, T1.idetalleproducto, T1.idestadoprod, T3.ideposito, T1.idubicacion, T1.idorden, T1.idgrano,T1.idtipoproducto, T1.idordenasoc, T6.tipo, T6.nrorden, T6.lote, 
                         T7.tipo AS tipordendest, T7.nrorden AS nrordendest, T7.lote AS loteordendest, T6.cliente, T6.idtipo, T6.statusorden, T6.idcliente
FROM            dbo.detalleproducto AS T1 INNER JOIN
                         dbo.estadoprod AS T2 ON T1.idestadoprod = T2.idestadoprod LEFT OUTER JOIN
                         dbo.vista_ubicaciones AS T3 ON T1.idubicacion = T3.idubicacion INNER JOIN
                         dbo.grano AS T4 ON T1.idgrano = T4.idgrano INNER JOIN
                         dbo.tipoproducto AS T5 ON T1.idtipoproducto = T5.idtipoproducto LEFT OUTER JOIN
                         dbo.vista_ordenes AS T6 ON T1.idorden = T6.idorden LEFT OUTER JOIN
                         dbo.vista_ordenes AS T7 ON T1.idordenasoc = T6.idorden
GO

CREATE VIEW [dbo].[vista_clientesordenesactivas]
AS
SELECT        idcliente, cliente
FROM            dbo.vista_ordenes
WHERE        (idusuariocierre = 0) AND (idusuarioanul = 0)
GROUP BY idcliente, cliente
GO


CREATE VIEW [dbo].[vista_ubicacionesproductos]
AS
SELECT        ubicacion, estadoprod, COUNT(idetalleproducto) AS cant, idorden, idestadoprod, ideposito, idubicacion
FROM            dbo.vista_detalleproducto
GROUP BY ubicacion, estadoprod, idorden, idestadoprod, ideposito, idubicacion
GO


CREATE VIEW [dbo].[vista_statusubicaciones]
AS
SELECT        TOP (100) PERCENT T1.codubicacion AS ubicacion, T1.capacidad, (CASE WHEN SUM(T2.cant) > 0 THEN SUM(T2.cant) ELSE 0 END) AS cant, 
                         (CASE WHEN SUM(T2.cant) > 0 THEN T1.capacidad - SUM(T2.cant) ELSE t1.capacidad END) AS disponible, T1.ideposito, T1.idubicacion, T1.bloque, T1.rackpasillo, 
                         T1.pos, T1.alt, T1.cliente, T1.estubic, T1.deposito
FROM            dbo.vista_ubicaciones AS T1 LEFT OUTER JOIN
                         dbo.vista_ubicacionesproductos AS T2 ON T1.idubicacion = T2.idubicacion
WHERE        (T1.estdep = 'SI')
GROUP BY T1.codubicacion, T1.capacidad, T1.ideposito, T1.idubicacion, T1.bloque, T1.rackpasillo, T1.pos, T1.alt, T1.cliente, T1.estubic, T1.deposito
GO


CREATE VIEW [dbo].[vista_disponibletotaldep]
AS
SELECT        SUM(capacidad) AS capacidad, SUM(cant) AS utilizado, SUM(disponible) AS disponible
FROM            dbo.vista_statusubicaciones
GO

CREATE VIEW [dbo].[vista_disponibletotalxdep]
AS
SELECT        ideposito, SUM(capacidad) AS capacidad, SUM(cant) AS utilizado, SUM(disponible) AS disponible
FROM            dbo.vista_statusubicaciones
GROUP BY ideposito
GO

CREATE VIEW [dbo].[vista_disponibletotalxdepbloque]
AS
SELECT        ideposito, bloque, SUM(capacidad) AS capacidad, SUM(cant) AS utilizado, SUM(disponible) AS disponible
FROM            dbo.vista_statusubicaciones
GROUP BY ideposito, bloque
GO

CREATE VIEW [dbo].[vista_disponibletotalxdepbloquerackpasillo]
AS
SELECT        ideposito, bloque,rackpasillo, SUM(capacidad) AS capacidad, SUM(cant) AS utilizado, SUM(disponible) AS disponible
FROM            dbo.vista_statusubicaciones
GROUP BY ideposito, bloque,rackpasillo
GO

CREATE VIEW [dbo].[vista_numeradororden]
AS
SELECT        idtipo,cosecha, MAX(nroref) AS nroref, codtipo
FROM            dbo.vista_ordenes
GROUP BY idtipo,cosecha, codtipo
GO

CREATE VIEW [dbo].[vista_statusbloques]
AS
SELECT        bloque, cliente, estubic, SUM(capacidad) AS capacidad, SUM(cant) AS utilizado, SUM(disponible) AS disponible, ideposito
FROM            dbo.vista_statusubicaciones
GROUP BY bloque, cliente, ideposito, estubic
GO

CREATE VIEW [dbo].[vista_statusrackpasillos]
AS
SELECT        bloque, rackpasillo, cliente, estubic, SUM(capacidad) AS capacidad, SUM(cant) AS utilizado, SUM(disponible) AS disponible, ideposito
FROM            dbo.vista_statusubicaciones
GROUP BY bloque, rackpasillo, cliente, ideposito, estubic
GO

CREATE VIEW [dbo].[vista_stkgrano]
AS
SELECT        grano, estadoprod, COUNT(idetalleproducto) AS Cant, SUM(kg) AS Kg
FROM            dbo.vista_detalleproducto
WHERE        (idestadoprod = 2) OR
                         (idestadoprod = 6) OR
                         (idestadoprod = 7)
GROUP BY grano, estadoprod
GO

CREATE VIEW [dbo].[vista_stktipoproducto]
AS
SELECT        tipoproducto, estadoprod, COUNT(idetalleproducto) AS Cant, SUM(kg) AS Kg
FROM            dbo.vista_detalleproducto
WHERE        (idestadoprod = 2) OR
                         (idestadoprod = 6) OR
                         (idestadoprod = 7)
GROUP BY tipoproducto, estadoprod
GO

CREATE VIEW [dbo].[vista_stkgranotipoproducto]
AS
SELECT        grano,tipoproducto, estadoprod, COUNT(idetalleproducto) AS Cant, SUM(kg) AS Kg
FROM            dbo.vista_detalleproducto
WHERE        (idestadoprod = 2) OR
                         (idestadoprod = 6) OR
                         (idestadoprod = 7)
GROUP BY grano,tipoproducto, estadoprod
GO

CREATE VIEW [dbo].[vista_ubicacioneslotes]
AS
SELECT        orden.fecha, orden.lote, u.ubicacion, SUM(u.cant) AS cant, u.idorden, orden.idtipo, orden.idcliente
FROM            dbo.vista_ubicacionesproductos AS u INNER JOIN
                         dbo.vista_ordenes AS orden ON u.idorden = orden.idorden
WHERE        (u.idestadoprod = 2) OR
                         (u.idestadoprod = 6)
GROUP BY orden.fecha, orden.lote, u.ubicacion, u.idorden, orden.idtipo, orden.idcliente, u.idestadoprod
GO

CREATE VIEW [dbo].[vista_movdepxfecha]
AS
SELECT        T2.idaccionmovil, T1.accion, CONVERT(VARCHAR(10), T2.fechahorareg, 103) AS Fecha, COUNT(T2.idmovdep) AS cant
FROM            dbo.accionmovil AS T1 LEFT OUTER JOIN
                         dbo.movdep AS T2 ON T1.idaccionmovil = T2.idaccionmovil
GROUP BY T1.accion, CONVERT(VARCHAR(10), T2.fechahorareg, 103), T2.idaccionmovil
GO

CREATE VIEW [dbo].[vista_crudodisponibleotproduccion]
AS
SELECT        T1.idot AS idotprod, T2.idotasoc, T3.codigo, T3.kg, T3.deposito, T3.bloque, T3.rackpasillo, T3.pos
FROM            dbo.vista_ordendetrabajo AS T1 LEFT OUTER JOIN
                         dbo.vista_asocot AS T2 ON T1.idot = T2.idot LEFT OUTER JOIN
                         dbo.vista_detproducto AS T3 ON T2.idotasoc = T3.idot
WHERE        (T1.idstatusot = 6) AND (T3.idproducto = 1) AND (T3.idestadoprod = 2)
GO

CREATE VIEW [dbo].[vista_productosorden]
AS
SELECT        grano,tipoproducto, codigo, estadoprod,ubicacion, idetalleproducto, idestadoprod, idorden,ideposito,idubicacion,idordenasoc
FROM            dbo.vista_detalleproducto
GO

CREATE VIEW [dbo].[vista_terminadoendepositoproduccion]
AS
SELECT        grano,tipoproducto, codigo, ubicacion,idetalleproducto,idubicacion
FROM            dbo.vista_productosorden AS T1
WHERE        (ideposito = 2) 
GO

CREATE VIEW [dbo].[vista_productosreservados]
AS
SELECT        cliente, lote, tipo, statusorden, fechaingstk, grano,tipoproducto, nrobulto, codigo, kg, ubicacion, deposito, bloque, rackpasillo, pos, estadoprod, diastk, loteordendest, tipordendest, 
                         idetalleproducto, ideposito, idubicacion, idgrano,idtipoproducto, idorden, idordenasoc
FROM            dbo.vista_detalleproducto
WHERE        (idestadoprod = 6)
GO

CREATE VIEW [dbo].[vista_totalordenesabiertasxtipo]
AS
SELECT        tipo, COUNT(idorden) AS cant, idtipo
FROM            dbo.vista_ordenes
WHERE        (idstatusorden = 1)
GROUP BY tipo, idtipo
GO

CREATE VIEW [dbo].[vista_totalordenesabiertasxtipocliente]
AS
SELECT        cliente, tipo, COUNT(idorden) AS cant, idtipo, idcliente
FROM            dbo.vista_ordenes
WHERE        (idstatusorden = 1)
GROUP BY cliente, tipo, idtipo, idcliente
GO

CREATE VIEW [dbo].[vista_totalproductosasociados]
AS
SELECT        grano, tipoproducto, COUNT(idetalleproducto) AS cant, idordenasoc
FROM            dbo.vista_detalleproducto
GROUP BY grano, tipoproducto, idordenasoc
GO

CREATE VIEW [dbo].[vista_totalesproductosasociadosordenenejecucion]
AS
SELECT        T1.idtipo, T2.estadoprod, T2.idestadoprod, COUNT(T2.idetalleproducto) AS cant, T1.idorden
FROM            dbo.vista_ordenes AS T1 LEFT OUTER JOIN
                         dbo.vista_detalleproducto AS T2 ON T1.idorden = T2.idordenasoc
WHERE        (T1.idstatusorden = 3)
GROUP BY T1.idtipo, T2.estadoprod, T2.idestadoprod, T1.idorden
GO

CREATE VIEW [dbo].[vista_totalproductosinubicacion]
AS
SELECT        COUNT(idetalleproducto) AS cant
FROM            dbo.detalleproducto
WHERE        (idubicacion = 0)
GO