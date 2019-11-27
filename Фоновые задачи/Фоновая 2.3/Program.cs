using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_2._3
{   
        
    
    class Program
    {
        
        static void Overloaded(ref int n)
        {   int sum = 0, i = 1;
            for(; i < n; i++)
            {
                if (n % i == 0) sum += i;
            }
            if (sum > n) Console.Write("Число {0} является избыточным.", n);
            else
            {
                sum = 0; //сброс суммы
               while(true)
                {
                    n++;
                    for (int j = 1; j < n; j++)
                    {
                        if (n % j == 0) sum += j;
                    }
                    if (sum > n) break;
                }
                Console.Write("Число не избыточное, ближайшее избыточое - {0}", n);
            }
        }
        static void Main(string[] args)
        {   
            Console.OutputEncoding = Encoding.Unicode;
            int n = int.Parse(Console.ReadLine());
            Overloaded(ref n);
            
            Console.ReadKey();
        }
    }
}
