using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_7._1
{
    class Program
    {
        static short ZnachenieBita(short X, short N)
        {
            if (X << N == 0)
            {
                Console.WriteLine("0");
            }
            else Console.WriteLine("1");
            return 0;
        }
        static void Main()
        {
            short X = short.Parse(Console.ReadLine()), N = short.Parse(Console.ReadLine());
            ZnachenieBita(X, N);
        }
    }
}