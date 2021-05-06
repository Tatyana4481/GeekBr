using System;

namespace task_5
{
    // Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название месяца: ");
            string Month = Console.ReadLine().ToLower();
            Console.Write("Введите среднюю температуру за месяц:");
            int Gradus = Convert.ToInt32(Console.ReadLine());
            if (Gradus <= 0)
            {
                Console.WriteLine("Так себе погодка.");
            }
            else
            {
                switch (Month)
                {
                    case "январь":
                    case "февраль":
                    case "декабрь":
                        Console.WriteLine("Дождливая зима.");
                        break;
                    default:
                        Console.WriteLine("Так себе погодка.");
                        break;
                }
            }
        }
    }
}
