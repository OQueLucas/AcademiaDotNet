create database livraria;

-- create table editoras
-- (
-- 	id integer not null primary key identity,
-- 	nome varchar(60) not null
-- );

-- create table autores
-- (
-- 	id integer not null primary key identity,
-- 	nome varchar(50) not null,
-- 	nacionalidade varchar(40)
-- );

-- create table categorias
-- (
-- 	id integer primary key not null identity,
-- 	nome varchar(50) not null
-- );

-- create table livros
-- (
-- 	isbn varchar(22) primary key not null,
-- 	titulo varchar(50) not null,
-- 	ano integer not null,
-- 	fk_editora integer not null,
-- 	fk_categoria integer not null,
-- 	foreign key (fk_editora) references editoras(id),
-- 	foreign key (fk_categoria) references categorias(id)
-- );

-- create table livro_autor
-- (
-- 	id integer not null primary key identity,
-- 	fk_livro varchar(22) not null,
-- 	fk_autor integer not null,
-- 	foreign key (fk_livro) references livros(isbn),
-- 	foreign key (fk_autor) references autores(id)
-- );

SELECT * FROM categorias;
SELECT * FROM editoras;
SELECT * FROM autores;
SELECT * FROM livros;
SELECT * FROM livro_autor;

INSERT INTO categorias
VALUES ('Literatura Juvenil');
INSERT INTO categorias
VALUES ('Ficção Centífica');
INSERT INTO categorias
VALUES ('Humor');

INSERT INTO editoras
VALUES ('Rocco');
INSERT INTO editoras
VALUES ('Wmf Martins Fontes');
INSERT INTO editoras
VALUES ('Casa da Palavra');
INSERT INTO editoras
VALUES ('Belas Letras');
INSERT INTO editoras
VALUES ('Matrix');

INSERT INTO autores
VALUES ('J. K. Rowling', 'Inglaterra');
INSERT INTO autores
VALUES ('Clive Staples Lewis', 'Inglaterra');
INSERT INTO autores
VALUES ('Affonso Solano', 'Brasil');
INSERT INTO autores
VALUES ('Marcos Piangers', 'Brasil');
INSERT INTO autores
VALUES ('Ciro Botelho', 'Brasil');
INSERT INTO autores
VALUES ('Bianca Mól', 'Brasil');
INSERT INTO autores
VALUES ('Tiririca', 'Brasil');

INSERT INTO livros
VALUES ('5132135123', 'Harry Potter e a pedra filosofal', 2000, 1, 1);
INSERT INTO livros
VALUES ('1231215123', 'As Crônicas de Nárnia', 2009, 2, 1);
INSERT INTO livros
VALUES ('5123123158', 'O espadachim de carvão', 2013, 3, 2);
INSERT INTO livros
VALUES ('4125124123', 'O Papai é Pop', 2015, 4, 3);
INSERT INTO livros
VALUES ('5234523432', 'Pior que tá não fica', 2015, 5, 3);
INSERT INTO livros
VALUES ('6345623423', 'Garota desdobrável', 2015, 3, 1);
INSERT INTO livros
VALUES ('5123543532', 'Harry Potter e o prisoneiro de Azkaban', 2000, 1, 1);

INSERT INTO livro_autor
VALUES ('5132135123', 1);
INSERT INTO livro_autor
VALUES ('1231215123', 2);
INSERT INTO livro_autor
VALUES ('5123123158', 3);
INSERT INTO livro_autor
VALUES ('4125124123', 4);
INSERT INTO livro_autor
VALUES ('5234523432', 5);
INSERT INTO livro_autor
VALUES ('6345623423', 6);
INSERT INTO livro_autor
VALUES ('5123543532', 1);
INSERT INTO livro_autor
VALUES ('5234523432', 7);

-- 7 
SELECT * FROM livros
ORDER BY titulo;

-- 8
SELECT a.fk_livro, b.titulo, b.ano, d.nome, c.nome, c.nacionalidade, e.nome FROM livro_autor a
INNER JOIN livros b
ON a.fk_livro = b.isbn
INNER JOIN autores c
ON a.fk_autor = c.id
INNER JOIN editoras d
ON b.fk_editora = d.id
INNER JOIN categorias e
ON b.fk_categoria = e.id
ORDER BY c.nome;

-- 9
SELECT a.fk_livro, b.titulo, b.ano, d.nome, c.nome, c.nacionalidade, e.nome FROM livro_autor a
INNER JOIN livros b
ON a.fk_livro = b.isbn
INNER JOIN autores c
ON a.fk_autor = c.id
INNER JOIN editoras d
ON b.fk_editora = d.id
INNER JOIN categorias e
ON b.fk_categoria = e.id
WHERE e.nome = 'Literatura Juvenil'
ORDER BY b.ano;


-- resolvido

-- 7
SELECT livros.isbn, livros.titulo, livros.ano, editoras.nome as editora, categorias.nome as categoria from livros, editoras, categorias
WHERE livros.fk_editora = editoras.id AND
	livros.fk_categoria = categorias.id
ORDER BY titulo, ano asc;

-- 8
SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome as editora, categorias.nome as categoria 
from livros, editoras, categorias, livro_autor, autores
WHERE livros.fk_editora = editoras.id AND
	livros.fk_categoria = categorias.id AND
	livro_autor.fk_livro = livros.isbn AND
	livro_autor.fk_autor = autores.id
ORDER BY nome asc;

-- 9
SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome as editora, categorias.nome as categoria 
from livros, editoras, categorias, livro_autor, autores
WHERE livros.fk_editora = editoras.id AND
	livros.fk_categoria = categorias.id AND
	livro_autor.fk_livro = livros.isbn AND
	livro_autor.fk_autor = autores.id AND
	categorias.nome = 'Literatura Juvenil'
ORDER BY ano asc;

UPDATE categorias
SET nome = 'Ficção Científica'
WHERE nome = 'Ficção Centífica';

-- 10
SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome as editora, categorias.nome as categoria 
from livros, editoras, categorias, livro_autor, autores
WHERE livros.fk_editora = editoras.id AND
	livros.fk_categoria = categorias.id AND
	livro_autor.fk_livro = livros.isbn AND
	livro_autor.fk_autor = autores.id AND
	(categorias.nome = 'Humor' OR categorias.nome = 'Ficção Científica') AND
	(ano > 2000 AND ano < 2010)
ORDER BY nome asc;