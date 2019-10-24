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

        static int Extra(int q, int p)
        {
            for (int i = 2; i < q; i++)
            {

                if (q % i == 0)
                {
                    int k = 0;
                    for (int j = 2; j < p; j++)
                    {
                        if (p % j == 0 && i == j) k++;
                    }
                    if (k == 0) Console.WriteLine(i);
                    else Console.WriteLine("NO");
                }
            }
            return 0;
        }

        static void Main()
        {      //2 вариант
            int N = int.Parse(Console.ReadLine()); //q = int.Parse(Console.ReadLine()); ;
            Console.WriteLine(SummaCifrNeKratnych3(N));
            Console.ReadKey();
        }
    }
}
