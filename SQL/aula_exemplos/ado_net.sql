CREATE DATABASE ado_net;

CREATE TABLE pessoas
(
    id INTEGER PRIMARY KEY IDENTITY,
    nome VARCHAR(50) NOT NULL,
    idade INTEGER
)

CREATE LOGIN adonet WITH PASSWORD='senha1234';
CREATE USER adonet FROM LOGIN adonet;

EXEC sp_addrolemember 'DB_DATAREADER', 'adonet';

EXEC sp_addrolemember 'DB_DATAWRITER', 'adonet';

INSERT INTO pessoas VALUES ('Gabriel', 25), ('Felipe', 33);

SELECT * FROM pessoas;