using System;

namespace task_5
{
    // Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
    class Program
    {
        static void Main(string[] args)
        {
            string MonthJan = "январь";
            string MonthFeb = "февраль";
            string MonthDec = "декабрь";
            Console.WriteLine("Введите название месяца: ");
            string Month = (Console.ReadLine()).ToLower();
            //      Month = Month.ToLower();
            Console.WriteLine("Введите среднюю температуру за месяц:");
            int Gradus = Convert.ToInt32(Console.ReadLine());
            if (Gradus > 0)
            {

                if (Month == MonthJan || MonthFeb || MonthDec)
                {
                    Console.WriteLine("Дождливая зима.");
                }
            }
            Console.WriteLine("Пока!");
        }
    }
}
