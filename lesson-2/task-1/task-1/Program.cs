using System;
// Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите максимальную температуру за сутки: ");
            double MaxTemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите минимальную температуру за сутки: ");
            double MinTemp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine ("Среднесуточная температура равна " +((MaxTemp + MinTemp) /2));
        }
    }
}
