CREATE DATABASE lebi;
USE lebi;

select * from pacientes;
-- TRUNCATE TABLE Pacientes;


CREATE TABLE Pacientes (
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	cpf VARCHAR(14) NOT NULL,
    telefone VARCHAR (14) NOT NULL,
    endereco VARCHAR (100),
    dataNascimento DATE,
    senha VARCHAR (100) NOT NULL
);

CREATE  TABLE Medicos (
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR (100),
    especialidade VARCHAR (100),
    CRM VARCHAR (10)
 );   

 
CREATE TABLE Agenda (
	id INT AUTO_INCREMENT PRIMARY KEY, 
    horario time,
	dia varchar(20)
);

CREATE TABLE Agenda_Medico (
	id INT AUTO_INCREMENT PRIMARY KEY,
	idMedico INT,
	idAgenda INT,
	
	FOREIGN KEY (idMedico) REFERENCES Medicos(id),
	FOREIGN KEY (idAgenda) REFERENCES Agenda(id)	
);

CREATE TABLE consulta_paciente (
	id INT AUTO_INCREMENT PRIMARY KEY,
    email VARCHAR(100),
	medico varchar (100),
    especialidade varchar (100),
	horario time,
	dia varchar (20)
);

DROP TABLE consulta_paciente;

select * from consulta_paciente;

