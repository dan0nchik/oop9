using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Фоновая
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine()), b = float.Parse(Console.ReadLine()), c = float.Parse(Console.ReadLine());

            float result = Math.Pow((c + b), 1 / 3); //+ Math.Sin(a/4) + Math.Sqrt((a + b + 4) / 2) + Math.Pow(c,2);
            
            Console.Write(result);
            Console.ReadKey();

        }
    }
}
