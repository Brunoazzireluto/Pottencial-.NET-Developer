using exceções_e_coleções.models;
using System.Globalization;


// try 
// {
//     string[] linhas = File.ReadAllLines("Arquivos/Leitura.txt");

//     foreach(string linha in linhas)    
//     {
//         Console.WriteLine(linha);
//     }

// }catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. O arquivo {ex.FileName} Não foi encontrado");

// }catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um Erro na leitura do arquvio, Diretorio não encontrado: {ex.Message}");

// }catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção Genérica: {ex.Message}"); // -> Execção genérica

// }finally
// {
//     Console.WriteLine();
//     Console.WriteLine("Chegou até aqui");
//     Console.WriteLine();
// }

//sobre o throw

// new ExemploExcecao().Metodo1();

//Filas - coleção Queue

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(8);
// fila.Enqueue(16);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

//pilhas - coleção stack

// Stack<int> pilha = new Stack<int>();

// pilha.Push(8);
// pilha.Push(16);
// pilha.Push(32);
// pilha.Push(64);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);    
// }


// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(128);


// foreach(int item in pilha)
// {
//     Console.WriteLine(item);    
// }

//Dicionarios

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");
estados.Add("RJ", "Rio de Janeiro");

foreach(KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}


// ou foreach(var item in estados)
Console.WriteLine("____________________________");
estados.Remove("BA");
estados["SP"] = "Estado de São Paulo";
foreach(KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
}

Console.WriteLine("____________________________");

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

Console.WriteLine("____________________________");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");

}else
{
    Console.WriteLine($"Valor Não existe, é seguro adicionar a chave: {chave}");

}

Console.WriteLine(estados["MG"]);