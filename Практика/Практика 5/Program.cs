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

            int max = int.MinValue;

            for (int i = 1; i <= N - 1; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > max) max = a;
            }
            return max;
        }  
        
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            NumberOfExtremum(N);
            Console.ReadKey();
        }
        
    }
}
