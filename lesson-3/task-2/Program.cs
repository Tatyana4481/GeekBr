using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        { 
            string [,] guide = new string[5, 2];

            for (int i = 0; i < guide.GetLength(0); i++)
            {
                int k = 0;
                Console.Write("Введите имя: ");
                guide[i, k] = Console.ReadLine();
                Console.Write("Введите номер телефона или адрес электронной почты: ");
                guide[i, k + 1] = Console.ReadLine();
            }
            Console.WriteLine("Имя:\t\tТелефон или электронная почта:");
            for (int i = 0; i < guide.GetLength(0); i++)
            {
                for (int j = 0; j < guide.GetLength(1); j++)
                {
                    Console.Write($"{guide[i, j]}\t\t");
                }
                Console.WriteLine();
            }

        }
    }
}
