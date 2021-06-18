USE Pessoas;

SELECT * FROM Pessoas;

SELECT * FROM Telefones;

SELECT * FROM Emails;

SELECT * FROM CNHs;

SELECT Pessoas.Nome, Telefones.Descricao AS Telefone, Emails.Descricao AS Email,
CNHs.Descricao AS CNH FROM Pessoas 
INNER JOIN Telefones
ON Pessoas.IdPessoa = Telefones.IdPessoa
INNER JOIN Emails
ON Pessoas.IdPessoa = Emails.IdPessoa
INNER JOIN CNHs
ON Pessoas.IdPessoa = CNHs.IdPessoa
ORDER BY Pessoas.Nome DESC;