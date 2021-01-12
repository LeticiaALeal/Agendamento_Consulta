CREATE DATABASE lebi;
USE lebi;

CREATE TABLE Pacientes (
	idPaciente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
	email VARCHAR(100),
	cpf VARCHAR(11),
    telefone VARCHAR (10),
    endereco VARCHAR (100),
    dataNascimento DATE
);

CREATE  TABLE Medicos (
	idMedico INT AUTO_INCREMENT,
    nome VARCHAR (100),
    idEspecialidade VARCHAR (100), 
    
    PRIMARY KEY (idMedico, idEspecialidade)
);

CREATE TABLE Especialidade (
	idEspecialidade VARCHAR (100) 


);