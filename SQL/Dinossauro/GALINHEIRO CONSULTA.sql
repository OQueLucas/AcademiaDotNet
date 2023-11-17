
-- 7
SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome as País 
FROM dinossauro, grupo, descobridor, era, pais
WHERE 
	descobridor.ID = fk_descobridor AND
	era.ID = fk_era AND
	pais.ID = fk_paisOrigem AND
	grupo.ID = fk_grupo
ORDER BY Dinossauro;

SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome FROM dinossauro
INNER JOIN descobridor ON descobridor.id = fk_descobridor
INNER JOIN grupo ON grupo.id = fk_grupo
INNER JOIN era ON era.ID = fk_era
INNER JOIN pais ON pais.ID = fk_paisOrigem
ORDER BY Dinossauro;

-- 8
SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome as País 
FROM dinossauro, grupo, descobridor, era, pais
WHERE descobridor.ID = fk_descobridor AND
	era.ID = fk_era AND
	pais.ID = fk_paisOrigem AND
	grupo.ID = fk_grupo
ORDER BY Descobridor;

SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome as País 
FROM dinossauro
INNER JOIN grupo ON grupo.ID = fk_grupo
INNER JOIN descobridor ON descobridor.ID = fk_descobridor
INNER JOIN era ON era.ID = fk_era
INNER JOIN pais ON pais.ID = fk_paisOrigem
ORDER BY Descobridor;

-- 9
SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome as País 
FROM dinossauro, grupo, descobridor, era, pais
WHERE descobridor.ID = fk_descobridor AND
	era.ID = fk_era AND
	pais.ID = fk_paisOrigem AND
	grupo.ID = fk_grupo AND
	grupo.nome = 'anquilossauros'
ORDER BY Ano_Descoberta;

SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome as País 
FROM dinossauro
INNER JOIN grupo ON grupo.ID = fk_grupo
INNER JOIN descobridor ON descobridor.ID = fk_descobridor
INNER JOIN era ON era.ID = fk_era
INNER JOIN pais ON pais.ID = fk_paisOrigem
WHERE grupo.nome = 'anquilossauros'
ORDER BY Ano_Descoberta;

-- 10
SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome as País 
FROM dinossauro, grupo, descobridor, era, pais
WHERE descobridor.ID = fk_descobridor AND
	era.ID = fk_era AND
	pais.ID = fk_paisOrigem AND
	grupo.ID = fk_grupo AND
	(grupo.nome = 'anquilossauros' OR grupo.nome = 'Ceratopsídeos')
ORDER BY Ano_Descoberta;

SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome as País 
FROM dinossauro
INNER JOIN grupo ON grupo.ID = fk_grupo
INNER JOIN descobridor ON descobridor.ID = fk_descobridor
INNER JOIN era ON era.ID = fk_era
INNER JOIN pais ON pais.ID = fk_paisOrigem
WHERE grupo.nome = 'anquilossauros' OR grupo.nome = 'Ceratopsídeos'
ORDER BY Ano_Descoberta;


SELECT * FROM dinossauro WHERE peso IN (3,6, 4);

SELECT * FROM dinossauro WHERE peso BETWEEN 2 AND 6;

SELECT * FROM dinossauro WHERE anoDescoberta > 1900;

-- COUNT SUM AVG
SELECT fk_grupo, AVG(peso) as Media
from dinossauro
GROUP BY fk_grupo;

SELECT fk_grupo, count(*) as quantidade
FROM dinossauro
GROUP BY fk_grupo;

SELECT fk_grupo, SUM(peso) as Somatorio
FROM dinossauro
GROUP BY fk_grupo
HAVING SUM(peso) > 5;