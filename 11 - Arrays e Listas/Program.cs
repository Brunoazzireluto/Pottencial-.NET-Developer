
int[] arrayInt = new int[3];

arrayInt[0] = 5;
arrayInt[1] = 10;
arrayInt[2] = 8;

//arrayInt[3] = 1; -> Indice invalido
// Console.WriteLine(arrayInt.Length);

// Console.WriteLine("Percorrendo com for");
// for(int cont = 0; cont < arrayInt.Length; cont++)
// {
//     Console.WriteLine($"Posição N°{cont} - {arrayInt[cont]}");
// }

// Console.WriteLine();
// int contForEach = 0;
// Console.WriteLine("Percorrendo com Foreach");
// foreach (var value in arrayInt)
// {
//     Console.WriteLine($"Posição N°{contForEach} - {value}");
//     contForEach++;

// }

//Redimensinomento de arrays 

// Array.Resize(ref arrayInt, arrayInt.Length * 2);

// Console.WriteLine(arrayInt.Length);



//copiando array

// int[] arrayIntMaior =  new int[arrayInt.Length * 2];
// Array.Copy(arrayInt, arrayIntMaior, arrayInt.Length);

// Console.WriteLine("Copiando Array");
// for(int cont = 0; cont < arrayIntMaior.Length; cont++)
// {
//     Console.WriteLine($"Posição N°{cont} - {arrayIntMaior[cont]}");
// }



//listas

List<string> listaString  = new List<string>();

listaString.Add("SP");
listaString.Add("RJ");
listaString.Add("MG");

Console.WriteLine("Percorrendo a Lista com For");
for(int cont = 0; cont < listaString.Count; cont++)
{
    Console.WriteLine($"Posição N°{cont} - {listaString[cont]}");
}

Console.WriteLine();
int contForEach = 0;
Console.WriteLine("Percorrendo a lista com Foreach");
foreach (string value in listaString)
{
    Console.WriteLine($"Posição N°{contForEach} - {value}");
    contForEach++;
}

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("ES");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("PP");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("PP");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");