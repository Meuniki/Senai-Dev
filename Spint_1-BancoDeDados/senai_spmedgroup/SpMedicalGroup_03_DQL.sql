USE MASTER

use SpMedicalGroup

SELECT * FROM USUARIOS;

SELECT * FROM TipoUsuarios;

SELECT * FROM Medicos;
SELECT IdMedico, CRM, Nome, IdEspecialidade, IdClinica, IdUsuario FROM Medicos;

SELECT * FROM Pacientes;

SELECT * FROM Clinicas;
SELECT IdClinica, Nome, CNPJ, RazaoSocial, Endereco  FROM Clinicas;

SELECT * FROM Consultas;
SELECT IdConsulta, DataConsulta, Situacao, Descricao, IdMedico, IdPaciente FROM Consultas

SELECT * FROM Especialidades;