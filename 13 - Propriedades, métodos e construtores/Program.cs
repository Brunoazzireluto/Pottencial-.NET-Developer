using Propriedades_metodos_e_construtores.models;

Pessoa p1 = new Pessoa();

p1.Nome = "Bruno";
p1.Idade = 24;

p1.Apresentar();

Pessoa p2 = new Pessoa();

p2.Nome = "";
p2.Idade = -1;

p2.Apresentar();