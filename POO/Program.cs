using POO.models;

// abstração

// Pessoa p1 = new Pessoa();
// p1.Nome = "Bruno";
// p1.Idade = 24;

// p1.Apresentar();


// Encapsulamento
// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();
// c1.Sacar(800);


// //Herança
// Aluno a1 = new Aluno();

// a1.Nome = "Bruno";
// a1.Idade = 24;
// a1.Nota = 7.5;
// a1.Apresentar();

// //polimorfismo
// Professor p1 = new Professor();
// p1.Nome = "Bruno";
// p1.Idade = 24;
// p1.Salario = 2300.00M;
// p1.Apresentar();

//Classe Abstrata -> Usada como base, so pode ser usada quando houver herança dela

// Corrente c = new Corrente();

// c.Creditar(500);
// c.ExibirSaldo();

//Construtor por herança
//Verificar classe Professor e Aluno
// Pessoa p1 = new Pessoa("Bruno");
// Aluno a1 = new Aluno("Bruno");

// a1.Apresentar();


//classe Selada -> impede que outras classes herdem dela, só pode ser instanciada por ela mesmo

//Verificar Classe Professor

//classe object
// a classe system.object é a mãe de todas as classes no .net, todas as classes derivam dela
//Verificar Classe Computador

// Computador c = new Computador();
// Console.WriteLine(c.ToString());


//Interfaces -> é como se fosse uma classe abstrata, 
//podemos definir metodós abstratos e ela não pode ser instanciada
//Para interfaces é possivel implementar mais de uma inteface na mesmma classe

Calculadora c = new Calculadora();

Console.WriteLine(c.Somar(1, 2));

//metodo padrão -> ver metodo dividir na interface ICalculadora, métodos que não tem corpo são obrigatorios
//para a implementação e os que tem corpo são opcionais 