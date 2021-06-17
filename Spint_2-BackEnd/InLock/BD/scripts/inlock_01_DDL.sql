-- Criar um banco de dados chamado inlock_games_manha/tarde;
CREATE DATABASE inlock_games_manha;
GO

USE inlock_games_manha;
GO

-- Criar uma tabela de estúdios com os campos de idEstudio e nomeEstudio;
CREATE TABLE Estudio(
idEstudio INT PRIMARY KEY IDENTITY,
nomeEstudio VARCHAR(255) UNIQUE NOT NULL
);
GO

--  Criar uma tabela de jogos com os campos idJogo, nomeJogo, descrição,
-- dataLancamento, valor e idEstudio;
CREATE TABLE Jogos(
idJogo INT PRIMARY KEY IDENTITY,
nomeJogo VARCHAR(255) UNIQUE NOT NULL,
descrição TEXT NOT NULL,
dataLancamento DATE NOT NULL,
valor DECIMAL(18,2) NOT NULL,
idEstudio INT FOREIGN KEY REFERENCES Estudio(idEstudio)
);
GO

--Criar uma tabela de tipos de usuários contendo os campos idTipoUsuario e titulo;
CREATE TABLE TipoUsuario(
idTipoUsuario INT PRIMARY KEY IDENTITY NOT NULL,
titulo VARCHAR(255) UNIQUE NOT NULL
);
GO

--Criar uma tabela de usuários contendo os campos de idUsuario, email, senha e idTipoUsuario;
CREATE TABLE Usuario(
idUsuario INT PRIMARY KEY IDENTITY,
email VARCHAR(255) UNIQUE NOT NULL,
senha VARCHAR(255) NOT NULL,
idTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(idTipoUsuario)
);