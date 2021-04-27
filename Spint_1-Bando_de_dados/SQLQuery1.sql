

CREATE DATABASE Filmes
USE FILMES

CREATE TABLE Genero(
idGenero int PRIMARY KEY IDENTITY,
nome varchar(255)
)

CREATE TABLE Filme(
idFilme INT PRIMARY KEY IDENTITY,
titulo VARCHAR(255),
idGenero int FOREIGN KEY REFERENCES Genero(idGenero)
)

SELECT * FROM FILME