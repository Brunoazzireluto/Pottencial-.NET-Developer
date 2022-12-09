// int quantidadeEmEstoque = 10;
// // int quantidadeEmEstoque = 3;

// int quantidadeDeCompra = 0;

// bool possivelVenda = quantidadeDeCompra > 0 && quantidadeEmEstoque >= quantidadeDeCompra;

// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine();
// Console.WriteLine($"Quantidade Compra: {quantidadeDeCompra}");
// Console.WriteLine();
// Console.WriteLine($"É Possivel realizar a venda? {possivelVenda}");
// Console.WriteLine();


// if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Não temos a quantidade em estoque");
// }

// // if aninhado

// if (quantidadeDeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda Realizada");
// }
// else
// {
//     Console.WriteLine("Não temos a quantidade em estoque");
// }


Console.WriteLine("Digite uma Letra");
string? letra = Console.ReadLine();
Console.WriteLine();

// if (
//     letra  == "a" ||
//     letra  == "e" ||
//     letra  == "i" ||
//     letra  == "o" ||
//     letra  == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Nâo é vogal");
// }

// Switch case

switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma Vogal");
        break;
}