USE inlock_games_manha;
GO

INSERT INTO TipoUsuario(titulo) VALUES
('ADMINISTRADOR'),
('CLIENTE');
GO

--Inserir um usuário do tipo ADMINISTRADOR que tenha o e-mail igual a
--admin@admin.com e a senha igual a admin;
INSERT INTO Usuario(email, senha, idTipoUsuario) VALUES
('admin@admin.com','admin',1);
GO

--Inserir um usuário do tipo CLIENTE que tenha o e-mail igual a
--cliente@cliente.com e a senha igual a cliente;
INSERT INTO Usuario(email, senha, idTipoUsuario) VALUES
('cliente@cliente.com','cliente',2);
GO

--Inserir três estúdios: um com o nome de Blizzard, outro com o nome de
--Rockstar Studios e o último com o nome de Square Enix;
INSERT INTO Estudio(nomeEstudio) VALUES
('Blizzard'),
('Rockstar Studio'),
('Square Enix');
GO

/*Inserir um jogo com o nome de: Diablo 3, com data de lançamento de: 15 de
maio de 2012, que contenha a descrição de: é um jogo que contém bastante
ação e é viciante, seja você um novato ou um fã. Seu estúdio é a Blizzard. E o
jogo custa R$ 99,00;*/
INSERT INTO Jogos(nomeJogo, descrição, dataLancamento, valor, idEstudio) VALUES
('Diablo 3', 'é um jogo que contém bastante ação e é viciante, 
seja você um novato ou um fã', '2012-05-15', 99, 1);
GO


/*Inserir um jogo com o nome de: Red Dead Redemption II, com a descrição de: jogo
eletrônico de ação-aventura western. Seu estúdio será a Rockstar Studios. Lançado
mundialmente em 26 de outubro de 2018. E o jogo custa R$ 120,00;*/
INSERT INTO Jogos(nomeJogo, descrição, dataLancamento, valor, idEstudio) VALUES
('Red Dead Redemption II','jogo
eletrônico de ação-aventura western','2018-10-26',120,2);