-> Projeto de um sistema para cadastro de óculos;

Módulos para cadastro: 
- Manter Funcionários;
- Manter Cidades;
- Manter Fornecedores;
- Manter Óculos;
- Manter Categorias;

Últimas adições é o uso de relatórios implementados por meio SGBD. 

- Projeto mais focado na implementação de recursos via SQL > 
> Uso de Triggers, Procedures, Functions e Views
> 3 Triggers, para registrar os óculos deletados em uma tabela de backup e outro para os fonecedores e por último trigger para validar CPF;
> 2 Functions, uma para calcular o valor total de óculos por categoria e outra para validar o CPF;
> 2 Views, uma para Juntar os Óculos aos fornecedores e cidades e outra para trazer os Óculos por Categoria;
> 2 Procedures, uma para Verificar o Óculos por categoria(pesquisando por nome) e outra para Verificar a idade dos funcionários do sistema; 

Script para criar o banco de dados(SQLserver):
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE DATABASE DatabaseOculos;
GO

USE DatabaseOculos;
GO

CREATE TABLE Cidades(
	idCidade INT IDENTITY(1,1),
	nomeCidade NVARCHAR(40) NOT NULL,
	nomeEstado NVARCHAR(40) NOT NULL,
	CONSTRAINT PK_CIDADES PRIMARY KEY (idCidade)
);
GO

CREATE TABLE Fornecedores(
	idFornecedor INT IDENTITY(1,1),
	idCidade INT,
	nomeFornecedor NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_FORNECEDOR PRIMARY KEY (idFornecedor),
	CONSTRAINT FK_CIDADE FOREIGN KEY (idCidade) REFERENCES Cidades(idCidade)
	ON DELETE CASCADE
);
GO 

CREATE TABLE Categorias(
	idCategoria INT IDENTITY(1,1),
	nomeCategoria NVARCHAR(30) NOT NULL
	CONSTRAINT PK_CATEGORIA PRIMARY KEY (idCategoria)
);
GO

CREATE TABLE Oculos(
	idOculos INT IDENTITY(1,1),
	idCategoria INT,
	idFornecedor INT,
	nomeOculos NVARCHAR(40) NOT NULL,
	modeloOculos NVARCHAR(40) NOT NULL,
	precoOculos MONEY NOT NULL,
	possuiGrau CHAR(1) NOT NULL,
	qtdGrau FLOAT,
	CONSTRAINT PK_OCULOS PRIMARY KEY (idOculos),
	CONSTRAINT FK_CATEGORIA FOREIGN KEY (idCategoria) REFERENCES Categorias(idCategoria),
	CONSTRAINT FK_FORNECEDOR FOREIGN KEY (idFornecedor) REFERENCES Fornecedores(idFornecedor)
	ON DELETE CASCADE
);

CREATE TABLE FornecedoresDeletados(
	idFornecedor INT,
    idCidade INT,
	nomeFornecedor NVARCHAR(50) NOT NULL,
	dataDel DATETIME DEFAULT GETDATE()
);

CREATE TABLE OculosDeletados(
	idOculos INT ,
	idCategoria INT,
	idFornecedor INT,
	nomeOculos NVARCHAR(40) NOT NULL,
	modeloOculos NVARCHAR(40) NOT NULL,
	precoOculos MONEY NOT NULL,
	possuiGrau CHAR(1) NOT NULL,
	qtdGrau FLOAT,
	dataDelete DATETIME DEFAULT GETDATE()
);


CREATE TRIGGER BACKUP_FORNECEDOR
ON Fornecedores
AFTER DELETE 
AS 
INSERT INTO fornecedoresDeletados(idFornecedor, idCidade, nomeFornecedor,dataDel)
SELECT D.idFornecedor, D.idCidade, D.nomeFornecedor, GETDATE()
FROM deleted AS D
GO

SELECT * FROM FornecedoresDeletados
GO

CREATE VIEW buscarOculosCategoria AS
SELECT Ca.idCategoria, nomeCategoria, Oc.idOculos, Oc.nomeOculos, Oc.modeloOculos FROM Oculos Oc
INNER JOIN Categorias Ca ON Ca.idCategoria = Oc.idCategoria
GO

SELECT * FROM buscarOculosCategoria
GO

DROP PROCEDURE Proc_buscarOculosPorCategoria

CREATE PROCEDURE Proc_buscarOculosPorCategoria
    @id INT
AS
BEGIN
    SELECT idCategoria, nomeCategoria, idOculos, nomeOculos, modeloOculos
    FROM buscarOculosCategoria 
    WHERE idCategoria = @id;
END;
GO

EXEC Proc_buscarOculosPorCategoria @id = 3;
GO

SELECT * FROM Oculos

CREATE FUNCTION Fun_SomaOculosPorCategoria(@nomeCategoria NVARCHAR(50))
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @Soma DECIMAL(10,2);
	DECLARE @nomeCat NVARCHAR(30);

    SELECT @Soma = SUM(precoOculos)
    FROM Oculos Oc
    INNER JOIN Categorias Ca ON Ca.idCategoria = Oc.idCategoria
    WHERE Ca.nomeCategoria LIKE '%' + @nomeCategoria + '%';

    RETURN ISNULL(@Soma, 0);
END;
GO


SELECT dbo.Fun_SomaOculosPorCategoria('Esp') AS 'Preço total Categoria';
GO


CREATE TRIGGER BACKUP_OCULOS	
ON Oculos
AFTER DELETE 
AS 
INSERT INTO OculosDeletados(idOculos, idCategoria, idFornecedor, nomeOculos, modeloOculos, precoOculos, possuiGrau, qtdGrau, dataDelete)
SELECT D.idOculos, D.idCategoria, D.idFornecedor, D.nomeOculos, D.modeloOculos, D.precoOculos, D.possuiGrau, D.qtdGrau, GETDATE()
FROM deleted AS D
GO

SELECT * FROM OculosDeletados
GO

CREATE TABLE funcionarios(
	idFunc INT IDENTITY(1,1),
	nomeFunc NVARCHAR(60) NOT NULL,
	dataNascimento DATE NOT NULL,
	cpfFunc NVARCHAR(14) NOT NULL, 
	dataEntradaEmpresa DATE NOT NULL
	CONSTRAINT PK_FUNCIONARIO PRIMARY KEY (idFunc)
);
GO

ALTER TABLE funcionarios 
ADD CONSTRAINT UQ_CPF UNIQUE (cpfFunc);
GO

SELECT fun.nomeFunc, fun.dataNascimento,
       CAST(DATEDIFF(YEAR, fun.dataNascimento, GETDATE()) AS VARCHAR) + ' anos, ' +
       CAST(DATEDIFF(MONTH, fun.dataNascimento, GETDATE()) % 12 AS VARCHAR) + ' meses, ' +
       CAST(DATEDIFF(DAY, DATEADD(MONTH, DATEDIFF(MONTH, fun.dataNascimento, GETDATE()), fun.dataNascimento), GETDATE()) AS VARCHAR) + ' dias' AS tempo_desde_cadastro
FROM funcionarios fun 
WHERE fun.nomeFunc LIKE '%Jor%';


CREATE PROCEDURE Proc_CalcularTempoDeCadastro
@nomeFunc NVARCHAR(60)
AS
BEGIN 
	SET NOCOUNT ON;
	SELECT fun.nomeFunc, fun.dataNascimento,
       CAST(DATEDIFF(YEAR, fun.dataNascimento, GETDATE()) AS VARCHAR) + ' anos, ' +
       CAST(DATEDIFF(MONTH, fun.dataNascimento, GETDATE()) % 12 AS VARCHAR) + ' meses, ' +
       CAST(DATEDIFF(DAY, DATEADD(MONTH, DATEDIFF(MONTH, fun.dataNascimento, GETDATE()), fun.dataNascimento), GETDATE()) AS VARCHAR) + ' dias' AS tempo_desde_cadastro
	FROM funcionarios fun 
	WHERE fun.nomeFunc LIKE '%' + @nomeFunc + '%';
END;
GO

EXEC Proc_CalcularTempoDeCadastro @nomeFunc = 'Juuca'


CREATE VIEW Vw_OculosPorFonecedorCidade
AS
SELECT Oc.idOculos, Oc.nomeOculos, Oc.modeloOculos, forn.nomeFornecedor, Cid.nomeCidade, Cid.nomeEstado FROM Oculos Oc
INNER JOIN Fornecedores forn ON forn.idFornecedor = Oc.idFornecedor
INNER JOIN Cidades cid ON cid.idCidade = forn.idCidade 

CREATE FUNCTION Func_valida_CPF(@cpf VARCHAR(14))
RETURNS BIT
AS
BEGIN
    DECLARE @cpf_limp VARCHAR(11);
    DECLARE @soma1 INT = 0, @soma2 INT = 0;
    DECLARE @resto1 INT, @resto2 INT;
    DECLARE @digito1 INT, @digito2 INT;
    DECLARE @i INT;

    SET @cpf_limp = REPLACE(REPLACE(REPLACE(@cpf, '.', ''), '-', ''), ' ', '');

    IF LEN(@cpf_limp) != 11
        RETURN 0;

    IF @cpf_limp = REPLICATE(SUBSTRING(@cpf_limp, 1, 1), 11)
        RETURN 0;

    SET @i = 1;
    WHILE @i <= 9
    BEGIN
        SET @soma1 = @soma1 + CAST(SUBSTRING(@cpf_limp, @i, 1) AS INT) * (11 - @i);
        SET @i = @i + 1;
    END

    SET @resto1 = @soma1 % 11;
    SET @digito1 = CASE WHEN @resto1 < 2 THEN 0 ELSE 11 - @resto1 END;

    SET @i = 1;
    WHILE @i <= 10
    BEGIN
        SET @soma2 = @soma2 + CAST(SUBSTRING(@cpf_limp, @i, 1) AS INT) * (12 - @i);
        SET @i = @i + 1;
    END

    SET @resto2 = @soma2 % 11;
    SET @digito2 = CASE WHEN @resto2 < 2 THEN 0 ELSE 11 - @resto2 END;

    IF @digito1 != CAST(SUBSTRING(@cpf_limp, 10, 1) AS INT) OR @digito2 != CAST(SUBSTRING(@cpf_limp, 11, 1) AS INT)
        RETURN 0;

    RETURN 1;
END;


CREATE TRIGGER Tg_validar_cpf
ON funcionarios
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted WHERE dbo.Func_valida_CPF(cpfFunc) = 0)
    BEGIN
        RAISERROR ('CPF inválido', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;


insert into funcionarios(nomeFunc, dataNascimento, cpfFunc, dataEntradaEmpresa)
values ('Gilberto Riosiono', '19/03/2000','042.154.750-23','20/06/2024');


SELECT f.nomeFunc, f.dataNascimento, f.cpfFuncm, f.dataEntradaEmpresa FROM funcionarios f WHERE f.idFunc = 4; 
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Atividade implementada para as disciplinas envolvendo banco de dados nos semestres 3 e 4. 
Direitos da aplicação reservados a @Eduardo_Henrique_Meneghetti
