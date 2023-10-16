/*
** Login 28/08/2023
*/
CREATE DATABASE Sistema;
USE Sistema;

CREATE TABLE Usuario(
	codigo INT IDENTITY(1,1),
	usuario VARCHAR(20),
	senha VARCHAR(32),
	PRIMARY KEY (codigo)
)

/* Alterações acima feitas em 28/08/2023 */
select * from Funcionario
CREATE TABLE Empresa(
    codigo_empresa INT IDENTITY(1,1),
    nome VARCHAR(30),
    CNPJ VARCHAR(18),
    CEP VARCHAR(9),
    rua VARCHAR(30),
    numero INT,
    complemento VARCHAR(12),
    bairro VARCHAR(30),
    estado CHAR(2),
    municipio VARCHAR(30),
    pais INT,
    telefone VARCHAR(14),
    PRIMARY KEY (codigo_empresa)
)

select * from Funcionario
CREATE TABLE Funcionario(
    codigo_funcionario INT IDENTITY(1,1),
    empresa INT,
    nome VARCHAR(20),
    data_nascimento DATE,
    estado_civil INT,
    sexo CHAR,
    email VARCHAR(60),
	celular VARCHAR(11),
    CPF VARCHAR(14),
    RG VARCHAR(12),
    CTPS VARCHAR(15), 
    CEP VARCHAR(9),
    rua VARCHAR(30),
    numero INT,
    complemento VARCHAR(12),
    bairro VARCHAR(30),
    municipio VARCHAR(30),
    estado CHAR(2),
    pais INT,
    cargo VARCHAR(30), /*Alterar para int e criar tabela de cargos*/
	setor VARCHAR(30), /*Alterar para int e criar tabela de setores*/
    tipo_contrato INT,
    salario DECIMAL(10,2),
    jornada INT,
    situacao CHAR,
    data_admissao DATE,
    data_demissao DATE,
    PRIMARY KEY (codigo_funcionario),
    FOREIGN KEY (empresa) REFERENCES empresa(codigo_empresa)
)

CREATE TABLE Estado_Civil(
	codigo INT,
	valor VARCHAR(30),
	PRIMARY KEY (codigo),
)

CREATE TABLE Marcacao_Ponto(
    codigo_ponto INT IDENTITY(1,1),
    funcionario INT,
    data_ponto DATE,
    entrada1 CHAR,
    saida1 CHAR,
    entrada2 CHAR,
    saida2 CHAR,
    PRIMARY KEY (codigo_marcacao_ponto),
    FOREIGN KEY (funcionario) REFERENCES funcionario(codigo_funcionario)
)

CREATE TABLE Desconto(
    codigo_desconto INT IDENTITY(1,1),
    funcionario INT,
    descricao VARCHAR(30),
    tipo_desconto INT,
    desconto INT,
    PRIMARY KEY (codigo_desconto),
    FOREIGN KEY (funcionario) REFERENCES funcionario(codigo_funcionario)
)

CREATE TABLE Setor(
    codigo_setor INT IDENTITY(1,1),
    nome VARCHAR(30),
    PRIMARY KEY (codigo_setor)
)

CREATE TABLE Cargo(
    codigo_cargo INT IDENTITY(1,1),
    nome VARCHAR(30),
    PRIMARY KEY (codigo_cargo)
)

CREATE TABLE Tipo_Contrato(
    codigo_tipo_contrato INT IDENTITY(1,1),
    nome VARCHAR(30),
    PRIMARY KEY (codigo_tipo_contrato)
)

CREATE TABLE Grau_Instrucao(
    codigo_grau_instrução INT IDENTITY(1,1),
    nome VARCHAR(30),
    PRIMARY KEY (codigo_grau_instrução)
)

CREATE TABLE Estado_Civil(
    codigo_estado_civil INT IDENTITY(1,1),
    descricao VARCHAR(30),
    PRIMARY KEY (codigo_estado_civil)
)

CREATE TABLE Situação(
    codigo_situação INT IDENTITY(1,1),
    descricao VARCHAR(30),
    PRIMARY KEY (codigo_situação)
)

CREATE TABLE estados(
    codigo_estado INT IDENTITY(1,1),
    nome VARCHAR(30),
    sigla CHAR(2),
    PRIMARY KEY (codigo_estado)
)
CREATE TABLE pais(
    codigo_pais INT IDENTITY(1,1),
    nome VARCHAR(30),
    PRIMARY KEY (codigo_pais)
)

CREATE TABLE situacao(
    codigo_situacao INT IDENTITY(1,1),
    descricao VARCHAR(30),
    PRIMARY KEY (codigo_situacao)
)








/* INSERÇÕES DE TESTE NA TABELA EMPRESA */
INSERT INTO Empresa(nome,CNPJ,CEP,rua,numero,complemento,bairro,municipio,estado,pais,telefone)
Values('Empresa Açucar Ltda.','12345678900001','12345-678','Av. Principal',123,'Sala 1','Centro','São Paulo','SP',1,'(11)1234-5678')

INSERT INTO Empresa(nome,CNPJ,CEP,rua,número,complemento,bairro,estado,pais,telefone)
Values('Empresa Pão S.A.','98765432100001','54321-876','Rua das Flores',456,'Andar 5','Jardim Botânico','Rio de Janeiro','Brasil','(21)98765432')

INSERT INTO Empresa(nome,CNPJ,CEP,rua,número,complemento,bairro,estado,pais,telefone)
Values('Empresa 123 Investimentos Ltda.','55555555500001','22222-333','Rua das Palmeiras',789,'Torre A, 10º andar','Alphaville','São Paulo','Brasil','(11)98765432')

/* CONSULTA NA TABELA EMPRESA DEVE RETORNAR OS 3 REGISTROS INSERIDOS ANTERIORMENTE */

SELECT nome,CNPJ,CEP,rua,numero,complemento,bairro,estado,pais,telefone FROM Empresa


/* INSERÇÕES DE TESTE NA TABELA FUNCIONARIO */
INSERT INTO Funcionario(empresa,nome,data_nascimento,sexo,email,CPF,CEP,celular,cargo,salario)
Values(1,'Maria Silva','15/05/1985','F','maria.silva@example.com','123.456.789-00','12345-678','(11)987654321','Analista de Recursos Humanos','4500.00')

INSERT INTO Funcionario(empresa,nome,data_nascimento,sexo,email,CPF,CEP,celular,cargo,salario)
Values(1,'Pedro Santos','10/11/1990','M','pedro.santos@example.com','987.654.321-00','54321-876','(21)123456789','Engenheiro de Software','7200.00')

INSERT INTO Funcionario(empresa,nome,data_nascimento,sexo,email,CPF,CEP,celular,cargo,salario)
Values(1,'Ana Pereira','25/08/1988','F','ana.pereira@example.com','555.555.555-00','22222-333','(11)876543210','Assistente Administrativo','3200.00')


/* CONSULTA NA TABELA DE FUNCIONARIO */
SELECT * FROM Funcionario WHERE codigo_funcionario = 2 or codigo_funcionario = 2002

/* INSERÇÕES PARA A TABELA ESTADO_CIVIL */
INSERT INTO Estado_Civil(codigo,valor) VALUES(0,'Solteiro(a)')
INSERT INTO Estado_Civil(codigo,valor) VALUES(1,'Casado(a)')
INSERT INTO Estado_Civil(codigo,valor) VALUES(2,'Divorciado(a)')
INSERT INTO Estado_Civil(codigo,valor) VALUES(3,'Viuvo(a)')

SELECT * FROM Estado_Civil

/* CONSULTA NA TABELA FUNCIONARIO DEVE RETORNAR OS 3 REGISTROS INSERIDOS ANTERIORMENTE */

SELECT empresa,nome,data_nascimento,sexo,email,CPF,CEP,celular,cargo,salario FROM Funcionario