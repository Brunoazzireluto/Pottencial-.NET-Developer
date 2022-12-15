// using Tuplas_Operador_Ternário_e_Desconstrução.Models;


// (int id, string nome, string sobrenome, decimal altura) tupla = (1, "Bruno", "Alves", 1.88M);

// Console.WriteLine($"id: {tupla.id}");
// Console.WriteLine($"nome: {tupla.nome}");
// Console.WriteLine($"sobrenome: {tupla.sobrenome}");
// Console.WriteLine($"altura: {tupla.altura}");

// ValueTuple<int, string, string, decimal> tupla2 = (2, "Bruno", "Azzireluto", 1.88M);

// Console.WriteLine($"id: {tupla2.Item1}");
// Console.WriteLine($"nome: {tupla2.Item2}");
// Console.WriteLine($"sobrenome: {tupla2.Item3}");
// Console.WriteLine($"altura: {tupla2.Item4}");

// var tupla3 = Tuple.Create(3, "Bruno", "Azzireluto", 1.88M);

// Console.WriteLine($"id: {tupla3.Item1}");
// Console.WriteLine($"nome: {tupla3.Item2}");
// Console.WriteLine($"sobrenome: {tupla3.Item3}");
// Console.WriteLine($"altura: {tupla3.Item4}");


// LeituraDeArquivo  arquivo = new LeituraDeArquivo();

// var  (sucesso, linhas, quantidadeLinhas) =  arquivo.LerArquivo("arquivo/texto.txt");

// if (sucesso)
// {
//     Console.WriteLine($"quantidade de linhas no arquivo: {quantidadeLinhas}");
//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }

// descartando informação

// var  (sucessos, linhass, _) =  arquivo.LerArquivo("arquivo/texto.txt");

// if (sucessos)
// {
//     Console.WriteLine($"quantidade de linhas no arquivo: {quantidadeLinhas}");
//     foreach(string linha in linhass)
//     {
//         Console.WriteLine(linha);
//     }
// }else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }

// descontrutor

// Pessoa p1 = new Pessoa("Bruno", "Alves");

// (string nome, string sobrenome) = p1;

// Console.WriteLine(nome +" "+ sobrenome);

// if ternario 

int num = 15;
bool ePar = false;

ePar = num % 2 == 0;

Console.WriteLine($"O número {num} é " + (ePar ? "par" : "Impar"));

if (num % 2 == 0)
{
    Console.WriteLine($"O número {num} é par");
}else
{
    Console.WriteLine($"O número {num} é Impar");

}