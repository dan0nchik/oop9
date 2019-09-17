using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            string s = "";
            while(x != 2)
            {
                x = x / 2;
                if(x % 2 == 0)
                {
                    s += "0";
                    Console.WriteLine(s);
                }
                else
                {
                    s += "1";
                    x -= 1;
                    Console.WriteLine(s);

                }
                s += "1";
                Console.WriteLine(s);
           
            }
            char[] k = s.ToCharArray();
            Array.Reverse(k);
            Console.WriteLine("");
            Console.WriteLine(k);

            Console.ReadKey();
        }
    }
}
