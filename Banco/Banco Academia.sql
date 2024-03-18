﻿USE master
GO
ALTER DATABASE GestaoDeAcademia SET SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
DROP DATABASE GestaoDeAcademia
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
	CPF VARCHAR(15) UNIQUE,
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
	CPF CHAR(14) UNIQUE,
	Telefone CHAR(14),
	Email VARCHAR(60),
	Endereco VARCHAR(100),
	DataCadastro DATETIME
)
GO
CREATE TABLE Fornecedor
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100),
	CpfCnpj VARCHAR(15) UNIQUE,
	Email VARCHAR(200),
	Telefone CHAR(14),
	Endereco VARCHAR(100),
	Descricao VARCHAR(150),
	TipoDeMoedaId INT,
	TipoContaId INT,
	FornecedorId INT,
	NomeBanco VARCHAR(50),
	NumeroAgencia VARCHAR(6),
	NumeroConta VARCHAR(21),
	ChavePix VARCHAR(32),
	NomeTitular VARCHAR(100),
	Iban VARCHAR(34),
	Obs VARCHAR(100)
)
GO
CREATE TABLE CompraProduto
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	DataCompra DateTime,
	FornecedorId INT,
	FormaPagamentoId INT,
	ValorTotal FLOAT,
	FreteTotal Float 
)
GO
CREATE TABLE ItensCompra
(
	Id Int Primary key identity(1,1),
	CompraProdutoId INT,
	ProdutoId int,
	Marca VARCHAR(100),
	Quantidade INT,
	ValorFrete Float,
	ValorUnitario FLOAT,
	ValorTotal FLOAT
)
GO
CREATE TABLE Produto
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome Varchar(150),
	Marca VARCHAR(100),
	Preco FLOAT,
	QuantidadeEstoque int,
	CodigoDeBarras VARCHAR(20)
)
GO
CREATE TABLE Venda
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	UsuarioId INT,
	FormaPagamentoId INT,
	ClienteId INT,
	DataVenda DATETIME,
	TotalVenda FLOAT
)
GO
CREATE TABLE ItensVenda
(
	VendaId INT,
	ProdutoId INT,
	Quantidade INT,
	PrecoUnitario FLOAT,
	PrecoTotal FLOAT
)
/*GO
CREATE TABLE Financas
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	NumeroDoDocumento INT,
	FornecedorId INT,
	FormaPagamentoId INT,
	ValorTransacao FLOAT,
	Descricao VARCHAR(200),
	DataFinanca DATETIME,
	ImpostosPagos FLOAT,
	RetencaoDeImposto FLOAT,
	Conta FLOAT,
	Saldo FLOAT
)*/
GO
CREATE TABLE ControleDebito
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	ClienteId INT,
	FormaPagamentoId INT,
	ValorDebito FLOAT,
	DataLancamento DATETIME,
	DataVencimento DATETIME,
	DataPagamento DATETIME,
	Juros FLOAT,
	Desconto FLOAT,
	Acrescimo FLOAT	
)
GO
CREATE TABLE FormaPagamento
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(200)
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
 FormaPagamentoId INT,
 Debitado BIT
)
GO
CREATE TABLE PagamentoFuncionario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	FuncionarioId Int,
	FormaPagamentoId INT,
	Valor FLOAT,
	Desconto FLOAT,
	HoraExtra INT
)
GO
CREATE TABLE Funcionario
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome VARCHAR(100),
	CPF CHAR(14) UNIQUE,
	Cargo Varchar(20),
	Telefone CHAR(14),
	Email VARCHAR(60),
	Endereco VARCHAR(100),
)
GO
CREATE TABLE TipoDeConta
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	TipoConta VARCHAR(20)
)
GO
CREATE  TABLE TipoDeMoeda
(
	Id INT PRIMARY KEY IDENTITY(1,1),
	TipoMoeda VARCHAR(10)
)
GO

ALTER TABLE Venda
ADD CONSTRAINT FK_Venda_FormaPagamento
FOREIGN KEY (FormaPagamentoId)
REFERENCES FormaPagamento(Id);
/*GO
ALTER TABLE Financas
ADD CONSTRAINT FK_Financas_FormaPagamento 
FOREIGN KEY (FormaPagamentoId)
REFERENCES FormaPagamento(Id);*/
GO
ALTER TABLE PagamentoAluno
ADD CONSTRAINT FK_PagamentoAluno_FormaPagamento
FOREIGN KEY (FormaPagamentoId)
REFERENCES FormaPagamento(Id);
GO
ALTER TABLE PagamentoFuncionario
ADD CONSTRAINT FK_PagamentoFuncionario_FormaPagamento
FOREIGN KEY (FormaPagamentoId)
REFERENCES FormaPagamento(Id);
GO
ALTER TABLE ControleDebito
ADD CONSTRAINT FK_ControleDebito_FormaPagamento
FOREIGN KEY (FormaPagamentoId)
REFERENCES FormaPagamento(Id);
GO
ALTER TABLE ControleDebito
ADD CONSTRAINT FK_ControleDebito_Cliente
FOREIGN KEY (ClienteId)
REFERENCES Cliente(Id);
GO
ALTER TABLE CompraProduto
ADD CONSTRAINT FK_Compra_FormaPagamento
FOREIGN KEY (FormaPagamentoId)
REFERENCES FormaPagamento(Id);
GO
ALTER TABLE CompraProduto
ADD CONSTRAINT FK_Fornecedor_CompraProduto
FOREIGN KEY (FornecedorId)
REFERENCES Fornecedor(Id);
GO
ALTER TABLE ItensCompra
ADD CONSTRAINT FK_ItensCompra_Produto
FOREIGN KEY (ProdutoId)
REFERENCES Produto(Id);
GO
ALTER TABLE ItensCompra
ADD CONSTRAINT FK_ItensCompra_CompraProduto
FOREIGN KEY (CompraProdutoId)
REFERENCES CompraProduto(Id);
/*GO
ALTER TABLE Financas
ADD CONSTRAINT FK_Fornecedor_Financas
FOREIGN KEY (FornecedorId)
REFERENCES Fornecedor(ID)*/
GO
ALTER TABLE Venda
ADD CONSTRAINT FK_Venda_Usuario
FOREIGN KEY (UsuarioId)
REFERENCES Usuario(Id);
GO
ALTER TABLE Venda
ADD CONSTRAINT FK_Venda_Cliente FOREIGN KEY (ClienteId)
REFERENCES Cliente(Id)
ON DELETE SET NULL;
GO
ALTER TABLE ItensVenda
ADD CONSTRAINT FK_ItensVenda_Venda
FOREIGN KEY (VendaId)
REFERENCES Venda(Id);
GO
ALTER TABLE ItensVenda
ADD CONSTRAINT FK_ItensVenda_Produto
FOREIGN KEY (ProdutoId)
REFERENCES Produto(Id);
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
--
ALTER TABLE Fornecedor
ADD Rua VARCHAR(100)
GO

ALTER TABLE Fornecedor
ADD CEP VARCHAR(100)
GO

ALTER TABLE Fornecedor
ADD Bairro VARCHAR(100)
GO

ALTER TABLE Fornecedor
ADD Complemento VARCHAR(100)
GO

ALTER TABLE Fornecedor
ADD NumeroCasa INT
GO

ALTER TABLE Fornecedor
DROP COLUMN Endereco
GO

ALTER TABLE Fornecedor
ALTER COLUMN CEP VARCHAR(9)
GO

ALTER TABLE Fornecedor
ADD Pais VARCHAR(50)
GO

ALTER TABLE Fornecedor
ADD Cidade VARCHAR(50)
GO

ALTER TABLE Fornecedor
ADD Estado VARCHAR(100)
GO

ALTER TABLE Fornecedor
ALTER COLUMN Estado VARCHAR(50)
GO
--
ALTER TABLE Funcionario
ADD Rua VARCHAR(100)
GO

ALTER TABLE Funcionario
ADD CEP VARCHAR(100)
GO

ALTER TABLE Funcionario
ADD Bairro VARCHAR(100)
GO

ALTER TABLE Funcionario
ADD Complemento VARCHAR(100)
GO

ALTER TABLE Funcionario
ADD NumeroCasa INT
GO

ALTER TABLE Funcionario
DROP COLUMN Endereco
GO

ALTER TABLE Funcionario
ALTER COLUMN CEP VARCHAR(9)
GO

ALTER TABLE Funcionario
ADD Pais VARCHAR(50)
GO

ALTER TABLE Funcionario
ADD Cidade VARCHAR(50)
GO

ALTER TABLE Funcionario
ADD Estado VARCHAR(100)
GO

ALTER TABLE Funcionario
ALTER COLUMN Estado VARCHAR(50)
GO
--
ALTER TABLE Cliente
ADD Rua VARCHAR(100)
GO

ALTER TABLE Cliente
ADD CEP VARCHAR(100)
GO

ALTER TABLE Cliente
ADD Bairro VARCHAR(100)
GO

ALTER TABLE Cliente
ADD Complemento VARCHAR(100)
GO

ALTER TABLE Cliente
ADD NumeroCasa INT
GO

ALTER TABLE Cliente
DROP COLUMN Endereco
GO

ALTER TABLE Cliente
ALTER COLUMN CEP VARCHAR(9)
GO

ALTER TABLE Cliente
ADD Pais VARCHAR(50)
GO

ALTER TABLE Cliente
ADD Cidade VARCHAR(50)
GO

ALTER TABLE Cliente
ADD Estado VARCHAR(100)
GO

ALTER TABLE Cliente
ALTER COLUMN Estado VARCHAR(50)
GO
--
ALTER TABLE ControleDebito
ADD Descricao VARCHAR(200)
GO
--
ALTER TABLE FormaPagamento
ADD QuantidadeParcelas INT
GO
ALTER TABLE PlanoAssinatura
ADD Total FLOAT
GO
--
ALTER TABLE Venda
ADD Desconto FLOAT
GO
--
Alter Table ItensCompra
Drop column ValorFrete 
GO
--
ALter table CompraProduto
ADD ValorTotalNota Float
Go
--
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
GO
INSERT INTO Usuario (Nome, NomeUsuario, Email, CPF, Ativo, Senha, DataCadastro)values('Robson Souza','Rob','rob@gmail.com','00236512547',1,'123',getdate())
INSERT INTO Usuario (Nome, NomeUsuario, Email, CPF, Ativo, Senha, DataCadastro)values('Guilherme','Gui','Gui@gmail.com','00399892788',1,'123',getdate())
GO
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Gerente')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Vendedor')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Instrutor')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Estoquista')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Financeiro')
INSERT INTO GrupoUsuario(NomeGrupo)VALUES('Administrador')
GO
INSERT INTO UsuarioGrupoUsuario VALUES(2,2)
INSERT INTO UsuarioGrupoUsuario VALUES(3,1)
INSERT INTO UsuarioGrupoUsuario VALUES(1,6)
GO
--INSERT INTO PermissaoGrupoUsuario(IdGrupoUsuario, IdPermissao) VALUES(1,1)
GO
INSERT INTO PermissaoGrupoUsuario (IdGrupoUsuario, IdPermissao)(SELECT 6, Id FROM Permissao)
GO
INSERT INTO Cliente VALUES('Eloísa',1, '07790087655','(63)99124-9261','genism355@gmail.com',GETDATE(),'Magman','0987654','Lipídios',null,'107','Brasil', 'São Juares', 'Mato Fino')
INSERT INTO Cliente VALUES('Francisco',1, '012309371231','(63)99124-8899','clovis90@gmail.com',GETDATE(),'Milan','09665554','ragnar',null,'097','França', 'Rumiehe', 'Bonjuk')
GO
CREATE TRIGGER ATUALIZAR_ESTOQUE
ON ItensCompra
AFTER INSERT
AS
BEGIN
DECLARE @QUANTIDADE INT
DECLARE	@PRODUTOID INT
    SELECT @PRODUTOID = PRODUTOID, @QUANTIDADE = QUANTIDADE FROM inserted

    UPDATE Produto SET QuantidadeEstoque = QuantidadeEstoque + @QUANTIDADE WHERE Id = @PRODUTOID
END
GO
EXEC sp_rename 'dbo.Fornecedor.TipoContaId', 'TipoDeContaId', 'COLUMN';
GO
SELECT*FROM Usuario
SELECT*FROM UsuarioGrupoUsuario
SELECT*FROM GrupoUsuario
SELECT*FROM Permissao
SELECT*FROM ControleDebito
GO
