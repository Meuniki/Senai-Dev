USE MASTER


USE SpMedicalGroup;
GO


INSERT INTO Especialidades(Nome) VALUES
			('Acupuntura'),
			('Anestesiologia'),
			('Angiologia'),
			('Cardiologia'),
			('Cirurgia Cardiovascular'),
			('Cirurgia da Mão'),
			('Cirurgia do Aparelho Digestivo'),
			('Cirurgia Geral'),
			('Cirurgia Pediátrica'),
			('Cirurgia Plástica'),
			('Cirurgia Torácica'),
			('Cirurgia Vascular'),
			('Dermatologia'),
			('Radioterapia'),
			('Urologia'),
			('Pediatria'),
			('Psiquiatria');
GO

INSERT INTO TipoUsuarios(Tipo) VALUES
			('Paciente'),
			('Medico'),
			('ADM');
GO

INSERT INTO Usuarios(Email,Senha,IdTipoUsuario) VALUES
			('ricardo.lemos@spmedicalgroup.com.br', '123',2),
			('roberto.possarle@spmedicalgroup.com.br', '456',2),
			('helena.souza@spmedicalgroup.com.br', '789',2),
			('ligia@gmail.com','abc',1),
			('alexandre@gmail.com','def',1),
			('fernando@gmail.com','ghi',1),
			('henrique@gmail.com','jkl',1),
			('joao@hotmail.com','mno',1),
			('bruno@gmail.com','pqr',1),
			('mariana@outlook.com','stu',1)
GO

INSERT INTO Clinicas(Nome,CNPJ,RazaoSocial,Endereco) VALUES
			('Clinica Possarle','86400902000130','SP Medical Group','Av. Barão Limeira, 532, São Paulo, SP')

INSERT INTO Medicos(CRM,Nome,IdEspecialidade,IdClinica, IdUsuario) VALUES
			('54356-SP' ,'Ricardo Lemos',2,1,1),
			('53452-SP','Roberto Possarle',17,1,2),
			('65463-SP','Helena Strada',16,1,3);
GO

INSERT INTO Pacientes(Nome,DataNascimento,Telefone,RG,CPF,Endereco,IdUsuario)VALUES
			('Ligia', '1983-10-13', '11 3456-7654', '43522543-5', '94839859000', 'Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000',1),
			('Alexandre', '2001-7-23', '11 98765-6543', '32654345-7', '73556944057', 'Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200',1),
			('Fernando', '1978-10-10', '11 97208-4453', '54636525-3', '16839338002', 'Av. Ibirapuera - Indianópolis, 2927,  São Paulo - SP, 04029-200',1),
			('Henrique', '1985-10-13', '11 3456-6543', '54366362-5', '14332654765', 'R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030',1),
			('João', '1975-8-27', '11 7656-6377', '53254444-1', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380',1),
			('Bruno', '1972-3-21', '11 95436-8769', '54566266-7', '79799299004', 'Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001',1),
			('Mariana', '2018-3-5', 'NULL', '54566266-8', '13771913039', 'R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140',1)
;
GO


INSERT INTO Consultas(IdPaciente,IdMedico,DataConsulta,Situacao, Descricao) VALUES
			(7,3,'2020-20-1 15:00:00','Realizada',NULL),
			(2,2,'2020-1-6 10:00:00','Cancelada', NULL),
			(3,2,'2020-2-7 11:00:00 ','Realizada', NULL),
			(2,2,'2018-2-6 10:00:00','Realizada', NULL),
			(4,1,'2019-2-7 11:00:00','Cancelada', NULL),
			(7,3,'2020-3-8 15:00:00','Agendada', NULL),
			(4,1,'2020-3-9 11:00:00','Agendada', NULL);
GO
