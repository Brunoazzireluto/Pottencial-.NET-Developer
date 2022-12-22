-- Not null

SELECT * FROM Produtos p 

INSERT INTO Produtos (Nome, preco, Tamanho, Genero, DataCadastro)
VALUES ('Nome' , 10, 'G', 'M', GETDATE() )

-- unique

ALTER TABLE Produtos ADD UNIQUE(Nome)

-- CHECK

SELECT * FROM Produtos p 


ALTER TABLE Produtos ADD CONSTRAINT CHK_ColunaGenero 
CHECK(Genero = 'U' OR Genero = 'M' OR Genero = 'F' )

INSERT INTO Produtos (Nome, preco, Tamanho, Genero, DataCadastro)
VALUES ('Nome2' , 10, 'G', 'Z', GETDATE() )

--DEFAULT

ALTER TABLE Produtos ADD DEFAULT GETDATE() FOR  DataCadastro

INSERT INTO Produtos (Nome, preco, Tamanho, Genero)
VALUES ('Nome22' , 10, 'G', 'U' )


-- apagando uma Constraint
ALTER TABLE Produtos DROP CONSTRAINT UQ__Produtos__7D8FE3B27E6481B3

--stored Procedure

CREATE PROCEDURE InserirNovoProduto
@Nome varchar(255),
@Cor varchar(50),
@Preco decimal,
@Tamanho varchar(5),
@Genero varchar(1)

AS 

INSERT INTO Produtos (Nome, Cor,  preco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco, @Tamanho, @Genero )




EXECUTE InserirNovoProduto
'algo', 'azul', 10, 'g', 'M' 

EXECUTE InserirNovoProduto
@Nome = 'algo nome', @Cor = 'azul', @Preco = 10, @Tamanho = 'g', @Genero = 'M' 

--stored procedure SELECT 

SELECT * FROM Produtos p WHERE Tamanho = 'G'


CREATE PROCEDURE ObterProdutoPorTamanho
@Tamanho varchar(5)

AS 

SELECT * FROM Produtos p WHERE Tamanho = @Tamanho


EXEC ObterProdutoPorTamanho 'G'


CREATE PROCEDURE ObterTodosProdutos

AS 

SELECT * FROM Produtos 


EXEC ObterTodosProdutos


--Functions

SELECT 
Nome, 
Preco,
FORMAT(Preco - Preco / 100 * 10, 'N2') PrecoComDesconto
From Produtos p 
WHERE Tamanho = 'M'

CREATE FUNCTION CalcularDesconto(@Preco DECIMAL(13,2), @Porcentagem INT)
RETURNS DECIMAL(13,2)
BEGIN 
	RETURN @Preco - @Preco / 100 * @Porcentagem
END



SELECT 
Nome, 
Preco,
dbo.CalcularDesconto(Preco, 10) PrecoComDesconto
From Produtos p 
WHERE Tamanho = 'M'








