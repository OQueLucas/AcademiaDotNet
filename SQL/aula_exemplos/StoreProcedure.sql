-- GO
-- CREATE PROCEDURE procedimento (@parametro INT)
-- AS 

GO
create PROCEDURE teste2
WITH ENCRYPTION
AS
SELECT nome, anoDescoberta
FROM dinossauro;

EXEC teste2;

drop PROCEDURE teste2;

exec sp_helptext teste2;

GO
CREATE PROCEDURE teste3 (@par as int) 
AS 
SELECT @par;

EXEC teste3 5;

GO
CREATE PROCEDURE teste4 (@ano as Int)
AS
SELECT * FROM dinossauro WHERE anoDescoberta = @ano;

EXEC TESTE4 1999;

select * from descobridor;

GO
CREATE PROCEDURE teste5 (@nome as Varchar(50))
AS 
INSERT INTO descobridor VALUES (@nome)

EXEC teste5 'Fabricio'
EXEC teste5 @nome='Isaque'

GO
CREATE PROCEDURE exercicio1 (@nome as Varchar(50))
AS
SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo
FROM dinossauro
INNER JOIN grupo ON grupo.ID = fk_grupo
WHERE grupo.nome = @nome

EXEC exercicio1 Anquilossauros;

EXEC exercicio1 Ceratopsídeos;

EXEC exercicio1 Estegossauros;

SELECT nome as Dinossauro, peso as Toneladas
FROM dinossauro

GO
CREATE PROCEDURE exercicio2 (@id as int, @peso as int)
AS 
UPDATE dinossauro
SET peso = @peso
WHERE id = @id

-- 6
EXEC exercicio2 2, 6

GO
CREATE PROCEDURE exercicio2TESTE (@id as int, @peso as int)
AS 
UPDATE dinossauro
SET peso = @peso
WHERE id = @id

SELECT nome as Dinossauro, peso as Toneladas
FROM dinossauro;

EXEC exercicio2TESTE 2, 6;