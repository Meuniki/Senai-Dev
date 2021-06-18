USE Veiculos;
GO

SELECT * FROM Empresas;

SELECT * FROM Marcas;

SELECT * FROM Modelos;

SELECT * FROM Veiculos;

SELECT * FROM Clientes;

SELECT * FROM Alugueis;


SELECT DataInicio, DataFim, Clientes.Nome AS Cliente, Modelos.Descricao AS Modelo, Veiculos.Placa
FROM Alugueis
INNER JOIN Clientes
ON Alugueis.IdCliente = Clientes.IdCliente
INNER JOIN Veiculos
ON Alugueis.IdVeiculo = Veiculos.IdVeiculo
INNER JOIN Modelos
ON Modelos.IdModelo = Veiculos.IdModelo


SELECT DataInicio, DataFim, Clientes.Nome AS Cliente, Modelos.Descricao AS Modelo, Veiculos.Placa
FROM Alugueis
INNER JOIN Clientes
ON Alugueis.IdCliente = Clientes.IdCliente
INNER JOIN Veiculos
ON Alugueis.IdVeiculo = Veiculos.IdVeiculo
INNER JOIN Modelos
ON Modelos.IdModelo = Veiculos.IdModelo
WHERE Clientes.Nome = 'Saulo';