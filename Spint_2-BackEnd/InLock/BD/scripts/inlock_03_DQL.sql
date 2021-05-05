USE inlock_games_manha;

-- Listar todos os usu�rios;
SELECT * FROM Usuario;

--Listar todos os est�dios;
SELECT * FROM Estudio;

--Listar todos os jogos;
SELECT * FROM Jogos;

--Listar todos os jogos e seus respectivos est�dios;
SELECT JOGOS.nomeJogo AS [Nome do jogo], Estudio.nomeEstudio AS Estudio FROM JOGOS
INNER JOIN Estudio ON Jogos.idJogo = Estudio.idEstudio

--Buscar e trazer na lista todos os est�dios com os respectivos jogos. Obs.: Listar
--todos os est�dios mesmo que eles n�o contenham nenhum jogo de refer�ncia;
SELECT Estudio.nomeEstudio AS Estudio, JOGOS.nomeJogo AS [Nome do jogo] FROM JOGOS
FULL JOIN Estudio ON Jogos.idJogo = Estudio.idEstudio

--Buscar um usu�rio por e-mail e senha (login);
SELECT * FROM Usuario WHERE email like 'cliente@cliente.com' AND senha LIKE 'cliente';

--Buscar um jogo por idJogo;
SELECT * FROM Jogos WHERE idJogo = 2

--Buscar um est�dio por idEstudio;
SELECT * FROM Estudio WHERE idEstudio = 1