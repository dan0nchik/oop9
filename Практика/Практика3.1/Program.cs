using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int a = 2; a <= 9; a++)
            {
                for(int b = 2; b <= 9; b++)
                {
                    int c = a * b;
                    Console.WriteLine("{0} \t", c);
                }
            }
            Console.ReadKey();
        }
    }
}
