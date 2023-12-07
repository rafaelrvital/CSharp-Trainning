-- 1 - Buscar o nome e ano dos filmes
SELECT NOME
	 , ANO
  FROM FILMES

-- 2 - Buscar o nome e ano dos filmes, ordenados por ordem crescente pelo ano
SELECT NOME
	 , ANO
  FROM FILMES
 ORDER BY ANO

-- 3 - Buscar pelo filme de volta para o futuro, trazendo o nome, ano e a dura��o
SELECT NOME
	 , ANO
	 , DURACAO
  FROM FILMES
 WHERE NOME = 'De volta para o futuro'

-- 4 - Buscar os filmes lan�ados em 1997
SELECT ID
	 , NOME
	 , ANO
	 , DURACAO
  FROM FILMES
 WHERE ANO = 1997

-- 5 - Buscar os filmes lan�ados AP�S o ano 2000
SELECT ID
	 , NOME
	 , ANO
	 , DURACAO
  FROM FILMES
 WHERE ANO > 2000

-- 6 - Buscar os filmes com a duracao maior que 100 e menor que 150, ordenando pela duracao em ordem crescente
SELECT ID
	 , NOME
	 , ANO
	 , DURACAO
  FROM FILMES
 WHERE DURACAO > 100
   AND DURACAO < 150
 ORDER BY DURACAO DESC

-- 7 - Buscar a quantidade de filmes lan�adas no ano, agrupando por ano, ordenando pela quantidade de filmes lan�ados em ordem decrescente
SELECT ANO
	 , COUNT(*) AS QUANTIDADE
FROM FILMES
GROUP BY ANO
ORDER BY QUANTIDADE DESC

-- 8 - Buscar os Atores do g�nero masculino, retornando o PrimeiroNome, UltimoNome
SELECT ID
	 , PRIMEIRONOME
	 , ULTIMONOME
	 , GENERO
  FROM ATORES
 WHERE GENERO = 'M'

-- 9 - Buscar os Atores do g�nero feminino, retornando o PrimeiroNome, UltimoNome, e ordenando pelo PrimeiroNome
SELECT ID
	 , PRIMEIRONOME
	 , ULTIMONOME
	 , GENERO
  FROM ATORES
 WHERE GENERO = 'F'
 ORDER BY PRIMEIRONOME

-- 10 - Buscar o nome do filme e o g�nero
SELECT FILMES.NOME
	 , GENEROS.GENERO
  FROM FILMESGENERO
 INNER JOIN FILMES ON FILMESGENERO.IDFILME = FILMES.ID
 INNER JOIN GENEROS ON FILMESGENERO.IDGENERO = GENEROS.ID

-- 11 - Buscar o nome do filme e o g�nero do tipo "Mist�rio"
SELECT FILMES.NOME
	 , GENEROS.GENERO
  FROM FILMESGENERO
 INNER JOIN FILMES ON FILMESGENERO.IDFILME = FILMES.ID
 INNER JOIN GENEROS ON FILMESGENERO.IDGENERO = GENEROS.ID
 WHERE GENEROS.GENERO = 'Mist�rio'

-- 12 - Buscar o nome do filme e os atores, trazendo o PrimeiroNome, UltimoNome e seu Papel
SELECT Filmes.Nome
	 , ATORES.PRIMEIRONOME
	 , ATORES.ULTIMONOME
	 , ELENCOFILME.PAPEL
  FROM ELENCOFILME
 INNER JOIN FILMES ON ELENCOFILME.IDFILME = FILMES.ID
 INNER JOIN ATORES ON ELENCOFILME.ID = ATORES.ID
 INNER JOIN GENEROS ON ELENCOFILME.IDATOR = GENEROS.ID