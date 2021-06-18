USE Pclinics;
GO

SELECT * FROM Clinicas;

SELECT * FROM TiposPets;

SELECT * FROM Racas;

SELECT * FROM Donos;

SELECT * FROM Veterinarios;

SELECT * FROM Pets;

SELECT * FROM Atendimentos;


SELECT V.Nome AS Veterin�rio, V.CRMV, C.RazaoSocial AS Clinica FROM Veterinarios V
INNER JOIN Clinicas C
ON V.IdClinica = C.IdClinica;


SELECT Racas.Descricao AS Ra�as FROM Racas
WHERE Racas.Descricao LIKE 'S%';


SELECT TiposPets.Descricao AS [Tipos de pets] FROM TiposPets
WHERE TiposPets.Descricao LIKE '%O';


SELECT P.Nome AS Pet, D.Nome AS Dono FROM Pets P
INNER JOIN Donos D
ON P.IdDono = D.IdDono


SELECT A.DataAtendimento AS [Data da consulta], A.Descricao, V.Nome AS Veterin�rio,
P.Nome AS Pet, R.Descricao AS Ra�a, TP.Descricao AS [Tipo do pet], D.Nome AS Dono,
C.RazaoSocial AS Cl�nica
FROM Atendimentos A
INNER JOIN Veterinarios V
ON A.IdVeterinario = V.IdVeterinario
INNER JOIN Pets P
ON A.IdPet = P.IdPet
INNER JOIN Racas R
ON P.IdRaca = R.IdRaca
INNER JOIN TiposPets TP
ON R.IdTipoPet = TP.IdTipoPet
INNER JOIN Donos D
ON P.IdDono = D.IdDono
INNER JOIN Clinicas C
ON V.IdClinica = C.IdClinica;