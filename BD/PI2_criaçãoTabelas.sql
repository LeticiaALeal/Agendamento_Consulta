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

