//  Найти максимальное из трех чисел

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Enter third number: ");
int c = int.Parse(Console.ReadLine() ?? "0");

int Max(int a, int b, int c)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
}
int max = Max(a, b, c);
Console.WriteLine("Max number: ");
Console.WriteLine(max);
