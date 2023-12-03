CREATE DATABASE banco;

USE banco;

CREATE TABLE Clientes (
    ID INTEGER PRIMARY KEY IDENTITY,
    nome VARCHAR(100),
    email VARCHAR(100)
);

CREATE TABLE Pedidos (
    ID INTEGER PRIMARY KEY IDENTITY,
    datapedido DATE,
    valor DECIMAL(12,2),
    ID_Cliente INTEGER,
    FOREIGN KEY (ID_Cliente) REFERENCES Clientes(ID)
);

INSERT INTO Clientes (nome, email) VALUES ('Ricardo Frohlich da Silva', 'ricardosma@gmail.com');
INSERT INTO Clientes (nome, email) VALUES ('Fabricio Tonetto', 'fabriciotonetto@gmail.com');
INSERT INTO Clientes (nome, email) VALUES ('Alexandre de Oliveira Zamberlan', 'alexz@gmail.com');

INSERT INTO Pedidos (datapedido, valor, ID_CLIENTE) VALUES ('2023-12-10', 153.50, 1);
INSERT INTO Pedidos (datapedido, valor, ID_CLIENTE) VALUES ('2023-12-15', 179.50, 2);
INSERT INTO Pedidos (datapedido, valor, ID_CLIENTE) VALUES ('2023-12-25', 1809.50, 3);

SELECT * FROM Clientes;
SELECT * FROM Pedidos;