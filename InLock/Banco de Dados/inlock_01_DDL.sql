CREATE DATABASE InLock_Games_Manha;

USE InLock_Games_Manha;

CREATE TABLE Estudios
(
	idEstudio			INT PRIMARY KEY IDENTITY
	,nomeEstudio		VARCHAR(200) NOT NULL
);

CREATE TABLE Jogos
(
	idJogo				INT PRIMARY KEY IDENTITY
	,idEstudio			INT FOREIGN KEY REFERENCES Estudios (idEstudio)
	,nomeJogo			VARCHAR(200) NOT NULL
	,descricao			VARCHAR(150) NOT NULL
	,dataLancamento		DATE
	,valor				FLOAT
);

CREATE TABLE TipoUsuarios
(
	idTipoUsuario		INT PRIMARY KEY IDENTITY
	,titulo				VARCHAR(200) NOT NULL
);

CREATE TABLE Usuarios
(
	idUsuario			INT PRIMARY KEY IDENTITY
	,idTipoUsuario		INT FOREIGN KEY REFERENCES TipoUsuarios (idTipoUsuario)
	,titulo				VARCHAR(200)
	,email				VARCHAR(150) NOT NULL
	,senha				VARCHAR(150) NOT NULL
);