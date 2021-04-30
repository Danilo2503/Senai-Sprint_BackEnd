USE SENAI_HROADS_MANHA;

INSERT INTO Classes(Nome)
VALUES ('Bárbaro'),('Cruzado'),('Caçadora de Demônios'),('Monge'),('Necromante'),('Feitiçeiro'),('Arcanista');

INSERT INTO Personagens(IdClasse,Nome,CapacidadeVida,CapacidadeMana,DataAtualizacao,DataCriacao)
VALUES (1,'DeuBug',100,80,'2021-03-01','2019-01-18')
	  ,(4,'BitBug',70,100,'2021-03-01','2016-03-17')
	  ,(7,'Fer8',75,60,'2021-03-01','2018-03-18');

INSERT INTO TiposDeHabilidades(Nome)
VALUES ('Ataque'),('Defesa'),('Cura'),('Magia');

INSERT INTO Habilidades(IdTipoHabilidade,Nome)
VALUES (1,'Lança Mortal'),(2,'Escudo Supremo'),(3,'Recuperar Vida'),(4,'');

INSERT INTO Classes_Habilidades(IdClasse,IdHabilidade)
VALUES (1,1),(1,2),(2,2),(3,1),(4,2),(4,3),(6,3);

INSERT INTO TiposUsuarios(Titulo)
VALUES ('Administrador'),('Jogador');

INSERT INTO Usuarios(Nome,Email,Senha,idTipoUsuario)
VALUES ('Danilo','danilo@email.com','senai132',1),('Enzzo','enzzo@email.com','132senai',2);

