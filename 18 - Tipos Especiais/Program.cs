using _18___Tipos_Especiais.models;
using Newtonsoft.Json;

//tipos Nulos

bool? desejaReceberEmail = null;

if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuario Optou por receber email");
}else
{
        
    Console.WriteLine("O usuario Não respondeu ou não optou por receber email");

}

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> Listvenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in Listvenda)
{
    Console.WriteLine($"id: {venda.Id}, produto: {venda.Produto}, " +
     $" preço: {venda.Preco}, Data: {venda.dataVenda.ToString("dd/MM/yyyy HH:mm")}, "+
     $"{(venda.Desconto.HasValue ?  $"Desconto de: {venda.Desconto}" : "")}");
}


//Tipos Anonimos

var tipoAnonimo = new { nome = "Bruno", Sobrenome = "Alves", altura = 1.80};

Console.WriteLine();
Console.WriteLine("Nome "+ tipoAnonimo.nome);
Console.WriteLine("sobrenome "+ tipoAnonimo.Sobrenome);
Console.WriteLine("Altura "+ tipoAnonimo.altura);

//Tipos anonimos em coleção

var listaAnonima = Listvenda.Select(x => new { x.Produto, x.Preco});

foreach(var venda in listaAnonima)
{
    Console.WriteLine($"produto: {venda.Produto}");
    Console.WriteLine($"Preço: {venda.Preco}");

}


// Tipo dinamico

dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da Variavel {variavelDinamica.GetType()}");

variavelDinamica = "Text";
Console.WriteLine($"Tipo da Variavel {variavelDinamica.GetType()}");

//Clases Genericas

//Verificar a classe MeuArray

MeuArray<int> arrayInt = new MeuArray<int>();

arrayInt.AdicionarElemento(5);

Console.WriteLine();
Console.WriteLine(arrayInt[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElemento("500");

Console.WriteLine();
Console.WriteLine(arrayString[0]);


//Metodo de extensão

int numero = 20;
bool ePar = numero.ehPar();


Console.WriteLine($"O número {numero} é " + (ePar ? "par" : "Impar"));