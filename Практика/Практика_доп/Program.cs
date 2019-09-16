using System;

namespace Практика_доп
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()), y = int.Parse(Console.ReadLine()), z = int.Parse(Console.ReadLine());
            Console.WriteLine(x == y && x == z && y == z ? "Yes" : "No");
            Console.ReadKey();
        }
    }
}