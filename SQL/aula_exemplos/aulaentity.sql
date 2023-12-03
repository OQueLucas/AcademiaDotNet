CREATE DATABASE aulaentity;

CREATE LOGIN aulaentity WITH PASSWORD='senha1234';
CREATE USER aulaentity FROM LOGIN aulaentity;

EXEC sp_addrolemember 'DB_DATAREADER', 'aulaentity';

EXEC sp_addrolemember 'DB_DATAWRITER', 'aulaentity';

SELECT * FROM pessoas;
SELECT * FROM emails;