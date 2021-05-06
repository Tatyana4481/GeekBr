using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Hello";
            for (int i = line.Length-1; i >= 0; i--)
            { Console.Write(line[i]); }
            
        }
    }
}
