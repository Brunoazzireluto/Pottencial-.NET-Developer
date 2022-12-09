//Primeiro Challenge;

// // int n = int.Parse(Console.ReadLine());
// int n = 4421;
// int p = 1, s = 0;
// while (n > 0){
//     int l = n % 10;
//     Console.WriteLine(l);
//     p *= l;
//     Console.WriteLine(p);
//     s += l;
//     Console.WriteLine(s);
//     n /=  10;
// }

//     Console.WriteLine($"Valor é {p-s}");


//segundo challenge

// int qt = int.Parse(Console.ReadLine());
// string[] v = new string[2];

// for (int i = 0; i < qt; ++i)
// {
//     v = Console.ReadLine().Split(" ");
//     string a = v[0];
//     string b = v[1];

//     if (b.Length > a.Length)
//         Console.WriteLine("nao encaixa");
//     else if (a.EndsWith(b))
//         Console.WriteLine("encaixa");
//     else
//         Console.WriteLine("nao encaixa");
// }

//terceiro Chalenge

    int n = 4;
    int count = 0;
 
    for (int i = 1; i <= n; i++) {
        if (n % i == 0 ) {
            count++;
        }
        if (count > n ) {
            Console.WriteLine(false);
        }
    }
        Console.WriteLine(count == 3);