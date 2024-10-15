CREATE DATABASE IF NOT EXISTS academico;

USE academico;

CREATE TABLE aluno
(
	id 			    INT         NOT NULL AUTO_INCREMENT,
    matricula  		VARCHAR(15) NOT NULL,
    dt_nascimento 	DATETIME    NOT NULL,
    nome            VARCHAR(80) NOT NULL,
    endereco        VARCHAR(80) NOT NULL,
    bairro          VARCHAR(80) NOT NULL,
    cidade          VARCHAR(80) NOT NULL,
    estado          VARCHAR(02) NOT NULL,
    senha           VARCHAR(20) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE curso (
    id INT NOT NULL AUTO_INCREMENT,
    codigo INT NOT NULL,
    nome VARCHAR(80) NOT NULL,
    nivel VARCHAR(20) NOT NULL,
    duracao INT NOT NULL,
    periodo VARCHAR(20) NOT NULL,
    area VARCHAR(20) NOT NULL,
    PRIMARY KEY (id)
);
