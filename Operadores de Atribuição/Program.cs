int a = 5;
int b = 6;
int c = a + b;
Console.WriteLine(c);

// c = c + 5;
c += 5;
Console.WriteLine(c);

// c = c - 6;

c -= 6;
Console.WriteLine(c);


// Convertendo Tipos de Variaveis
//Cast - Casting
int d = Convert.ToInt32("5");
Console.WriteLine(d);
int e = int.Parse("5"); // -> Todos os tipos terão o método Parse
Console.WriteLine(e);

