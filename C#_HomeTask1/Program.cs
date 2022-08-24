// По двум заданным числам проверять является ли первое квадратом второго.

Console.WriteLine("Add first number: ");
int a = int.Parse (Console.ReadLine() ?? "0");

Console.WriteLine("Add second number: ");
int b = int.Parse (Console.ReadLine() ?? "0");

if (b*b == a )
Console.WriteLine("First is perfect square of second!");
else
Console.WriteLine("First is not perfect square of second!");