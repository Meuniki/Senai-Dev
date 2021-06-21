USE SENAI_HROADS_MANHA
GO

-- Selecionar todos os personagens;
SELECT * FROM Personagens

-- Selecionar todos as classes;
SELECT * FROM Classes

-- Selecionar somente o nome das classes;
SELECT Nome FROM Classes

--Selecionar todas as habilidades;
SELECT * FROM Habilidades

-- Realizar a contagem de quantas habilidades estão cadastradas;
SELECT COUNT(IdHabilidade) as Habilidades_Cadastradas 
FROM Habilidades

-- Selecionar somente os id’s das habilidades classificando-os por ordem crescente;
SELECT IdHabilidade 
FROM Habilidades
ORDER BY IdHabilidade ASC

-- Selecionar todos os tipos de habilidades;
SELECT * FROM TipoHabilidades

-- Selecionar todas as habilidades e a quais tipos de habilidades elas fazem parte;
SELECT Habilidades.IdHabilidade,
	   Habilidades.Nome,
	   TipoHabilidades.descricao as Tipo,IdTipoHabilidade 
FROM Habilidades JOIN TipoHabilidades 
ON Habilidades.IdTipoHabilidade = TipoHabilidades.IdTipoHalidade;

-- Selecionar todos os personagens e suas respectivas classes;
SELECT Personagens.Nome, Classes.Nome
FROM Personagens JOIN Classes 
ON Personagens.IdClasse = Classes.IdClasse

-- Selecionar todas as habilidades e suas classes (somente as que possuem correspondência);
SELECT * FROM Habilidades INNER JOIN ClassesHabilidades 
ON Habilidades.IdHabilidade = ClassesHabilidades.IdHabilidade
JOIN Classes ON Classes.IdClasse = ClassesHabilidades.IdClasse

-- Selecionar todos os personagens e as classes (mesmo que elas não tenham correspondência em personagens);
SELECT * FROM Personagens 
RIGHT JOIN Classes ON Personagens.IdClasse = Classes.IdClasse

-- Selecionar todas as classes e suas respectivas habilidades;
SELECT Classes.Nome, Habilidades.Nome FROM Habilidades INNER JOIN ClassesHabilidades 
ON Habilidades.IdHabilidade = ClassesHabilidades.IdHabilidade
JOIN Classes ON Classes.IdClasse = ClassesHabilidades.IdClasse

-- Selecionar todas as habilidades e suas classes (somente as que possuem correspondência);
SELECT  Habilidades.Nome, Classes.Nome FROM Habilidades LEFT JOIN ClassesHabilidades 
ON Habilidades.IdHabilidade = ClassesHabilidades.IdHabilidade
JOIN Classes ON Classes.IdClasse = ClassesHabilidades.IdClasse

-- Selecionar todas as habilidades e suas classes (mesmo que elas não tenham correspondência).
SELECT  Habilidades.Nome, Classes.Nome FROM Habilidades RIGHT JOIN ClassesHabilidades 
ON Habilidades.IdHabilidade = ClassesHabilidades.IdHabilidade
RIGHT JOIN Classes ON Classes.IdClasse = ClassesHabilidades.IdClasse