CREATE DATABASE joins;

USE joins;

CREATE TABLE java
(
    professor VARCHAR(50) NULL
);

CREATE TABLE net
(
    professor VARCHAR(50) NULL
);

INSERT INTO java VALUES ('Fabricio'), ('Gabriel'), ('Luan');

INSERT INTO net VALUES ('Fabricio'), ('Ricardo'), ('Alexandre');

-- inner join
SELECT * FROM java
INNER JOIN net ON java.professor = net.professor;

-- left join
SELECT * FROM java
LEFT JOIN net ON java.professor = net.professor;

-- left join exclusive
SELECT * FROM java
LEFT JOIN net ON java.professor = net.professor
WHERE net.professor IS NULL;

-- right join
SELECT java.professor AS Java, net.professor AS Net FROM java
RIGHT JOIN net ON java.professor = net.professor;

-- right join exclusive
SELECT * FROM java
RIGHT JOIN net ON java.professor = net.professor
WHERE java.professor IS NULL;

-- outer join
SELECT * FROM java
FULL OUTER JOIN net ON java.professor = net.professor; 

-- outer join exclusive
SELECT * FROM java
FULL OUTER JOIN net ON java.professor = net.professor
WHERE java.professor IS NULL OR net.professor IS NULL