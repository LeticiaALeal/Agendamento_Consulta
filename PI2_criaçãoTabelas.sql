CREATE DATABASE lebi;
USE lebi;


CREATE TABLE Pacientes (
	idPaciente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
	email VARCHAR(100),
	cpf VARCHAR(11),
    telefone VARCHAR (12),
    endereco VARCHAR (100),
    dataNascimento DATE
);

CREATE  TABLE Medicos (
	idMedico INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR (100),
    especialidade VARCHAR (100),
    CRM VARCHAR (10)
 );   

/*CREATE TABLE Especialidade (
	idEspecialidade INT (2) 


); */

CREATE TABLE Consultas (
	idMedico INT,
	idPaciente INT, 
	dataConsulta DATE,
	hora TIME, 
    
	FOREIGN KEY (idMedico) REFERENCES Medicos (idMedico) on update cascade,
	FOREIGN KEY (idPaciente) REFERENCES Pacientes (idPaciente) on update cascade    
);
