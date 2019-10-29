using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_5
{
    class Program
    {   static int NumberOfExtremum(int N)
        {

            int max = int.MinValue, min = int.MaxValue;
            int a, kMax = 0, kMin = 0;
            for (int i = 1; i <= N; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a > max)
                {
                    max = a;
                    kMax = i;
                }
                if(a < min)
                {
                    min = a;
                    kMin = i;
                }
            }
            if (kMin > kMax) return kMin;
            else return kMax;

        }  
        
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            
            Console.WriteLine(NumberOfExtremum(N));
               Console.ReadKey();
        }
        
    }
}
