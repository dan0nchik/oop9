using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6
{
    class Program
    {      
         static void _1(int N)
        {
            int a, k = 0;
            while(N > 0)
            {
                a = N % 10;
                if (a % 3 == 0) k += a;
                N /= 10;
            }
            if (k == 0) Console.WriteLine("NO");
            else Console.WriteLine(k);
        }
        static void _2(int N)
        {   
            int last = N % 10;
            int k = 0;
            while(N > 1)
            {
                N /= 10;
                k++;
            }
            double pow = Math.Pow(10, k);
            double first = N / pow;
            double M = N / 10 + first;
            Console.WriteLine();   
        }
        static void _3(int N)
        {
            int k = 0;
            while (N > 1)
            {
                N /= 10;
                k++;
            }
            k -= 1;
            double num = N / Math.Pow(10, k);

            Console.WriteLine(num * -1);
        }
        static void Main(string[] args)
        {      //2


            /*int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            int c = a % b;
            Console.WriteLine(c);
            Знак остатка от деления зависит от */
            int N = int.Parse(Console.ReadLine());
            _3(N);
            Console.ReadKey();
        }
    }
}
