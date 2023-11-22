IF OBJECT_ID(N'log', N'U') IS NULL
CREATE TABLE log
(
    ID INTEGER PRIMARY KEY IDENTITY,
    acao VARCHAR(15) NOT NULL,
    descricao VARCHAR(250),
    quando DATETIME NOT NULL
)

SELECT * FROM dinossauro;
SELECT * FROM log;

DROP TRIGGER DinossauroInsert; 

-- 5

GO
IF OBJECT_ID(N'DinossauroInsert') IS NULL
CREATE TRIGGER DinossauroInsert
ON dinossauro
AFTER INSERT
AS
    DECLARE @inicio INTEGER
    DECLARE @fim INTEGER

    SELECT @inicio = (SELECT inicio FROM inserted)
    SELECT @fim = (SELECT fim FROM inserted)

BEGIN
    IF(@inicio < @fim)
        BEGIN
            ROLLBACK TRANSACTION;
            INSERT INTO log VALUES ('Inserção', 'Nada alterado, pois ' + CONVERT(VARCHAR(3), @inicio) + ' deve ser mais antigo que o ' + CONVERT(VARCHAR(3), @fim), GETDATE())
            RAISERROR('Sem inserção, inicio mais recente que o fim', 14, 1);
        END
    ELSE
        BEGIN
            INSERT INTO log VALUES ('Inserção', 'Inserido o inicio ' + CONVERT(VARCHAR(3), @inicio) + ' e o fim ' + CONVERT(VARCHAR(3), @fim), GETDATE())
        END
END


GO
CREATE TRIGGER DinossauroUpdate
ON dinossauro
AFTER Update
AS
    DECLARE @novo_inicio INTEGER
    DECLARE @novo_fim INTEGER

    DECLARE @antigo_inicio INTEGER
    DECLARE @antigo_fim INTEGER

    SELECT @novo_inicio = (SELECT inicio FROM inserted)
    SELECT @novo_fim = (SELECT fim FROM inserted)

    SELECT @antigo_inicio = (SELECT inicio FROM deleted)
    SELECT @antigo_fim = (SELECT fim FROM deleted)

BEGIN
    IF(@novo_inicio < @novo_fim)
        BEGIN
            ROLLBACK TRANSACTION;
            INSERT INTO log VALUES ('Alteração', 'Nada alterado, pois ' + CONVERT(VARCHAR(3), @novo_inicio) + ' deve ser mais antigo que o ' + CONVERT(VARCHAR(3), @novo_fim), GETDATE())
            RAISERROR('Sem alteração, inicio mais recente que o fim', 14, 1);
        END
    ELSE
        BEGIN
            INSERT INTO log VALUES ('Alteração', 'Alterado o inicio ' + CONVERT(VARCHAR(3), @antigo_inicio) + ' e o fim ' + CONVERT(VARCHAR(3), @antigo_fim), GETDATE())
        END
END


-- 6

GO
ALTER TRIGGER DinossauroInsert
ON dinossauro
AFTER INSERT
AS
    DECLARE @inicio INTEGER
    DECLARE @fim INTEGER
    DECLARE @nome_era VARCHAR(50)
    DECLARE @inicio_era INTEGER
    DECLARE @fim_era INTEGER

    SELECT @inicio = (SELECT inicio FROM inserted);
    SELECT @fim = (SELECT fim FROM inserted);
    SELECT @nome_era = (SELECT era.nome FROM era INNER JOIN inserted ON era.ID = inserted.fk_era);
    SELECT @inicio_era = (SELECT era.inicio FROM era INNER JOIN inserted ON era.ID = inserted.fk_era);
    SELECT @fim_era = (SELECT era.fim FROM era INNER JOIN inserted ON era.ID = inserted.fk_era);

BEGIN
    IF(@inicio < @fim)
        BEGIN
            ROLLBACK TRANSACTION;
            INSERT INTO log VALUES ('Inserção', 'Nada alterado, pois ' + CONVERT(VARCHAR(3), @inicio) + ' deve ser mais antigo que o ' + CONVERT(VARCHAR(3), @fim), GETDATE())
            RAISERROR('Sem inserção, inicio mais recente que o fim', 14, 1);
        END
    ELSE
    IF (@inicio > @inicio_era AND @fim < @fim_era)
        BEGIN
            ROLLBACK TRANSACTION;
            INSERT INTO log VALUES ('Inserção', 'Nada inserido, pois as datas não estão correpondendo a era ' + @nome_era, GETDATE())
            RAISERROR('Sem inserção, era incorreta', 14, 1);
        END
    ELSE
        BEGIN
            INSERT INTO log VALUES ('Inserção', 'Inserido o inicio ' + CONVERT(VARCHAR(3), @inicio) + ' e o fim ' + CONVERT(VARCHAR(3), @fim), GETDATE())
        END
END


GO
ALTER TRIGGER DinossauroUpdate
ON dinossauro
AFTER Update
AS
    DECLARE @novo_inicio INTEGER
    DECLARE @novo_fim INTEGER

    DECLARE @antigo_inicio INTEGER
    DECLARE @antigo_fim INTEGER

    DECLARE @nome_era VARCHAR(50)
    DECLARE @inicio_era INTEGER
    DECLARE @fim_era INTEGER

    SELECT @nome_era = (SELECT era.nome FROM era INNER JOIN inserted ON era.ID = inserted.fk_era);
    SELECT @inicio_era = (SELECT era.inicio FROM era INNER JOIN inserted ON era.ID = inserted.fk_era);
    SELECT @fim_era = (SELECT era.fim FROM era INNER JOIN inserted ON era.ID = inserted.fk_era);

    SELECT @novo_inicio = (SELECT inicio FROM inserted)
    SELECT @novo_fim = (SELECT fim FROM inserted)

    SELECT @antigo_inicio = (SELECT inicio FROM deleted)
    SELECT @antigo_fim = (SELECT fim FROM deleted)

BEGIN
    IF(@novo_inicio < @novo_fim)
        BEGIN
            ROLLBACK TRANSACTION;
            INSERT INTO log VALUES ('Alteração', 'Nada alterado, pois ' + CONVERT(VARCHAR(3), @novo_inicio) + ' deve ser mais antigo que o ' + CONVERT(VARCHAR(3), @novo_fim), GETDATE())
            RAISERROR('Sem alteração, inicio mais recente que o fim', 14, 1);
        END
    ELSE
    IF (@novo_inicio > @inicio_era AND @novo_fim < @fim_era)
        BEGIN
            ROLLBACK TRANSACTION;
            INSERT INTO log VALUES ('Alteração', 'Nada alterado, pois as datas não estão correpondendo a era ' + @nome_era, GETDATE())
            RAISERROR('Sem alteração, era incorreta', 14, 1);
        END
    ELSE
        BEGIN
            -- INSERT INTO log VALUES ('Alteração', 'Alterado o inicio de ' + CONVERT(VARCHAR(3), @antigo_inicio) + ' para ' + CONVERT(VARCHAR(3), @novo_inicio) + ' e o fim de ' + CONVERT(VARCHAR(3), @antigo_fim), GETDATE() + ' para ' + CONVERT(VARCHAR(3), @novo_inicio))
            INSERT INTO log VALUES ('Alteração', 'Alterado o inicio de ' + CONVERT(VARCHAR(3), @antigo_inicio) + ' para ' + CONVERT(VARCHAR(3), @novo_inicio) + ' e o fim de ' + CONVERT(VARCHAR(3), @antigo_fim) + ' para ' + CONVERT(VARCHAR(3), @novo_inicio), GETDATE())
        END
END

SELECT dinossauro.nome as Dinossauro, grupo.nome as Grupo, peso as Toneladas, anoDescoberta as Ano_Descoberta, descobridor.nome as Descobridor, era.nome as Era, dinossauro.inicio, dinossauro.fim, pais.nome FROM dinossauro
INNER JOIN descobridor ON descobridor.id = fk_descobridor
INNER JOIN grupo ON grupo.id = fk_grupo
INNER JOIN era ON era.ID = fk_era
INNER JOIN pais ON pais.ID = fk_paisOrigem
ORDER BY Dinossauro;
SELECT * FROM era;
SELECT * FROM log;

GO
create trigger validaInsereDinossauroEra
on DINOSSAUROS
after insert
as
begin
    declare @dinoIni int
    declare @dinoFim int
    declare @eraIni int
    declare @eraFim int
 
    select @dinoIni = (select inserted.inicio from inserted)
    select @dinoFim = (select inserted.fim from inserted)
    select @eraIni = (select ERAS.inicio from ERAS where ERAS.id_era = (select inserted.fk_era from inserted))
    select @eraFim = (select ERAS.fim from ERAS where ERAS.id_era = (select inserted.fk_era from inserted))

    if (@dinoIni > @eraIni) and (@dinoFim < @eraFim)
    begin
        insert into log values ('Inserção', 'Novo dinossauro inserido em Dinossauros', GETDATE());
        print('Dinossauro inseridos com sucesso!')
    end
    else
    begin
        ROLLBACK;
        insert into log values ('Inserção', 'tentativa de inserção de novo dinossauro na tabela Dinossauros', GETDATE());
        RAISERROR('INVALIDO', 14,1);
        RETURN;
        end
end

DELETE FROM dinossauro
WHERE nome = 'Tricerátops'