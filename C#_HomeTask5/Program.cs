// Показать четные числа от 1 до N

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int length = N + 1;

int[] array = new int[length];
     for (int i=0 ; i<length ; i++)
     {
         array[i] = i; 
         if (array[i] % 2 == 0)
         {
            Console.WriteLine ("{0}", i);
         }
     }