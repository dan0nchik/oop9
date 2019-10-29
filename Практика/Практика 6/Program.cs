using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6
{
    class Program
    {
        static int SummaCifrNeKratnych3(int N)
        {
            int a, k = 0;
            while (N > 0)
            {
                a = N % 10;
                if (a % 3 != 0) k += a;
                N /= 10;
            }
            if (k == 0) return 0;
            else return k;
        }
        
        static void Main()
        {      //2 вариант
            int N = int.Parse(Console.ReadLine());//, q = int.Parse(Console.ReadLine()); ;
            Console.WriteLine(Delitel(N));
            Console.ReadKey();
        }
    }
}
