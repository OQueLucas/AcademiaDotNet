CREATE DATABASE GALINHEIRO;

USE GALINHEIRO;

USE ACADEMIADOTNET;

DROP DATABASE GALINHEIRO;

CREATE TABLE descobridor
(
	ID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(60) NOT NULL
);

CREATE TABLE pais
(
	ID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(60) NOT NULL
);

CREATE TABLE era
(
	ID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(50) NOT NULL,
	inicio INTEGER NOT NULL,
	fim INTEGER NOT NULL
);

CREATE TABLE grupo
(
	ID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(30)
)

CREATE TABLE dinossauro
(
	ID INTEGER PRIMARY KEY IDENTITY,
	nome VARCHAR(70) NOT NULL,
	peso INTEGER NOT NULL,
	anoDescoberta INTEGER NOT NULL,
	inicio INTEGER NOT NULL,
	fim INTEGER NOT NULL,
	fk_grupo INTEGER NOT NULL,
	fk_descobridor INTEGER NOT NULL,
	fk_paisOrigem INTEGER NOT NULL,
	fk_era INTEGER NOT NULL
	FOREIGN KEY (fk_grupo) REFERENCES grupo(ID),
	FOREIGN KEY (fk_descobridor) REFERENCES descobridor(ID),
	FOREIGN KEY (fk_paisOrigem) REFERENCES pais(ID),
	FOREIGN KEY (fk_era) REFERENCES era(ID)
);

INSERT INTO descobridor
VALUES ('Maryasnka');
INSERT INTO descobridor
VALUES ('John Bell Hatcher');
INSERT INTO descobridor
VALUES ('Cientistas Alemães');
INSERT INTO descobridor
VALUES ('Museu Americano de História Natural');
INSERT INTO descobridor
VALUES ('Othniel Charles Marsh');
INSERT INTO descobridor
VALUES ('Barnum Brown');
INSERT INTO descobridor
VALUES ('John Bell Hatcher');

SELECT * FROM descobridor;

INSERT INTO pais
VALUES ('Mongolia');
INSERT INTO pais
VALUES ('Canadá');
INSERT INTO pais
VALUES ('Tanzânia');
INSERT INTO pais
VALUES ('China');
INSERT INTO pais
VALUES ('America do Norte');
INSERT INTO pais
VALUES ('USA');

SELECT * FROM pais;

INSERT INTO era
VALUES ('Cretáceo', 145, 65);
INSERT INTO era
VALUES ('Jurassico', 205, 142);

SELECT * FROM era;

INSERT INTO grupo
VALUES ('Anquilossauros');
INSERT INTO grupo
VALUES ('Ceratopsídeos');
INSERT INTO grupo
VALUES ('Estegossauros');
INSERT INTO grupo
VALUES ('Terápodes');

SELECT * FROM grupo;

INSERT INTO dinossauro (nome, fk_grupo, peso, anoDescoberta, fk_descobridor, fk_era, inicio, fim, fk_paisOrigem)
VALUES ('Saichania', 1, 4, 1977, 1, 1, 145, 66, 1);
INSERT INTO dinossauro (nome, fk_grupo, peso, anoDescoberta, fk_descobridor, fk_era, inicio, fim, fk_paisOrigem)
VALUES ('Tricerátops', 2, 6, 1887, 2, 1, 70, 66, 2);
INSERT INTO dinossauro (nome, fk_grupo, peso, anoDescoberta, fk_descobridor, fk_era, inicio, fim, fk_paisOrigem)
VALUES ('Kentrossauro', 3, 2, 1909, 3, 2, 201,145, 3);
INSERT INTO dinossauro (nome, fk_grupo, peso, anoDescoberta, fk_descobridor, fk_era, inicio, fim, fk_paisOrigem)
VALUES ('Pinacossauro', 1, 6, 1999, 4, 1, 85, 75, 4);
INSERT INTO dinossauro (nome, fk_grupo, peso, anoDescoberta, fk_descobridor, fk_era, inicio, fim, fk_paisOrigem)
VALUES ('Alossauro', 4, 3, 1877, 5, 2, 155, 150, 5);
INSERT INTO dinossauro (nome, fk_grupo, peso, anoDescoberta, fk_descobridor, fk_era, inicio, fim, fk_paisOrigem)
VALUES ('Torosauro', 2, 8, 1891, 7, 1, 67, 65, 6);
INSERT INTO dinossauro (nome, fk_grupo, peso, anoDescoberta, fk_descobridor, fk_era, inicio, fim, fk_paisOrigem)
VALUES ('Anquilossauros', 1, 8, 1906, 6, 1, 66, 63, 5);

SELECT * FROM dinossauro;
