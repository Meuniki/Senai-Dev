USE Optus;
GO

SELECT * FROM Artistas;

SELECT * FROM Estilos;

SELECT * FROM Albuns;

SELECT * FROM AlbunsEstilos;

SELECT * FROM Usuarios;


SELECT Nome, Email, Permissao FROM Usuarios
WHERE Usuarios.Permissao LIKE 'Administrador'


SELECT Titulo AS Album, YEAR(DataLancamento) AS Lancamento, Localizacao, QtdMinutos AS Duração, Ativo, Artistas.Nome AS Artista 
FROM Albuns
INNER JOIN Artistas
ON Albuns.IdArtista = Artistas.IdArtista
WHERE Albuns.DataLancamento > '2000'


SELECT Nome, Email, Permissao FROM Usuarios
WHERE Email LIKE 's.santos@email.com' AND Senha LIKE '123456'


SELECT Titulo, DataLancamento, Localizacao, QtdMinutos, Ativo, AR.Nome AS Artista, E.Nome AS Estilo 
FROM Albuns AL
INNER JOIN Artistas AR
ON AL.IdArtista = AR.IdArtista
INNER JOIN AlbunsEstilos AE
ON AL.IdAlbum = AE.IdAlbum
INNER JOIN Estilos E
ON AE.IdEstilo = E.IdEstilo
WHERE AL.Ativo = 'true'