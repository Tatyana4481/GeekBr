using System;

//1.Написать программу, выводящую элементы двумерного массива по диагонали.


namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в создаваемом массиве: ");
            int line = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в создаваемом массиве: ");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] ar = new int[line, column];
            Console.Write("Центральная диагональ: ");
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Random r = new Random();
                    ar[i, j] = r.Next(1, 50);
                    if (i==j) 
                    {
                        Console.Write($"ar[{i},{j}]={ar[i,j]}\t");
                     }
                }
            }
            Console.ReadLine();
            Console.Clear();
                for (int i = 0; i < ar.GetLength(0)-1; i++)
            {
                Console.Write($"{i+1} Параллельная диагональ: ");
                int k = 1;
                for (int j = 0; j < ar.GetLength(0)-i; j++)
                {
                    Console.Write($"ar[{i + k},{j}]={ar[i + k, j]}\t");
                    k++;
                    if ((k>=ar.GetLength(0)-i) || (k >= ar.GetLength(1)))
                    {
                        break;
                    }
                   
                }
                Console.WriteLine();
            }
         }
    }
}
