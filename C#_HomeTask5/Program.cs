// Показать четные числа от 1 до N

Console.WriteLine("Enter number: ");
int N = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[N];
for (int i=0 ; i<=N ; i++)
     {
         array[i]= i - 1;
      }
