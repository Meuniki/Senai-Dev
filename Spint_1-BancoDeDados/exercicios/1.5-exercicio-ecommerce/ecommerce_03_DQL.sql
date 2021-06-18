USE Ecommerce;
GO

SELECT * FROM Lojas;

SELECT * FROM Categorias;

SELECT * FROM SubCategorias;

SELECT * FROM Produtos;

SELECT * FROM Clientes;

SELECT * FROM Pedidos;

SELECT * FROM PedidosProdutos;


SELECT CL.Nome Cliente, PR.Titulo Produto, SC.Nome SubCategoria, CA.Nome Categoria FROM Pedidos PE
INNER JOIN Clientes CL
ON PE.IdCliente = CL.IdCliente
INNER JOIN PedidosProdutos PP
ON PE.IdPedido = PP.IdPedido
INNER JOIN Produtos PR
ON PP.IdProduto = PR.IdProduto
INNER JOIN SubCategorias SC
ON PR.IdSubCategoria = SC.IdSubCategoria
INNER JOIN Categorias CA
ON SC.IdCategoria = CA.IdCategoria;