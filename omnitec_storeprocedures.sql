-- CREACION DE STORE PROCEDURES

USE [omnitec]

GO
GRANT EXECUTE TO [omnitec]
GO

GO

/******   Script Date: 09/12/2020 09:30  ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



alter PROCEDURE [dbo].[proc_buscar_checkexisteorden]
@idtipo int,
@idcliente int,
@comprobante varchar(50)
AS
SELECT * FROM [omnitec].[dbo]. [vista_ordenes]
WHERE idtipo=@idtipo  and idcliente=@idcliente and comprobante=@comprobante 
GO

CREATE PROCEDURE [dbo].[proc_buscar_checkidordenxtiponroref]
@idtipo int,
@nroref int
AS
SELECT * FROM [omnitec].[dbo]. [ordenes]
WHERE idtipo=@idtipo  and nroref=@nroref
GO

alter PROCEDURE [dbo].[proc_buscar_ordenesxfechas]
@idtipo int,
@idcliente int,
@idstatusorden int,
@desde date,
@hasta date
AS
IF (@idtipo=0 and @idcliente=0 and @idstatusorden=0)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta
END
IF (@idtipo>0 and @idcliente=0 and @idstatusorden=0)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idtipo=@idtipo
END
IF (@idtipo>0 and @idcliente>0 and @idstatusorden=0)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idtipo=@idtipo and idcliente=@idcliente
END
IF (@idtipo=0 and @idcliente>0 and @idstatusorden=0)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idcliente=@idcliente
END
IF (@idtipo=0 and @idcliente=0 and @idstatusorden=1)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuariocierre=0 and idusuarioanul =0
END
IF (@idtipo>0 and @idcliente=0 and @idstatusorden=1)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuariocierre=0 and idusuarioanul =0 and @idtipo =@idtipo 
END
IF (@idtipo>0 and @idcliente>0 and @idstatusorden=1)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuariocierre=0 and idusuarioanul =0 and @idtipo =@idtipo and @idcliente  =@idcliente  
END
IF (@idtipo=0 and @idcliente>0 and @idstatusorden=1)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuariocierre=0 and idusuarioanul =0 and @idcliente  =@idcliente  
END
IF (@idtipo=0 and @idcliente=0 and @idstatusorden=2)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuariocierre>0 and idusuarioanul =0
END
IF (@idtipo>0 and @idcliente=0 and @idstatusorden=2)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuariocierre>0 and idusuarioanul =0 and idtipo=@idtipo
END
IF (@idtipo>0 and @idcliente>0 and @idstatusorden=2)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuariocierre>0 and idusuarioanul =0 and idtipo=@idtipo and idcliente=@idcliente
END
IF (@idtipo=0 and @idcliente>0 and @idstatusorden=2)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuariocierre>0 and idusuarioanul =0 and  idcliente=@idcliente
END
IF (@idtipo=0 and @idcliente=0 and @idstatusorden=3)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuarioanul >0
END
IF (@idtipo>0 and @idcliente=0 and @idstatusorden=3)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuarioanul >0 and idtipo=@idtipo
END
IF (@idtipo>0 and @idcliente>0 and @idstatusorden=3)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuarioanul >0 and idtipo=@idtipo and idcliente=@idcliente
END
IF (@idtipo=0 and @idcliente>0 and @idstatusorden=3)
BEGIN
	SELECT fecha,tipo,nrorden,lote,cuit,cliente,comprobante,cant,dnichofer,chofer,chasis,acoplado,observaciones,statusorden,diasab,registro,fechahorareg,idorden,idstatusorden FROM [omnitec].[dbo]. [vista_ordenes]
	WHERE fecha>=@desde and fecha<=@hasta and idusuarioanul >0 and idcliente=@idcliente
END
GO


create PROCEDURE [dbo].[proc_insertar_cabanalisisorden]
	(@idorden 		int, 
	@fecha 		date,
	@nromuestra	varchar(20),
	@obsrecha text,
	@idusuarioalta		int)

AS INSERT INTO [omnitec].[dbo].[cabanalisisorden] 
	 (idorden, 
	 fecha,
	nromuestra,obsrecha ,idusuarioalta) 
 
VALUES 
	( @idorden ,@fecha,
	@nromuestra  ,@obsrecha ,@idusuarioalta )

GO

create PROCEDURE [dbo].[proc_insertar_fotoanalisisorden]
	(@idcabanalisisorden 		int, 
	@rutaimg 		varchar(150),
	@archivo 		varchar(50),
	@idusuario		int)

AS INSERT INTO [omnitec].[dbo].[imganal] 
	 (idcabanalisisorden , 
	 rutaimg,
	 archivo,
	idusuario ) 
 
VALUES 
	( @idcabanalisisorden  ,@rutaimg ,@archivo
	,@idusuario)




CREATE PROCEDURE [dbo].[proc_insertar_datostransporteorden]
	(@idorden int,
	@comprobante	varchar(50),
	@dnichofer varchar(15),
	@chofer varchar(100),
	@chasis varchar(15),
	@acoplado varchar(15))

AS INSERT INTO [omnitec].[dbo].[datostransporteorden] 
	 ( idorden,
	comprobante,
	dnichofer,chofer,chasis,acoplado) 
 
VALUES 
	( @idorden,
	@comprobante  ,
@dnichofer,@chofer,@chasis,@acoplado )

GO

CREATE PROCEDURE [dbo].[proc_insertar_ordenes]
	( @fecha 		date,
	@idcosecha int,
	@idtipoproducto int,
	@idgrano int,
	@idtipo int,
	@nroref int,
	@nrorden varchar(6),
	@lote varchar(50),
	@idcliente int,
	@observaciones text,
	@idusuarioreg		int)

AS INSERT INTO [omnitec].[dbo].[ordenes] 
	 ( fecha,
	 idcosecha,
	 idtipoproducto,
	 idgrano,
	 idtipo,
	 nroref,
	 nrorden,
	 lote,
	idcliente,
	observaciones,idusuarioreg) 
 
VALUES 
	( @fecha,
	@idcosecha,
	@idtipoproducto,
	@idgrano,
	@idtipo,
	@nroref,
	@nrorden,
	@lote,
	@idcliente ,
	@observaciones,@idusuarioreg )
GO

CREATE PROCEDURE [dbo].[proc_insertar_productoenorden]
	( @idorden int,
	@fechaingstk 		date,
	@idgrano int,
	@idtipoproducto int,
	@nrobulto int,
	@codigo varchar(50),
	@kg real,
	@idusuarioreg		int)
	AS
	 INSERT INTO [omnitec].[dbo].[detalleproducto] 
	 ( idorden,
	 fechaingstk,
	 idgrano,
	 idtipoproducto,
	 nrobulto,
	 codigo,
	kg,
	idusuarioreg) 
 
VALUES 
	( @idorden,
	@fechaingstk,
	@idgrano,
	@idtipoproducto,
	@nrobulto,
	@codigo,
	@kg ,
	@idusuarioreg )
GO

create PROCEDURE [dbo].[proc_insertar_usuario]
	(@nombre varchar(50),
	@usuario	varchar(50),
	@password varchar(50),
	@passwordmovil varchar(50),
	@email varchar(50),
	@perfil varchar(5),
	@diasexpiraclave int,
	@feactclave date,
	@accesomovil varchar(2))

AS INSERT INTO [omnitec].[dbo].[usuarios] 
	 ( nombre,
	usuario,
	password ,passwordmovil ,email,perfil ,diasexpiraclave ,feactclave ,accesomovil ) 
 
VALUES 
	( @nombre ,
	@usuario   ,
@password ,@passwordmovil ,@email ,@perfil ,@diasexpiraclave ,@feactclave ,@accesomovil  )

GO

create PROCEDURE [dbo].[proc_modificar_actualizaclave]
	(@idusuario int,
	@fecha 		date,
	@password	varchar(50))

AS UPDATE [omnitec].[dbo].[usuarios] 
	 SET 
	 feactclave=@fecha,
	password=@password
where 
	idusuario=@idusuario
GO

create PROCEDURE [dbo].[proc_modificar_cabanalisisorden]
	(@idcabanalisisorden		int, 
	@fecha 		date,
	@idestadomuestra	int,
	@obsrecha text)

AS UPDATE [omnitec].[dbo].[cabanalisisorden] 
	 SET 
	 fecha=@fecha,
	idestadomuestra=@idestadomuestra ,obsrecha =@obsrecha
where 
	idcabanalisisorden=@idcabanalisisorden
GO

create PROCEDURE [dbo].[proc_modificar_cerrarorden]
	( @idorden int,
	@fechacierre 		date,
	@idusuariocierre	int)

AS UPDATE [omnitec].[dbo].[ordenes] 
	 SET fechacierre=@fechacierre,idstatusorden =2,
	idusuariocierre =@idusuariocierre,fechahoracierre=getdate(),idusuariomodif =@idusuariocierre,fechahoramodif=getdate() 
 WHERE 
	 idorden=@idorden

GO

CREATE PROCEDURE [dbo].[proc_insertar_fotoanalisisorden]
	(@idcabanalisisorden 		int, 
	@rutaimg 		varchar(150),
	@archivo	varchar(50),
	@idusuario		int)

AS INSERT INTO [omnitec].[dbo].[imganal]  
	 (idcabanalisisorden , 
	 rutaimg ,
	archivo ,idusuario ) 
 
VALUES 
	( @idcabanalisisorden  ,@rutaimg ,
	@archivo  ,@idusuario )
GO

create PROCEDURE [dbo].[proc_modificar_ordenenejecucion]
	(	@idorden int,
		@idtipo int,
		@idusuariomodif	int)

AS 
UPDATE [omnitec].[dbo].[ordenes]
	SET fechahoramodif =getdate(),idusuariomodif =@idusuariomodif ,idstatusorden  =1
WHERE idstatusorden =3 and idtipo=@idtipo
UPDATE [omnitec].[dbo].[ordenes] 
	 SET fechahoramodif =getdate(),idusuariomodif =@idusuariomodif ,idstatusorden  =3 
 WHERE 
	 idorden=@idorden

GO



CREATE PROCEDURE [dbo].[proc_modificar_datostransporteorden]
	(@idorden int,
	@comprobante	varchar(50),
	@dnichofer varchar(15),
	@chofer varchar(100),
	@chasis varchar(15),
	@acoplado varchar(15))

AS UPDATE [omnitec].[dbo].[datostransporteorden] 
	 SET	comprobante=@comprobante,
	dnichofer=@dnichofer,chofer=@chofer,chasis=@chasis,acoplado=@acoplado
WHERE idorden =@idorden

GO

CREATE PROCEDURE [dbo].[proc_modificar_despachardevolverproducto]
	( @idetalleproducto int,
	@idordenasoc int,
	@fechaegrestk 		date,
	@idestadoprod int,
	@idusuario		int)

AS 
UPDATE [omnitec].[dbo].[detalleproducto] 
	 SET 
	 idordenasoc  =@idordenasoc  ,
	 fechaegrestk =@fechaegrestk ,
	 idestadoprod =@idestadoprod ,
	 idusuariomodif=@idusuario ,
	 fechahoramodif=getdate(),
	 idubicacion=0
 WHERE 
	idetalleproducto=@idetalleproducto 
GO

create PROCEDURE [dbo].[proc_modificar_feultimoiniciousuario]
	( @idusuario int)

AS UPDATE [omnitec].[dbo].[usuarios]  
	 SET feultimoinicio =getdate() 
 WHERE 
	 idusuario =@idusuario 

GO

CREATE PROCEDURE [dbo].[proc_modificar_cerrarorden]
	( @idorden int,
	@fecha 		date,
	@idusuariomodif		int)

AS UPDATE [omnitec].[dbo].[ordenes] 
	 SET fechacierre=@fecha,
	idstatusorden=2,
	idusuariomodif=@idusuariomodif,fechahoramodif=getdate() 
 WHERE 
	 idorden=@idorden

GO

Create PROCEDURE [dbo].[proc_modificar_desacociarproductosreservadosenordenasoc]
	( @idorden int,
	@idusuariomodif int)

AS UPDATE [omnitec].[dbo].[detalleproducto] 
	 SET 
	 idordenasoc=0,idestadoprod =2,idusuariomodif=@idusuariomodif,fechahoramodif=getdate() 
 WHERE 
	 idordenasoc=@idorden and idestadoprod =6

GO

CREATE PROCEDURE [dbo].[proc_modificar_orden]
	( @idorden int,
	@idtipo int,
	@fecha 		date,
	@idcosecha int,
	@observaciones text,
	@idusuariomodif		int)

AS 
IF (@idtipo=1 or @idtipo=2 or @idtipo=5)
BEGIN
	UPDATE [omnitec].[dbo].[detalleproducto] 
		set fechaingstk=@fecha
	WHERE idorden=@idorden
END
IF (@idtipo=3 or @idtipo=4)
BEGIN
	UPDATE [omnitec].[dbo].[detalleproducto] 
		set fechaegrestk=@fecha
	WHERE idorden=@idorden
END
BEGIN
UPDATE [omnitec].[dbo].[ordenes] 
	 SET fecha=@fecha,idcosecha=@idcosecha,
	observaciones=@observaciones,idusuariomodif=@idusuariomodif,fechahoramodif=getdate() 
 WHERE 
	 idorden=@idorden
END 
GO


CREATE PROCEDURE [dbo].[proc_buscar_analisisxfechas]
@idtipo int,
@idcliente int,
@desde date,
@hasta date
AS
IF (@idtipo=0 and @idcliente=0 )
BEGIN
	SELECT * FROM [omnitec].[dbo]. [vista_analisis]
	WHERE fecha>=@desde and fecha<=@hasta and (idtipo=1 or idtipo=2)
END
IF (@idtipo>0 and @idcliente=0 )
BEGIN
	SELECT * FROM [omnitec].[dbo]. [vista_analisis]
	WHERE fecha>=@desde and fecha<=@hasta and idtipo=@idtipo
END
IF (@idtipo>0 and @idcliente>0 )
BEGIN
	SELECT * FROM [omnitec].[dbo]. [vista_analisis]
	WHERE fecha>=@desde and fecha<=@hasta and idtipo=@idtipo and idcliente=@idcliente
END
IF (@idtipo=0 and @idcliente>0 )
BEGIN
	SELECT * FROM [omnitec].[dbo]. [vista_analisis]
	WHERE fecha>=@desde and fecha<=@hasta and idcliente=@idcliente and (idtipo=1 or idtipo=2)
END
GO

CREATE PROCEDURE [dbo].[proc_buscar_listarlotesproducidosxfechas]
@desde date,
@hasta date
AS
	SELECT lote,cliente,producto,count(idproducto) as cant,sum(kg) as kg FROM [omnitecPII].[dbo].vista_detproducto 
	WHERE fechaingstk>=@desde and fechaingstk<=@hasta and idproducto<>1  group by lote,cliente,producto ORDER BY lote
GO

CREATE PROCEDURE [dbo].[proc_buscar_listamovimientosxfecha]
@fecha date
AS
	SELECT  *  FROM [omnitec].[dbo].vista_movdepxfecha 
	WHERE fecha>=@fecha  
GO