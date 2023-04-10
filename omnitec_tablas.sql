USE [omnitec]
GO



CREATE TABLE [dbo].[ptrconfig](
	[idptrconfig] [int] IDENTITY(1,1) NOT NULL,
	[ptrname] [varchar](50) NOT NULL,
	[ptrfile] [varchar](2) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_ptrconfig] PRIMARY KEY CLUSTERED 
(
	[idptrconfig] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ptrconfig] ADD  CONSTRAINT [DF_ptrconfig_hab]  DEFAULT ('SI') FOR [hab]
GO

/******   Script Date: 08/12/2020 19:30  ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[depositos](
	[ideposito] [int] IDENTITY(1,1) NOT NULL,
	[deposito] [varchar](50) NOT NULL,
	[codeposito] [varchar](5) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_deposito] PRIMARY KEY CLUSTERED 
(
	[ideposito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[depositos] ADD  CONSTRAINT [DF_depositos_hab]  DEFAULT ('SI') FOR [hab]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'estado de deposito SI habilitado No deshabilitado' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'depositos', @level2type=N'COLUMN',@level2name=N'hab'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tabla de depositos' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'depositos'
GO

INSERT INTO [dbo].[depositos] 
           ([deposito] 
           ,[codeposito])
     VALUES
           ('CRUDO'
           ,'CRU')
GO

INSERT INTO [dbo].[depositos] 
           ([deposito] 
           ,[codeposito])
     VALUES
           ('PRODUCCION'
           ,'PRO')
GO

INSERT INTO [dbo].[depositos] 
           ([deposito] 
           ,[codeposito])
     VALUES
           ('REFRIGERADO'
           ,'REF')
GO

INSERT INTO [dbo].[depositos] 
           ([deposito] 
           ,[codeposito])
     VALUES
           ('ING REFRIGERADO'
           ,'IRF')
GO

INSERT INTO [dbo].[depositos] 
           ([deposito] 
           ,[codeposito])
     VALUES
           ('ALERO'
           ,'ALE')
GO

CREATE TABLE [dbo].[clientes](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](20) NOT NULL,
	[tipocuit] [varchar](20) NOT NULL,
	[cliente] [varchar](100) NOT NULL,
	[codcliente] [varchar](5) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[clientes] ADD  CONSTRAINT [DF_clientes_hab]  DEFAULT ('SI') FOR [hab]
GO

CREATE TABLE [dbo].[paisafip](
	[idpaisafip] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](20) NOT NULL,
	[pais] [varchar](250) NOT NULL,
	[tiposujeto] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_paisafip] PRIMARY KEY CLUSTERED 
(
	[idpaisafip] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[paisafip] ADD  CONSTRAINT [DF_paisafip_hab]  DEFAULT ('SI') FOR [hab]
GO


CREATE TABLE [dbo].[cosecha](
	[idcosecha] [int] IDENTITY(1,1) NOT NULL,
	[cosecha] [int] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_cosecha] PRIMARY KEY CLUSTERED 
(
	[idcosecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[cosecha] ADD  CONSTRAINT [DF_cosecha_hab]  DEFAULT ('SI') FOR [hab]
GO


CREATE TABLE [dbo].[grano](
	[idgrano] [int] IDENTITY(1,1) NOT NULL,
	[grano] [varchar](10) NOT NULL,
	[codgrano] [varchar](4) NOT NULL,
	[hab] [varchar](2) NULL,
 CONSTRAINT [PK_grano] PRIMARY KEY CLUSTERED 
(
	[idgrano] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[grano] ADD  CONSTRAINT [DF_grano_hab]  DEFAULT ('SI') FOR [hab]
GO

CREATE TABLE [dbo].[tipoproducto](
	[idtipoproducto] [int] IDENTITY(1,1) NOT NULL,
	[tipoproducto] [varchar](50) NOT NULL,
	[abr] [varchar](50) NOT NULL,
	[operacion] [varchar](2) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_tipoproducto] PRIMARY KEY CLUSTERED 
(
	[idtipoproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tipoproducto] ADD  CONSTRAINT [DF_tipoproducto_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[tipoproducto] 
           ([tipoproducto] 
           ,[abr] 
		   ,[operacion])
     VALUES
           ('CONFITERIA'
           ,'CF'
		   ,'RE')
GO

INSERT INTO [dbo].[tipoproducto] 
           ([tipoproducto] 
           ,[abr] 
		   ,[operacion])
     VALUES
           ('INDUSTRIA'
           ,'IN'
		   ,'RE')
GO

INSERT INTO [dbo].[tipoproducto] 
           ([tipoproducto] 
           ,[abr] 
		   ,[operacion])
     VALUES
           ('BLANCHADO'
           ,'BL'
		   ,'PR')
GO

INSERT INTO [dbo].[tipoproducto] 
           ([tipoproducto] 
           ,[abr] 
		   ,[operacion])
     VALUES
           ('RECHAZO SELECCION'
           ,'RS'
		   ,'PR')
GO

CREATE TABLE [dbo].[statusorden](
	[idstatusorden] [int] IDENTITY(1,1) NOT NULL,
	[statusorden] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_statusorden] PRIMARY KEY CLUSTERED 
(
	[idstatusorden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[statusorden] ADD  CONSTRAINT [DF_statusorden_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[statusorden] 
           ([statusorden] )
     VALUES
           ('ABIERTA')
GO

INSERT INTO [dbo].[statusorden] 
           ([statusorden] )
     VALUES
           ('CERRADA')
GO

INSERT INTO [dbo].[statusorden] 
           ([statusorden] )
     VALUES
           ('EN EJECUCION')
GO


INSERT INTO [dbo].[statusorden] 
           ([statusorden] )
     VALUES
           ('ANULADA')
GO

CREATE TABLE [dbo].[grupoanalisis](
	[idgrupoanalisis] [int] IDENTITY(1,1) NOT NULL,
	[grupoanalisis] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_grupoanalisis] PRIMARY KEY CLUSTERED 
(
	[idgrupoanalisis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[grupoanalisis] ADD  CONSTRAINT [DF_grupoanalisis_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[grupoanalisis]
           ([grupoanalisis])
     VALUES
           ('DAÑO TIPO 1')
GO

INSERT INTO [dbo].[grupoanalisis]
           ([grupoanalisis])
     VALUES
           ('DAÑO TIPO 2')
GO

INSERT INTO [dbo].[grupoanalisis]
           ([grupoanalisis])
     VALUES
           ('DEFECTOS MENORES')
GO

INSERT INTO [dbo].[grupoanalisis]
           ([grupoanalisis])
     VALUES
           ('OTROS')
GO

CREATE TABLE [dbo].[itemanalisis](
	[iditemanalisis] [int] IDENTITY(1,1) NOT NULL,
	[idgrupoanalisis] [int] NOT NULL,
	[itemanalisis] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_itemanalisis] PRIMARY KEY CLUSTERED 
(
	[iditemanalisis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[itemanalisis] ADD  CONSTRAINT [DF_itemanalisis_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (1
           ,'BROTADO')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (1
           ,'HELADO')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (1
           ,'DAÑO POR INSECTOS')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (1
           ,'MOHO INTERNO')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (2
           ,'ARDIDO')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (2
           ,'PODRIDO')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (2
           ,'MOHO EXTERNO')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (3
           ,'MANCHADOS')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (3
           ,'SUCIOS')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (3
           ,'CHUZOS')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (4
           ,'CANTIDAD DE CUERPOS EXTRAÑOS')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (4
           ,'% HUMEDAD')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (4
           ,'% PARTIDO')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (4
           ,'% QUEBRADO')
GO

INSERT INTO [dbo].[itemanalisis]
           ([idgrupoanalisis]
           ,[itemanalisis])
     VALUES
           (4
           ,'% ENTERO')
GO


CREATE TABLE [dbo].[accionmovil](
	[idaccionmovil] [int] IDENTITY(1,1) NOT NULL,
	[accion] [varchar](50) NOT NULL,
	[codigoaccion] [varchar](20) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_accionmovil] PRIMARY KEY CLUSTERED 
(
	[idaccionmovil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[accionmovil] ADD  CONSTRAINT [DF_accionmovil_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[accionmovil]
           ([accion]
           ,[codigoaccion])
     VALUES
           ('RECEPCION PRODUCTO'
           ,'RECPRO')
GO

INSERT INTO [dbo].[accionmovil]
           ([accion]
           ,[codigoaccion])
     VALUES
           ('ENVIO A PRODUCCION'
           ,'ENVPROD')
GO

INSERT INTO [dbo].[accionmovil]
           ([accion]
           ,[codigoaccion])
     VALUES
           ('UBICAR TERMINADO'
           ,'UBICTER')
GO

INSERT INTO [dbo].[accionmovil]
           ([accion]
           ,[codigoaccion])
     VALUES
           ('DESPACHO PROD'
           ,'DESPRO')
GO

INSERT INTO [dbo].[accionmovil]
           ([accion]
           ,[codigoaccion])
     VALUES
           ('DEVOLUCION PROD'
           ,'DEVPRO')
GO

INSERT INTO [dbo].[accionmovil]
           ([accion]
           ,[codigoaccion])
     VALUES
           ('REMOVIDO'
           ,'REMPROD')
GO


CREATE TABLE [dbo].[tiporden](
	[idtipo] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](20) NOT NULL,
	[codtipo] [varchar](5) NOT NULL,
	[hab] [varchar](2) NULL,
 CONSTRAINT [PK_tiporden] PRIMARY KEY CLUSTERED 
(
	[idtipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tiporden] ADD  CONSTRAINT [DF_tiporden_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[tiporden] 
           ([tipo]
           ,[codtipo] )
     VALUES
           ('RECEPCION'
           ,'REC')
GO

INSERT INTO [dbo].[tiporden] 
           ([tipo]
           ,[codtipo] )
     VALUES
           ('PRODUCCION'
           ,'PROD')
GO

INSERT INTO [dbo].[tiporden] 
           ([tipo]
           ,[codtipo] )
     VALUES
           ('DEVOLUCION'
           ,'DEV')
GO

INSERT INTO [dbo].[tiporden] 
           ([tipo]
           ,[codtipo] )
     VALUES
           ('DESPACHO'
           ,'DES')
GO

INSERT INTO [dbo].[tiporden] 
           ([tipo]
           ,[codtipo] )
     VALUES
           ('REPROCESO'
           ,'REP')
GO

CREATE TABLE [dbo].[ordenes](
	[idorden] [int] IDENTITY(1,1) NOT NULL,
	[idtipo] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[idcosecha] [int] NOT NULL,
	[idtipoproducto] [int] NOT NULL,
	[idgrano] [int] NOT NULL,
	[nroref] [int] NOT NULL,
	[nrorden] [varchar](6) NOT NULL,
	[lote] [varchar](50) NOT NULL,
	[idcliente] [int] NOT NULL,
	[observaciones] [text] NOT NULL,
	[fechacierre] [date] NOT NULL,
	[idusuariocierre] [int] NOT NULL,
	[fechahoracierre] [datetime] NOT NULL,
	[idstatusorden] [int] NOT NULL,
	[idusuarioreg] [int] NOT NULL,
	[fechahorareg] [datetime] NOT NULL,
	[idusuariomodif] [int] NOT NULL,
	[fechahoramodif] [datetime] NOT NULL,
	[idusuarioanul] [int] NOT NULL,
	[fechahoranul] [datetime] NOT NULL,
 CONSTRAINT [PK_ordenes] PRIMARY KEY CLUSTERED 
(
	[idorden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_nroref]  DEFAULT ((0)) FOR [nroref]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_nrorden]  DEFAULT ((0)) FOR [nrorden]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_lote]  DEFAULT ((0)) FOR [lote]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_fechacierre]  DEFAULT ('01/01/1900') FOR [fechacierre]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_idusuariocierre]  DEFAULT ((0)) FOR [idusuariocierre]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_fechahoracierre]  DEFAULT ('01/01/1900') FOR [fechahoracierre]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_idstatusorden]  DEFAULT ((1)) FOR [idstatusorden]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_fechahorareg]  DEFAULT (getdate()) FOR [fechahorareg]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_idusuariomodif]  DEFAULT ((0)) FOR [idusuariomodif]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_fechahoramodif]  DEFAULT ('01/01/1900') FOR [fechahoramodif]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_idusuarioanul]  DEFAULT ((0)) FOR [idusuarioanul]
GO

ALTER TABLE [dbo].[ordenes] ADD  CONSTRAINT [DF_ordenes_fechahoranul]  DEFAULT ('01/01/1900') FOR [fechahoranul]
GO

CREATE TABLE [dbo].[datostransporteorden](
	[idatostransporte] [int] IDENTITY(1,1) NOT NULL,
	[idorden] [int] NOT NULL,
	[comprobante] [varchar](50) NOT NULL,
	[dnichofer] [varchar](15) NOT NULL,
	[chofer] [varchar](100) NOT NULL,
	[chasis] [varchar](15) NOT NULL,
	[acoplado] [varchar](15) NOT NULL,
 CONSTRAINT [PK_datostransporteorden] PRIMARY KEY CLUSTERED 
(
	[idatostransporte] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[asocorden](
	[idasocorden] [int] IDENTITY(1,1) NOT NULL,
	[idorden] [int] NOT NULL,
	[idordenasoc] [int] NOT NULL,
	[cant] [int] NOT NULL,
	[idusuarioreg] [int] NOT NULL,
	[fechahorareg] [datetime] NOT NULL,
	[idusuarioanul] [int] NOT NULL,
	[fechahoranul] [datetime] NOT NULL,
 CONSTRAINT [PK_asocorden] PRIMARY KEY CLUSTERED 
(
	[idasocorden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[asocorden] ADD  CONSTRAINT [DF_asocorden_fechahorareg]  DEFAULT (getdate()) FOR [fechahorareg]
GO

ALTER TABLE [dbo].[asocorden] ADD  CONSTRAINT [DF_asocorden_idusuarioanul]  DEFAULT ((0)) FOR [idusuarioanul]
GO

ALTER TABLE [dbo].[asocorden] ADD  CONSTRAINT [DF_asocorden_fechahoranul]  DEFAULT ('01/01/1900') FOR [fechahoranul]
GO

CREATE TABLE [dbo].[estadomuestra](
	[idestadomuestra] [int] IDENTITY(1,1) NOT NULL,
	[estadomuestra] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_estadomuestra] PRIMARY KEY CLUSTERED 
(
	[idestadomuestra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[estadomuestra] ADD  CONSTRAINT [DF_estadomuestra_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[estadomuestra]
           ([estadomuestra])
     VALUES
           ('INICIAL')
GO

INSERT INTO [dbo].[estadomuestra]
           ([estadomuestra])
     VALUES
           ('ACEPTADA')
GO

INSERT INTO [dbo].[estadomuestra]
           ([estadomuestra])
     VALUES
           ('RECHAZADA')
GO

INSERT INTO [dbo].[estadomuestra]
           ([estadomuestra])
     VALUES
           ('ANULADA')
GO


CREATE TABLE [dbo].[cabanalisisorden](
	[idcabanalisisorden] [int] IDENTITY(1,1) NOT NULL,
	[idorden] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[nromuestra] [varchar](20) NOT NULL,
	[idestadomuestra] [int] NOT NULL,
	[obsrecha] [text] NOT NULL,
	[idusuarioalta] [int] NOT NULL,
	[fechahorareg] [datetime] NOT NULL,
	[idusuariomodif] [int] NOT NULL,
	[fechahoramodif] [datetime] NOT NULL,
	[idusuarioanul] [int] NOT NULL,
	[fechahoranul] [datetime] NOT NULL,
 CONSTRAINT [PK_cabanalisisorden] PRIMARY KEY CLUSTERED 
(
	[idcabanalisisorden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[cabanalisisorden] ADD  CONSTRAINT [DF_cabanalisisorden_idestadomuestra]  DEFAULT ((2)) FOR [idestadomuestra]
GO

ALTER TABLE [dbo].[cabanalisisorden] ADD  CONSTRAINT [DF_cabanalisisorden_fechahorareg]  DEFAULT (getdate()) FOR [fechahorareg]
GO

ALTER TABLE [dbo].[cabanalisisorden] ADD  CONSTRAINT [DF_cabanalisisorden_idusuariomodif]  DEFAULT ((0)) FOR [idusuariomodif]
GO

ALTER TABLE [dbo].[cabanalisisorden] ADD  CONSTRAINT [DF_cabanalisisorden_fechahoramodif]  DEFAULT ('01/01/1900') FOR [fechahoramodif]
GO

ALTER TABLE [dbo].[cabanalisisorden] ADD  CONSTRAINT [DF_cabanalisisorden_idusuarioanul]  DEFAULT ((0)) FOR [idusuarioanul]
GO

ALTER TABLE [dbo].[cabanalisisorden] ADD  CONSTRAINT [DF_cabanalisisorden_fechahoranul]  DEFAULT ('01/01/1900') FOR [fechahoranul]
GO


CREATE TABLE [dbo].[detanalisisorden](
	[idetanalisisorden] [int] IDENTITY(1,1) NOT NULL,
	[idcabanalisisorden] [int] NOT NULL,
	[iditemanalisis] [int] NOT NULL,
	[valor] [real] NOT NULL,
	[est] [varchar](2) NOT NULL,
	[idusuarioreg] [int] NOT NULL,
	[fechahorareg] [datetime] NOT NULL,
 CONSTRAINT [PK_detanalisisorden] PRIMARY KEY CLUSTERED 
(
	[idetanalisisorden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[detanalisisorden] ADD  CONSTRAINT [DF_detanalisisorden_est]  DEFAULT ('AC') FOR [est]
GO

ALTER TABLE [dbo].[detanalisisorden] ADD  CONSTRAINT [DF_detanalisisorden_fechahorareg]  DEFAULT (getdate()) FOR [fechahorareg]
GO

CREATE TABLE [dbo].[imganal](
	[idimganal] [int] IDENTITY(1,1) NOT NULL,
	[idcabanalisisorden] [int] NOT NULL,
	[rutaimg] [varchar](150) NOT NULL,
	[archivo] [varchar](50) NOT NULL,
	[idusuario] [int] NOT NULL,
	[fechaimg] [datetime] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_imganal] PRIMARY KEY CLUSTERED 
(
	[idimganal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[imganal] ADD  CONSTRAINT [DF_imganal_fechaimg]  DEFAULT (getdate()) FOR [fechaimg]
GO

ALTER TABLE [dbo].[imganal] ADD  CONSTRAINT [DF_imganal_hab]  DEFAULT ('SI') FOR [hab]
GO

CREATE TABLE [dbo].[rutaimg](
	[rutaimg] [varchar](150) NOT NULL
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[detalleproducto](
	[idetalleproducto] [int] IDENTITY(1,1) NOT NULL,
	[idorden] [int] NOT NULL,
	[idordenasoc] [int] NOT NULL,
	[fechaingstk] [date] NOT NULL,
	[idgrano] [int] NOT NULL,
	[idtipoproducto] [int] NOT NULL,
	[nrobulto] [int] NOT NULL,
	[codigo] [varchar](50) NOT NULL,
	[idubicacion] [int] NOT NULL,
	[idestadoprod] [int] NOT NULL,
	[kg] [real] NOT NULL,
	[fechaegrestk] [date] NOT NULL,
	[idusuarioreg] [int] NOT NULL,
	[fechahorareg] [datetime] NOT NULL,
	[idusuariomodif] [int] NOT NULL,
	[fechahoramodif] [datetime] NOT NULL,
	[idusuarioubic] [int] NOT NULL,
	[fechahoraubic] [datetime] NOT NULL,
	[idusuarioanul] [int] NOT NULL,
	[fechahoranul] [datetime] NOT NULL,
 CONSTRAINT [PK_detalleproducto] PRIMARY KEY CLUSTERED 
(
	[idetalleproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_idordenasoc]  DEFAULT ((0)) FOR [idordenasoc]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_fechaingstk]  DEFAULT ('01/01/1900') FOR [fechaingstk]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_idubicacion]  DEFAULT ((0)) FOR [idubicacion]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_idestadoprod]  DEFAULT ((1)) FOR [idestadoprod]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_kg]  DEFAULT ((0)) FOR [kg]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_fechaegrestk]  DEFAULT ('01/01/1900') FOR [fechaegrestk]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_fechahorareg]  DEFAULT (getdate()) FOR [fechahorareg]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_idusuariomodif]  DEFAULT ((0)) FOR [idusuariomodif]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_fechahoramodif]  DEFAULT ('01/01/1900') FOR [fechahoramodif]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_idusuarioubic]  DEFAULT ((0)) FOR [idusuarioubic]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_fechahoraubic]  DEFAULT ('01/01/1900') FOR [fechahoraubic]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_idusuarioanul]  DEFAULT ((0)) FOR [idusuarioanul]
GO

ALTER TABLE [dbo].[detalleproducto] ADD  CONSTRAINT [DF_detalleproducto_fechahoranul]  DEFAULT ('01/01/1900') FOR [fechahoranul]
GO


CREATE TABLE [dbo].[estadoprod](
	[idestadoprod] [int] IDENTITY(1,1) NOT NULL,
	[estadoprod] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_estadoprod] PRIMARY KEY CLUSTERED 
(
	[idestadoprod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[estadoprod] ADD  CONSTRAINT [DF_estadoprod_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[estadoprod]
           ([estadoprod])
     VALUES
           ('GENERADO')
GO

INSERT INTO [dbo].[estadoprod]
           ([estadoprod])
     VALUES
           ('EN STOCK')
GO

INSERT INTO [dbo].[estadoprod]
           ([estadoprod])
     VALUES
           ('DEVUELTO')
GO

INSERT INTO [dbo].[estadoprod]
           ([estadoprod])
     VALUES
           ('PROCESADO')
GO

INSERT INTO [dbo].[estadoprod]
           ([estadoprod])
     VALUES
           ('ANULADO')
GO

INSERT INTO [dbo].[estadoprod]
           ([estadoprod])
     VALUES
           ('RESERVADO')
GO

INSERT INTO [dbo].[estadoprod]
           ([estadoprod])
     VALUES
           ('DAÑADO')
GO

INSERT INTO [dbo].[estadoprod]
           ([estadoprod])
     VALUES
           ('DESPACHADO')
GO






CREATE TABLE [dbo].[movdep](
	[idmovdep] [int] IDENTITY(1,1) NOT NULL,
	[idaccionmovil] [int] NOT NULL,
	[idetalleproducto] [int] NOT NULL,
	[idubicacionorigen] [int] NOT NULL,
	[idubicaciondestino] [int] NOT NULL,
	[est] [varchar](2) NOT NULL,
	[appmovil] [varchar](2) NOT NULL,
	[idusuarioreg] [int] NOT NULL,
	[fechahorareg] [datetime] NOT NULL,
	[idusuarioanul] [int] NOT NULL,
	[fechahoranul] [datetime] NOT NULL,
 CONSTRAINT [PK_removdep] PRIMARY KEY CLUSTERED 
(
	[idmovdep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[movdep] ADD  CONSTRAINT [DF_movdep_idaccionmovil]  DEFAULT (0) FOR [idaccionmovil]
GO

ALTER TABLE [dbo].[movdep] ADD  CONSTRAINT [DF_movdep_est]  DEFAULT ('AC') FOR [est]
GO

ALTER TABLE [dbo].[movdep] ADD  CONSTRAINT [DF_movdep_appmovil]  DEFAULT ('NO') FOR [appmovil]
GO

ALTER TABLE [dbo].[movdep] ADD  CONSTRAINT [DF_movdep_fechahorareg]  DEFAULT (getdate()) FOR [fechahorareg]
GO

ALTER TABLE [dbo].[movdep] ADD  CONSTRAINT [DF_movdep_idusuarioanul]  DEFAULT ((0)) FOR [idusuarioanul]
GO

ALTER TABLE [dbo].[movdep] ADD  CONSTRAINT [DF_movdep_fechahoranul]  DEFAULT ('01/01/1900') FOR [fechahoranul]
GO



CREATE TABLE [dbo].[producto](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](50) NOT NULL,
	[umed] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[producto] ADD  CONSTRAINT [DF_producto_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[producto]
           ([producto]
           ,[umed])
     VALUES
           ('CRUDO',
           ,'BIG BAG')
GO

INSERT INTO [dbo].[producto]
           ([producto]
           ,[umed])
     VALUES
           ('ENTERO',
           ,'BIG BAG')
GO

INSERT INTO [dbo].[producto]
           ([producto]
           ,[umed])
     VALUES
           ('QUEBRADO',
           ,'BIG BAG')
GO

INSERT INTO [dbo].[producto]
           ([producto]
           ,[umed])
     VALUES
           ('INDUSTRIA',
           ,'BIG BAG')
GO


CREATE TABLE [dbo].[reservaubicacionesclientes](
	[idresubiccli] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NOT NULL,
	[idubicacion] [int] NOT NULL,
	[hab] [varchar](2) NOT NULL,
	[idusuarioreg] [int] NOT NULL,
	[fechahorareg] [datetime] NOT NULL,
	[idusuarioanul] [int] NOT NULL,
	[fechahoranul] [datetime] NOT NULL,
 CONSTRAINT [PK_reservaubicacionesclientes] PRIMARY KEY CLUSTERED 
(
	[idresubiccli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[reservaubicacionesclientes] ADD  CONSTRAINT [DF_reservaubicacionesclientes_hab]  DEFAULT ('SI') FOR [hab]
GO

ALTER TABLE [dbo].[reservaubicacionesclientes] ADD  CONSTRAINT [DF_reservaubicacionesclientes_fechahorareg]  DEFAULT (getdate()) FOR [fechahorareg]
GO

ALTER TABLE [dbo].[reservaubicacionesclientes] ADD  CONSTRAINT [DF_reservaubicacionesclientes_idusuarioanul]  DEFAULT ((0)) FOR [idusuarioanul]
GO

ALTER TABLE [dbo].[reservaubicacionesclientes] ADD  CONSTRAINT [DF_reservaubicacionesclientes_fechahoranul]  DEFAULT ('01/01/1900') FOR [fechahoranul]
GO




CREATE TABLE [dbo].[ubicaciones](
	[idubicacion] [int] IDENTITY(1,1) NOT NULL,
	[ideposito] [int] NOT NULL,
	[bloque] [varchar](5) NOT NULL,
	[rackpasillo] [varchar](5) NOT NULL,
	[pos] [varchar](3) NOT NULL,
	[alt] [varchar](2) NOT NULL,
	[capacidad] [int] NOT NULL,
	[codubicacion] [varchar](30) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_ubicaciones] PRIMARY KEY CLUSTERED 
(
	[idubicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ubicaciones] ADD  CONSTRAINT [DF_ubicaciones_hab]  DEFAULT ('SI') FOR [hab]
GO

CREATE TABLE [dbo].[usuarios](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](500) NOT NULL,
	[passwordmovil] [varchar](500) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[perfil] [varchar](5) NOT NULL,
	[diasexpiraclave] [int] NOT NULL,
	[feactclave] [date] NOT NULL,
	[feultimoinicio] [datetime] NOT NULL,
	[accesomovil] [varchar](2) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_feultimoinicio]  DEFAULT ('01/01/1900') FOR [feultimoinicio]
GO

ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_accesomovil]  DEFAULT ('SI') FOR [accesomovil]
GO

ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_hab]  DEFAULT ('SI') FOR [hab]
GO


