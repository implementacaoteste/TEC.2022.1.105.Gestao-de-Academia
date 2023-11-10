USE master
GO

IF(EXISTS(SELECT 1 FROM master.sys.databases WHERE name = 'Academia'))
ALTER DATABASE Academia SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO

IF(EXISTS(SELECT 1 FROM master.sys.databases WHERE name = 'Academia'))
DROP DATABASE Academia
GO

CREATE DATABASE GestaoDeAcademia
GO

USE GestaoDeAcademia
GO

IF OBJECT_ID('Usuario', 'U') IS NULL
CREATE TABLE Usuario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100),
	NomeUsuario VARCHAR(50),
	Email VARCHAR(60),
	CPF VARCHAR(15),
	Ativo BIT,
	Senha VARCHAR(50)
)
GO

IF OBJECT_ID('GrupoUsuario', 'U') IS NULL
CREATE TABLE GrupoUsuario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	NomeGrupo VARCHAR(150)
)
GO

IF OBJECT_ID('Permissao', 'U') IS NULL
CREATE TABLE Permissao
(
	Id INT PRIMARY KEY,
	Descricao VARCHAR(250)
)
GO

IF OBJECT_ID('UsuarioGrupoUsuario', 'U') IS NULL
CREATE TABLE UsuarioGrupoUsuario
(
	IdUsuario INT,
	IdGrupoUsuario INT,
	CONSTRAINT PK_UsuarioGrupoUsuario PRIMARY KEY (IdUsuario, IdGrupoUsuario)
)
GO

IF OBJECT_ID('PermissaoGrupoUsuario', 'U') IS NULL
CREATE TABLE PermissaoGrupoUsuario
(
	IdPermissao INT,
	IdGrupoUsuario INT,
	CONSTRAINT PK_PermissaoGrupoUsuario PRIMARY KEY (IdPermissao, IdGrupoUsuario)
)
GO
CREATE TABLE Cliente
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100),
	Aluno BIT,
	CPF CHAR(14),
	Telefone CHAR(14),
	Email VARCHAR(60),
	Endereco VARCHAR(100),
	DataCadastro SMALLDATETIME
)
GO
CREATE TABLE Fornecedor
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100),
	CpfCnpj VARCHAR(15),
	Email VARCHAR(200),
	Telefone CHAR(14),
	Endereco VARCHAR(100)
)
GO

CREATE TABLE Produto
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100),
	Marca VARCHAR(30),
	Preco FLOAT,
	Quantidade INT,
	CodigoDeBarras VARCHAR(20)
)
GO
CREATE TABLE Venda
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	funcionarioId INT,
	ClienteId INT,
	DataVenda SMALLDATETIME,
	TotalVenda FLOAT
)
GO
CREATE TABLE Venda_Direta
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FuncionarioId INT,
	ProdutoId INT,
	NomeProduto VARCHAR(100),
	Quantidade INT,
	PrecoUnitario FLOAT,
	DataVenda SMALLDATETIME,
	PrecoTotal FLOAT
)
GO
CREATE TABLE Itens_Venda
(
	VendaId INT,
	ProdutoId INT,
	Quantidade INT,
	PrecoUnitario FLOAT,
	PrecoTotal FLOAT
)
GO
CREATE TABLE Financas
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FormaPagamento VARCHAR(30),
	ValorTransacao FLOAT,
	DescricaoTransacao VARCHAR(200),
	DataFinanca SMALLDATETIME,
	Fornecedor VARCHAR(100),
	Cliente VARCHAR(100),
	NumeroDoDocumento INT,
	ImpostosPagos FLOAT,
	RetencaoDeImposto FLOAT,
	Conta FLOAT,
	Saldo FLOAT
)
GO
CREATE TABLE Controle_Debito
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ClienteId INT,
	Estatus BIT,
	ValorDebito FLOAT,
	FormaPagamento VARCHAR(30),
	DataLancamento SMALLDATETIME,
	DataVencimento SMALLDATETIME,
	DataPagamento SMALLDATETIME
	
)
GO
CREATE TABLE Exercicios
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome Varchar(20)
)
GO
CREATE TABLE PlanoAssinatura
(
 Id INT PRIMARY KEY IDENTITY(1,1),
 TipoPlano VARCHAR(15),
 ValorPlano FLOAT,
 Desconto FLOAT
)
GO
CREATE TABLE PagamentoAluno
(
 Id INT PRIMARY KEY IDENTITY(1,1),
 AlunoId INT,
 PlanoAssinaturaId INT,
 Debitado BIT
)
GO
CREATE TABLE PagamentoFuncionario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FuncionarioId Int,
	Valor FLOAT,
	Desconto FLOAT,
	HoraExtra INT
)
GO
CREATE TABLE Funcionario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100),
	CPF CHAR(14),
	Telefone CHAR(14),
	Email VARCHAR(60),
	Endereco VARCHAR(100),
)
GO
CREATE TABLE ControleEstoque
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ProdutoId INT,
	DataEntrada SMALLDATETIME,
	DataSaida SMALLDATETIME,
	Quantidade FLOAT,
	SaldoTotal FLOAT
)
GO

ALTER TABLE Venda
ADD CONSTRAINT FK_Venda_Funcionario
FOREIGN KEY (FuncionarioId)
REFERENCES Funcionario(Id);
GO

ALTER TABLE Venda
ADD CONSTRAINT FK_Venda_Cliente
FOREIGN KEY (ClienteId)
REFERENCES Cliente(Id);
GO

ALTER TABLE Venda_Direta
ADD CONSTRAINT FK_VendaDireta_Funcionario
FOREIGN KEY (FuncionarioId)
REFERENCES Funcionario(Id);
GO

ALTER TABLE Venda_Direta
ADD CONSTRAINT FK_VendaDireta_Produto
FOREIGN KEY (ProdutoId)
REFERENCES Produto(Id);
GO

ALTER TABLE Itens_Venda
ADD CONSTRAINT FK_ItensVenda_Venda
FOREIGN KEY (VendaId)
REFERENCES Venda(Id);

ALTER TABLE Itens_Venda
ADD CONSTRAINT FK_ItensVenda_Produto
FOREIGN KEY (ProdutoId)
REFERENCES Produto(Id);
GO

ALTER TABLE Financas
ADD CONSTRAINT FK_Financas_Fornecedor
FOREIGN KEY (Fornecedor)
REFERENCES Fornecedor(Nome);
GO

ALTER TABLE Financas
ADD CONSTRAINT FK_Financas_Cliente
FOREIGN KEY (Cliente)
REFERENCES Cliente(Nome);
GO

ALTER TABLE Controle_Debito
ADD CONSTRAINT FK_ControleDebito_Cliente
FOREIGN KEY (ClienteId)
REFERENCES Cliente(Id);
GO

ALTER TABLE PagamentoAluno
ADD CONSTRAINT FK_PagamentoAluno_Aluno
FOREIGN KEY (AlunoId)
REFERENCES Cliente(Id);
GO

ALTER TABLE PagamentoAluno
ADD CONSTRAINT FK_PagamentoAluno_PlanoAssinatura
FOREIGN KEY (PlanoAssinaturaId)
REFERENCES PlanoAssinatura(Id);
GO

ALTER TABLE PagamentoFuncionario
ADD CONSTRAINT FK_PagamentoFuncionario_Funcionario
FOREIGN KEY (FuncionarioId)
REFERENCES Funcionario(Id);
GO

ALTER TABLE ControleEstoque
ADD CONSTRAINT FK_ControleEstoque_Produto
FOREIGN KEY (ProdutoId)
REFERENCES Produto(Id);
GO

IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE object_id = OBJECT_ID('Usuario') AND IS_PRIMARY_KEY = 1)
ALTER TABLE Usuario ADD CONSTRAINT PK_Usuario PRIMARY KEY (Id)

GO
IF NOT EXISTS (SELECT 1 FROM SYS.INDEXES WHERE object_id = OBJECT_ID('PermissaoGrupoUsuario') AND IS_PRIMARY_KEY = 1)
ALTER TABLE PermissaoGrupoUsuario ADD CONSTRAINT PK_PermissaoGrupoUsuario PRIMARY KEY (IdPermissao, IdGrupoUsuario)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('UsuarioGrupoUsuario') AND name = 'FK_UsuarioGrupoUsuario_Usuario')
ALTER TABLE UsuarioGrupoUsuario
ADD CONSTRAINT FK_UsuarioGrupoUsuario_Usuario
FOREIGN KEY (IdUsuario) REFERENCES Usuario(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('UsuarioGrupoUsuario') AND name = 'FK_UsuarioGrupoUsuario_GrupoUsuario')
ALTER TABLE UsuarioGrupoUsuario
ADD CONSTRAINT FK_UsuarioGrupoUsuario_GrupoUsuario
FOREIGN KEY (IdGrupoUsuario) REFERENCES GrupoUsuario(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('PermissaoGrupoUsuario') AND name = 'FK_PermissaoGrupoUsuario_Permissao')
ALTER TABLE PermissaoGrupoUsuario
ADD CONSTRAINT FK_PermissaoGrupoUsuario_Permissao
FOREIGN KEY (IdPermissao) REFERENCES Permissao(Id)

GO

IF NOT EXISTS (SELECT 1 FROM SYS.FOREIGN_KEYS WHERE PARENT_OBJECT_ID = OBJECT_ID('PermissaoGrupoUsuario') AND name = 'FK_PermissaoGrupoUsuario_GrupoUsuario')
ALTER TABLE PermissaoGrupoUsuario
ADD CONSTRAINT FK_PermissaoGrupoUsuario_GrupoUsuario
FOREIGN KEY (IdGrupoUsuario) REFERENCES GrupoUsuario(Id)

GO

IF COL_LENGTH('Usuario', 'DataCadastro') IS NULL
ALTER TABLE Usuario ADD DataCadastro DATETIME DEFAULT GETDATE()

GO

IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 1))INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 2))INSERT INTO Permissao(Id, Descricao)VALUES(2,'Cadastrar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 3))INSERT INTO Permissao(Id, Descricao)VALUES(3,'Alterar usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 4))INSERT INTO Permissao(Id, Descricao)VALUES(4,'Excluir usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 5))INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 6))INSERT INTO Permissao(Id, Descricao)VALUES(6,'Cadastrar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 7))INSERT INTO Permissao(Id, Descricao)VALUES(7,'Alterar grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 8))INSERT INTO Permissao(Id, Descricao)VALUES(8,'Excluir grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 9))INSERT INTO Permissao(Id, Descricao)VALUES(9,'Adicionar permissão a um grupo de usuário')
IF(NOT EXISTS(SELECT 1 FROM Permissao WHERE Id = 10))INSERT INTO Permissao(Id, Descricao)VALUES(10,'Adicionar grupo de usuário a um usuário')
GO

IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Adm'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Administrador da Silva', 'Adm', '123', 1)
IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Geno'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Genoveva', 'Geno', '123', 1)
IF(NOT EXISTS(SELECT 1 FROM Usuario WHERE NomeUsuario = 'Dag'))INSERT INTO Usuario(Nome, NomeUsuario, Senha, Ativo)VALUES('Dagorlina', 'Dag', '123', 1)
GO

INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Gerente')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Vendedor')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Fiscal de caixa')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Estoquista')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Operador de caixa')

GO
INSERT INTO UsuarioGrupoUsuario VALUES(2,1)
INSERT INTO UsuarioGrupoUsuario VALUES(1,2)
GO

INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(3,1)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(3,2)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(3,5)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(4,2)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(4,1)
INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(4,5)
GO

INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)(SELECT 1, Id FROM Permissao)
GO
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 1)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 2)
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)VALUES(2, 3)
GO


select*from Usuario