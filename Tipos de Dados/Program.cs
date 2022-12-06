string apresentacao = "Olá Seja bem vindo";

int quantidade = 2;

double altura = 1.80;

decimal preco = 1.88M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da Variavel quantidade: " + quantidade);
Console.WriteLine("Valor da Variavel altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da Variavel preço: " + preco);
Console.WriteLine("Valor da Variavel condição: " + condicao);

quantidade = 10;

Console.WriteLine("O novo valor da Variavel quantidade é: " + quantidade);


//Variavel de Data

DateTime dataAtual = DateTime.Now;

Console.WriteLine(dataAtual);

DateTime dataMaisCinco =  dataAtual.AddDays(5);

Console.WriteLine(dataMaisCinco);

Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));