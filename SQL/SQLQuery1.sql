/****** Script para el comando SelectTopNRows de SSMS  ******/
/*
SELECT TOP 1000 [id]
      ,[nombre]
      ,[apellido]
      ,[edad]
  FROM [Padron].[dbo].[Personas]
  */
/*
SELECT id, nombre, apellido, edad
FROM Padron.dbo.Personas
WHERE id > 1
ORDER BY edad DESC
*/

/*
INSERT INTO Padron.dbo.Personas
(nombre,apellido, edad)
values
('Juan','Enrique',47)

SELECT id, nombre, apellido, edad
FROM Padron.dbo.Personas
WHERE id > 1
ORDER BY edad DESC
*/
/*
UPDATE Padron.dbo.Personas
SET nombre = 'Alfredo',
	apellido = 'Perez',
	edad = 24
WHERE id = 6
*/

/*
DELETE FROM Padron.dbo.Personas
WHERE id = 7

SELECT id, nombre, apellido, edad
FROM Padron.dbo.Personas
*/

SELECT id, nombre, apellido, edad
FROM Padron.dbo.Personas