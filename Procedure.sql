USE [datasam]
GO

/****** Object:  StoredProcedure [dbo].[proc_abrir_ticketbalanza]    Script Date: 12/01/2023 07:02:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Diego Becker>
-- Create date: <08-01-2023>
-- Description:	<Apertura de Tickets de Balanza>
-- =============================================

CREATE PROCEDURE [dbo].[proc_abrir_ticketbalanza]
@idcomprobante int,
@idatbalanzas int,
@tipopesada varchar(2),
@tipoticketbal varchar(2),
@idusuariopesadaentrada int
AS
BEGIN
INSERT INTO ticketbalanza
 (idcomprobante,idatbalanzas,tipopesada,tipoticketbal,idusuariopesadaentrada )
VALUES
           (@idcomprobante,@idatbalanzas ,@tipopesada,@tipoticketbal,@idusuariopesadaentrada )
end
GO


CREATE PROCEDURE [dbo].[proc_activar_modoperaturno_CACAD]
AS
BEGIN
UPDATE modoperaturno
 SET hab='NO'
UPDATE modoperaturno
 SET hab='SI'
WHERE idmodoperaturno=3
end
GO

CREATE PROCEDURE [dbo].[proc_activar_modoperaturno_CACAU]
AS
BEGIN
UPDATE modoperaturno
 SET hab='NO'
UPDATE modoperaturno
 SET hab='SI'
WHERE idmodoperaturno=2 
end
GO

CREATE PROCEDURE [dbo].[proc_activar_modoperaturno_CAE]
AS
BEGIN
UPDATE modoperaturno
 SET hab='NO'
UPDATE modoperaturno
 SET hab='SI'
WHERE idmodoperaturno=1 
end
GO

CREATE PROCEDURE [dbo].[proc_activar_modoperaturno_SCA]
AS
BEGIN
UPDATE modoperaturno
 SET hab='NO'
UPDATE modoperaturno
 SET hab='SI'
WHERE idmodoperaturno=4
end
GO

CREATE PROCEDURE [dbo].[proc_actualizar_iniciosesionusuarios]
	@idusuario int
AS
BEGIN
UPDATE usuarios  
 SET feultimoingreso=GETDATE() 
WHERE idusuario = @idusuario 
end
GO

create PROCEDURE [dbo].[proc_anular_datbalanzas]
@idatbalanzas int
AS
BEGIN
update datbalanzas
 SET hab='NO'
WHERE idatbalanzas=@idatbalanzas
end
GO

CREATE PROCEDURE [dbo].[proc_anular_ticketbalanza]
@idcomprobante int,
@idusuarioanul int
AS
BEGIN
UPDATE ticketbalanza
 SET fechahoranul=getdate(),idusuarioanul=@idusuarioanul,estadoticket='AN'
WHERE
          idcomprobante=@idcomprobante
UPDATE comprobante
 SET hab='NO'
WHERE
          idcomprobante=@idcomprobante
UPDATE movimientostock
 SET hab='NO'
WHERE
          idcomprobante=@idcomprobante
end
GO

Create PROCEDURE [dbo].[proc_anular_turno]
@idturno int,
@idusuarioanul int
AS
BEGIN
UPDATE turno
 SET fechahoranul=getdate(),idusuarioanul=@idusuarioanul,estado='AN',hab='NO'
WHERE
          idturno=@idturno
end
GO

create PROCEDURE [dbo].[proc_asignar_nroturno]
AS
BEGIN
UPDATE turno
 SET nroturno=idturno
end
GO

Create PROCEDURE [dbo].[proc_asignar_ordendeservicioencomprobante]
@idcomprobante int,
@idordendeservicio int
AS
BEGIN
UPDATE comprobante
 set idordendeservicio=@idordendeservicio
WHERE
     idcomprobante=@idcomprobante
end
GO

create PROCEDURE [dbo].[proc_buscar_choferxnombredoc]
@condicion varchar(50)
AS
SELECT nrodoc,nombre,idpersona FROM vista_persona
WHERE (nombre like  @condicion + '%'  or nrodoc like @condicion + '%' ) and (chofer='SI' and hab='SI')
GO

create PROCEDURE [dbo].[proc_buscar_comprobantesxfechas]
@desde date,
@hasta date
AS
SELECT * FROM vista_comprobante
WHERE fecha>=@desde and fecha<=@hasta
GO

create PROCEDURE [dbo].[proc_buscar_contratistaxtiponombrecuit]
@condicion varchar(50)
AS
SELECT cuit,nombre,idproveedor FROM vista_proveedor
WHERE (nombre like  @condicion + '%'  or cuit like @condicion + '%' ) and (contratista='SI' and hab='SI')
GO

create PROCEDURE [dbo].[proc_buscar_movimientostockxfechas]
@desde date,
@hasta date
AS
SELECT * FROM vista_movimientostock
WHERE fecha>=@desde and fecha<=@hasta
GO

CREATE PROCEDURE [dbo].[proc_buscar_movimientostockxmovstkfechas]
@desde date,
@hasta date,
@movimientostk varchar(2)
AS
SELECT fecha,cliente,tipocomprobante, nrocomp, contenedor, servicio,movimientostock,producto, umed, deposito, codigo, tipo, lote, partida, cant, hab FROM vista_movimientostock
WHERE fecha>=@desde and fecha<=@hasta and movimientostock=@movimientostk 
GO

CREATE PROCEDURE [dbo].[proc_buscar_ordendeservicioxnrorefclidocdga]
@idsucursal int,
@condicion varchar(50)
AS
SELECT * FROM vista_ordendeservicio
WHERE idsucursal=@idsucursal and (nrorefcliente like  @condicion + '%'  or docdga like @condicion + '%') and estorden='SI'
GO

create PROCEDURE [dbo].[proc_buscar_personaxnombredoc]
@condicion varchar(50)
AS
SELECT * FROM vista_persona
WHERE nombre like  @condicion + '%'  or nrodoc like @condicion + '%'
GO

Create PROCEDURE [dbo].[proc_buscar_planoperacionesxfecha]
@fecha date
AS
SELECT * FROM vista_planoperaciones
WHERE fecha=@fecha
GO

create PROCEDURE [dbo].[proc_check_plandeoperaciones]
@fecha date,
@idordendeservicio int
AS
BEGIN
SELECT * FROM vista_planoperaciones
WHERE fecha=@fecha and idordendeservicio=@idordendeservicio
end
GO

create PROCEDURE [dbo].[proc_anular_planoperaciones]
@idplanoperaciones int
AS
BEGIN
update planoperaciones
 SET estado='AN'
WHERE idplanoperaciones=@idplanoperaciones
end
GO

create PROCEDURE [dbo].[proc_buscar_proveedoresxtiponombrecuit]
@condicion varchar(50)
AS
SELECT cuit,nombre,contratista,transportista,hab,idproveedor FROM vista_proveedor
WHERE nombre like  @condicion + '%'  or cuit like @condicion + '%'
GO

CREATE PROCEDURE [dbo].[proc_buscar_ticketsbalanzacerradosxfechas]
@desde date,
@hasta date
AS
SELECT * FROM vista_ticketbalanza
WHERE fecha>=@desde and fecha<=@hasta and  estadoticket='CE'
GO

CREATE PROCEDURE [dbo].[proc_buscar_ticketsbalanzacerradosxfechascliente]
@desde date,
@hasta date,
@idcliente int
AS
SELECT * FROM vista_ticketbalanza
WHERE fecha>=@desde and fecha<=@hasta and idcliente=@idcliente and estadoticket='CE'
GO


create PROCEDURE [dbo].[proc_buscar_transportistaxtiponombrecuit]
@condicion varchar(50)
AS
SELECT cuit,nombre,idproveedor FROM vista_proveedor
WHERE (nombre like  @condicion + '%'  or cuit like @condicion + '%' ) and (transportista='SI' and hab='SI')
GO

CREATE PROCEDURE [dbo].[proc_insertar_acceso]
@acceso varchar(50)
AS
BEGIN
INSERT INTO acceso 
 (acceso )
VALUES
           (@acceso )
end
GO

create PROCEDURE [dbo].[proc_insertar_balanza]
@idtipobalanza int,
@nombre varchar(50),
@puerto varchar(10),
@baudios varchar(10),
@dbits varchar(5),
@observaciones text
AS
BEGIN
INSERT INTO balanzas
 (idtipobalanza,nombre,puerto,baudios,dbits,observaciones )
VALUES
           (@idtipobalanza ,@nombre,@puerto,@baudios,@dbits,@observaciones )
end
GO

Create PROCEDURE [dbo].[proc_insertar_cliente]
@cuit varchar(15),
@razonsocial varchar(50),
@direccion varchar(150),
@idlocalidad int,
@observaciones text,
@logo image
AS
BEGIN
INSERT INTO cliente
 (cuit,razonsocial,direccion,idlocalidad,observaciones,logo )
VALUES
           (@cuit ,@razonsocial,@direccion ,@idlocalidad,@observaciones,@logo )
end
GO

create PROCEDURE [dbo].[proc_insertar_clientensucursal]
@idcliente int,
@idsucursal int
AS
BEGIN
INSERT INTO clientensucursal
 (idcliente,idsucursal )
VALUES
           (@idcliente ,@idsucursal )
end
GO

Create PROCEDURE [dbo].[proc_insertar_cuitempresa]
@cuit varchar(15),
@razonsocial varchar(50)
AS
BEGIN
INSERT INTO cuitempresa
 (cuit,razonsocial )
VALUES
           (@cuit ,@razonsocial )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_comprobante]
@idsucursal int,
@fecha date,
@idtipocomprobante int,
@nrocomp int,
@idturno int,
@idordendeservicio int
AS
BEGIN
INSERT INTO comprobante
 (idsucursal,fecha,idtipocomprobante,nrocomp,idturno,idordendeservicio )
VALUES
           (@idsucursal,@fecha,@idtipocomprobante ,@nrocomp,@idturno,@idordendeservicio )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_datbalanzas]
@idbalanza int,
@verificacion varchar(50),
@lot varchar(50),
@codaduana varchar(15),
@ns varchar(50),
@certificado varchar(50),
@fechavtocertificado date
AS
BEGIN
INSERT INTO datbalanzas
 (idbalanza,verificacion,lot,codaduana,ns,certificado,fechavtocertificado )
VALUES
           (@idbalanza ,@verificacion,@lot,@codaduana,@ns,@certificado,@fechavtocertificado )
end
GO

create PROCEDURE [dbo].[proc_insertar_datacomprobante]
@idcomprobante int,
@contenedor varchar(20),
@observaciones text
AS
BEGIN
INSERT INTO datacomprobante
 (idcomprobante,contenedor,observaciones )
VALUES
           (@idcomprobante,@contenedor,@observaciones )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_datbalanzas]
@idbalanza int,
@verificacion varchar(50),
@lot varchar(50),
@codaduana varchar(15),
@ns varchar(50),
@certificado varchar(50),
@fechavtocertificado date
AS
BEGIN
INSERT INTO datbalanzas
 (idbalanza,verificacion,lot,codaduana,ns,certificado,fechavtocertificado )
VALUES
           (@idbalanza ,@verificacion,@lot,@codaduana,@ns,@certificado,@fechavtocertificado )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_deposito]
@idsucursal int,
@deposito varchar(50),
@codigo varchar(5),
@tipo varchar(1),
@cantcalles int,
@cantposiciones int
AS
BEGIN
INSERT INTO deposito
 (idsucursal,deposito,codigo,tipo,cantcalles,cantposiciones )
VALUES
           (@idsucursal ,@deposito,@codigo,@tipo,@cantcalles,@cantposiciones )
end
GO

create PROCEDURE [dbo].[proc_insertar_empresa]
@cuit varchar(15),
@razonsocial varchar(50),
@direccion varchar(150),
@idlocalidad int,
@observaciones text,
@logo image
AS
BEGIN
INSERT INTO empresa
 (cuit,razonsocial,direccion,idlocalidad,observaciones,logo )
VALUES
           (@cuit ,@razonsocial,@direccion ,@idlocalidad,@observaciones,@logo )
end
GO

create PROCEDURE [dbo].[proc_insertar_itemscontrolacceso]
@itemcontrol varchar(50),
@xvto varchar(2),
@apempleado varchar(1),
@apchofer varchar(1),
@approveedor varchar(1),
@apvisita varchar(1),
@apvehiculo varchar(1)
AS
BEGIN
INSERT INTO itemscontrolacceso
 (itemcontrol,xvto,apempleado,apchofer,approveedor,apvisita,apvehiculo )
VALUES
           (@itemcontrol ,@xvto,@apempleado,@apchofer,@approveedor,@apvisita,@apvehiculo )
end
GO

create PROCEDURE [dbo].[proc_insertar_localidad]
@idprovincia int,
@localidad varchar(50)
AS
BEGIN
INSERT INTO localidad
 (idprovincia,localidad )
VALUES
           (@idprovincia,@localidad )
end
GO


CREATE PROCEDURE [dbo].[proc_insertar_modobalanza]
@idbalanza int,
@modobalanza varchar(1),
@idusuario int
AS
BEGIN
UPDATE modobalanza SET hab='NO' WHERE idbalanza=@idbalanza
INSERT INTO modobalanza 
 (idbalanza,modobalanza,idusuario )
VALUES
           (@idbalanza,@modobalanza,@idusuario )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_movimientostock]
@idcomprobante int,
@ideposito int,
@lote varchar(50),
@partida varchar(50),
@cant real,
@movstk varchar(2)
AS
BEGIN
INSERT INTO movimientostock(idcomprobante,ideposito,lote,partida,cant,movstk)
 VALUES (@idcomprobante,@ideposito,@lote,@partida,@cant,@movstk)
end
GO

Create PROCEDURE [dbo].[proc_insertar_operacion]
@fecha date,
@nrop int,
@idcliente int,
@idsucursal int,
@descripcion varchar(50),
@nrorefcliente varchar(50),
@docdga varchar(50),
@idservicio int,
@movimientostock varchar(2),
@observaciones text
AS
BEGIN
INSERT INTO operacion
 (fecha,nrop,idcliente,idsucursal,descripcion,nrorefcliente,docdga,idservicio,movimientostock,observaciones )
VALUES
           (@fecha,@nrop,@idcliente,@idsucursal,@descripcion,@nrorefcliente,@docdga,@idservicio,@movimientostock,@observaciones )
end
GO

create PROCEDURE [dbo].[proc_insertar_operativo]
@idsucursal int,
@idtipoperativo int,
@fecha date,
@desde date,
@hasta date,
@descripcion varchar(50),
@observaciones text,
@idusuarioregistro int
AS
BEGIN
INSERT INTO operativo
 (idsucursal,idtipoperativo,fecha,desde,hasta,descripcion,observaciones,idusuarioregistro )
VALUES
           (@idsucursal,@idtipoperativo,@fecha,@desde,@hasta,@descripcion,@observaciones,@idusuarioregistro )
end
GO

Create PROCEDURE [dbo].[proc_insertar_ordendeservicio]
@fecha date,
@idcliente int,
@idsucursal int,
@nrorefcliente varchar(50),
@docdga varchar(50),
@idservicio int,
@movimientostock varchar(2),
@idproducto int,
@cant int,
@kg int,
@observaciones text
AS
BEGIN
INSERT INTO ordendeservicio
 (fecha,idcliente,idsucursal,nrorefcliente,docdga,idservicio,movimientostock,idproducto,cant,kg,observaciones )
VALUES
           (@fecha,@idcliente,@idsucursal,@nrorefcliente,@docdga,@idservicio,@movimientostock,@idproducto,@cant,@kg,@observaciones )
end
GO

create PROCEDURE [dbo].[proc_insertar_pais]
@pais varchar(50)
AS
BEGIN
INSERT INTO pais
 (pais )
VALUES
           (@pais )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_perfil]
@perfil varchar(50)
AS
BEGIN
INSERT INTO perfil  
 (perfil )
VALUES
           (@perfil )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_perfilenacceso]
@idperfil int,
@idacceso int,
@hab varchar(2)
AS
BEGIN
INSERT INTO perfilenacceso 
 (idperfil,idacceso,hab )
VALUES
           (@idperfil,@idacceso,@hab )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_persona]
@idcuitempresa int,
@nrodoc varchar(20),
@nombre varchar(50),
@email varchar(250),
@idnacionalidad int,
@empleado varchar(2),
@chofer varchar(2),
@proveedor varchar(2),
@visita varchar(2)
AS
BEGIN
INSERT INTO [dbo].[persona]
           ([idcuitempresa]
		   ,[nrodoc]
           ,[nombre]
		   ,[email]
		   ,[idnacionalidad]
           ,[empleado]
           ,[chofer]
           ,[proveedor]
           ,[visita])
     VALUES
           (@idcuitempresa
		   ,@nrodoc
           ,@nombre
		   ,@email
		   ,@idnacionalidad
           ,@empleado
           ,@chofer
           ,@proveedor
           ,@visita)
end
GO

create PROCEDURE [dbo].[proc_insertar_plandeoperaciones]
@fecha date,
@idordendeservicio int,
@cantbultos int,
@cantkg int,
@cantcam int,
@cantcnt int,
@observaciones text
AS
BEGIN
INSERT INTO planoperaciones
 (fecha,idordendeservicio,cantbultos,cantkg,cantcam,cantcnt,observaciones )
VALUES
           (@fecha,@idordendeservicio,@cantbultos,@cantkg,@cantcam,@cantcnt,@observaciones )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_producto]
@idcliente int,
@codcliente varchar(50),
@producto varchar(50),
@idumed int,
@tstkxpeso varchar(2),
@tstkxcantidad varchar(2),
@movesxlote varchar(2),
@movesxpartida varchar(2)
AS
BEGIN
INSERT INTO producto
 (idcliente,codcliente,producto,idumed,tstkxpeso,tstkxcantidad,movesxlote,movesxpartida )
VALUES
           (@idcliente ,@codcliente,@producto ,@idumed,@tstkxpeso,@tstkxcantidad,@movesxlote,@movesxpartida )
end
GO


CREATE PROCEDURE [dbo].[proc_insertar_proveedor]
@cuit varchar(20),
@nombre varchar(50),
@email varchar(250),
@contratista varchar(2),
@transportista varchar(2),
@ata varchar(2)
AS
BEGIN
INSERT INTO [dbo].[proveedor]
           ([cuit]
           ,[nombre]
		   ,[email]
           ,[contratista]
           ,[transportista]
		   ,[ATA])
     VALUES
           (@cuit
           ,@nombre
		   ,@email
           ,@contratista
           ,@transportista
		   ,@ata)
end
GO

create PROCEDURE [dbo].[proc_insertar_provincia]
@idpais int,
@provincia varchar(50)
AS
BEGIN
INSERT INTO provincia
 (idpais,provincia )
VALUES
           (@idpais,@provincia )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_servicio]
@servicio varchar(50)
AS
BEGIN
INSERT INTO servicios
 (servicio )
VALUES
           (@servicio )
end
GO

create PROCEDURE [dbo].[proc_insertar_sucursal]
@idempresa int,
@nombresucursal varchar(50),
@direccion varchar(150),
@idlocalidad int,
@observaciones text
AS
BEGIN
INSERT INTO sucursal
 (idempresa,nombresucursal,direccion,idlocalidad,observaciones )
VALUES
           (@idempresa,@nombresucursal,@direccion ,@idlocalidad,@observaciones )
end
GO

Create PROCEDURE [dbo].[proc_insertar_sucursalapp]
@idsucursal int
AS
BEGIN
INSERT INTO sucursalapp
 (idsucursal )
VALUES
           (@idsucursal )
end
GO


CREATE PROCEDURE [dbo].[proc_insertar_turno]
@nroturno int,
@movint varchar(2),
@idsucursal int,
@fecha date,
@fechaplanif date,
@idusuarioing int,
@idcliente int,
@idtransportista int,
@idchofer int,
@chasis varchar(15),
@acoplado varchar(15),
@observaciones text
AS
BEGIN
INSERT INTO turno
 (nroturno,movint,idsucursal,fecha,fechaplanif,ingreso,idusuarioing,idcliente,idtransportista,idchofer,chasis,acoplado,observaciones )
VALUES
           (@nroturno,@movint,@idsucursal ,@fecha,@fechaplanif,getdate() ,@idusuarioing,@idcliente,@idtransportista,@idchofer,@chasis,@acoplado,@observaciones )
end
GO

Create PROCEDURE [dbo].[proc_insertar_umed]
@umed varchar(50)
AS
BEGIN
INSERT INTO umed
 (umed )
VALUES
           (@umed )
end
GO

CREATE PROCEDURE [dbo].[proc_insertar_usuarios]
@nombre varchar(50),
	@usuario	varchar(50),
	@password varchar(500),
	@email varchar(150),
	@idperfil int,
	@diasexpirapassword int
AS
BEGIN
INSERT INTO usuarios  
 (nombre,usuario ,password ,email ,idperfil,diasexpirapassword,feultimocambiopassword )
VALUES
           (@nombre ,@usuario ,@password ,@email ,@idperfil ,@diasexpirapassword ,GETDATE() )
end
GO

Create PROCEDURE [dbo].[proc_modificar_anularecuperamovimientostock]
@idmovimientostock int,
@hab varchar(2)
AS
BEGIN
UPDATE movimientostock
 SET hab=@hab
WHERE
     idmovimientostock=@idmovimientostock
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_balanza]
@idbalanza int,
@idtipobalanza int,
@nombre varchar(50),
@puerto varchar(10),
@baudios varchar(10),
@dbits varchar(5),
@observaciones text,
@hab varchar(2)
AS
BEGIN
UPDATE balanzas
 SET idtipobalanza=@idtipobalanza,nombre=@nombre,puerto=@puerto,baudios=@baudios,dbits=@dbits,observaciones=@observaciones,
 hab=@hab
WHERE idbalanza=@idbalanza
end
GO

Create PROCEDURE [dbo].[proc_modificar_cliente]
@idcliente int,
@cuit varchar(15),
@razonsocial varchar(50),
@direccion varchar(150),
@idlocalidad int,
@observaciones text,
@logo image,
@hab varchar(2)
AS
BEGIN
UPDATE cliente
 SET cuit=@cuit,razonsocial=@razonsocial,direccion=@direccion,idlocalidad=@idlocalidad,observaciones=@observaciones,
 logo =@logo, hab=@hab
WHERE idcliente=@idcliente
end
GO

create PROCEDURE [dbo].[proc_modificar_clientensuc]
@idclientensucursal int,
@hab varchar (2)
AS
BEGIN
UPDATE clientensucursal
 SET hab=@hab
WHERE idclientensucursal=@idclientensucursal
end
GO

create PROCEDURE [dbo].[proc_modificar_cuitempresa]
@idcuitempresa int,
@cuit varchar(15),
@razonsocial varchar(50),
@hab varchar(2)
AS
BEGIN
UPDATE cuitempresa
 SET cuit=@cuit,razonsocial=@razonsocial, hab=@hab
WHERE @idcuitempresa=@idcuitempresa
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_comprobante]
@idcomprobante int,
@idturno int,
@contenedor varchar(20),
@observaciones text,
@hab varchar(2)
AS
BEGIN
UPDATE comprobante
 set idturno=@idturno,hab=@hab
WHERE
     idcomprobante=@idcomprobante
UPDATE datacomprobante
 set contenedor=@contenedor,observaciones=@observaciones
WHERE
     idcomprobante=@idcomprobante
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_deposito]
@ideposito int,
@tipo varchar(1),
@cantcalles int,
@cantposiciones int,
@hab varchar(2)
AS
BEGIN
update deposito
 SET tipo=@tipo,cantcalles=@cantcalles,cantposiciones=@cantposiciones,hab=@hab
WHERE
     ideposito=@ideposito
end
GO

create PROCEDURE [dbo].[proc_modificar_empresa]
@idempresa int,
@cuit varchar(15),
@razonsocial varchar(50),
@direccion varchar(150),
@idlocalidad int,
@observaciones text,
@logo image,
@hab varchar(2)
AS
BEGIN
UPDATE empresa
 SET cuit=@cuit,razonsocial=@razonsocial,direccion=@direccion,idlocalidad=@idlocalidad,observaciones=@observaciones,
 logo =@logo, hab=@hab
WHERE idempresa=@idempresa
end
GO

CREATE  PROCEDURE [dbo].[proc_modificar_estadoperfil]
	@idperfil int,
	@hab varchar(2)
AS
BEGIN
UPDATE perfil 
 SET hab =@hab 
WHERE idperfil = @idperfil
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_estadoperfilenacceso]
	@idperfil int,
	@idacceso int,
	@hab varchar(2)
AS
BEGIN
UPDATE perfilenacceso 
 SET hab =@hab 
WHERE idperfil = @idperfil and idacceso=@idacceso
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_estadoservicio]
@idservicio int,
@hab varchar(2)
AS
BEGIN
UPDATE servicios
 SET hab=@hab
WHERE idservicio=@idservicio 
end
GO

create PROCEDURE [dbo].[proc_modificar_itemscontrolacceso]
@iditemscontrolacceso int,
@apempleado varchar(1),
@apchofer varchar(1),
@approveedor varchar(1),
@apvisita varchar(1),
@apvehiculo varchar(1),
@hab varchar(2)
AS
BEGIN
UPDATE itemscontrolacceso
 SET apempleado=@apempleado,apchofer=@apchofer,approveedor=@approveedor,apvisita=@apvisita,apvehiculo=@apvehiculo,hab=@hab
WHERE iditemscontrolacceso=@iditemscontrolacceso
end
GO

Create PROCEDURE [dbo].[proc_modificar_operacion]
@idoperacion int,
@descripcion varchar(50),
@nrorefcliente varchar(50),
@docdga varchar(50),
@movimientostock varchar(2),
@observaciones text,
@activa varchar(2)
AS
BEGIN
UPDATE operacion
  SET descripcion=@descripcion,nrorefcliente=@nrorefcliente,docdga=@docdga,movimientostock=@movimientostock,observaciones=@observaciones
WHERE idoperacion=@idoperacion
end
GO

Create PROCEDURE [dbo].[proc_modificar_persona]
@idpersona int,
@idcuitempresa int,
@email varchar(250),
@idnacionalidad int,
@empleado varchar(2),
@chofer varchar(2),
@proveedor varchar(2),
@visita varchar(2),
@hab varchar(2)
AS
BEGIN
UPDATE persona
    SET idcuitempresa=@idcuitempresa,
		email=@email,
		idnacionalidad=@idnacionalidad
		,empleado=@empleado
           ,chofer=@chofer
           ,proveedor=@proveedor
           ,visita=@visita
		   ,hab=@hab
     WHERE
           idpersona=@idpersona
end
GO

Create PROCEDURE [dbo].[proc_modificar_personachofer]
@idpersona int
AS
BEGIN
UPDATE persona
    SET    chofer='SI'
     WHERE
           idpersona=@idpersona
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_producto]
@idproducto int,
@codcliente varchar(50),
@producto varchar(50),
@idumed int,
@tstkxpeso varchar(2),
@tstkxcantidad varchar(2),
@movesxlote varchar(2),
@movesxpartida varchar(2),
@hab varchar(2)
AS
BEGIN
UPDATE producto
 SET codcliente=@codcliente,producto=@producto,idumed=@idumed,tstkxpeso=@tstkxpeso ,
 tstkxcantidad=@tstkxcantidad,movesxlote=@movesxlote,movesxpartida=@movesxpartida  ,hab=@hab
WHERE idproducto=@idproducto 
end
GO

Create PROCEDURE [dbo].[proc_modificar_proveedor]
@idproveedor int,
@contratista varchar(2),
@transportista varchar(2),
@hab varchar(2)
AS
BEGIN
UPDATE proveedor
    SET contratista=@contratista
           ,transportista=@transportista
           ,hab=@hab
     WHERE
           idproveedor=@idproveedor
end
GO

create PROCEDURE [dbo].[proc_modificar_sucursal]
@idsucursal int,
@nombresucursal varchar(50),
@direccion varchar(150),
@idlocalidad int,
@observaciones text,
@hab varchar(2)
AS
BEGIN
UPDATE sucursal
 SET nombresucursal=@nombresucursal,direccion=@direccion,idlocalidad=@idlocalidad,observaciones=@observaciones,
  hab=@hab
WHERE idsucursal=@idsucursal
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_turno]
@idturno int,
@fechaplanif date,
@movint varchar(2),
@idcliente int,
@idtransportista int,
@idchofer int,
@chasis varchar(15),
@acoplado varchar(15),
@observaciones text,
@hab varchar(2)
AS
BEGIN
UPDATE turno
 SET fechaplanif=@fechaplanif,movint=@movint,idcliente=@idcliente,idtransportista=@idtransportista,idchofer=@idchofer,chasis=@chasis,
 acoplado=@acoplado,observaciones=@observaciones,hab=@hab
WHERE
          idturno=@idturno
end
GO

create PROCEDURE [dbo].[proc_modificar_umed]
@idumed int,
@hab varchar(2)
AS
BEGIN
UPDATE umed
 SET hab=@hab
WHERE idumed=@idumed 
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_usuarios]
	@idusuario int,
	@email varchar(50),
	@idperfil int,
	@diasexpirapassword int,
	@hab varchar(2)
AS
BEGIN
UPDATE usuarios  
 SET email=@email,idperfil=@idperfil   ,diasexpirapassword=@diasexpirapassword ,hab =@hab 
WHERE idusuario = @idusuario 
end
GO

CREATE PROCEDURE [dbo].[proc_salida_turno]
@idturno int,
@idusuarioeg int
AS
BEGIN
UPDATE turno
 SET egreso=getdate(),idusuarioeg=@idusuarioeg,estado='SP'
WHERE
          idturno=@idturno
end
GO

-- =============================================
-- cambios 14-01-2023 ---
-- =============================================

Create PROCEDURE [dbo].[proc_insertar_deposito]
@idsucursal int,
@deposito varchar(50),
@codigo varchar(5),
@tipo varchar(1),
@cantcalles int,
@cantposiciones int
AS
BEGIN
INSERT INTO deposito
 (idsucursal,deposito,codigo,tipo,cantcalles,cantposiciones )
VALUES
           (@idsucursal ,@deposito,@codigo,@tipo,@cantcalles,@cantposiciones )
end

Create PROCEDURE [dbo].[proc_modificar_deposito]
@ideposito int,
@tipo varchar(1),
@cantcalles int,
@cantposiciones int,
@hab varchar(2)
AS
BEGIN
update deposito
 SET tipo=@tipo,cantcalles=@cantcalles,cantposiciones=@cantposiciones,hab=@hab
WHERE
     ideposito=@ideposito
end

Create PROCEDURE [dbo].[proc_insertar_ordendeservicio]
@fecha date,
@idoperacion int,
@idservicio int,
@movimientostock varchar(2),
@observaciones text
AS
BEGIN
INSERT INTO ordenservicio
 (fecha,idoperacion,idservicio,movimientostock,observaciones )
VALUES
           (@fecha,@idoperacion,@idservicio,@movimientostock,@observaciones )
end
GO

Create PROCEDURE [dbo].[proc_modificar_ordendeservicio]
@idordendeservicio int,
@nrorefcliente varchar(50),
@docdga varchar(50),
@movimientostock varchar(2),
@idproducto int,
@cant int,
@kg int,
@observaciones text,
@activa varchar(2)
AS
BEGIN
UPDATE ordendeservicio
 SET   nrorefcliente=@nrorefcliente,docdga=@docdga,movimientostock=@movimientostock,@idproducto=@idproducto ,cant=@cant,kg=@kg,  observaciones=@observaciones,activa=@activa
WHERE
	idordendeservicio=@idordendeservicio
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_persona]
@idpersona int,
@email varchar(250),
@idnacionalidad int,
@empleado varchar(2),
@chofer varchar(2),
@proveedor varchar(2),
@visita varchar(2),
@hab varchar(2)
AS
BEGIN
UPDATE persona
    SET email=@email,idnacionalidad=@idnacionalidad,empleado=@empleado
           ,chofer=@chofer
           ,proveedor=@proveedor
           ,visita=@visita
		   ,hab=@hab
     WHERE
           idpersona=@idpersona
end
GO

Create PROCEDURE [dbo].[proc_modificar_personachofer]
@idpersona int
AS
BEGIN
UPDATE persona
    SET    chofer='SI'
     WHERE
           idpersona=@idpersona
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_producto]
@idproducto int,
@codcliente varchar(50),
@producto varchar(50),
@idumed int,
@tstkxpeso varchar(2),
@tstkxcantidad varchar(2),
@movesxlote varchar(2),
@movesxpartida varchar(2),
@hab varchar(2)
AS
BEGIN
UPDATE producto
 SET codcliente=@codcliente,producto=@producto,idumed=@idumed,tstkxpeso=@tstkxpeso ,
 tstkxcantidad=@tstkxcantidad,movesxlote=@movesxlote,movesxpartida=@movesxpartida  ,hab=@hab
WHERE idproducto=@idproducto 
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_proveedor]
@idproveedor int,
@cuit varchar(20),
@email varchar(250),
@contratista varchar(2),
@transportista varchar(2),
@hab varchar(2)
AS
BEGIN
UPDATE proveedor
    SET cuit=@cuit,email=@email,contratista=@contratista
           ,transportista=@transportista
           ,hab=@hab
     WHERE
           idproveedor=@idproveedor
end
GO

create PROCEDURE [dbo].[proc_modificar_sucursal]
@idsucursal int,
@nombresucursal varchar(50),
@direccion varchar(150),
@idlocalidad int,
@observaciones text,
@hab varchar(2)
AS
BEGIN
UPDATE sucursal
 SET nombresucursal=@nombresucursal,direccion=@direccion,idlocalidad=@idlocalidad,observaciones=@observaciones,
  hab=@hab
WHERE idsucursal=@idsucursal
end
GO

Create PROCEDURE [dbo].[proc_modificar_sucursalapp]
@idsucursal int
AS
BEGIN
UPDATE sucursalapp
 SET idsucursal = @idsucursal
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_ticketbalanza]
@idticketbalanza int,
@idcomprobante int,
@idmovimientostock int,
@contenedor varchar(20),
@taracontenedor int,
@origendestino varchar(50),
@precintos varchar(50),
@idata int,
@observaciones text,
@idusuariomodif int,
@ideposito int,
@lote varchar(50),
@partida varchar(50),
@cant real,
@merma int
AS
BEGIN
UPDATE ticketbalanza
 set taracontenedor=@taracontenedor,origendestino=@origendestino,precintos=@precintos,idata=@idata,merma=@merma,idusuariomodif=@idusuariomodif,
 fechahoramodif=getdate()
WHERE
     idticketbalanza=@idticketbalanza
UPDATE datacomprobante
 set contenedor=@contenedor,observaciones=@observaciones
WHERE
     idcomprobante=@idcomprobante
UPDATE movimientostock
 set ideposito=@ideposito,lote=@lote,partida=@partida,cant=@cant
WHERE
     idmovimientostock=@idmovimientostock
end
GO

Create PROCEDURE [dbo].[proc_modificar_ticketbalanzapesoentrada]
@idticketbalanza int,
@pesoentrada int,
@modopesadaentrada varchar(2),
@idusuariopesadaentrada int
AS
BEGIN
UPDATE ticketbalanza
 set pesoentrada=@pesoentrada,modopesadaentrada=@modopesadaentrada,idusuariopesadaentrada=@idusuariopesadaentrada,
 fechahorapesadaentrada=getdate(),estadoticket='PE'
WHERE
     idticketbalanza=@idticketbalanza
end
GO

Create PROCEDURE [dbo].[proc_modificar_ticketbalanzapesosalida]
@idticketbalanza int,
@pesosalida int,
@modopesadasalida varchar(2),
@idusuariopesadasalida int
AS
BEGIN
UPDATE ticketbalanza
 set pesosalida=@pesosalida,modopesadasalida=@modopesadasalida,idusuariopesadasalida=@idusuariopesadasalida,
 fechahorapesadasalida=getdate(),estadoticket='CE'
WHERE
     idticketbalanza=@idticketbalanza
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_turno]
@idturno int,
@fechaplanif date,
@movint varchar(2),
@idcliente int,
@idtransportista int,
@idchofer int,
@chasis varchar(15),
@acoplado varchar(15),
@observaciones text,
@hab varchar(2)
AS
BEGIN
UPDATE turno
 SET fechaplanif=@fechaplanif,movint=@movint,idcliente=@idcliente,idtransportista=@idtransportista,idchofer=@idchofer,chasis=@chasis,
 acoplado=@acoplado,observaciones=@observaciones,hab=@hab
WHERE
          idturno=@idturno
end
GO

create PROCEDURE [dbo].[proc_modificar_umed]
@idumed int,
@hab varchar(2)
AS
BEGIN
UPDATE umed
 SET hab=@hab
WHERE idumed=@idumed 
end
GO

CREATE PROCEDURE [dbo].[proc_modificar_usuarios]
	@idusuario int,
	@email varchar(50),
	@idperfil int,
	@diasexpirapassword int,
	@hab varchar(2)
AS
BEGIN
UPDATE usuarios  
 SET email=@email,idperfil=@idperfil   ,diasexpirapassword=@diasexpirapassword ,hab =@hab 
WHERE idusuario = @idusuario 
end
GO

CREATE PROCEDURE [dbo].[proc_salida_turno]
@idturno int,
@idusuarioeg int
AS
BEGIN
UPDATE turno
 SET egreso=getdate(),idusuarioeg=@idusuarioeg,estado='SP'
WHERE
          idturno=@idturno
end
GO

create PROCEDURE [dbo].[proc_total_turnosxfechas]
@desde date,
@hasta date
AS
SELECT count(idturno) as cant FROM vista_turnos
WHERE fecha>=@desde and fecha<=@hasta
GO

create PROCEDURE [dbo].[proc_total_Estadoturnosxfechas]
@desde date,
@hasta date
AS
SELECT count(idturno) as cant FROM vista_turnos
WHERE fecha>=@desde and fecha<=@hasta
GO

Create PROCEDURE [dbo].[proc_total_Camionesxfechas]
@desde date,
@hasta date
AS
SELECT count(chasis) as cant FROM vista_turnos
WHERE fecha>=@desde and fecha<=@hasta 
group by chasis
GO

Create PROCEDURE [dbo].[proc_total_MovInternoxfechas]
@desde date,
@hasta date
AS
SELECT count(idturno) as cant FROM vista_turnos
WHERE fecha>=@desde and fecha<=@hasta and movint='SI'
GO