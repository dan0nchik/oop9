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
        {   //потестить
            int a, k = 0;
            while(N > 0)
            {
                a = N % 10;
                if (a % 3 != 0) k += a;
                N /= 10;
            }
            if (k == 0) Console.WriteLine("NO");
            else Console.WriteLine($"1: {k}");
        }
        static void _2(int N)
        {   
            int last = N % 10;
            int k = 1;
            //находим кол-во цифр
            while (N > 0)
            {
                N /= 10;
                k *= 10;
            }
            // меняем
            int first = N / k;
            int m = N / 10 + first;
            int g = last * k;
            int f = N - g;
            int final = f + g;
            Console.WriteLine(first);
            
        }
        static void _3(int N)
        {   
            int k = 1;
            int n = N;
            while (N > 0)
            {
                N /= 10;
                k *= 10;
            }
            k /= 100;
            n /= k;
            n %= 10;
            Console.WriteLine($"3: {-n}");
        }
        static void _4(int N)
        {
            int m = 0, j = 0, k = 1;
           while(N > 0)
            {
                int a = N % 10;
                if (a != 3)
                {
                    m = m + k * a;
                    k = k * 10;
                }
                
                N /= 10;

            }
            Console.WriteLine($"4: {m}");
        }

        static void _5(int p, int q)
        {
            for(int i = 1; i <= q; i++)
            {
                if (q % i == 0) 
                {
                    for(int j = 1; j <= p; j++)
                    {
                        if (p % j == 0 && i == j) break;
                    }
                     
                    Console.WriteLine(i); 
                }
            }

            //я хотел сделать так, что если второй for проходил без брейков, то выводилось i. 
            //Я не знаю как проверить for на полное прохождение.
        }
        static void Main(string[] args)
        {      //2 вариант


            /*int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            int c = a % b;
            Console.WriteLine(c);
            Знак остатка от деления зависит от */
            int N = int.Parse(Console.ReadLine());
            _1(N);
            int p = int.Parse(Console.ReadLine()), j = int.Parse(Console.ReadLine());
            _5(p, j);

            Console.ReadKey();
        }
    }
}
