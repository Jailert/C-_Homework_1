// Показать вторую цифру трёхзначного числа

Console.WriteLine("Enter the three digit number: ");
int N = int.Parse(Console.ReadLine() ?? "0");
bool digit(int N)
{
bool result = true;
    if (N > 99 && N < 1000)
        {
            result = true;
        }
    else
        {
            result = false;
            Console.WriteLine("Not valid number, please choose three digit number!");
        }
    return result;
}    

if (digit(N))
{
    int a = (N / 10) % 10; 
    
    Console.Write ("Second number: ");
    Console.WriteLine (a);
}