USE MASTER
GO
DROP DATABASE IF EXISTS SENAI_HROADS_MANHA
GO

CREATE DATABASE SENAI_HROADS_MANHA;
GO 

USE SENAI_HROADS_MANHA;
GO

CREATE TABLE Classes(
	IdClasse INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(200)
);
GO

CREATE TABLE Personagens(
	IdPersonagen INT PRIMARY KEY IDENTITY,
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse),
	Nome VARCHAR(200) NOT NULL UNIQUE,
	CapMaxVida INT NOT NULL,
	CapMaxMana INT NOT NULL,
	DataAtualizacao DATE NOT NULL,
	DataCriacao DATE NOT NULL,
);
GO

CREATE TABLE TipoHabilidades(
	IdTipoHalidade INT PRIMARY KEY IDENTITY,
	descricao VARCHAR(300) NOT NULL
);
GO

CREATE TABLE Habilidades(
	IdHabilidade INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(500) NOT NULL,
	IdTipoHabilidade INT FOREIGN KEY REFERENCES TipoHabilidades(IdTipoHalidade)
);
GO

CREATE TABLE ClassesHabilidades(
	IdHabilidade INT FOREIGN KEY REFERENCES Habilidades (IdHabilidade),
	IdClasse INT FOREIGN KEY REFERENCES Classes (IdClasse)
);
GO