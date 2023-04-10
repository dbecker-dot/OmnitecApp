USE [datasam]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




/****** Object:  Table [dbo].[acceso]    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[acceso](
	[idacceso] [int] IDENTITY(1,1) NOT NULL,
	[acceso] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_acceso] PRIMARY KEY CLUSTERED 
(
	[idacceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[acceso] ADD  CONSTRAINT [DF_acceso_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[acceso]
           ([acceso])
     VALUES
           ('Configuracion'),('Clientes'),('Productos'),('Entradas'),('Salidas'),('Proveedores'),('Inventario')
		   ,('Balanza'),('Turnos'),('Operaciones'),('Control Acceso'),('Locale')
GO

/****** Object:  Table Balanza    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[balanzas](
	[idbalanza] [int] IDENTITY(1,1) NOT NULL,
	[idtipobalanza] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[puerto] [varchar](10) NOT NULL,
	[baudios] [varchar](10) NOT NULL,
	[dbits] [varchar](5) NOT NULL,
	[observaciones] [text] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_balanzas] PRIMARY KEY CLUSTERED 
(
	[idbalanza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[balanzas] ADD  CONSTRAINT [DF_balanzas_hab]  DEFAULT ('SI') FOR [hab]
GO


/****** Object:  Table Cliente    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[cliente](
	[idcliente] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](15) NOT NULL,
	[razonsocial] [varchar](50) NOT NULL,
	[direccion] [varchar](150) NOT NULL,
	[idlocalidad] [int] NOT NULL,
	[observaciones] [text] NOT NULL,
	[logo] [image] NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[idcliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[cliente] ADD  CONSTRAINT [DF_cliente_hab]  DEFAULT ('SI') FOR [hab]
GO



/****** Object:  Table clienteensucursal    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[clientensucursal](
	[idclientensucursal] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NOT NULL,
	[idsucursal] [int] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_clientensucursal] PRIMARY KEY CLUSTERED 
(
	[idclientensucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[clientensucursal] ADD  CONSTRAINT [DF_clientensucursal_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table comprobante    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[comprobante](
	[idcomprobante] [int] IDENTITY(1,1) NOT NULL,
	[idsucursal] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[idtipocomprobante] [int] NOT NULL,
	[nrocomp] [int] NOT NULL,
	[idturno] [int] NOT NULL,
	[idordendeservicio] [int] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_comprobantestk] PRIMARY KEY CLUSTERED 
(
	[idcomprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[comprobante] ADD  CONSTRAINT [DF_comprobante_idturno]  DEFAULT ((0)) FOR [idturno]
GO

ALTER TABLE [dbo].[comprobante] ADD  CONSTRAINT [DF_comprobantestk_hab]  DEFAULT ('SI') FOR [hab]
GO


/****** Object:  Table cuitempresa    Script Date: 25/02/2023  ******/

CREATE TABLE [dbo].[cuitempresa](
	[idcuitempresa] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](15) NOT NULL,
	[razonsocial] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_cuitempresa] PRIMARY KEY CLUSTERED 
(
	[idcuitempresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[cuitempresa] ADD  CONSTRAINT [DF_cuitempresa_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[cuitempresa]
           (cuit,razonsocial)
     VALUES
           (11111111111,'Generico')
GO


/****** Object:  Table datacomprobante    Script Date: 08/02/2023  ******/

CREATE TABLE [dbo].[datacomprobante](
	[idatacomprobante] [int] IDENTITY(1,1) NOT NULL,
	[idcomprobante] [int] NOT NULL,
	[contenedor] [varchar](20) NOT NULL,
	[observaciones] [text] NOT NULL,
 CONSTRAINT [PK_datacomprobante] PRIMARY KEY CLUSTERED 
(
	[idatacomprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/****** Object:  Table datbalanzas    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[datbalanzas](
	[idatbalanzas] [int] IDENTITY(1,1) NOT NULL,
	[idbalanza] [int] NOT NULL,
	[verificacion] [varchar](50) NOT NULL,
	[lot] [varchar](50) NOT NULL,
	[codaduana] [varchar](15) NOT NULL,
	[ns] [varchar](50) NOT NULL,
	[certificado] [varchar](50) NOT NULL,
	[fechavtocertificado] [date] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_datbalanzas] PRIMARY KEY CLUSTERED 
(
	[idatbalanzas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[datbalanzas] ADD  CONSTRAINT [DF_datbalanzas_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table deposito    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[deposito](
	[ideposito] [int] IDENTITY(1,1) NOT NULL,
	[idsucursal] [int] NOT NULL,
	[deposito] [varchar](50) NOT NULL,
	[codigo] [varchar](5) NOT NULL,
	[tipo] [varchar](1) NOT NULL,
	[cantcalles] [int] NOT NULL,
	[cantposiciones] [int] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_deposito] PRIMARY KEY CLUSTERED 
(
	[ideposito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[deposito] ADD  CONSTRAINT [DF_deposito_hab]  DEFAULT ('SI') FOR [hab]
GO


/****** Object:  Table empresa    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[empresa](
	[idempresa] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](15) NOT NULL,
	[razonsocial] [varchar](50) NOT NULL,
	[direccion] [varchar](150) NOT NULL,
	[idlocalidad] [int] NOT NULL,
	[observaciones] [text] NOT NULL,
	[logo] [image] NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_empresa] PRIMARY KEY CLUSTERED 
(
	[idempresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[empresa] ADD  CONSTRAINT [DF_empresa_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table itemscontrolacceso    Script Date: 21/02/2023  ******/

CREATE TABLE [dbo].[itemscontrolacceso](
	[iditemscontrolacceso] [int] IDENTITY(1,1) NOT NULL,
	[itemcontrol] [varchar](50) NOT NULL,
	[xvto] [varchar](2) NOT NULL,
	[apempleado] [varchar](1) NOT NULL,
	[apchofer] [varchar](1) NOT NULL,
	[approveedor] [varchar](1) NOT NULL,
	[apvisita] [varchar](1) NOT NULL,
	[apvehiculo] [varchar](1) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_itemscontrolacceso] PRIMARY KEY CLUSTERED 
(
	[iditemscontrolacceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[itemscontrolacceso] ADD  CONSTRAINT [DF_itemscontrolacceso_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table localidad    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[localidad](
	[idlocalidad] [int] IDENTITY(1,1) NOT NULL,
	[idprovincia] [int] NOT NULL,
	[localidad] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_localidad] PRIMARY KEY CLUSTERED 
(
	[idlocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[localidad] ADD  CONSTRAINT [DF_localidad_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[localidad]
           ([idprovincia],[localidad])
     VALUES
           (1,'SD')
GO

/****** Object:  Table modobalanza    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[modobalanza](
	[idmodobalanza] [int] IDENTITY(1,1) NOT NULL,
	[idbalanza] [int] NOT NULL,
	[modobalanza] [varchar](1) NOT NULL,
	[idusuario] [int] NOT NULL,
	[fechacambiomodo] [datetime] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_modobalanza] PRIMARY KEY CLUSTERED 
(
	[idmodobalanza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[modobalanza] ADD  CONSTRAINT [DF_modobalanza_fechacambiomodo]  DEFAULT (getdate()) FOR [fechacambiomodo]
GO

ALTER TABLE [dbo].[modobalanza] ADD  CONSTRAINT [DF_modobalanza_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table modoperaturno    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[modoperaturno](
	[idmodoperaturno] [int] IDENTITY(1,1) NOT NULL,
	[modoperaturno] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_modoperaturno] PRIMARY KEY CLUSTERED 
(
	[idmodoperaturno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[modoperaturno] ADD  CONSTRAINT [DF_modoperaturno_hab]  DEFAULT ('NO') FOR [hab]
GO

INSERT INTO [dbo].[modoperaturno]
           ([modoperaturno])
     VALUES
           ('Control Acceso Estricto'),('Control Acceso con autorizacion'),('Control Acceso con Advertencia'),('Sin Control de Acceso')
GO


/****** Object:  Table movimientostock    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[movimientostock](
	[idmovimientostock] [int] IDENTITY(1,1) NOT NULL,
	[idcomprobante] [int] NOT NULL,
	[ideposito] [int] NOT NULL,
	[lote] [varchar](50) NOT NULL,
	[partida] [varchar](50) NOT NULL,
	[cant] [real] NOT NULL,
	[movstk] [varchar](2) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_movimientostock] PRIMARY KEY CLUSTERED 
(
	[idmovimientostock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[movimientostock] ADD  CONSTRAINT [DF_movimientostock_movstk]  DEFAULT ('-') FOR [movstk]
GO

ALTER TABLE [dbo].[movimientostock] ADD  CONSTRAINT [DF_movimientostock_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table nacionalidad    Script Date: 09/02/2023  ******/

CREATE TABLE [dbo].[nacionalidad](
	[idnacionalidad] [int] IDENTITY(1,1) NOT NULL,
	[nacionalidad] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_nacionalidad] PRIMARY KEY CLUSTERED 
(
	[idnacionalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[nacionalidad] ADD  CONSTRAINT [DF_nacionalidad_hab]  DEFAULT ('SI') FOR [hab]
GO
INSERT INTO [dbo].[nacionalidad]
           ([nacionalidad])
     VALUES
           ('SD'),('Argentina'),('Brasil'),('Chile'),('Uruguay'),('Paraguay'),('Bolivia')
GO

/****** Object:  Table operacion    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[operacion](
	[idoperacion] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[nrop] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
	[idsucursal] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[nrorefcliente] [varchar](50) NOT NULL,
	[docdga] [varchar](50) NOT NULL,
	[observaciones] [text] NOT NULL,
	[activa] [varchar](2) NOT NULL,
 CONSTRAINT [PK_operacion] PRIMARY KEY CLUSTERED 
(
	[idoperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[operacion] ADD  CONSTRAINT [DF_operacion_activa]  DEFAULT ('SI') FOR [activa]
GO

/****** Object:  Table operativo    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[operativo](
	[idoperativo] [int] IDENTITY(1,1) NOT NULL,
	[idsucursal] [int] NOT NULL,
	[idtipoperativo] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[desde] [date] NOT NULL,
	[hasta] [date] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[observaciones] [text] NOT NULL,
	[hab] [varchar](2) NOT NULL,
	[idusuarioregistro] [int] NOT NULL,
	[fechahoralta] [datetime] NOT NULL,
	[idusuariomodifico] [int] NOT NULL,
	[fechahoramodifico] [datetime] NOT NULL,
	[idusuarioanulo] [int] NOT NULL,
	[fechahoranulo] [datetime] NOT NULL,
 CONSTRAINT [PK_operativo] PRIMARY KEY CLUSTERED 
(
	[idoperativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[operativo] ADD  CONSTRAINT [DF_operativo_hab]  DEFAULT ('SI') FOR [hab]
GO

ALTER TABLE [dbo].[operativo] ADD  CONSTRAINT [DF_operativo_fechahoralta]  DEFAULT (getdate()) FOR [fechahoralta]
GO

ALTER TABLE [dbo].[operativo] ADD  CONSTRAINT [DF_operativo_idusuariomodifico]  DEFAULT ((0)) FOR [idusuariomodifico]
GO

ALTER TABLE [dbo].[operativo] ADD  CONSTRAINT [DF_operativo_fechahoramodifico]  DEFAULT (((1900)-(1))-(1)) FOR [fechahoramodifico]
GO

ALTER TABLE [dbo].[operativo] ADD  CONSTRAINT [DF_operativo_idusuarioanulo]  DEFAULT ((0)) FOR [idusuarioanulo]
GO

ALTER TABLE [dbo].[operativo] ADD  CONSTRAINT [DF_operativo_fechahoranulo]  DEFAULT (((1900)-(1))-(1)) FOR [fechahoranulo]
GO



/****** Object:  Table ordendeservicio    Script Date: 01/02/2023  ******/

CREATE TABLE [dbo].[ordendeservicio](
	[idordendeservicio] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[idcliente] [int] NOT NULL,
	[idsucursal] [int] NOT NULL,
	[nrorefcliente] [varchar](50) NOT NULL,
	[docdga] [varchar](50) NOT NULL,
	[idservicio] [int] NOT NULL,
	[movimientostock] [varchar](5) NOT NULL,
	[idproducto] [int] NOT NULL,
	[cant] [int] NOT NULL,
	[kg] [int] NOT NULL,
	[observaciones] [text] NOT NULL,
	[activa] [varchar](2) NOT NULL,
 CONSTRAINT [PK_ordendeservicio] PRIMARY KEY CLUSTERED 
(
	[idordendeservicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ordendeservicio] ADD  CONSTRAINT [DF_ordendeservicio_idproducto]  DEFAULT ((0)) FOR [idproducto]
GO

ALTER TABLE [dbo].[ordendeservicio] ADD  CONSTRAINT [DF_ordendeservicio_cant]  DEFAULT ((0)) FOR [cant]
GO

ALTER TABLE [dbo].[ordendeservicio] ADD  CONSTRAINT [DF_ordendeservicio_kg]  DEFAULT ((0)) FOR [kg]
GO

ALTER TABLE [dbo].[ordendeservicio] ADD  CONSTRAINT [DF_ordendeservicio_activa]  DEFAULT ('SI') FOR [activa]
GO


/****** Object:  Table pais    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[pais](
	[idpais] [int] IDENTITY(1,1) NOT NULL,
	[pais] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_pais] PRIMARY KEY CLUSTERED 
(
	[idpais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[pais] ADD  CONSTRAINT [DF_pais_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[pais]
           ([pais])
     VALUES
           ('SD'),('Argentina')
GO

/****** Object:  Table perfil    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[perfil](
	[idperfil] [int] IDENTITY(1,1) NOT NULL,
	[perfil] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_perfil] PRIMARY KEY CLUSTERED 
(
	[idperfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[perfil] ADD  CONSTRAINT [DF_perfil_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[perfil]
           ([perfil])
     VALUES
           ('Administrador')
GO

/****** Object:  Table perfilacceso    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[perfilenacceso](
	[idperfilenacceso] [int] IDENTITY(1,1) NOT NULL,
	[idperfil] [int] NOT NULL,
	[idacceso] [int] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_perfilenacceso] PRIMARY KEY CLUSTERED 
(
	[idperfilenacceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[perfilenacceso] ADD  CONSTRAINT [DF_perfilenacceso_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[perfilenacceso]
           ([idperfil],[idacceso],[hab])
     VALUES
           (1,1,'SI')
GO

/****** Object:  Table persona    Script Date: 26/02/2023  ******/


CREATE TABLE [dbo].[persona](
	[idpersona] [int] IDENTITY(1,1) NOT NULL,
	[idcuitempresa] [int] NOT NULL,
	[nrodoc] [varchar](20) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[idnacionalidad] [int] NOT NULL,
	[empleado] [varchar](2) NOT NULL,
	[chofer] [varchar](2) NOT NULL,
	[proveedor] [varchar](2) NOT NULL,
	[visita] [varchar](2) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[idpersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[persona] ADD  CONSTRAINT [DF_persona_idcuitempresa]  DEFAULT ((0)) FOR [idcuitempresa]
GO

ALTER TABLE [dbo].[persona] ADD  CONSTRAINT [DF_persona_email]  DEFAULT ('-') FOR [email]
GO

ALTER TABLE [dbo].[persona] ADD  CONSTRAINT [DF_persona_idnacionalidad]  DEFAULT ((0)) FOR [idnacionalidad]
GO

ALTER TABLE [dbo].[persona] ADD  CONSTRAINT [DF_persona_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table producto    Script Date: 09/02/2023  ******/

CREATE TABLE [dbo].[planoperaciones](
	[idplanoperaciones] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[idordendeservicio] [int] NOT NULL,
	[cantbultos] [int] NOT NULL,
	[cantkg] [int] NOT NULL,
	[cantcam] [int] NOT NULL,
	[cantcnt] [int] NOT NULL,
	[observaciones] [text] NOT NULL,
	[estado] [varchar](15) NOT NULL,
 CONSTRAINT [PK_planoperaciones] PRIMARY KEY CLUSTERED 
(
	[idplanoperaciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/****** Object:  Table producto    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[producto](
	[idproducto] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NOT NULL,
	[codcliente] [varchar](50) NOT NULL,
	[producto] [varchar](50) NOT NULL,
	[idumed] [int] NOT NULL,
	[tstkxpeso] [varchar](2) NOT NULL,
	[tstkxcantidad] [varchar](2) NOT NULL,
	[movesxlote] [varchar](2) NOT NULL,
	[movesxpartida] [varchar](2) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[idproducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[producto] ADD  CONSTRAINT [DF_producto_stkxkg]  DEFAULT ('NO') FOR [tstkxpeso]
GO

ALTER TABLE [dbo].[producto] ADD  CONSTRAINT [DF_producto_stkxlote]  DEFAULT ('NO') FOR [tstkxcantidad]
GO

ALTER TABLE [dbo].[producto] ADD  CONSTRAINT [DF_producto_movesxlote]  DEFAULT ('NO') FOR [movesxlote]
GO

ALTER TABLE [dbo].[producto] ADD  CONSTRAINT [DF_producto_stkxpartida]  DEFAULT ('NO') FOR [movesxpartida]
GO

ALTER TABLE [dbo].[producto] ADD  CONSTRAINT [DF_producto_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table proveedor    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[proveedor](
	[idproveedor] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](20) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[email] [varchar](250) NOT NULL,
	[contratista] [varchar](2) NOT NULL,
	[transportista] [varchar](2) NOT NULL,
	[ATA] [varchar](2) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[idproveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[proveedor] ADD  CONSTRAINT [DF_proveedor_email]  DEFAULT (' ') FOR [email]
GO

ALTER TABLE [dbo].[proveedor] ADD  CONSTRAINT [DF_proveedor_contratista]  DEFAULT ('NO') FOR [contratista]
GO

ALTER TABLE [dbo].[proveedor] ADD  CONSTRAINT [DF_proveedor_transportista]  DEFAULT ('NO') FOR [transportista]
GO

ALTER TABLE [dbo].[proveedor] ADD  CONSTRAINT [DF_proveedor_ATA]  DEFAULT ('NO') FOR [ATA]
GO

ALTER TABLE [dbo].[proveedor] ADD  CONSTRAINT [DF_proveedor_hab]  DEFAULT ('SI') FOR [hab]
GO


/****** Object:  Table provincia    Script Date: 27/01/2023  ******/

CREATE TABLE [dbo].[provincia](
	[idprovincia] [int] IDENTITY(1,1) NOT NULL,
	[idpais] [int] NOT NULL,
	[provincia] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_provincia] PRIMARY KEY CLUSTERED 
(
	[idprovincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[provincia] ADD  CONSTRAINT [DF_provincia_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[provincia]
           ([idpais],[provincia])
     VALUES
           (1,'SD')
GO

/****** Object:  Table relproveedorpersona    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[relproveedorpersona](
	[idrelproveedorpersona] [int] IDENTITY(1,1) NOT NULL,
	[idproveedor] [int] NOT NULL,
	[idpersona] [int] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_relproveedorpersona] PRIMARY KEY CLUSTERED 
(
	[idrelproveedorpersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[relproveedorpersona] ADD  CONSTRAINT [DF_relproveedorpersona_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table servicios    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[servicios](
	[idservicio] [int] IDENTITY(1,1) NOT NULL,
	[servicio] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_serviciosoperativos] PRIMARY KEY CLUSTERED 
(
	[idservicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[servicios] ADD  CONSTRAINT [DF_servicios_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[servicios]
           ([servicio])
     VALUES
           ('Descarga Buque / Barcaza'),('Carga Buque / Barcaza'),('Consolidado de Contenedor (Dep)'),('Consolidado de Contenedor (Dir)'),
		   ('Desconsolidado de Contenedor (Dep)'),('Desconsolidado de Contenedor (Dir)'),('Entrega a Camion'),('Recepcion de Camion')
GO

/****** Object:  Table sucursal    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[sucursal](
	[idsucursal] [int] IDENTITY(1,1) NOT NULL,
	[idempresa] [int] NOT NULL,
	[nombresucursal] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[idlocalidad] [int] NOT NULL,
	[observaciones] [text] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_sucursal] PRIMARY KEY CLUSTERED 
(
	[idsucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[sucursal] ADD  CONSTRAINT [DF_sucursal_hab]  DEFAULT ('SI') FOR [hab]
GO




/****** Object:  Table sucursalapp    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[sucursalapp](
	[idsucursal] [int] NOT NULL
) ON [PRIMARY]
GO

/****** Object:  Table ticketbalanza    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[ticketbalanza](
	[idticketbalanza] [int] IDENTITY(1,1) NOT NULL,
	[idcomprobante] [int] NOT NULL,
	[fechahoraticket] [datetime] NOT NULL,
	[idatbalanzas] [int] NOT NULL,
	[tipopesada] [varchar](2) NOT NULL,
	[tipoticketbal] [varchar](2) NOT NULL,
	[idusuariopesadaentrada] [int] NOT NULL,
	[pesoentrada] [int] NOT NULL,
	[modopesadaentrada] [varchar](1) NOT NULL,
	[fechahorapesadaentrada] [datetime] NOT NULL,
	[idusuariopesadasalida] [int] NOT NULL,
	[pesosalida] [int] NOT NULL,
	[modopesadasalida] [varchar](1) NOT NULL,
	[fechahorapesadasalida] [datetime] NOT NULL,
	[contenedor] [varchar](20) NOT NULL,
	[taracontenedor] [int] NOT NULL,
	[origendestino] [varchar](50) NOT NULL,
	[precintos] [varchar](150) NOT NULL,
	[idata] [int] NOT NULL,
	[observaciones] [text] NOT NULL,
	[estadoticket] [varchar](2) NOT NULL,
	[merma] [int] NOT NULL,
	[idusuariomodif] [int] NOT NULL,
	[fechahoramodif] [datetime] NOT NULL,
	[idusuarioanul] [int] NOT NULL,
	[fechahoranul] [datetime] NOT NULL,
 CONSTRAINT [PK_ticketbalanza] PRIMARY KEY CLUSTERED 
(
	[idticketbalanza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_fechahoraticket]  DEFAULT (getdate()) FOR [fechahoraticket]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_tipopesada]  DEFAULT ('') FOR [tipopesada]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_tipoticketbal]  DEFAULT ('') FOR [tipoticketbal]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_pesoentrada]  DEFAULT ((0)) FOR [pesoentrada]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_modopesadaentrada]  DEFAULT ('') FOR [modopesadaentrada]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_fechahorapesadaentrada]  DEFAULT (getdate()) FOR [fechahorapesadaentrada]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_idusuariopesadasalida]  DEFAULT ((0)) FOR [idusuariopesadasalida]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_pesosalida]  DEFAULT ((0)) FOR [pesosalida]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_modopesadasalida]  DEFAULT ('') FOR [modopesadasalida]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_fechahorapesadasalida]  DEFAULT ('1900-01-01') FOR [fechahorapesadasalida]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_contenedor]  DEFAULT ('-') FOR [contenedor]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_taracontenedor]  DEFAULT ((0)) FOR [taracontenedor]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_origendestino]  DEFAULT ('-') FOR [origendestino]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_precintos]  DEFAULT ('-') FOR [precintos]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_idata]  DEFAULT ((0)) FOR [idata]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_observaciones]  DEFAULT ('-') FOR [observaciones]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_estadoticket]  DEFAULT ('AB') FOR [estadoticket]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_merma]  DEFAULT ((0)) FOR [merma]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_idusuariomodif]  DEFAULT ((0)) FOR [idusuariomodif]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_fechahoramodif]  DEFAULT ('1900-01-01') FOR [fechahoramodif]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_idusuarioanul]  DEFAULT ((0)) FOR [idusuarioanul]
GO

ALTER TABLE [dbo].[ticketbalanza] ADD  CONSTRAINT [DF_ticketbalanza_fechahoranul]  DEFAULT ('1900-01-01') FOR [fechahoranul]
GO

/****** Object:  Table tipobalanza    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[tipobalanza](
	[idtipobalanza] [int] IDENTITY(1,1) NOT NULL,
	[tipobalanza] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipobalanza] PRIMARY KEY CLUSTERED 
(
	[idtipobalanza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[tipobalanza]
           ([tipobalanza])
     VALUES
           ('FISCAL CAMIONES'),('FISCAL BULTOS'),('NACIONAL CAMIONES'),('NACIONAL BULTOS')
GO


/****** Object:  Table tipocomprobante    Script Date: 27/01/2023  ******/


CREATE TABLE [dbo].[tipocomprobante](
	[idtipocomprobante] [int] IDENTITY(1,1) NOT NULL,
	[tipocomprobante] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_tipocomprobante] PRIMARY KEY CLUSTERED 
(
	[idtipocomprobante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tipocomprobante] ADD  CONSTRAINT [DF_tipocomprobante_hab]  DEFAULT ('SI') FOR [hab]
GO

INSERT INTO [dbo].[tipocomprobante]
           ([tipocomprobante])
     VALUES
           ('Ticket Balanza'),('Tally'),('Ajuste Stock'),('Remito'),('Carta de Porte'),('Otro')
GO

/****** Object:  Table tipooperativo    Script Date: 09/02/2023  ******/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipoperativo]') AND type in (N'U'))
DROP TABLE [dbo].[tipoperativo]
ELSE
CREATE TABLE [dbo].[tipoperativo](
	[idtipoperativo] [int] IDENTITY(1,1) NOT NULL,
	[tipoperativo] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_tipoperativo] PRIMARY KEY CLUSTERED 
(
	[idtipoperativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table turno    Script Date: 20/02/2023  ******/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[turno]') AND type in (N'U'))
DROP TABLE [dbo].[turno]
ELSE
CREATE TABLE [dbo].[turno](
	[idturno] [int] IDENTITY(1,1) NOT NULL,
	[nroturno] [int] NOT NULL,
	[movint] [varchar](2) NOT NULL,
	[idsucursal] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[fechaplanif] [date] NOT NULL,
	[ingreso] [datetime] NOT NULL,
	[idusuarioing] [int] NOT NULL,
	[idcliente] [int] NOT NULL,
	[idtransportista] [int] NOT NULL,
	[idchofer] [int] NOT NULL,
	[chasis] [varchar](15) NOT NULL,
	[acoplado] [varchar](15) NOT NULL,
	[observaciones] [text] NOT NULL,
	[egreso] [datetime] NOT NULL,
	[idusuarioeg] [int] NOT NULL,
	[estado] [varchar](5) NOT NULL,
	[hab] [varchar](2) NOT NULL,
	[idusuarioanul] [int] NOT NULL,
	[fechahoranul] [datetime] NOT NULL,
 CONSTRAINT [PK_turno] PRIMARY KEY CLUSTERED 
(
	[idturno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_nroturno]  DEFAULT ((0)) FOR [nroturno]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_fechaplanif]  DEFAULT ('1900-01-01') FOR [fechaplanif]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_ingreso]  DEFAULT (getdate()) FOR [ingreso]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_salida]  DEFAULT ('1900-01-01') FOR [egreso]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_idusuarioeg]  DEFAULT ((0)) FOR [idusuarioeg]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_estado]  DEFAULT ('EP') FOR [estado]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_hab]  DEFAULT ('SI') FOR [hab]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_idusuarioanul]  DEFAULT ((0)) FOR [idusuarioanul]
GO

ALTER TABLE [dbo].[turno] ADD  CONSTRAINT [DF_turno_fechahoranul]  DEFAULT (((1900)-(1))-(1)) FOR [fechahoranul]
GO



/****** Object:  Table umed    Script Date: 27/01/2023  ******/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[umed]') AND type in (N'U'))
DROP TABLE [dbo].[umed]
ELSE
CREATE TABLE [dbo].[umed](
	[idumed] [int] IDENTITY(1,1) NOT NULL,
	[umed] [varchar](50) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_umed] PRIMARY KEY CLUSTERED 
(
	[idumed] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[umed] ADD  CONSTRAINT [DF_umed_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table usuarios    Script Date: 27/01/2023  ******/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[usuarios]
ELSE
CREATE TABLE [dbo].[usuarios](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](500) NOT NULL,
	[email] [varchar](150) NOT NULL,
	[idperfil] [int] NOT NULL,
	[diasexpirapassword] [int] NOT NULL,
	[feultimocambiopassword] [datetime] NOT NULL,
	[feultimoingreso] [datetime] NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_feultimoingreso]  DEFAULT ('1900-01-01') FOR [feultimoingreso]
GO

ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_hab]  DEFAULT ('SI') FOR [hab]
GO

/****** Object:  Table vehiculos    Script Date: 27/01/2023  ******/

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[vehiculos]') AND type in (N'U'))
DROP TABLE [dbo].[vehiculos]
ELSE
CREATE TABLE [dbo].[vehiculos](
	[idvehiculo] [int] IDENTITY(1,1) NOT NULL,
	[idcuitempresa] [int] NOT NULL,
	[idtipovehiculo] [int] NOT NULL,
	[dominio] [varchar](15) NOT NULL,
	[hab] [varchar](2) NOT NULL,
 CONSTRAINT [PK_vehiculos] PRIMARY KEY CLUSTERED 
(
	[idvehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

SELECT COUNT(*) as tablas from Information_Schema.Tables where TABLE_TYPE = 'BASE TABLE'