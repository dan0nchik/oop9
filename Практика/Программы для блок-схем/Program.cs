using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Программы_для_блок_схем
{
    class Program
    {

        static void _1()
        {
            int a = int.Parse(Console.ReadLine()), b= int.Parse(Console.ReadLine()), c= int.Parse(Console.ReadLine()), sr = 0;
            if (a > b)
                if (a < c)
                    sr = a;
                else sr = a;
            Console.WriteLine(sr);
            
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            _1();
        }
    }
}
