USE Czbooks
GO

INSERT INTO Categorias(Tipo) VALUES
('Aventura'),
('A��o'),
('Terror'),
('Misterio'),
('Fant�sia'),
('M�fia');
GO

INSERT INTO Livrarias(Nome,Endereco) VALUES
('Cultura','Av: Paulista');
GO

INSERT INTO TipoUsuarios(Tipo) VALUES
('Administrador'),
('Cliente'),
('Autor');
GO

INSERT INTO Usuarios(Email,Senha,IdTipoUsuario) VALUES
('adm@adm.com','123',1),
('cliente@cliente.com','123',2),
('autor@autor.com','123',3),
('autor2@autor.com','123',3),
('autor3@autor.com','123',3);
GO

INSERT INTO Autores(Nome,IdUsuario) VALUES
('J. K. Rowling',3),
('J. R. R. Tolkien',4),
('Mario Puzo',5);
GO

INSERT INTO Livros(Titulo,Sinopse,DataPublicacao,Preco,IdCategoria,IdAutor,IdLivraria) VALUES
('Harry Potter e a Pedra Filosofal','O livro conta a hist�ria de Harry Potter, um �rf�o','1997-07-26',34.57,1,1,1),
('A Sociedade do Anel','Narra o in�cio da  hist�ria do Um Anel','1954-06-29',39.90,5,2,1),
('O poderoso chef�o','sobre uma fam�lia de mafiosos de origem siciliana que imigra para os Estados Unidos.','1969-03-10',60.71,6,3,1);
GO