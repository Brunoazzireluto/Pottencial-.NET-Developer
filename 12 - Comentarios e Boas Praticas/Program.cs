// Comentario de Linha única - > Muito bom para descrições Rapídas 

using Comentarios_e_Boas_Praticas.models;

//instanciando a classe pessoas
Pessoa p = new Pessoa();

//atribui o nome e a idade da pessoa
p.Nome = "algum";
p.Idade = 10;


//faz a aprensentação da pessoa
p.Apresentar();



/*
Comentario
de multiplas
linhas
*/

/*
Instanciando uma nova pessoa
*/
Pessoa p2 = new Pessoa();


/*
Passando um novo nome e uma nova idade
para as variaveis da classe
nome recebe uma string e idade recebe um int
*/
p2.Nome = "algum2";
p2.Idade = 12;


//Comentario de Classe -> ver Models/Pessoa.cs

Pessoa p3 = new Pessoa();
p3.Apresentar();

//Comentario de metódos e paramentros -> ver Models/Calculadora.cs
Calculadora calc = new Calculadora();
calc.Somar(1,2);
calc.Subtrair(1, 2);