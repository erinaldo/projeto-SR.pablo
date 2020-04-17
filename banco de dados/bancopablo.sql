-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 20-Fev-2020 às 13:14
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.3.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bancopablo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `agendamento`
--

CREATE TABLE `agendamento` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(200) NOT NULL,
  `DATA_AGENDAMENTO` date DEFAULT NULL,
  `EMAIL` varchar(100) DEFAULT NULL,
  `TELEFONE` varchar(20) DEFAULT NULL,
  `ID_PRODUTO` int(11) DEFAULT NULL,
  `DESCRICAO` varchar(200) DEFAULT NULL,
  `STATUS` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `categoriadespesa`
--

CREATE TABLE `categoriadespesa` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `categoriadespesa`
--

INSERT INTO `categoriadespesa` (`ID`, `NOME`) VALUES
(28, 'APARTAMENTO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `cliente`
--

CREATE TABLE `cliente` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(200) DEFAULT NULL,
  `OBS` varchar(100) DEFAULT NULL,
  `DATA` datetime DEFAULT NULL,
  `DIAVENCIMENTO` varchar(2) DEFAULT NULL,
  `EMAILPARTICULAR` varchar(200) DEFAULT NULL,
  `CPFCNPJ` varchar(100) DEFAULT NULL,
  `TELEFONE1` varchar(100) DEFAULT NULL,
  `TELEFONE2` varchar(100) DEFAULT NULL,
  `ENDERECO` varchar(300) DEFAULT NULL,
  `BAIRRO` varchar(150) DEFAULT NULL,
  `CIDADE` varchar(100) DEFAULT NULL,
  `CEP` varchar(100) DEFAULT NULL,
  `NUMEROINDETIDADE` varchar(20) DEFAULT NULL,
  `FOTO` longblob DEFAULT NULL,
  `IMAGEM1` longblob DEFAULT NULL,
  `IMAGEM2` longblob DEFAULT NULL,
  `IMAGEM3` longblob DEFAULT NULL,
  `STATUS` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `cliente`
--

INSERT INTO `cliente` (`ID`, `NOME`, `OBS`, `DATA`, `DIAVENCIMENTO`, `EMAILPARTICULAR`, `CPFCNPJ`, `TELEFONE1`, `TELEFONE2`, `ENDERECO`, `BAIRRO`, `CIDADE`, `CEP`, `NUMEROINDETIDADE`, `FOTO`, `IMAGEM1`, `IMAGEM2`, `IMAGEM3`, `STATUS`) VALUES
(114, 'JOHNNY DO NASCIMENTO SA', '', '2020-02-10 00:00:00', '15', '', '951.699.542-04', '92 98119-0108', '', '', '', '', '00000-000', '', NULL, NULL, NULL, NULL, 'ATIVO'),
(115, 'JOSE HERIQUE', '', '2020-02-15 00:00:00', '02', '', '', '', '', '', '', '', '', '', NULL, NULL, NULL, NULL, 'ATIVO'),
(116, 'JOSUE DA SILVA BORBA', '', '2020-02-19 00:00:00', '10', '', '000.000.000-00', '', '', 'RUA COSME FERREIRA', 'SAO JOSE 1', 'MANAUS', '00000-000', '', NULL, NULL, NULL, NULL, 'ATIVO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `contrato`
--

CREATE TABLE `contrato` (
  `ID` int(11) NOT NULL,
  `ID_CLIENTE` int(11) NOT NULL,
  `VALOR_MES` decimal(11,0) NOT NULL,
  `DIA_BASE` int(11) NOT NULL,
  `SITUACAO` varchar(150) DEFAULT NULL,
  `DOCUMENTO` varchar(300) DEFAULT NULL,
  `ID_IMOVEL` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `contrato`
--

INSERT INTO `contrato` (`ID`, `ID_CLIENTE`, `VALOR_MES`, `DIA_BASE`, `SITUACAO`, `DOCUMENTO`, `ID_IMOVEL`) VALUES
(116, 114, '1000', 15, 'CANCELADO', 'C: \\Users\\Public\\Pictures\\Sample Pictures\\Desert.jpg', 1),
(117, 114, '1', 15, 'CANCELADO', 'C: \\Users\\Public\\Pictures\\Sample Pictures\\Desert.jpg', 1),
(118, 114, '100', 15, 'CANCELADO', 'C: \\Users\\Public\\Pictures\\Sample Pictures\\Desert.jpg', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `contratoimprestimo`
--

CREATE TABLE `contratoimprestimo` (
  `ID` int(11) NOT NULL,
  `ID_CLIENTE` int(11) NOT NULL,
  `VALOR_IMPRESTADO` decimal(18,2) NOT NULL,
  `JUROS` varchar(15) DEFAULT NULL,
  `VALOR_JUROS` decimal(18,2) DEFAULT NULL,
  `DIA_BASE` int(11) DEFAULT NULL,
  `SITUACAO` varchar(100) DEFAULT NULL,
  `DATA` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `contratoimprestimo`
--

INSERT INTO `contratoimprestimo` (`ID`, `ID_CLIENTE`, `VALOR_IMPRESTADO`, `JUROS`, `VALOR_JUROS`, `DIA_BASE`, `SITUACAO`, `DATA`) VALUES
(9, 114, '1000.00', '0,05%', '128.05', 15, 'ATIVO', '2020-02-18'),
(10, 115, '1000.00', '0,05%', '154.87', 2, 'ATIVO', '2020-02-19');

-- --------------------------------------------------------

--
-- Estrutura da tabela `contratoimprestimoparcela`
--

CREATE TABLE `contratoimprestimoparcela` (
  `ID` int(11) NOT NULL,
  `ID_CONTRATO` int(11) NOT NULL,
  `PLANO` varchar(200) DEFAULT NULL,
  `N_MENSALIDADE` int(11) DEFAULT NULL,
  `DATA_PAGAMENTO` date DEFAULT NULL,
  `DATA_VENCIMENTO` date DEFAULT NULL,
  `VALOR_PRESTACAO` decimal(18,2) DEFAULT NULL,
  `VALOR_JUROS` decimal(18,2) DEFAULT NULL,
  `AMORTIZACAO` decimal(18,2) DEFAULT NULL,
  `SALDODEVEDOR` decimal(18,2) DEFAULT NULL,
  `FORMA_PAGAMENTO` varchar(100) DEFAULT NULL,
  `VALOR_PAGO` decimal(18,2) DEFAULT NULL,
  `VALORFRACIONADO` decimal(18,2) DEFAULT NULL,
  `SITUACAO` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `contratoimprestimoparcela`
--

INSERT INTO `contratoimprestimoparcela` (`ID`, `ID_CONTRATO`, `PLANO`, `N_MENSALIDADE`, `DATA_PAGAMENTO`, `DATA_VENCIMENTO`, `VALOR_PRESTACAO`, `VALOR_JUROS`, `AMORTIZACAO`, `SALDODEVEDOR`, `FORMA_PAGAMENTO`, `VALOR_PAGO`, `VALORFRACIONADO`, `SITUACAO`) VALUES
(29, 9, 'Plano Imprestimo Price', 1, '2020-02-18', '2020-02-18', '282.01', '50.00', '232.01', '767.99', 'DINHEIRO', '282.01', '0.00', 'PAGO'),
(30, 9, 'Plano Imprestimo Price', 2, NULL, '2020-03-18', '282.01', '38.40', '243.61', '524.38', NULL, NULL, NULL, 'NAO PAGO'),
(31, 9, 'Plano Imprestimo Price', 3, NULL, '2020-04-18', '282.01', '26.22', '255.79', '268.58', NULL, NULL, NULL, 'NAO PAGO'),
(32, 9, 'Plano Imprestimo Price', 4, NULL, '2020-05-18', '282.01', '13.43', '268.58', '0.00', NULL, NULL, NULL, 'NAO PAGO'),
(33, 10, 'Plano Imprestimo Price', 1, NULL, '2020-02-19', '230.97', '50.00', '180.97', '819.03', NULL, NULL, NULL, 'ATRASADO'),
(34, 10, 'Plano Imprestimo Price', 2, NULL, '2020-03-19', '230.97', '40.95', '190.02', '629.00', NULL, NULL, NULL, 'NAO PAGO'),
(35, 10, 'Plano Imprestimo Price', 3, NULL, '2020-04-19', '230.97', '31.45', '199.52', '429.48', NULL, NULL, NULL, 'NAO PAGO'),
(36, 10, 'Plano Imprestimo Price', 4, NULL, '2020-05-19', '230.97', '21.47', '209.50', '219.98', NULL, NULL, NULL, 'NAO PAGO'),
(37, 10, 'Plano Imprestimo Price', 5, NULL, '2020-06-19', '230.98', '11.00', '219.98', '0.00', NULL, NULL, NULL, 'NAO PAGO');

-- --------------------------------------------------------

--
-- Estrutura da tabela `contratoparcelamento`
--

CREATE TABLE `contratoparcelamento` (
  `ID` int(11) NOT NULL,
  `ID_CONTRATO` int(11) NOT NULL,
  `PLANO` varchar(100) NOT NULL,
  `N_MENSALIDADE` int(11) NOT NULL,
  `DATA_PAGAMENTO` date DEFAULT NULL,
  `DATA_VENCIMENTO` date DEFAULT NULL,
  `VALOR` decimal(18,2) DEFAULT NULL,
  `FORMA_PAGAMENTO` varchar(150) DEFAULT NULL,
  `VALOR_PAGO` decimal(18,2) DEFAULT NULL,
  `SITUACAO` varchar(150) DEFAULT NULL,
  `VALORFRACIONADO` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `contratoparcelamento`
--

INSERT INTO `contratoparcelamento` (`ID`, `ID_CONTRATO`, `PLANO`, `N_MENSALIDADE`, `DATA_PAGAMENTO`, `DATA_VENCIMENTO`, `VALOR`, `FORMA_PAGAMENTO`, `VALOR_PAGO`, `SITUACAO`, `VALORFRACIONADO`) VALUES
(2541, 116, 'PLANO ALUGUEL', 1, '2020-01-27', '2020-02-15', '800.00', NULL, NULL, 'CANCELADO', NULL),
(2542, 116, 'PLANO ALUGUEL', 2, '2020-01-27', '2020-03-15', '1000.00', NULL, NULL, 'CANCELADO', NULL),
(2543, 117, 'PLANO ALUGUEL', 1, '2020-02-11', '2020-02-10', '1.00', NULL, NULL, 'CANCELADO', NULL),
(2544, 117, 'PLANO ALUGUEL', 2, '2020-02-10', '2020-03-10', '1.00', 'CREDITO', '1.00', 'PAGO', NULL),
(2545, 118, 'PLANO ALUGUEL', 1, '2020-02-11', '2020-02-10', '100.00', NULL, NULL, 'CANCELADO', NULL),
(2546, 118, 'PLANO ALUGUEL', 2, '2020-02-11', '2020-03-10', '100.00', NULL, NULL, 'CANCELADO', NULL),
(2547, 118, 'PLANO ALUGUEL', 3, '2020-02-11', '2020-04-10', '100.00', NULL, NULL, 'CANCELADO', NULL),
(2548, 118, 'PLANO ALUGUEL', 4, '2020-02-11', '2020-05-10', '100.00', NULL, NULL, 'CANCELADO', NULL),
(2549, 119, 'PLANO ALUGUEL', 1, '2020-02-18', '2020-02-12', '100.00', 'DEBITO', NULL, 'FRACIONADO', '50.00'),
(2550, 119, 'PLANO ALUGUEL', 2, NULL, '2020-03-15', '100.00', NULL, NULL, 'NAO PAGO', NULL),
(2551, 119, 'PLANO ALUGUEL', 3, NULL, '2020-04-15', '100.00', NULL, NULL, 'NAO PAGO', NULL),
(2552, 119, 'PLANO ALUGUEL', 4, NULL, '2020-05-15', '100.00', NULL, NULL, 'NAO PAGO', NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `despesa`
--

CREATE TABLE `despesa` (
  `ID` int(11) NOT NULL,
  `DESCRICAO` varchar(200) NOT NULL,
  `ID_CATEGORIA` int(11) NOT NULL,
  `DATA` date NOT NULL,
  `VALOR` decimal(18,2) NOT NULL,
  `ID_IMOVEL` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `despesa`
--

INSERT INTO `despesa` (`ID`, `DESCRICAO`, `ID_CATEGORIA`, `DATA`, `VALOR`, `ID_IMOVEL`) VALUES
(54, 'teste com imovel', 28, '2020-02-12', '2.50', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `equipamento`
--

CREATE TABLE `equipamento` (
  `ID` int(11) NOT NULL,
  `ID_FORNECEDOR` int(10) NOT NULL,
  `NOME` varchar(200) DEFAULT NULL,
  `MODELO` varchar(100) DEFAULT NULL,
  `MARCA` varchar(100) DEFAULT NULL,
  `QUANTIDADE_INSTALADO` int(11) DEFAULT NULL,
  `QUANTIDADE_ESTOQUE` int(11) DEFAULT NULL,
  `QUANTIDADE_EXTRAVIDO` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `forncedor`
--

CREATE TABLE `forncedor` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(200) NOT NULL,
  `RASAOSOCIAL` varchar(100) DEFAULT NULL,
  `IE` varchar(1000) DEFAULT NULL,
  `CNPJ` varchar(20) DEFAULT NULL,
  `ENDERECO` varchar(200) DEFAULT NULL,
  `EMAIL` varchar(100) DEFAULT NULL,
  `TELEFONE` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `forncedor`
--

INSERT INTO `forncedor` (`ID`, `NOME`, `RASAOSOCIAL`, `IE`, `CNPJ`, `ENDERECO`, `EMAIL`, `TELEFONE`) VALUES
(3, 'ANTONIA VANDA ALVES DO NASCIMENTO', '', '', '', '', '', '');

-- --------------------------------------------------------

--
-- Estrutura da tabela `imovel`
--

CREATE TABLE `imovel` (
  `ID` int(11) NOT NULL,
  `ID_CATEGORIA` int(11) DEFAULT NULL,
  `NOME` varchar(200) DEFAULT NULL,
  `SITUACAO` varchar(100) DEFAULT NULL,
  `TIPO` varchar(100) DEFAULT NULL,
  `OCUPACAO` varchar(100) DEFAULT NULL,
  `ID_CORRETOR` int(11) DEFAULT NULL,
  `CIDADE` varchar(100) DEFAULT NULL,
  `BAIRRO` varchar(100) DEFAULT NULL,
  `NUMERO` varchar(30) DEFAULT NULL,
  `ESTADO` varchar(50) DEFAULT NULL,
  `COMPLEMENTO` varchar(100) DEFAULT NULL,
  `PROPRIETARIO` varchar(100) DEFAULT NULL,
  `LOCALCHAVE` varchar(100) DEFAULT NULL,
  `ULTIMAATUALIZACAO` varchar(100) DEFAULT NULL,
  `QUARTOS` int(11) DEFAULT NULL,
  `SUITES` int(11) DEFAULT NULL,
  `PAVIMENTO` int(11) DEFAULT NULL,
  `GARAGEM` int(11) DEFAULT NULL,
  `SALA` int(11) DEFAULT NULL,
  `BANHEIRO` int(11) DEFAULT NULL,
  `ANDAR` int(11) DEFAULT NULL,
  `AREATERRENO` int(11) DEFAULT NULL,
  `AREACONSTRUIDA` int(11) DEFAULT NULL,
  `IDADEIMOVEL` int(11) DEFAULT NULL,
  `PRAZOENTREGA` int(11) DEFAULT NULL,
  `EDIFICIO` varchar(100) DEFAULT NULL,
  `CONSTRUTORA` varchar(100) DEFAULT NULL,
  `DESCRICAO` varchar(100) DEFAULT NULL,
  `VALORIPTU` decimal(18,2) DEFAULT NULL,
  `VALORCODOMINIO` decimal(18,2) DEFAULT NULL,
  `VALORPRECO` decimal(18,2) DEFAULT NULL,
  `IMAGEM1` longblob DEFAULT NULL,
  `IMAGEM2` longblob DEFAULT NULL,
  `IMAGEM3` longblob DEFAULT NULL,
  `VALORALUGUEL` decimal(18,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `imovel`
--

INSERT INTO `imovel` (`ID`, `ID_CATEGORIA`, `NOME`, `SITUACAO`, `TIPO`, `OCUPACAO`, `ID_CORRETOR`, `CIDADE`, `BAIRRO`, `NUMERO`, `ESTADO`, `COMPLEMENTO`, `PROPRIETARIO`, `LOCALCHAVE`, `ULTIMAATUALIZACAO`, `QUARTOS`, `SUITES`, `PAVIMENTO`, `GARAGEM`, `SALA`, `BANHEIRO`, `ANDAR`, `AREATERRENO`, `AREACONSTRUIDA`, `IDADEIMOVEL`, `PRAZOENTREGA`, `EDIFICIO`, `CONSTRUTORA`, `DESCRICAO`, `VALORIPTU`, `VALORCODOMINIO`, `VALORPRECO`, `IMAGEM1`, `IMAGEM2`, `IMAGEM3`, `VALORALUGUEL`) VALUES
(1, 28, 'APARTAMENTO EDIF.SALES AP2514', 'PLANO ALUGUEL', 'Comercial', 'Desocupado', 3, 'MANAUS', 'SAO JOSE', '', 'AMAZONAS', '', 'JOHNNY', 'JOHNNY', '', 2, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 'EDIFICIO SALES', 'JB CONSTRUÇÕES', '', '0.00', '0.00', '256000.00', NULL, NULL, NULL, '1000.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `parametros`
--

CREATE TABLE `parametros` (
  `ID` int(11) NOT NULL,
  `NOMEEMPRESA` varchar(200) DEFAULT NULL,
  `EMAIL` varchar(200) DEFAULT NULL,
  `SENHA` varchar(200) DEFAULT NULL,
  `porta` varchar(100) DEFAULT NULL,
  `smtp` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `receita`
--

CREATE TABLE `receita` (
  `ID` int(11) NOT NULL,
  `DESCRICAO` varchar(200) NOT NULL,
  `ID_CATEGORIA` int(11) NOT NULL,
  `DATA` date NOT NULL,
  `VALOR` decimal(18,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `receita`
--

INSERT INTO `receita` (`ID`, `DESCRICAO`, `ID_CATEGORIA`, `DATA`, `VALOR`) VALUES
(15, '', 28, '2020-01-27', '0.00'),
(17, 'acascas', 28, '2020-02-11', '0.00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuario`
--

CREATE TABLE `usuario` (
  `ID` int(11) NOT NULL,
  `NOME` varchar(200) NOT NULL,
  `LOGIN` varchar(100) NOT NULL,
  `SENHA` varchar(300) NOT NULL,
  `CARGO` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `usuario`
--

INSERT INTO `usuario` (`ID`, `NOME`, `LOGIN`, `SENHA`, `CARGO`) VALUES
(2, 'johnny do nascimento', 'admin', '123', 'operador');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `agendamento`
--
ALTER TABLE `agendamento`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `categoriadespesa`
--
ALTER TABLE `categoriadespesa`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `contrato`
--
ALTER TABLE `contrato`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `contratoimprestimo`
--
ALTER TABLE `contratoimprestimo`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `contratoimprestimoparcela`
--
ALTER TABLE `contratoimprestimoparcela`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `contratoparcelamento`
--
ALTER TABLE `contratoparcelamento`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `despesa`
--
ALTER TABLE `despesa`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `equipamento`
--
ALTER TABLE `equipamento`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `forncedor`
--
ALTER TABLE `forncedor`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `imovel`
--
ALTER TABLE `imovel`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `parametros`
--
ALTER TABLE `parametros`
  ADD PRIMARY KEY (`ID`);

--
-- Índices para tabela `receita`
--
ALTER TABLE `receita`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_CATEGORIA` (`ID_CATEGORIA`);

--
-- Índices para tabela `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `agendamento`
--
ALTER TABLE `agendamento`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=117;

--
-- AUTO_INCREMENT de tabela `categoriadespesa`
--
ALTER TABLE `categoriadespesa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT de tabela `cliente`
--
ALTER TABLE `cliente`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=117;

--
-- AUTO_INCREMENT de tabela `contrato`
--
ALTER TABLE `contrato`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=120;

--
-- AUTO_INCREMENT de tabela `contratoimprestimo`
--
ALTER TABLE `contratoimprestimo`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `contratoimprestimoparcela`
--
ALTER TABLE `contratoimprestimoparcela`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT de tabela `contratoparcelamento`
--
ALTER TABLE `contratoparcelamento`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2553;

--
-- AUTO_INCREMENT de tabela `despesa`
--
ALTER TABLE `despesa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=55;

--
-- AUTO_INCREMENT de tabela `equipamento`
--
ALTER TABLE `equipamento`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de tabela `forncedor`
--
ALTER TABLE `forncedor`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `imovel`
--
ALTER TABLE `imovel`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `parametros`
--
ALTER TABLE `parametros`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `receita`
--
ALTER TABLE `receita`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `usuario`
--
ALTER TABLE `usuario`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `receita`
--
ALTER TABLE `receita`
  ADD CONSTRAINT `receita_ibfk_1` FOREIGN KEY (`ID_CATEGORIA`) REFERENCES `categoriadespesa` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
