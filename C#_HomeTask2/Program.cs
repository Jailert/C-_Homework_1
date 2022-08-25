// По заданному номеру дня недели вывести его название.

Console.WriteLine("Add day number: ");

int a = int.Parse(Console.ReadLine() ?? "0");
bool days(int a)
{
bool result = true;
    if (a > 0 && a <= 7)
        {
            result = true;
        }
    else
        {
            result = false;
            Console.WriteLine("Not valid day number, please choose from 1 to 7");
        }
    return result;
}    
if (days(a))
{
    if (a == 1)
    {
        Console.WriteLine("Today is Monday");
    }
    else if (a == 2)
    {
        Console.WriteLine("Today is Tuesday");
    }
    else if (a == 3)
    {
        Console.WriteLine("Today is Wednesday");
    }
    else if (a == 4)
    {
        Console.WriteLine("Today is Thursday");
    }
    else if (a == 5)
    {
        Console.WriteLine("Today is Friday");
    }
    else if (a == 6)
    {
        Console.WriteLine("Today is Saturday");
    }
    else if (a == 7)
    {
        Console.WriteLine("Today is Sunday");
    }
}
    

