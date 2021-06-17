USE inlock_games_manha;
GO

INSERT INTO TipoUsuario(titulo) VALUES
('ADMINISTRADOR'),
('CLIENTE');
GO

--Inserir um usu�rio do tipo ADMINISTRADOR que tenha o e-mail igual a
--admin@admin.com e a senha igual a admin;
INSERT INTO Usuario(email, senha, idTipoUsuario) VALUES
('admin@admin.com','admin',1);
GO

--Inserir um usu�rio do tipo CLIENTE que tenha o e-mail igual a
--cliente@cliente.com e a senha igual a cliente;
INSERT INTO Usuario(email, senha, idTipoUsuario) VALUES
('cliente@cliente.com','cliente',2);
GO

--Inserir tr�s est�dios: um com o nome de Blizzard, outro com o nome de
--Rockstar Studios e o �ltimo com o nome de Square Enix;
INSERT INTO Estudio(nomeEstudio) VALUES
('Blizzard'),
('Rockstar Studio'),
('Square Enix');
GO

/*Inserir um jogo com o nome de: Diablo 3, com data de lan�amento de: 15 de
maio de 2012, que contenha a descri��o de: � um jogo que cont�m bastante
a��o e � viciante, seja voc� um novato ou um f�. Seu est�dio � a Blizzard. E o
jogo custa R$ 99,00;*/
INSERT INTO Jogos(nomeJogo, descri��o, dataLancamento, valor, idEstudio) VALUES
('Diablo 3', '� um jogo que cont�m bastante a��o e � viciante, 
seja voc� um novato ou um f�', '2012-05-15', 99, 1);
GO


/*Inserir um jogo com o nome de: Red Dead Redemption II, com a descri��o de: jogo
eletr�nico de a��o-aventura western. Seu est�dio ser� a Rockstar Studios. Lan�ado
mundialmente em 26 de outubro de 2018. E o jogo custa R$ 120,00;*/
INSERT INTO Jogos(nomeJogo, descri��o, dataLancamento, valor, idEstudio) VALUES
('Red Dead Redemption II','jogo
eletr�nico de a��o-aventura western','2018-10-26',120,2);