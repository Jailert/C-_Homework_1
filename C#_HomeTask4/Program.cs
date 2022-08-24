// Выяснить является ли число чётным

Console.WriteLine("Enter number: ");
int a = int.Parse(Console.ReadLine() ?? "0");

if (a % 2 == 0)
{
    Console.WriteLine("Even number");
} 
else
{
    Console.WriteLine("Odd number");
}