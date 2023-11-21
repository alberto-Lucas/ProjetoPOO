-- Copiando estrutura do banco de dados para poocamadas
DROP DATABASE IF EXISTS `poocamadas`;
CREATE DATABASE IF NOT EXISTS `poocamadas`;
USE `poocamadas`;

-- Copiando estrutura para tabela poocamadas.cliente
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `id_cliente` int(11) NOT NULL auto_increment,
  `nome` varchar(255) NOT NULL default '',
  `rg` varchar(20) default NULL,
  `cpf` varchar(11) default NULL,
  `data_nascimento` date default NULL,
  `telefone` varchar(15) default NULL,
  PRIMARY KEY  (`id_cliente`)
) TYPE=MyISAM;

-- Copiando dados para a tabela poocamadas.cliente: 5 rows
REPLACE INTO `cliente` (`id_cliente`, `nome`, `rg`, `cpf`, `data_nascimento`, `telefone`) VALUES
	(1, 'LUCAS ALBERTO', '542337770', '39496863809', '1998-08-05', '(17) 99282-1919'),
	(2, 'Teste', '', '', '2023-11-20', ''),
	(3, 'Teste', '', '', '2023-11-20', ''),
	(4, 'Teste', '', '', '2023-11-20', ''),
	(5, 'Teste', '', '', '2023-11-20', '');

-- Copiando estrutura para tabela poocamadas.pedido
DROP TABLE IF EXISTS `pedido`;
CREATE TABLE IF NOT EXISTS `pedido` (
  `id_pedido` int(11) NOT NULL auto_increment,
  `data_hora` datetime NOT NULL default '0000-00-00 00:00:00',
  `id_cliente` int(11) NOT NULL default '0',
  `STATUS` char(1) NOT NULL default '',
  PRIMARY KEY  (`id_pedido`),
  KEY `id_cliente` (`id_cliente`)
) TYPE=MyISAM;

-- Copiando dados para a tabela poocamadas.pedido: 4 rows
REPLACE INTO `pedido` (`id_pedido`, `data_hora`, `id_cliente`, `STATUS`) VALUES
	(1, '2023-11-17 16:32:55', 1, 'F'),
	(2, '2023-11-18 16:41:23', 1, 'F'),
	(3, '2023-11-19 22:43:21', 2, 'C'),
	(5, '2023-11-20 22:46:20', 4, 'P');

-- Copiando estrutura para tabela poocamadas.pedido_item
DROP TABLE IF EXISTS `pedido_item`;
CREATE TABLE IF NOT EXISTS `pedido_item` (
  `id_pedido_item` int(11) NOT NULL auto_increment,
  `id_pedido` int(11) NOT NULL default '0',
  `id_produto` int(11) NOT NULL default '0',
  `quantidade` int(11) NOT NULL default '0',
  `valor_unitario` decimal(18,2) NOT NULL default '0.00',
  `valor_total` decimal(18,2) NOT NULL default '0.00',
  PRIMARY KEY  (`id_pedido_item`),
  KEY `id_pedido_item` (`id_pedido_item`),
  KEY `id_pedido` (`id_pedido`),
  KEY `id_produto` (`id_produto`)
) TYPE=MyISAM;

-- Copiando dados para a tabela poocamadas.pedido_item: 6 rows
REPLACE INTO `pedido_item` (`id_pedido_item`, `id_pedido`, `id_produto`, `quantidade`, `valor_unitario`, `valor_total`) VALUES
	(1, 1, 4, 2, 78.00, 156.00),
	(3, 2, 4, 1, 78.00, 78.00),
	(4, 3, 2, 1, 7.00, 7.00),
	(5, 3, 5, 2, 22.50, 45.00),
	(6, 4, 4, 1, 78.00, 78.00),
	(7, 5, 1, 1, 1.00, 1.00);

-- Copiando estrutura para tabela poocamadas.produto
DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `id_produto` int(11) NOT NULL auto_increment,
  `descricao` varchar(255) NOT NULL default '',
  `codigo_barras` varchar(14) default NULL,
  `unidade` varchar(10) default NULL,
  `preco_venda` decimal(18,2) NOT NULL default '0.00',
  `estoque_atual` int(11) NOT NULL default '0',
  PRIMARY KEY  (`id_produto`)
) TYPE=MyISAM;

-- Copiando dados para a tabela poocamadas.produto: 5 rows
REPLACE INTO `produto` (`id_produto`, `descricao`, `codigo_barras`, `unidade`, `preco_venda`, `estoque_atual`) VALUES
	(1, 'TESTE', '7897489798797', '1', 1.00, 1),
	(2, 'TESTE2', '8979879879797', '7', 7.00, 7),
	(3, 'TESTE', '7777777777777', 'UN', 7.00, 7),
	(4, 'PRODUTO TESTE', '1234567891234', 'UNI', 78.00, 7),
	(5, 'PRODUTO TESTE CADASTRO', '1234567891234', 'KG', 22.50, 5);