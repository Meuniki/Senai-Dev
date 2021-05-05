USE inlock_games_manha;

-- Listar todos os usuários;
SELECT * FROM Usuario;

--Listar todos os estúdios;
SELECT * FROM Estudio;

--Listar todos os jogos;
SELECT * FROM Jogos;

--Listar todos os jogos e seus respectivos estúdios;
SELECT JOGOS.nomeJogo AS [Nome do jogo], Estudio.nomeEstudio AS Estudio FROM JOGOS
INNER JOIN Estudio ON Jogos.idJogo = Estudio.idEstudio

--Buscar e trazer na lista todos os estúdios com os respectivos jogos. Obs.: Listar
--todos os estúdios mesmo que eles não contenham nenhum jogo de referência;
SELECT Estudio.nomeEstudio AS Estudio, JOGOS.nomeJogo AS [Nome do jogo] FROM JOGOS
FULL JOIN Estudio ON Jogos.idJogo = Estudio.idEstudio

--Buscar um usuário por e-mail e senha (login);
SELECT * FROM Usuario WHERE email like 'cliente@cliente.com' AND senha LIKE 'cliente';

--Buscar um jogo por idJogo;
SELECT * FROM Jogos WHERE idJogo = 2

--Buscar um estúdio por idEstudio;
SELECT * FROM Estudio WHERE idEstudio = 1