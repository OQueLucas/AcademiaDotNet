CREATE DATABASE joins;

USE joins;

IF OBJECT_ID(N'java', N'U') IS NULL
CREATE TABLE java
(
    professor VARCHAR(50) NULL
);

IF OBJECT_ID(N'net', N'U') IS NULL
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

IF OBJECT_ID(N'log', N'U') IS NULL
CREATE TABLE log
(
    ID INTEGER PRIMARY KEY IDENTITY,
    acao VARCHAR(15) NOT NULL,
    descricao VARCHAR(250),
    quando DATETIME NOT NULL
)

SELECT * FROM log;

GO
CREATE TRIGGER primeirotrigger
ON java
AFTER INSERT
AS
BEGIN
    INSERT INTO log VALUES ('Inserção', 'Foi inserido um novo professor em Java', GETDATE());
    PRINT('Professor inserido com sucecsso!');
END

SELECT * FROM java;
SELECT * FROM log;

INSERT INTO java VALUES ('Ricardo');

-- GO
-- CREATE TRIGGER triggerdelete
-- ON java
-- AFTER DELETE
-- AS
-- BEGIN
--     INSERT INTO log VALUES ('Exclusão', 'O professor foi excluído com sucesso!', GETDATE());
--     PRINT('Excluído com sucesso!');
-- END

DELETE FROM java WHERE professor = 'Ricardo';

DROP TRIGGER triggerdelete;

GO
CREATE TRIGGER triggerdelete
ON java
AFTER DELETE
AS
DECLARE @nome VARCHAR(15)
SELECT @nome = (SELECT deleted.professor FROM deleted)
BEGIN
    INSERT INTO log VALUES ('Exclusão', 'O professor ' + @nome + ' foi excluído da academia Java!', GETDATE());
    PRINT( @nome + ' foi excluído com sucesso!');
END

GO
CREATE TRIGGER primeiratrigger
ON java
AFTER INSERT
AS
    DECLARE @quantidade INTEGER
    DECLARE @nome VARCHAR(15)
    SELECT @quantidade = (SELECT COUNT(professor) FROM java)
BEGIN
    PRINT('Quantidade de registros: ' + CONVERT(VARCHAR(3), @quantidade))
    IF @quantidade <= 3
        BEGIN
            INSERT INTO log VALUES ('Inserção', 'O professor ' + @nome + ' foi inserido na academia Java!', GETDATE());
            PRINT( @nome + ' foi inserido com sucesso!');
        END
    ELSE
        BEGIN
            ROLLBACK;
            INSERT INTO log VALUES ('Inserção', 'O professor ' + @nome + ' não foi inserido na academia Java devido ao limite de professores ter sido atingido!', GETDATE());
            RAISERROR('Regra de 3 professores quebrou o insert', 14, 1);
        END
END

DROP TRIGGER primeiratrigger;

INSERT INTO java VALUES ('Ricardo');

DELETE FROM java WHERE professor = 'Ricardo';

SELECT * FROM java;
SELECT * FROM log;

-- GO
-- CREATE TRIGGER triggerupdate
-- ON java
-- AFTER UPDATE
-- AS
--     DECLARE @novo VARCHAR(15)
--     DECLARE @antigo VARCHAR(15)

--     SELECT @novo = (SELECT professor FROM inserted)
--     SELECT @antigo = (SELECT professor FROM deleted)

--     IF(ROWCOUNT_BIG() = 0)
--         RETURN;

-- BEGIN
--     IF(@novo = @antigo)
--         BEGIN
--             INSERT INTO log VALUES ('Alteração', 'Nada alterado, pois ' + @novo + 'não foi alterado', GETDATE())
--             RAISERROR('Sem alterações, dados identicos', 14, 1);
--             ROLLBACK TRANSACTION;
--         END
--     ELSE
--         BEGIN
--             INSERT INTO log VALUES ('Alteração', 'Professor ' + @antigo + 'foi substituído pelo ' + @novo, GETDATE())
--         END
-- END

UPDATE java SET professor = 'Ricardo' WHERE professor = 'Luan';

UPDATE java SET professor = 'Luan' WHERE professor = 'Ricardo';

DROP TRIGGER triggerupdate

go
create trigger triggerupdate
on java
after update
as 
    declare @novo varchar(15)
    declare @antigo varchar(15)

    select @novo  = (select professor from inserted)
    select @antigo = (select professor from deleted)

    IF(ROWCOUNT_BIG() = 0)
        return;

begin 
    if(@novo = @antigo)
        begin
            raiserror('sem alterações, dados identicos', 14,1);
            insert into log values ('Alteração', 'Nada alterado, pois ' + @novo + ' não foi alterado',
            GETDATE());
            rollback transaction;
        end
    else
        begin
            insert into log values ('Alteração', 'Professor ' + @antigo + ' foi substituido pelo ' + @novo,
            GETDATE());
        end
end