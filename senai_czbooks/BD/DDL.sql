CREATE DATABASE	Czbooks;
GO

USE Czbooks;
GO

CREATE TABLE Categorias(
	IdCategoria INT PRIMARY KEY IDENTITY,
	Tipo VARCHAR(60) NOT NULL
);
GO

CREATE TABLE Livrarias(
	IdLivraria INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(200) NOT NULL,
	Endereco VARCHAR(300) NOT NULL
);
GO

CREATE TABLE TipoUsuarios(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	Tipo VARCHAR(500)
);
GO

CREATE TABLE Usuarios(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuarios(IdTipoUsuario),
	Email VARCHAR(200) NOT NULL UNIQUE,
	Senha VARCHAR(200) NOT NULL
);
GO

CREATE TABLE Autores(
	IdAutor INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuarios(IdUsuario),
	Nome VARCHAR(500)
);
GO

CREATE TABLE Livros(
	IdLivro INT PRIMARY KEY IDENTITY,
	IdCategoria INT FOREIGN KEY REFERENCES Categorias(IdCategoria),
	IdLivraria INT FOREIGN KEY REFERENCES Livrarias(IdLivraria),
	IdAutor INT FOREIGN KEY REFERENCES Autores(IdAutor),
	Titulo VARCHAR(200) NOT NULL,
	Sinopse VARCHAR(2000) NOT NULL,
	DataPublicacao DATE NOT NULL,
	Preco DECIMAL(18,2) NOT NULL
);
GO