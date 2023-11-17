-- 7
SELECT livros.isbn, livros.titulo, livros.ano, editoras.nome AS editora, categorias.nome AS categoria
FROM livros, editoras, categorias
WHERE livros.fk_editora = editoras.id AND
	livros.fk_categoria = categorias.id
ORDER BY titulo, ano ASC;

SELECT livros.isbn, livros.titulo, livros.ano, editoras.nome AS editora, categorias.nome AS categoria 
FROM livros
INNER JOIN editoras ON editoras.id = fk_editora
INNER JOIN categorias ON categorias.id = fk_categoria
ORDER BY titulo, ano ASC;

-- 8
SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome AS editora, categorias.nome AS categoria 
FROM livros, editoras, categorias, livro_autor, autores
WHERE livros.fk_editora = editoras.id AND
	livros.fk_categoria = categorias.id AND
	livro_autor.fk_livro = livros.isbn AND
	livro_autor.fk_autor = autores.id
ORDER BY nome ASC;

SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome AS editora, categorias.nome AS categoria 
FROM livros
INNER JOIN livro_autor ON  livro_autor.fk_livro = livros.isbn
INNER JOIN autores ON autores.id = fk_autor
INNER JOIN editoras ON editoras.id = fk_editora
INNER JOIN categorias ON categorias.id = fk_categoria
ORDER BY nome ASC;

-- 9
SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome AS editora, categorias.nome AS categoria 
FROM livros, editoras, categorias, livro_autor, autores
WHERE livros.fk_editora = editoras.id AND
	livros.fk_categoria = categorias.id AND
	livro_autor.fk_livro = livros.isbn AND
	livro_autor.fk_autor = autores.id AND
	categorias.nome = 'Literatura Juvenil'
ORDER BY ano ASC;

SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome AS editora, categorias.nome AS categoria 
FROM livros
INNER JOIN livro_autor ON livro_autor.fk_livro = livros.isbn
INNER JOIN autores ON autores.id = livro_autor.fk_autor
INNER JOIN editoras ON editoras.id = fk_editora
INNER JOIN categorias ON categorias.id = fk_categoria
WHERE categorias.nome = 'Literatura Juvenil'
ORDER by ano ASC;

-- 10
SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome AS editora, categorias.nome AS categoria 
FROM livros, editoras, categorias, livro_autor, autores
WHERE livros.fk_editora = editoras.id AND
	livros.fk_categoria = categorias.id AND
	livro_autor.fk_livro = livros.isbn AND
	livro_autor.fk_autor = autores.id AND
	(categorias.nome = 'Humor' OR categorias.nome = 'Ficção Científica') AND
	(ano >= 2000 AND ano <= 2015)
ORDER BY nome ASC;

SELECT livros.isbn, livros.titulo, livros.ano, autores.nome, editoras.nome AS editora, categorias.nome AS categoria 
FROM livros
INNER JOIN livro_autor ON livro_autor.fk_livro = livros.isbn
INNER JOIN autores ON autores.id = livro_autor.fk_autor
INNER JOIN editoras ON editoras.id = fk_editora
INNER JOIN categorias ON categorias.id = fk_categoria
WHERE (ano BETWEEN 2000 AND 2015) AND
    (categorias.nome = 'Humor' OR categorias.nome = 'Ficção Científica')
ORDER BY nome ASC;
