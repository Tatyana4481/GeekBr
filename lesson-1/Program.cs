using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как ваше имя? "); ;
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}.");
        }
    }
}
