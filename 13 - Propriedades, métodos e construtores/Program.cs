using Propriedades_metodos_e_construtores.models;

Pessoa p1 = new Pessoa("Bruno", "alves");
p1.Idade = 24;
// p1.nomeCompleto = '';
//p1.Apresentar();

// Pessoa p2 = new Pessoa();

// p2.Nome = "";
// p2.Idade = -1;

// p2.Apresentar();


Pessoa p2 = new Pessoa(nome: "Bruno", sobrenome: "Azzireluto"); 
p2.Idade = 25;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.adicionarAluno(p1);
cursoDeIngles.adicionarAluno(p2);
cursoDeIngles.ListarAlunos();
