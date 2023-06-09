USE [omnitec]
GO
/****** Object:  Trigger [dbo].[print_qr]    Script Date: 06/04/2023 21:42:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER genera_bb ON Tolva_Entero
	AFTER INSERT 
AS 
BEGIN
    DECLARE @id as int
	DECLARE @idorden AS int
	DECLARE @LOTE AS varchar(50)
	DECLARE @FechaFin AS date
	DECLARE @FechaElab AS datetime
	DECLARE @idgrano AS int
	DECLARE @nrobulto AS int
	DECLARE @idtipoproducto AS int
	DECLARE @codigo AS varchar(50)
	DECLARE @kg AS real
	DECLARE @idprod AS int
	DECLARE @idtolva AS int
	DECLARE @idubicacion AS int
	SET @id = (Select ID from inserted)
	print @id
	set @lote = (select LOTE from vista_vinculacionTolva_Entero where @id=ID)
	set @idorden = (select idorden from vista_vinculacionTolva_Entero where @id=ID)
	set @FechaFin = (select FechaFin from vista_vinculacionTolva_Entero where @id=ID)
	set @FechaElab = (select FechaFin from vista_vinculacionTolva_Entero where @id=ID)
	set @idgrano = (select idgrano from vista_vinculacionTolva_Entero where @id=ID)
	set @nrobulto = (select nrobulto from vista_vinculacionTolva_Entero where @id=ID)
	set @codigo = (select codigo from vista_vinculacionTolva_Entero where @id=ID)
	set @kg = (select PESO from vista_vinculacionTolva_Entero where @id=ID)
	set @idtipoproducto=3
	set @idubicacion=18
	set @idprod=@id
	set @idtolva = 1
	print @lote
	DECLARE @appinsertbb varchar(500)
	insert into detalleproducto (idorden,fechaingstk,fechaelab,idgrano,idtipoproducto,nrobulto,codigo,idubicacion,kg,idprod,idtolva,idusuarioreg)
	values(@idorden,@FechaFin,@FechaElab,@idgrano,@idtipoproducto,@nrobulto,@codigo,@idubicacion,@kg,@idprod,@idtolva,1)
	
	/*select @appinsertbb = '"C:\Users\Usuario\Documents\GitHub\OmnitecApp\printetiquetas\bin\Debug\printetiquetas.exe"'
	print @appinsertbb
	Exec master ..xp_cmdshell @command = @appinsertbb*/
END
