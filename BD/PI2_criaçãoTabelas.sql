CREATE DATABASE lebi;
USE lebi;

CREATE TABLE Pacientes (
	id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
	email VARCHAR(100),
	cpf VARCHAR(14),
    telefone VARCHAR (12),
    endereco VARCHAR (100),
    dataNascimento DATE
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

CREATE TABLE agenda_medico (
	id INT AUTO_INCREMENT PRIMARY KEY,
	idMedico INT,
	idAgenda INT,
	
	FOREIGN KEY (idMedico) REFERENCES Medicos(id),
	FOREIGN KEY (idAgenda) REFERENCES Agenda(id)
	
);