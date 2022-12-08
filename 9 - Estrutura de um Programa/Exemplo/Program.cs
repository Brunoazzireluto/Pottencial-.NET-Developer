using Exemplo.Commons.models;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Bruno";
pessoa1        .Idade = 24;

pessoa1.
Apresentar();

Console.WriteLine(pessoa1.Nome);

Pessoa pessoaFisica = new Pessoa();

pessoaFisica.Nome = "algum nome";
pessoaFisica.Idade = 258;

pessoaFisica.Apresentar();