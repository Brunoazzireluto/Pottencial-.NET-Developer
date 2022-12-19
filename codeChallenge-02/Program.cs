// int n = int.Parse(Console.ReadLine());

// int[] num = new int[n];

// for (int i = 0; i < n; i++)
// {
//     num[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine(MajorityElement(num));

// int[] a = new int[5];

// a[0] = 5;
// a[1] = 7;
// a[2] = 5;
// a[3] = 7;
// a[4] = 7;


// static int MajorityElement(int[] nums)
// {
//     int major = nums[0];
//     int count = 1;
//     for (int i = 0; i < nums.Length; i++)
//     {
//         if ( major !=  nums[i]  )
//         {
//             major = nums[i];
//             // count;
//         }
//         else
//         {
//             if (major == nums[i])
//             {
//                 count++;
//             }
//             else
//             {
//                 count--;
//             }
//         }
//     }
//     return major;
// }
// Console.WriteLine(a[0]);
// Console.WriteLine(MajorityElement(a));


//challenge 02


// double salario = 0.00; 
// double reajuste = 0.00; 
// double novoSalario = 0.00; 
// double percentual = 0.00; 

// salario = Convert.ToDouble("2000,00");

// Console.WriteLine(salario);
// if( salario < 0) { 
//     return; 
// } else if (salario <= 400.00) { 
//     percentual = 15.00 / 100; 
//     reajuste = salario * percentual; 
//     novoSalario = salario + reajuste; 

// } else if ( salario <= 800.00 ) { 
//     percentual = 12.00 / 100; 
//     reajuste = salario * percentual;         
//     novoSalario = salario + reajuste; 

// } else if ( salario <= 1200.00 ) { 
//     percentual = 10.00 / 100; 
//     reajuste = salario * percentual;         
//     novoSalario = salario + reajuste; 

// } else if (salario <= 2000.00 ) { 
//     percentual = 7.00 /100 ; 
//     reajuste = salario * percentual;         
//     novoSalario = salario + reajuste; 

// } else { 
//     percentual = 4.00 / 100; 
//     reajuste = salario * percentual;         
//     novoSalario = salario + reajuste; 
// } 
// double perc = percentual * 100;

// Console.WriteLine("Novo salario: {0:0.00}", novoSalario  ); 
// Console.WriteLine("Reajuste ganho: {0:0.00}",reajuste  ); 
// Console.WriteLine("Em percentual: {0} %", perc.ToString("#") ); 

//challenge 3

// using System;

// class Desafio {
//   public static void Main() {
//     int quantidadeEntradas = 3;
      
//     while (quantidadeEntradas > 0) {
//       var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
//       if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
//         string[] tartarugas = Console.ReadLine().Split(" ");
//         var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
//         for (int i = 1; i < numeroQuantidade; i++) {
//           var tartaruga = Int32.Parse(tartarugas[i]);
            
//           if ( tartaruga > maiorVelocidade) {
//             maiorVelocidade = tartaruga;
//           }
//         }

//         if(maiorVelocidade < 10) {
//           Console.WriteLine(1);
//         } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
//           Console.WriteLine(2);
//         } else if (maiorVelocidade >= 20) {
//           Console.WriteLine(3);
//         }
//         quantidadeEntradas--;
//       } else {
//         Console.WriteLine("Insira um número entre 1 e 500");
//       }
//     }
//   }
// }