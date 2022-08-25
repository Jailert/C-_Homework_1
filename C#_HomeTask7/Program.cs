// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Enter number from 10 to 99 ");
int N = int.Parse(Console.ReadLine() ?? "0");

bool check(int N)
{
bool result = true;
    if (N > 9 && N < 100)
        {
            result = true;
        }
    else
        {
            result = false;
            Console.WriteLine("Not valid number, please choose number from 10 to 99!");
        }
    return result;
}
if (check(N))
{
    int a = N % 10;
    int b = N / 10;
    int max = 0;

    if (a == b)
    {
        Console.Write("Numbers are equal"); 
        return;
    }
    else if (a > b)
    {
        max = a;
    }
    else 
        max = b;

    Console.Write("Bigger number: ");
    Console.WriteLine(max);
}
