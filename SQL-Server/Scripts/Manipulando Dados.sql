SELECT * FROM Produtos 

-- usando COUNT
SELECT COUNT(*) QuantidadeProdutos FROM  Produtos

SELECT COUNT(*) QuantidadeProdutosM FROM  Produtos WHERE Tamanho = 'M'

-- usando SUM
 SELECT SUM(Preco) PrecoTotal From Produtos
 
 SELECT SUM(Preco) PrecoTotalM FROM  Produtos WHERE Tamanho = 'M'

 
-- Usando MIN, MAX e AVG
  
SELECT MAX(Preco) ProdutoMaisCaro FROM Produtos 
 
SELECT MAX(Preco) ProdutoMaisCaroM FROM Produtos WHERE Tamanho = 'M'

SELECT MIN(Preco) ProdutoMaisBarato FROM Produtos 

SELECT MIN(Preco) ProdutoMaisBaratoM FROM Produtos WHERE Tamanho = 'M'

SELECT AVG(Preco) PrecoMedio FROM Produtos

SELECT AVG(Preco) PrecoMedioM FROM Produtos WHERE Tamanho = 'M'

-- Concatenando Colunas

SELECT Nome+ ' , Cor: '+ Cor +' '+ Genero  nomeProduto FROM Produtos 

-- Upper e Lower

SELECT Nome+ ' , Cor: '+ Cor +' '+ Genero  nomeProdutoCompleto,
UPPER(Nome) Nome, 
LOWER(Cor) Cor
FROM Produtos 

-- Adicionando colunas

ALTER TABLE Produtos  ADD DataCadastro DATETIME2

UPDATE Produtos  SET DataCadastro  = GETDATE() 

ALTER TABLE Produtos DROP COLUMN  DataCadastro

-- Formantando uma Data
SELECT Nome+ ' , Cor: '+ Cor +' '+ Genero  nomeProdutoCompleto,
UPPER(Nome) Nome, 
LOWER(Cor) Cor,
FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm') Data
FROM Produtos 

--Group By

SELECT Tamanho, COUNT(*) Qauntidade FROM Produtos GROUP BY Tamanho 

SELECT Tamanho, COUNT(*) Qauntidade FROM Produtos
WHERE  Tamanho <> ''
GROUP BY Tamanho 
ORDER BY Qauntidade DESC

--Criando Tabela com FK

SELECT * FROM Clientes WHERE Id = 4 

CREATE TABLE Endereços (
	Id int PRIMARY KEY IDENTITY(1, 1),
	IdCliente int NULL,
	Rua varchar(255) NULL, 
	Bairro varchar(255) NULL,
	Cidade varchar(255) NULL,
	Estado varchar(2) NULL,
	
	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente) REFERENCES Clientes(Id)
)


SELECT * FROM Endereços e  


INSERT INTO Endereços VALUES (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'SP')

SELECT * FROM Clientes WHERE Id = 4 
SELECT * FROM Endereços WHERE IdCliente = 4 

-- Utilizando JOIN

SELECT * FROM Clientes INNER JOIN Endereços ON Clientes.Id = Endereços.IdCliente WHERE Clientes.id=4

SELECT 
Clientes.Nome,
Clientes.Sobrenome,
Clientes.Email, 
Endereços.Rua,
Endereços.Bairro,
Endereços.Cidade,
Endereços.Estado
FROM Clientes INNER JOIN Endereços 
ON Clientes.Id = Endereços.IdCliente 
WHERE Clientes.id=4


SELECT 
c.Nome,
c.Sobrenome,
c.Email, 
e.Rua,
e.Bairro,
e.Cidade,
e.Estado
FROM Clientes c 
INNER JOIN Endereços e
ON c.Id = e.IdCliente 
WHERE c.id=4



 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 