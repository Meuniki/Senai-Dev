USE SENAI_HROADS_MANHA
GO

INSERT INTO Classes(Nome) VALUES
			('Bárbaro'),
			('Cruzado'),
			('Caçadora'), 
			('Monge'), 
			('Necromante'), 
			('Feiticeiro'), 
			('Arcanista');
GO

INSERT INTO TipoHabilidades(Descricao) VALUES
			('Ataque'),
			('Magia'),
			('Cura'),
			('Defesa');
GO

INSERT INTO Habilidades(Nome, IdTipoHabilidade) VALUES
			('Lança Mortal', 1), 
			('Escudo Supremo', 2), 
			('Recuperar Vida', 3);
GO

INSERT INTO ClassesHabilidades(IdClasse,IdHabilidade) VALUES
			(1,1),
			(1,2),
			(4,3),
			(4,2);
GO

INSERT INTO Personagens(IdClasse,Nome,CapMaxVida,CapMaxMana,DataAtualizacao,DataCriacao) VALUES
			(1,'DeuBug',100,80,CURRENT_TIMESTAMP,'18-01-2019'),
			(4,'BitBug',70,100,CURRENT_TIMESTAMP,'17-03-2016'),
			(7,'Fer8',75,100,CURRENT_TIMESTAMP,'18-03-2018');
GO

-- Atualizar o nome do personagem Fer8 para Fer7;
UPDATE Personagens
Set Nome = 'Fer7'
WHERE IdPersonagen = 3

-- Atualizar o nome da classe de Necromante para Necromancer;
UPDATE Classes
Set Nome = 'Necromancer;'
WHERE IdClasse = 5