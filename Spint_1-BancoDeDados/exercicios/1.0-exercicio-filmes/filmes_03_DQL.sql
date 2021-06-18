USE Filmes;

SELECT * FROM Generos;

SELECT * FROM Filmes;


SELECT Filmes.idFilme, Filmes.Titulo AS Filme, Generos.Nome AS Genero FROM Filmes -- Tabela1
INNER JOIN Generos
ON Filmes.idGenero = Generos.idGenero;


SELECT Filmes.idFilme, Filmes.Titulo AS Filme, Generos.Nome AS Genero FROM Filmes -- Tabela1
LEFT JOIN Generos
ON Filmes.idGenero = Generos.idGenero;


SELECT Filmes.idFilme, Filmes.Titulo AS Filme, Generos.Nome AS Genero FROM Filmes -- Tabela1
RIGHT JOIN Generos
ON Filmes.idGenero = Generos.idGenero;


SELECT Filmes.idFilme, Filmes.Titulo AS Filme, Generos.Nome AS Genero FROM Filmes -- Tabela1
FULL OUTER JOIN Generos
ON Filmes.idGenero = Generos.idGenero;


SELECT * FROM Usuarios;


SELECT idUsuario, email, senha, permissao FROM Usuarios
WHERE email = 'saulo@email.com' AND senha = '123';