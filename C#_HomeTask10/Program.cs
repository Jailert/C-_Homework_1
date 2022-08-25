// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine() ?? "0");
bool digit(int N)
{
bool result = true;
    if (N > 99)
        {
            result = true;
        }
    if (N < 100)
        {
            result = false;
            Console.WriteLine("Not valid number, please choose at least three digit number!");
        }
    return result;
}    

if (digit(N))
{
    int a = (N / 100) % 10;
    Console.WriteLine("Third number: ");
    Console.WriteLine(a);
}
