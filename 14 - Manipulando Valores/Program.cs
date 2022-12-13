using Manipulando_Valores.models;
using System.Globalization;


// Pessoa p1 = new Pessoa("Bruno", "alves");
// p1.Idade = 24;


// Pessoa p2 = new Pessoa(nome: "Bruno", sobrenome: "Azzireluto"); 
// p2.Idade = 25;

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.adicionarAluno(p1);
// cursoDeIngles.adicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


//Concatenação de Valores

string numero1 = "10";
int numero2 = 20;

string resultado = numero1 + numero2;

Console.WriteLine(resultado);

// formantando valores monetarios
// alterando localização do codigo  
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1582.40M;

Console.WriteLine($"{valorMonetario:C}");

//alterando a localização da cultura

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

//Formatação personalizada

Console.WriteLine(valorMonetario.ToString("N3"));

// Representando Porcentagem

double porcetagem = .3421;

Console.WriteLine(porcetagem.ToString("P"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));

//formatando Datetime

DateTime data = DateTime.Now;
Console.WriteLine();
Console.WriteLine(data.ToString("dd/MM/yyy  HH:mm"));

//formantando Data e hora

Console.WriteLine();
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime data2 = DateTime.Parse("17/04/2022 18:00");
Console.WriteLine();
Console.WriteLine(data2);

//datetime com tryparse
string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact(
                dataString, "yyyy-MM-dd HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime data3);

if (sucesso)
{
    Console.WriteLine();
    Console.WriteLine($"Conversão com sucesso: {data3}");
}else
{
    Console.WriteLine();
    Console.WriteLine($"{dataString} Não é uma Data válida");
}


