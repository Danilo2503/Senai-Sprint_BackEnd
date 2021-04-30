USE Senai_HROADS_Manha;

INSERT INTO TipoHabilidade (TipoHabilidade)
VALUES					   ('Ataque')
						  ,('Defesa')
						  ,('Cura')
						  ,('Magia');

INSERT INTO Habilidade (NomeHabilidade, IdTipoHabilidade)
VALUES				   ('Lança Mortal', 1)
					  ,('Escudo Supremo', 2)
					  ,('Recuperar Vida', 3);

INSERT INTO Classe (NomeClasse)
VALUES			   ('Bárbaro')
				  ,('Cruzado')
				  ,('Caçadora de Demônios')
				  ,('Monge')
				  ,('Necromante')
				  ,('Feiticeiro')
				  ,('Arcanista');

INSERT INTO Personagem (NomePersonagem, IdClasse, VidaMáxima, ManaMáxima, DataAtualizacao, DataCriacao)
VALUES				   ('DeuBug' , 1 , 100 , 80 , '03/03/2021', '18/01/2019')
					  ,('BitBug' , 4 , 70 , 100 , '03/03/2021', '17/03/2016')
					  ,('Fer8' , 7 , 75 , 60 , '03/03/2021' , '19/03/2018');

INSERT INTO ClasseHabilidade (IdClasse, IdHabilidade)
VALUES						 (1, 1)
							,(1, 2)
							,(2, 2)
							,(3, 1)
							,(4, 3)
							,(4, 2)
							,(5, null)
							,(6, 3)
							,(7, null);

--Exercício 4
UPDATE Personagem
SET NomePersonagem = 'Fer7'
WHERE IdPersonagem = 3;

--Exercício 5
UPDATE Classe
SET NomeClasse = 'Necromancer'
WHERE IdClasse = 5;

--Exercício 6
SELECT * FROM Personagem

--Exercício 7
SELECT * FROM Classe

--Exercício 8
SELECT NomeClasse FROM Classe;

--Exercício 9
SELECT * FROM Habilidade;


