USE SENAI_HROADS_MANHA

-- Inserir todos os Registros no Banco de Dados
INSERT INTO Personagens (IdClasse, Nome, MaxVida, MaxMana, DataAtualizacao, DataCriacao)
VALUES (1, 'DeuBug', 100, 80, '01/03/21', '18/01/19'), (4, 'BitBug', 70, 100, '01/03/21', '17/03/16'), (7, 'Fer8', 75, 60, '01/03/21', '18/03/18');
select * from personagens

INSERT INTO ClassesHabilidades(IdClasse, IdHabilidade)
VALUES (1,1), (1,2), (2,2), (3,1), (4,3), (4,2), (6,3);
select * from ClassesHabilidades

INSERT INTO Classes (Nome)
VALUES ('Barbaro'), ('Cruzado'), ('Caçadora de Demonios'), ('Monge'), ('Necromante'), ('Feiticeiro'), ('Arcanista');
select * from classes

INSERT INTO Habilidades (IdTipoDeHabilidade, Nome)
VALUES (1, 'Lança Mortal'), (4, 'Escudo Supremo'), (3, 'Recuperar Vida');
select * from habilidades

INSERT INTO TiposDeHabilidades (Nome)
VALUES ('Ataque'), ('Magia'), ('Cura'), ('Defesa');
select * from TiposDeHabilidades

--Atualizar o Nome do Personagem de "Fer8" para "Fer7"
UPDATE Personagens
SET Nome='Fer7'
WHERE IdPersonagem = 3;

--Atualizar o Nome da Classe de "Necromante" para "Necromancer"
UPDATE Classes
SET Nome='Necromancer'
WHERE IdClasse=5;

SELECT * FROM habilidades
