CREATE DATABASE miniERP;

USE miniERP;

-- CREATE USER adonet FROM LOGIN adonet;

EXEC sp_addrolemember 'DB_DATAREADER', 'adonet';

EXEC sp_addrolemember 'DB_DATAWRITER', 'adonet';

IF OBJECT_ID(N'fornecedores', N'U') IS NULL
CREATE TABLE fornecedores
(
    ID INTEGER PRIMARY KEY IDENTITY,
    CNPJ VARCHAR(14) UNIQUE NOT NULL,
    RazaoSocial VARCHAR(50) UNIQUE NOT NULL
);

IF OBJECT_ID(N'produtos', N'U') IS NULL
CREATE TABLE produtos
(
    ID INTEGER PRIMARY KEY IDENTITY,
    nome VARCHAR(50) NOT NULL,
    preco FLOAT NOT NULL,
    quantidade_estoque INTEGER,
    fk_fornecedor INTEGER NOT NULL,
    FOREIGN KEY (fk_fornecedor) REFERENCES fornecedores(ID)
);

IF OBJECT_ID(N'clientes', N'U') IS NULL
CREATE TABLE clientes
(
    ID INTEGER PRIMARY KEY IDENTITY,
    CPF VARCHAR(11) UNIQUE NOT NULL,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
);

IF OBJECT_ID(N'status_nota', N'U') IS NULL
CREATE TABLE status_nota
(
    ID INTEGER PRIMARY KEY IDENTITY,
    status VARCHAR(30) NOT NULL UNIQUE
);

IF OBJECT_ID(N'notas', N'U') IS NULL
CREATE TABLE notas
(
    ID INTEGER PRIMARY KEY IDENTITY,
    data_compra DATETIME2 NULL DEFAULT GETDATE(),
    fk_status INTEGER NOT NULL,
    fk_cliente INTEGER NOT NULL,
    FOREIGN KEY (fk_status) REFERENCES status_nota(ID),
    FOREIGN KEY (fk_cliente) REFERENCES clientes(ID)
);

IF OBJECT_ID(N'itens_nota', N'U') IS NULL
CREATE TABLE itens_nota
(
    ID INTEGER PRIMARY KEY IDENTITY,
    nome VARCHAR(50) NOT NULL,
    preco FLOAT NOT NULL,
    quantidade INTEGER NOT NULL,
    fk_nota INTEGER NOT NULL,
    FOREIGN KEY (fk_nota) REFERENCES notas(ID)
);

INSERT INTO status_nota VALUES ('Cancelada');
INSERT INTO status_nota VALUES ('Emitida');
INSERT INTO status_nota VALUES ('Emitida');

-- DROP TABLE status_nota;
-- DROP TABLE itens_nota;
-- DROP TABLE notas;

SELECT * FROM fornecedores;
SELECT * FROM produtos;
SELECT * FROM clientes;
SELECT * FROM status_nota;
SELECT * FROM notas;
SELECT * FROM itens_nota;

-- INSERT INTO clientes VALUES ('12345678911', 'Lucas Queiroz', 'lucas@gmail.com');

-- INSERT INTO fornecedores VALUES ('12345678000134', 'Casas Bahia');
-- INSERT INTO fornecedores VALUES ('12543678000154', 'Amazon');
-- INSERT INTO fornecedores VALUES ('31443678000165', 'Americanas');

-- DELETE FROM fornecedores WHERE CNPJ = '12543678000154';

SELECT * FROM notas
INNER JOIN clientes on clientes.ID = notas.fk_cliente;

SELECT notas.ID, data_compra, fk_status, nome FROM notas
INNER JOIN clientes on clientes.ID = notas.fk_cliente

insert into notas values (GETDATE(), 9, 3);SELECT SCOPE_IDENTITY();

select notas.ID, data_compra, status_nota.status, fk_cliente from notas INNER JOIN status_nota ON status_nota.ID = fk_status;

select ID, nome, preco, quantidade, fk_nota from itens_nota

select * from notas;

update notas SET fk_status = 1 WHERE id = 3;