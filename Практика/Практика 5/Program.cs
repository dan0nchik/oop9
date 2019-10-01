using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_5
{
    class Program
    {   static void MinMax(int N)
        {
            int max = int.MinValue, min = int.MaxValue, k = 0, j = 0;
            for(int i = 1; i <= N; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if(a > max)
                {
                    max = a;
                    k = i;          
                }
                if(a < min)
                {
                    min = a;
                    j = i;
                    
                }
            }
            Console.WriteLine($"PLACE OF MAX = {k}   PLACE OF MIN = {j}");
            
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            MinMax(N);
            Console.ReadKey();
        }
        
    }
}
