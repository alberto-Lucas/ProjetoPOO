USE [master]
GO
DROP DATABASE IF EXISTS [pooCamadas]
GO
CREATE DATABASE [pooCamadas]
GO
USE [pooCamadas]
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](255) NOT NULL,
	[rg] [varchar](20) NULL,
	[cpf] [char](11) NULL,
	[data_nascimento] [date] NULL,
	[telefone] [varchar](15) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido]    Script Date: 21/11/2023 18:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido](
	[id_pedido] [int] IDENTITY(1,1) NOT NULL,
	[data_hora] [datetime] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[status] [char](1) NOT NULL,
 CONSTRAINT [PK_pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pedido_item]    Script Date: 21/11/2023 18:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pedido_item](
	[id_pedido] [int] NOT NULL,
	[id_pedido_item] [int] IDENTITY(1,1) NOT NULL,
	[id_produto] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[valor_unitario] [decimal](18, 2) NOT NULL,
	[valor_total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_itens_pedido] PRIMARY KEY CLUSTERED 
(
	[id_pedido] ASC,
	[id_pedido_item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[produto]    Script Date: 21/11/2023 18:17:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produto](
	[id_produto] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](255) NOT NULL,
	[codigo_barras] [varchar](14) NULL,
	[unidade] [char](10) NULL,
	[preco_venda] [decimal](18, 2) NOT NULL,
	[estoque_atual] [int] NOT NULL,
 CONSTRAINT [PK_produto] PRIMARY KEY CLUSTERED 
(
	[id_produto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([id_cliente], [nome], [rg], [cpf], [data_nascimento], [telefone]) VALUES (1, N'CLIENTE TESTE 1', N'123456789', N'12345678912', CAST(N'1990-01-01' AS Date), N'(17) 99999-7070')
INSERT [dbo].[cliente] ([id_cliente], [nome], [rg], [cpf], [data_nascimento], [telefone]) VALUES (2, N'CLIENTE TESTE 2', N'987456321', N'98765432198', CAST(N'2000-01-01' AS Date), N'(17) 98888-6060')
SET IDENTITY_INSERT [dbo].[cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[pedido] ON 

INSERT [dbo].[pedido] ([id_pedido], [data_hora], [id_cliente], [status]) VALUES (1, CAST(N'2023-11-17T18:12:00.287' AS DateTime), 1, N'F')
INSERT [dbo].[pedido] ([id_pedido], [data_hora], [id_cliente], [status]) VALUES (2, CAST(N'2023-11-18T18:12:00.750' AS DateTime), 2, N'F')
INSERT [dbo].[pedido] ([id_pedido], [data_hora], [id_cliente], [status]) VALUES (3, CAST(N'2023-11-19T18:12:00.357' AS DateTime), 1, N'P')
INSERT [dbo].[pedido] ([id_pedido], [data_hora], [id_cliente], [status]) VALUES (4, CAST(N'2023-11-20T18:13:00.503' AS DateTime), 2, N'C')
INSERT [dbo].[pedido] ([id_pedido], [data_hora], [id_cliente], [status]) VALUES (5, CAST(N'2023-11-21T18:13:21.710' AS DateTime), 2, N'P')
SET IDENTITY_INSERT [dbo].[pedido] OFF
GO
SET IDENTITY_INSERT [dbo].[pedido_item] ON 

INSERT [dbo].[pedido_item] ([id_pedido], [id_pedido_item], [id_produto], [quantidade], [valor_unitario], [valor_total]) VALUES (1, 1, 1, 2, CAST(12.50 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[pedido_item] ([id_pedido], [id_pedido_item], [id_produto], [quantidade], [valor_unitario], [valor_total]) VALUES (2, 2, 1, 2, CAST(12.50 AS Decimal(18, 2)), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[pedido_item] ([id_pedido], [id_pedido_item], [id_produto], [quantidade], [valor_unitario], [valor_total]) VALUES (2, 3, 2, 1, CAST(22.00 AS Decimal(18, 2)), CAST(22.00 AS Decimal(18, 2)))
INSERT [dbo].[pedido_item] ([id_pedido], [id_pedido_item], [id_produto], [quantidade], [valor_unitario], [valor_total]) VALUES (3, 4, 1, 1, CAST(12.50 AS Decimal(18, 2)), CAST(12.50 AS Decimal(18, 2)))
INSERT [dbo].[pedido_item] ([id_pedido], [id_pedido_item], [id_produto], [quantidade], [valor_unitario], [valor_total]) VALUES (4, 5, 2, 1, CAST(22.00 AS Decimal(18, 2)), CAST(22.00 AS Decimal(18, 2)))
INSERT [dbo].[pedido_item] ([id_pedido], [id_pedido_item], [id_produto], [quantidade], [valor_unitario], [valor_total]) VALUES (5, 6, 2, 5, CAST(22.00 AS Decimal(18, 2)), CAST(110.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[pedido_item] OFF
GO
SET IDENTITY_INSERT [dbo].[produto] ON 

INSERT [dbo].[produto] ([id_produto], [descricao], [codigo_barras], [unidade], [preco_venda], [estoque_atual]) VALUES (1, N'PRODUTO TESTE 1', N'1234567891234', N'UN        ', CAST(12.50 AS Decimal(18, 2)), 10)
INSERT [dbo].[produto] ([id_produto], [descricao], [codigo_barras], [unidade], [preco_venda], [estoque_atual]) VALUES (2, N'PRODUTO TESTE 2', N'9876543219876', N'UN        ', CAST(22.00 AS Decimal(18, 2)), 50)
SET IDENTITY_INSERT [dbo].[produto] OFF
GO
ALTER TABLE [dbo].[produto] ADD  CONSTRAINT [DF_produto_preco_venda]  DEFAULT ((0.00)) FOR [preco_venda]
GO
ALTER TABLE [dbo].[produto] ADD  CONSTRAINT [DF_produto_estoque_atual]  DEFAULT ((0)) FOR [estoque_atual]
GO
ALTER TABLE [dbo].[pedido]  WITH CHECK ADD  CONSTRAINT [FK_pedido_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[pedido] CHECK CONSTRAINT [FK_pedido_cliente]
GO
ALTER TABLE [dbo].[pedido_item]  WITH CHECK ADD  CONSTRAINT [FK_itens_pedido_pedido] FOREIGN KEY([id_pedido])
REFERENCES [dbo].[pedido] ([id_pedido])
GO
ALTER TABLE [dbo].[pedido_item] CHECK CONSTRAINT [FK_itens_pedido_pedido]
GO
ALTER TABLE [dbo].[pedido_item]  WITH CHECK ADD  CONSTRAINT [FK_itens_pedido_produto] FOREIGN KEY([id_produto])
REFERENCES [dbo].[produto] ([id_produto])
GO
ALTER TABLE [dbo].[pedido_item] CHECK CONSTRAINT [FK_itens_pedido_produto]
GO
