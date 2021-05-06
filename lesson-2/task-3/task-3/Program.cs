using System;

namespace task_3
//Определить, является ли введённое пользователем число чётным.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число для проверки на четность: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Число {number} четное.");
            }
            else
            {
                Console.WriteLine($"Число {number} нечетное."); 
            }
        }
    }
}
