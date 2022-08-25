// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine() ?? "0");

int c = a % b;

if (a % b == 0)
{
    Console.WriteLine ("First number is multiple of second");
    return;
}
if (a % b == c)
{
    Console.WriteLine ("First number is not multiple of second, modulo :");
    Console.WriteLine (c); 
}
  