--ORDER BY

/*SELECT * FROM Clientes 
ORDER BY Nome, Sobrenome 
 * */


-- Selecionando Colunas

/*SELECT Nome, Sobrenome,Email   FROM Clientes 
ORDER BY Nome, Sobrenome 
 * */


--Utilizando o where

/* SELECT Nome, Sobrenome, Email  FROM Clientes
WHERE Nome = 'Adam' AND Sobrenome = 'Reynolds'
ORDER BY Nome, Sobrenome 

SELECT Nome, Sobrenome, Email  FROM Clientes
WHERE AceitaComunicados  = 1
ORDER BY Nome, Sobrenome
*/

--Utilizando Like

/*SELECT Nome, Sobrenome, Email  FROM Clientes
WHERE Nome LIKE 'B%' --o sinal de % indica que o B deve ser a letra inicial e depois pode ser qualquer caractere
ORDER BY Nome, Sobrenome*/


/*SELECT Nome, Sobrenome, Email  FROM Clientes
WHERE Nome LIKE '%B%' --Desse Modo irá trazer todos que possuem B no nome
ORDER BY Nome, Sobrenome*/

/*%B ira trazer tudo que termine com B (% -> antes desse sinal qualquer caractere)
 * %B% irá trazer tudo que tenha B no nome
 * B% irá trazer tudo que começa com o B (% -> Depois desse sinal, qualquer caractere)*/


-- Relizando INSERT 

/*INSERT Into Clientes (Nome, Sobrenome, Email, AceitaComunicados, DataCadastro )
VALUES ('Bruno', 'Alves', 'Bruno@email.com', 1, GETDATE())*/
/*
SELECT *  FROM Clientes
WHERE Nome = 'Bruno' AND Sobrenome = 'Alves'*/


-- omitindo Colunas

/*INSERT Into Clientes VALUES ('Bruno', 'Alves', 'Bruno@email.com', 1, GETDATE())*/


-- Realizando um update

/*
SELECT *  FROM Clientes
WHERE Nome = 'Andrew' 
*/


-- Forma correta
/*
UPDATE Clientes 
SET Email = 'bruno.a@e-mail.com', AceitaComunicados = 0
WHERE Id = 1001
*/


/*-- Forma errada
UPDATE Clientes 
SET Email = 'novoemail@email.com'
WHERE Nome = 'Andrew'*/



-- Cuidados com o UPDATE 

/*BEGIN TRAN  -- -> Primeiro começa rodando esse

UPDATE Clientes 
SET Email = 'novoemail@email.com', AceitaComunicados = 1, Sobrenome = 'AHHHHH'

ROLLBACK -- -> Por ultimo rode esse para desfazer a operação

SELECT *  FROM Clientes*/

-- Deletenndo um registro

/*SELECT *  FROM Clientes
WHERE Nome = 'Andrew'

DELETE Clientes
WHERE Id = 47*/

-- Deletando todos os dados
/*
BEGIN TRAN 
DELETE Clientes
ROLLBACK
*/

--Criação de Tabelas

CREATE TABLE Produtos (
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255)NOT NULL,
	Cor varchar(50) NULL,
	Preco decimal(13, 2) NOT NULL,
	Tamanho varchar(5) NULL,
	Genero char(1) NULL
)

SELECT * FROM  Produtos p 






























