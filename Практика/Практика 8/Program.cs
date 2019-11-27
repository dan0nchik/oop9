using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_8
{   
    class Program
    {   
        public static void SumAndDiff(ref int a, ref int b)
    {
            int temp = a - b;
            int t = a + b;
            a = t;
            b = temp;
    }
        
        public static void Change(ref int n, int m)
        {
            int n1 = n, desyatki = 1, num = 0, n2 = 0;
            while(n1 > 0)
            {
                n1 /= 10;
                num++;
                desyatki *= 10;
            }
            while(desyatki > 1) { 
                desyatki /= 10;
                if(((n / desyatki) % 10) > m) n2 += 9 * desyatki;
                else
                if (((n / desyatki) % 10) % m == 0) n2 += m * desyatki;
                if ((((n / desyatki) % 10) < m) && (((n / desyatki) % 10) % m != 0)) n2 += desyatki * ((n / desyatki) % 10);
            }
            n = n2;
        }
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            SumAndDiff(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
            Change(ref n, m);
            Console.WriteLine(n);
            Console.ReadKey();

        }
       

    }
}
