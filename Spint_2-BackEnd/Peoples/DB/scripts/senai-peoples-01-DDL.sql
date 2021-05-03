CREATE DATABASE M_Peoples;
GO

USE M_Peoples;
GO

CREATE TABLE Funcionarios
(
	idFuncionarios		INT PRIMARY KEY IDENTITY,
	nome				VARCHAR(250) NOT NULL,
	sobrenome			VARCHAR(250) NOT NULL
);
GO