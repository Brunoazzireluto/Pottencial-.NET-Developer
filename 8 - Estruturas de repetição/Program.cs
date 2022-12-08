// //for

// int num = 2;
// for (int conte = 0; conte <= 1; conte++ )
// {
//     Console.WriteLine($"{num} x {conte} =  {num*conte}");
// }

// // While
// int cont = 0;
// while (cont <= 2)
// {
//     Console.WriteLine($"{cont+1}° Execução {num} x {cont} =  {num*cont}");
//     cont++;
//     if (cont == 5)
//     {
//         break;
//     }
// }

// // do while

// int soma = 0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um número(zero para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero  != 0);

// Console.WriteLine($"O total da soma dos números é: {soma}");

string? opcao;
bool exibirMenu = true;
while(exibirMenu)
{
 Console.Clear();
 Console.WriteLine("Digite a sua opção: ");
 Console.WriteLine("1 - Cadastrar Cliente");   
 Console.WriteLine("2 - Buscar Cliente");   
 Console.WriteLine("3 - Apagar Cliente");   
 Console.WriteLine("4 - Encerrar");   
 Console.WriteLine();   

 opcao = Console.ReadLine();
 Console.WriteLine();   


 switch(opcao)
{
    case "1":
        Console.WriteLine("Cadastro de Cliente");
        Console.WriteLine();   
        break;
    case "2":
        Console.WriteLine("Buscar Cliente");
        Console.WriteLine();   
        break;
    case "3":
        Console.WriteLine("Apagar Cliente");
        Console.WriteLine();   
        break;
    case "4":
        Console.WriteLine("Encerrar");
        Console.WriteLine();   
        // Environment.Exit(0);
        exibirMenu = false;
        break;

    default:
        Console.WriteLine("Opção Invalida");
        break;

}

}

Console.WriteLine("O programa se Encerrou");