USE MASTER


USE SpMedicalGroup;
GO


INSERT INTO Especialidades(Nome) VALUES
			('Acupuntura'),
			('Anestesiologia'),
			('Angiologia'),
			('Cardiologia'),
			('Cirurgia Cardiovascular'),
			('Cirurgia da M�o'),
			('Cirurgia do Aparelho Digestivo'),
			('Cirurgia Geral'),
			('Cirurgia Pedi�trica'),
			('Cirurgia Pl�stica'),
			('Cirurgia Tor�cica'),
			('Cirurgia Vascular'),
			('Dermatologia'),
			('Radioterapia'),
			('Urologia'),
			('Pediatria'),
			('Psiquiatria');
GO

INSERT INTO Medicos(CRM,Nome,Email,IdEspecialidade,Clinica,CNPJ,RazaoSocial,Endereco) VALUES
			('54356-SP' ,'Ricardo Lemos','ricardo.lemos@spmedicalgroup.com.br',2,'Clinica Possarle','86400902000130','SP Medical Group','Av. Bar�o Limeira, 532, S�o Paulo, SP'),
			('53452-SP','Roberto Possarle','roberto.possarle@spmedicalgroup.com.br',17,'Clinica Possarle','86400902000130','SP Medical Group','Av. Bar�o Limeira, 532, S�o Paulo, SP'),
			('65463-SP','Helena Strada','helena.souza@spmedicalgroup.com.br',16,'Clinica Possarle','86400902000130','SP Medical Group','Av. Bar�o Limeira, 532, S�o Paulo, SP');
GO

INSERT INTO Prontuarios(Nome,Email,DataNascimento,Telefone,RG,CPF,Endereco)VALUES
			('Ligia', 'ligia@gmail.com', '1983-10-13', '11 3456-7654', '43522543-5', '94839859000', 'Rua Estado de Israel 240,�S�o Paulo, Estado de S�o Paulo, 04022-000'),
			('Alexandre', 'alexandre@gmail.com', '2001-7-23', '11 98765-6543', '32654345-7', '73556944057', 'Av. Paulista, 1578 - Bela Vista, S�o Paulo - SP, 01310-200'),
			('Fernando', 'fernando@gmail.com', '1978-10-10', '11 97208-4453', '54636525-3', '16839338002', 'Av. Ibirapuera - Indian�polis, 2927,  S�o Paulo - SP, 04029-200'),
			('Henrique', 'henrique@gmail.com', '1985-10-13', '11 3456-6543', '54366362-5', '14332654765', 'R. Vit�ria, 120 - Vila Sao Jorge, Barueri - SP, 06402-030'),
			('Jo�o', 'joao@hotmail.com', '1975-8-27', '11 7656-6377', '53254444-1', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeir�o Pires - SP, 09405-380'),
			('Bruno', 'bruno@gmail.com', '1972-3-21', '11 95436-8769', '54566266-7', '79799299004', 'Alameda dos Arapan�s, 945 - Indian�polis, S�o Paulo - SP, 04524-001'),
			('Mariana', 'mariana@outlook.com', '2018-3-5', 'NULL', '54566266-8', '13771913039', 'R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140')
;
GO

INSERT INTO Consultas(IdProntuario,IdMedico,DataConsulta,Situacao) VALUES
			(7,3,'2020-20-1 15:00:00','Realizada'),
			(2,2,'2020-1-6 10:00:00','Cancelada'),
			(3,2,'2020-2-7 11:00:00 ','Realizada'),
			(2,2,'2018-2-6 10:00:00','Realizada'),
			(4,1,'2019-2-7 11:00:00','Cancelada'),
			(7,3,'2020-3-8 15:00:00','Agendada'),
			(4,1,'2020-3-9 11:00:00','Agendada');

SELECT * FROM Consultas