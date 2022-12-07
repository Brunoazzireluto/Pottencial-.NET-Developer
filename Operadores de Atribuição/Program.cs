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

int f = Convert.ToInt32(null);
Console.WriteLine(f);
// int g = int.Parse(null);  -> Valor Nulo no Parse irá dar um erro de excpetion
// Console.WriteLine(g); 

int inteiro = 4;
string g = inteiro.ToString();

Console.WriteLine(g);

// Cast Implicito
int j = 8;
double k = j;
Console.WriteLine(k);
long l = j;
Console.WriteLine(l);
long x = long.MaxValue;
Console.Write(x);
int w = int.MaxValue;
long q1 = w;
Console.WriteLine(q1);
