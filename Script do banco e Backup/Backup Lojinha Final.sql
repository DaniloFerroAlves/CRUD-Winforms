-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Set-2022 às 16:09
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `lojinha`
--
CREATE DATABASE IF NOT EXISTS `lojinha` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `lojinha`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cargo`
--

CREATE TABLE `cargo` (
  `cod_cargo` int(2) NOT NULL,
  `data_cadastro` datetime DEFAULT NULL,
  `nome` varchar(30) NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cargo`
--

INSERT INTO `cargo` (`cod_cargo`, `data_cadastro`, `nome`, `status`) VALUES
(1, '2022-09-21 10:50:57', 'Vendedor', b'1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoria`
--

CREATE TABLE `categoria` (
  `cod_categoria` int(2) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `nome` varchar(25) NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `categoria`
--

INSERT INTO `categoria` (`cod_categoria`, `data_cadastro`, `nome`, `status`) VALUES
(1, '2022-09-21 10:45:56', 'Jogo', b'1'),
(2, '2022-09-21 10:56:00', 'Teclado', b'1'),
(3, '2022-09-21 10:56:06', 'HeadSet', b'1'),
(4, '2022-09-21 10:56:10', 'Mouse', b'1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `cod_cliente` int(6) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `nome_social` varchar(80) DEFAULT NULL,
  `cpf` char(14) NOT NULL,
  `data_nascimento` date NOT NULL,
  `celular` char(15) DEFAULT NULL,
  `telefone` char(14) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL,
  `email` varchar(90) DEFAULT NULL,
  `cep` char(9) NOT NULL,
  `cidade` varchar(60) DEFAULT NULL,
  `rua` varchar(50) DEFAULT NULL,
  `numero` varchar(3) DEFAULT NULL,
  `complemento` varchar(70) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`cod_cliente`, `nome`, `nome_social`, `cpf`, `data_nascimento`, `celular`, `telefone`, `data_cadastro`, `status`, `email`, `cep`, `cidade`, `rua`, `numero`, `complemento`, `estado`, `bairro`) VALUES
(1, 'Theo Giovanni Nascimento', '', '655.829.031-60', '2002-08-25', '(82) 99606-1022', '', '2022-09-21 10:47:48', b'1', '', '57608-180', 'Palmeira dos Índios', 'Avenida Alagoas', '0', '', 'AL', 'Palmeira de Fora'),
(2, 'Manuela Kamilly Heloisa Porto', '', '855.795.010-13', '2002-02-25', '(41) 98392-1294', '', '2022-09-21 10:48:22', b'1', 'manuela-porto90@consultorialk.com.br', '83414-300', 'Colombo', 'Rodovia da Uva', '0', '', 'PR', 'Embu'),
(3, 'Cláudio João Gael Lopes', '', '735.985.257-96', '2002-06-26', '(69) 98547-7346', '', '2022-09-21 10:49:02', b'1', 'claudio-lopes72@maiamaquinas.com.br', '76820-220', 'Porto Velho', 'Rua Alexandre Guimarães', '0', '', 'RO', 'Agenor de Carvalho'),
(4, 'Mário Noah Moreira', '', '928.546.473-43', '2002-03-17', '(65) 98374-9923', '', '2022-09-21 10:49:38', b'1', 'mario.noah.moreira@limao.com.br', '78152-352', 'Várzea Grande', 'Rua Barra do Garças', '0', '', 'MT', 'São Matheus'),
(5, 'Nathan Miguel da Cunha', '', '626.393.282-12', '2002-05-26', '(68) 98554-2996', '', '2022-09-21 10:50:16', b'1', 'nathan.miguel.dacunha@gimail.com', '69908-646', 'Rio Branco', 'Travessa do Levitas', '0', '', 'AC', 'Loteamento Santa Helena');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `cod_funcionario` int(2) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `nome_social` varchar(80) DEFAULT NULL,
  `cpf` char(14) NOT NULL,
  `data_nascimento` date NOT NULL,
  `celular` char(15) DEFAULT NULL,
  `telefone` char(14) DEFAULT NULL,
  `data_cadastro` datetime NOT NULL,
  `status` bit(1) NOT NULL,
  `email` varchar(90) DEFAULT NULL,
  `login` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `tipo_acesso` varchar(50) NOT NULL,
  `cep` char(9) DEFAULT NULL,
  `cidade` varchar(60) DEFAULT NULL,
  `rua` varchar(50) DEFAULT NULL,
  `numero` varchar(3) DEFAULT NULL,
  `complemento` varchar(70) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `cod_cargo` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `funcionario`
--

INSERT INTO `funcionario` (`cod_funcionario`, `nome`, `nome_social`, `cpf`, `data_nascimento`, `celular`, `telefone`, `data_cadastro`, `status`, `email`, `login`, `senha`, `tipo_acesso`, `cep`, `cidade`, `rua`, `numero`, `complemento`, `estado`, `bairro`, `cod_cargo`) VALUES
(2, 'Mariah Giovana Allana Aragão', '', '768.222.774-55', '2002-02-12', '(81) 98402-8262', '', '2022-09-21 10:52:08', b'1', 'mariah.giovana.aragao@oerlikon.com', 'Mariah', '123', 'Administrativo', '54756-195', 'Camaragibe', 'Rua Antenor Navarro', '0', '', 'PE', 'Tabatinga', 1),
(3, 'Heloisa Isabel Bernardes', '', '927.869.498-31', '2002-02-13', '(91) 99592-4587', '', '2022-09-21 10:52:49', b'1', 'heloisaisabelbernardes@girocenter.com.br', 'heloisa', '123', 'Administrativo', '66080-450', 'Belém', 'Vila Santa Helena', '0', '', 'PA', 'Pedreira', 1),
(4, 'Maitê Sebastiana Jesus', '', '528.782.927-23', '2000-01-24', '(34) 99813-7327', '', '2022-09-21 10:53:40', b'1', 'maite.sebastiana.jesus@expressoforte.com.br', 'Maite', '1234', 'Administrativo', '38401-884', 'Uberlândia', 'Rua Pimenta Bueno', '0', '', 'MG', 'Jardim Brasília', 1),
(5, 'Kauê Murilo Luan Martins', '', '951.548.759-58', '2000-06-12', '(77) 99515-9302', '', '2022-09-21 10:54:47', b'1', 'kaue-martins75@hotmail.de', 'Kaue', '123', 'Administrativo', '45070-425', 'Vitória da Conquista', 'Rua N', '0', '', 'BA', 'São Pedro', 1),
(6, 'Emily Tereza Rezende', '', '385.753.392-73', '2000-04-08', '(32) 99900-4656', '', '2022-09-21 10:55:26', b'1', 'emily.tereza.rezende@avoeazul.com.br', 'Emily', '123', 'Administrativo', '36202-038', 'Barbacena', 'Beco Seis', '0', '', 'MG', 'Nossa Senhora Aparecida', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `genero`
--

CREATE TABLE `genero` (
  `cod_genero` int(2) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `nome` varchar(25) NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `genero`
--

INSERT INTO `genero` (`cod_genero`, `data_cadastro`, `nome`, `status`) VALUES
(1, '2022-09-21 10:45:56', '', b'1'),
(2, '2022-09-21 10:57:53', 'RPG', b'1'),
(3, '2022-09-21 10:58:04', 'Esporte', b'1'),
(4, '2022-09-21 10:58:17', 'FPS', b'1'),
(5, '2022-09-21 10:59:00', 'Ação', b'1'),
(6, '2022-09-21 11:06:27', 'CyberPunk', b'1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `locacao`
--

CREATE TABLE `locacao` (
  `cod_locacao` int(6) NOT NULL,
  `data_retirada` date DEFAULT NULL,
  `data_devolucao` int(2) DEFAULT NULL,
  `dinheiro` decimal(9,2) DEFAULT NULL,
  `pix` decimal(9,2) DEFAULT NULL,
  `cartao_credito` decimal(9,2) DEFAULT NULL,
  `cartao_debito` decimal(9,2) DEFAULT NULL,
  `valor_total` decimal(8,2) DEFAULT NULL,
  `cod_cliente` int(6) DEFAULT NULL,
  `cod_funcionario` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `locacao_produto`
--

CREATE TABLE `locacao_produto` (
  `cod_locacao_produto` int(11) NOT NULL,
  `cod_locacao` int(6) DEFAULT NULL,
  `cod_produto` int(5) DEFAULT NULL,
  `preco` decimal(8,2) NOT NULL,
  `quantidade` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `marca`
--

CREATE TABLE `marca` (
  `cod_marca` int(3) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `nome` varchar(30) NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `marca`
--

INSERT INTO `marca` (`cod_marca`, `data_cadastro`, `nome`, `status`) VALUES
(1, '2022-09-21 10:45:56', '', b'1'),
(2, '2022-09-21 10:57:12', 'LogiTech', b'1'),
(3, '2022-09-21 10:57:17', 'Redragon', b'1'),
(4, '2022-09-21 10:57:45', 'HyperX', b'1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `plataforma`
--

CREATE TABLE `plataforma` (
  `cod_plataforma` int(2) NOT NULL,
  `data_cadastro` datetime NOT NULL,
  `nome` varchar(25) NOT NULL,
  `status` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `plataforma`
--

INSERT INTO `plataforma` (`cod_plataforma`, `data_cadastro`, `nome`, `status`) VALUES
(1, '2022-09-21 10:45:56', '', b'1'),
(2, '2022-09-21 10:56:44', 'PlayStation 4', b'1'),
(3, '2022-09-21 10:56:53', 'Nintendo Switch', b'1'),
(4, '2022-09-21 10:57:05', 'XboxOne', b'1');

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

CREATE TABLE `produto` (
  `cod_produto` int(5) NOT NULL,
  `nome` text DEFAULT NULL,
  `preco_diaria` decimal(4,2) DEFAULT NULL,
  `especificacoes` text DEFAULT NULL,
  `sinopse` text DEFAULT NULL,
  `status` bit(1) NOT NULL,
  `quantidade` int(5) DEFAULT NULL,
  `faixa_etaria` char(3) DEFAULT NULL,
  `preco_custo` decimal(6,2) DEFAULT NULL,
  `observacao` varchar(100) DEFAULT NULL,
  `preco_venda` decimal(6,2) DEFAULT NULL,
  `data_lancamento` date DEFAULT NULL,
  `data_cadastro` datetime DEFAULT NULL,
  `desenvolvedor` varchar(50) DEFAULT NULL,
  `tipo` varchar(15) DEFAULT NULL,
  `lucro` decimal(6,2) DEFAULT NULL,
  `alugado` bit(1) DEFAULT NULL,
  `cod_genero` int(2) DEFAULT NULL,
  `cod_plataforma` int(2) DEFAULT NULL,
  `cod_marca` int(3) DEFAULT NULL,
  `cod_categoria` int(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`cod_produto`, `nome`, `preco_diaria`, `especificacoes`, `sinopse`, `status`, `quantidade`, `faixa_etaria`, `preco_custo`, `observacao`, `preco_venda`, `data_lancamento`, `data_cadastro`, `desenvolvedor`, `tipo`, `lucro`, `alugado`, `cod_genero`, `cod_plataforma`, `cod_marca`, `cod_categoria`) VALUES
(1, 'God of War Ragnarok', '0.00', '', 'Atreus anseia por conhecimento para ajudá-lo a entender a profecia de “Loki” e o papel que ele desempenhará no Ragnarök. Kratos deve decidir se será acorrentado pelo medo de repetir seus erros ou se libertar de seu passado para ser o pai que Atreus precisa.', b'1', 10, '18+', '250.00', '', '300.00', '2022-11-09', '2022-09-21 11:00:45', 'Santa Monica Studio', 'Venda', '20.00', b'0', 5, 2, 1, 1),
(2, 'Teclado Mecânico Gamer Logitech G PRO com Layout US, RGB LIGHTSYNC, Design TKL, Cabo Destacável, Switch GX Blue Clicky - 920-009388', '0.00', '- Inspirado no design tenkeyless profissional\r\n- Switches mecânicos GX Blue Clicky\r\n- Iluminação RGB LIGHTSYNC\r\n- Perfil integrado para armazenamento de iluminação*\r\n- 12 teclas FN programáveis\r\n- Taxa de transmissão de 1 ms.\r\n\r\n\r\nDimensões:\r\n- Comprimento: 153 mm\r\n- Largura: 360,5 mm\r\n- Altura: 34,3 mm', '', b'1', 15, '', '550.00', '', '605.00', '1900-01-01', '2022-09-21 11:01:54', '', 'Venda', '10.00', b'0', 1, 1, 2, 2),
(3, 'Headset Gamer HyperX Cloud Stinger, Drivers 50mm, Múltiplas Plataformas, P2 e P3 - HX-HSCS-BK/NA', '0.00', 'Fone de ouvido:\r\n- Driver dinâmico, 50 mm com magnetos de neodímio\r\n- Tipo circumaural, fechado\r\n- Resposta de frequência 18Hz–23,000 Hz\r\n- Impedância 30 Ω\r\n- Nível de pressão sonora 102 ± 3dBSPL/mW a 1kHz\r\n- T.H.D. ≤ 2%\r\n- Potência de entrada classificação 30mW, máxima 500mW\r\n- Tipo e comprimento do fio headset (1,3 m) + cabo de extensão em Y (1,7 m)\r\n- Conexão headset - plugue de 3,5 mm (4 polos) + cabo de extensão - plugues de 3,5 mm estéreo e de microfone\r\n\r\nMicrofone:\r\n- Elemento microfone condensador electret\r\n- Padrão polar uni-direcional, cancelamento de ruído\r\n- Resposta de frequência 50 Hz~18.000 Hz\r\n- Sensibilidade -40 dBV (0 dB=1 V/Pa,1 kHz) ', '', b'1', 5, '', '190.00', '', '209.00', '1900-01-01', '2022-09-21 11:02:42', '', 'Venda', '10.00', b'0', 1, 1, 4, 3),
(4, 'Elden Ring', '10.00', '', 'Marika, Radagon e a Ordem Dourada\r\nOs Numem vêm de fora das Terras Intermédias, são descendentes de habitantes de outro mundo e, embora sejam raros, tem uma vida longa. Em algum momento de sua existência, Marika foi escolhida como uma Empíria, uma escolhida pelos Dedos, agentes da Grande Vontade nas Terras Intermédias.', b'1', 1, '18+', '0.00', '', '0.00', '2022-02-25', '2022-09-21 11:04:18', 'From Software', 'Locação', '0.00', b'0', 2, 2, 1, 1),
(5, 'Dark Souls III', '7.00', '', 'Lothric é a cidade onde os Lordes das Cinzas se encontram, esses que têm seus deveres como herdeiros da Chama, responsáveis pela manutenção ou extinção da mesma. Entretanto, quando o dever chamou tais Lordes, cada um fugiu para uma parte do mundo, renunciando e negando seu trabalho.', b'1', 1, '18+', '0.00', '', '0.00', '2016-03-24', '2022-09-21 11:05:27', 'From Software', 'Locação', '0.00', b'0', 2, 4, 1, 1),
(6, 'Pokemon Sword and Shield', '5.00', '', 'Semelhante a muitas entradas anteriores na franquia Pokémon, os jogadores embarcam em uma jornada pela região para se tornar o treinador mais forte, lutando contra oito treinadores poderosos chamados Líderes de Ginásio e eventualmente, o Campeão da região', b'1', 1, '10+', '0.00', '', '0.00', '2019-11-15', '2022-09-21 11:07:59', 'Game Freak', 'Locação', '0.00', b'0', 2, 3, 1, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `cod_venda` int(7) NOT NULL,
  `data_venda` date DEFAULT NULL,
  `total_venda` decimal(8,2) NOT NULL,
  `desconto` decimal(4,2) DEFAULT NULL,
  `dinheiro` decimal(9,2) DEFAULT NULL,
  `pix` decimal(9,2) DEFAULT NULL,
  `cartao_credito` decimal(9,2) DEFAULT NULL,
  `cartao_debito` decimal(9,2) DEFAULT NULL,
  `cod_funcionario` int(2) DEFAULT NULL,
  `cod_cliente` int(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda_produto`
--

CREATE TABLE `venda_produto` (
  `cod_venda_produto` int(11) NOT NULL,
  `cod_venda` int(7) DEFAULT NULL,
  `cod_produto` int(5) DEFAULT NULL,
  `preco` decimal(8,2) NOT NULL,
  `quantidade` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cargo`
--
ALTER TABLE `cargo`
  ADD PRIMARY KEY (`cod_cargo`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`cod_categoria`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`cod_cliente`),
  ADD UNIQUE KEY `cpf` (`cpf`);

--
-- Índices para tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`cod_funcionario`),
  ADD UNIQUE KEY `cpf` (`cpf`),
  ADD KEY `cod_cargo` (`cod_cargo`);

--
-- Índices para tabela `genero`
--
ALTER TABLE `genero`
  ADD PRIMARY KEY (`cod_genero`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `locacao`
--
ALTER TABLE `locacao`
  ADD PRIMARY KEY (`cod_locacao`),
  ADD KEY `cod_cliente` (`cod_cliente`),
  ADD KEY `cod_funcionario` (`cod_funcionario`);

--
-- Índices para tabela `locacao_produto`
--
ALTER TABLE `locacao_produto`
  ADD PRIMARY KEY (`cod_locacao_produto`),
  ADD KEY `cod_locacao` (`cod_locacao`),
  ADD KEY `cod_produto` (`cod_produto`);

--
-- Índices para tabela `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`cod_marca`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `plataforma`
--
ALTER TABLE `plataforma`
  ADD PRIMARY KEY (`cod_plataforma`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`cod_produto`),
  ADD KEY `cod_genero` (`cod_genero`),
  ADD KEY `cod_plataforma` (`cod_plataforma`),
  ADD KEY `cod_marca` (`cod_marca`),
  ADD KEY `cod_categoria` (`cod_categoria`);

--
-- Índices para tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`cod_venda`),
  ADD KEY `cod_funcionario` (`cod_funcionario`),
  ADD KEY `cod_cliente` (`cod_cliente`);

--
-- Índices para tabela `venda_produto`
--
ALTER TABLE `venda_produto`
  ADD PRIMARY KEY (`cod_venda_produto`),
  ADD KEY `cod_venda` (`cod_venda`),
  ADD KEY `cod_produto` (`cod_produto`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cargo`
--
ALTER TABLE `cargo`
  MODIFY `cod_cargo` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `categoria`
--
ALTER TABLE `categoria`
  MODIFY `cod_categoria` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `cod_cliente` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `cod_funcionario` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `genero`
--
ALTER TABLE `genero`
  MODIFY `cod_genero` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `locacao`
--
ALTER TABLE `locacao`
  MODIFY `cod_locacao` int(6) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `locacao_produto`
--
ALTER TABLE `locacao_produto`
  MODIFY `cod_locacao_produto` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `marca`
--
ALTER TABLE `marca`
  MODIFY `cod_marca` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `plataforma`
--
ALTER TABLE `plataforma`
  MODIFY `cod_plataforma` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `cod_produto` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `cod_venda` int(7) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `venda_produto`
--
ALTER TABLE `venda_produto`
  MODIFY `cod_venda_produto` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD CONSTRAINT `funcionario_ibfk_1` FOREIGN KEY (`cod_cargo`) REFERENCES `cargo` (`cod_cargo`);

--
-- Limitadores para a tabela `locacao`
--
ALTER TABLE `locacao`
  ADD CONSTRAINT `locacao_ibfk_1` FOREIGN KEY (`cod_cliente`) REFERENCES `cliente` (`cod_cliente`),
  ADD CONSTRAINT `locacao_ibfk_2` FOREIGN KEY (`cod_funcionario`) REFERENCES `funcionario` (`cod_funcionario`);

--
-- Limitadores para a tabela `locacao_produto`
--
ALTER TABLE `locacao_produto`
  ADD CONSTRAINT `locacao_produto_ibfk_1` FOREIGN KEY (`cod_locacao`) REFERENCES `locacao` (`cod_locacao`),
  ADD CONSTRAINT `locacao_produto_ibfk_2` FOREIGN KEY (`cod_produto`) REFERENCES `produto` (`cod_produto`);

--
-- Limitadores para a tabela `produto`
--
ALTER TABLE `produto`
  ADD CONSTRAINT `produto_ibfk_1` FOREIGN KEY (`cod_genero`) REFERENCES `genero` (`cod_genero`),
  ADD CONSTRAINT `produto_ibfk_2` FOREIGN KEY (`cod_plataforma`) REFERENCES `plataforma` (`cod_plataforma`),
  ADD CONSTRAINT `produto_ibfk_3` FOREIGN KEY (`cod_marca`) REFERENCES `marca` (`cod_marca`),
  ADD CONSTRAINT `produto_ibfk_4` FOREIGN KEY (`cod_categoria`) REFERENCES `categoria` (`cod_categoria`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`cod_funcionario`) REFERENCES `funcionario` (`cod_funcionario`),
  ADD CONSTRAINT `venda_ibfk_2` FOREIGN KEY (`cod_cliente`) REFERENCES `cliente` (`cod_cliente`);

--
-- Limitadores para a tabela `venda_produto`
--
ALTER TABLE `venda_produto`
  ADD CONSTRAINT `venda_produto_ibfk_1` FOREIGN KEY (`cod_venda`) REFERENCES `venda` (`cod_venda`),
  ADD CONSTRAINT `venda_produto_ibfk_2` FOREIGN KEY (`cod_produto`) REFERENCES `produto` (`cod_produto`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
