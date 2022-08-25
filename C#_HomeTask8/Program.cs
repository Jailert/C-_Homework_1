// Удалить вторую цифру трёхзначного числа

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
    int delete = 2;
    var str = N.ToString();
    N = int.Parse(str.Remove(str.Length - delete, 1));
    Console.WriteLine("Number without second digit: ");
    Console.WriteLine(N);
}