create database livraria;

create table editoras
(
	id integer not null primary key identity,
	nome varchar(60) not null
);

create table autores
(
	id integer not null primary key identity,
	nome varchar(50) not null,
	nacionalidade varchar(40)
);

create table categorias
(
	id integer primary key not null identity,
	nome varchar(50) not null
);

create table livros
(
	isbn varchar(22) primary key not null,
	titulo varchar(50) not null,
	ano integer not null,
	fk_editora integer not null,
	fk_categoria integer not null,
	foreign key (fk_editora) references editoras(id),
	foreign key (fk_categoria) references categorias(id)
);

create table livro_autor
(
	id integer not null primary key identity,
	fk_livro varchar(22) not null,
	fk_autor integer not null,
	foreign key (fk_livro) references livros(isbn),
	foreign key (fk_autor) references autores(id)
);

SELECT * FROM categorias;
SELECT * FROM editoras;
SELECT * FROM autores;
SELECT * FROM livros;

INSERT INTO categorias
VALUES ('Terror');

INSERT INTO categorias (nome)
VALUES ('Comédia');

INSERT INTO categorias (nome)
VALUES ('Romance');

INSERT INTO editoras
VALUES ('Rocco');

INSERT INTO editoras
VALUES ('Darkside');

INSERT INTO autores(nome)
VALUES ('JK Rowling');

INSERT INTO autores(nome)
VALUES ('Lovecraft');

INSERT INTO autores(nome, nacionalidade)
VALUES ('Lovecraft', 'americano');

SELECT * FROM livros;

INSERT INTO livros (isbn, titulo, ano, fk_editora, fk_categoria)
VALUES ('6435345', 'Chamado de Cthulhu', 1922 , 2, 1);

INSERT INTO livros (isbn, titulo, ano, fk_editora, fk_categoria)
VALUES ('31313124', 'O Corvo', 1922 , 2, 1);

INSERT INTO livros (isbn, titulo, ano, fk_editora, fk_categoria)
VALUES ('6345342', 'O Corvo', 1922 , 1, 3);

SELECT * FROM categorias;
SELECT * FROM editoras;
SELECT * FROM autores;
SELECT * FROM livros;

SELECT * FROM livro_autor;

INSERT INTO livro_autor
VALUES ('41412313', 3);

INSERT INTO livro_autor
VALUES ('41412313', 2);


INSERT INTO livro_autor
VALUES ('6435345', 2);

SELECT * FROM categorias;

UPDATE categorias
SET nome = 'Juvenil'

UPDATE categorias
SET nome = 'Terror'
WHERE id = 1;

UPDATE categorias
SET nome = 'Comedia'
WHERE id = 2;

UPDATE categorias 
SET nome = 'Romance'
WHERE nome = 'Comedia';

SELECT * FROM autores;

UPDATE autores
SET nome = 'J. K. Rowling', nacionalidade = 'Britânica'
where id = 1;

UPDATE autores
SET nome = 'Alan Poe', nacionalidade = 'Americano'
where id = 2;

UPDATE autores
SET nome = 'Alan Poe', nacionalidade = 'Americano'
where id = 5;

SELECT * FROM livros;

UPDATE livros
SET ano = 1890
WHERE isbn = '6435345';

UPDATE livros
SET titulo = 'Harry Potter', ano = 1994
WHERE isbn = '41412313';

UPDATE livros
SET fk_categoria = 3
WHERE ano > 1950;

SELECT * FROM categorias;

DELETE FROM categorias WHERE id = 2;

