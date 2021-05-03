USE M_Peoples;

SELECT nome, sobrenome 
FROM Funcionarios;

SELECT nome, sobrenome 
FROM Funcionarios 
WHERE idFuncionarios = 1;

SELECT CONCAT (nome, ' ', sobrenome) AS nomeCompleto 
FROM Funcionarios

SELECT nome, sobrenome 
FROM funcionarios
ORDER BY sobrenome ASC;
