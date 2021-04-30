USE Senai_HROADS_Manha;

--Exercício 10
SELECT COUNT (IdHabilidade) AS [Quant. de Habilidades]
FROM Habilidade;

--Exercício 11
SELECT IdHabilidade
FROM Habilidade
ORDER BY IdHabilidade ASC;

--Exercício 12
SELECT * FROM TipoHabilidade;

--Exercício 13
SELECT Habilidade.NomeHabilidade As Habilidade, TipoHabilidade.TipoHabilidade AS Genero FROM Habilidade
LEFT JOIN TipoHabilidade
ON Habilidade.IdTipoHabilidade = TipoHabilidade.IdTipoHabilidade;

--Exercício 14
SELECT Personagem.NomePersonagem AS Personagem, Classe.NomeClasse AS Classe FROM Personagem
LEFT JOIN Classe
ON Personagem.IdClasse = Classe.IdClasse;

--Exercício 15
SELECT Personagem.NomePersonagem AS Personagem , Classe.NomeClasse AS Classe FROM Personagem
RIGHT JOIN Classe
ON Personagem.IdClasse = Classe.IdClasse;

--Exercício 16
SELECT Classe.NomeClasse AS Classe, Habilidade.NomeHabilidade AS Habilidades FROM ClasseHabilidade
INNER JOIN Habilidade
ON Habilidade.IdHabilidade = ClasseHabilidade.IdHabilidade
INNER JOIN Classe
ON Classe.IdClasse = ClasseHabilidade.IdClasse;

--Exercício 17
SELECT Habilidade.NomeHabilidade AS Habilidade, Classe.NomeClasse AS Classe FROM ClasseHabilidade
INNER JOIN Habilidade
ON Habilidade.IdHabilidade = ClasseHabilidade.IdHabilidade
INNER JOIN Classe
ON Classe.IdClasse = ClasseHabilidade.IdClasse;

--Exercício 18
SELECT Habilidade.NomeHabilidade AS Habilidade, Classe.NomeClasse AS Classe FROM ClasseHabilidade
LEFT JOIN Habilidade
ON Habilidade.IdHabilidade = ClasseHabilidade.IdHabilidade
LEFT JOIN Classe
ON Classe.IdClasse = ClasseHabilidade.IdClasse;