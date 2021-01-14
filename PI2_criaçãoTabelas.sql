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
 
CREATE TABLE Agenda (
	idAgenda INT AUTO_INCREMENT, 
    idMedico INT,
	idPaciente INT, 
	idConsulta INT,
    
	FOREIGN KEY (idMedico) REFERENCES Medicos (idMedico) on update cascade,
	FOREIGN KEY (idPaciente) REFERENCES Pacientes (idPaciente) on update cascade,   
    FOREIGN KEY (idAgenda) REFERENCES ConsultasMarcadas(idConsulta)
);

CREATE TABLE ConsultasMarcadas (
	idConsulta INT AUTO_INCREMENT,	
    dataConsulta DATE,
	horaConsulta TIME, 

	FOREIGN KEY (idConsulta) REFERENCES Agenda(idAgenda) on update cascade
); 

 


