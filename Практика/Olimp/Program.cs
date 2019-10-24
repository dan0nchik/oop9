using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int tT = int.Parse(Console.ReadLine()), UTCT = int.Parse(Console.ReadLine()), UTC0 = 0, UTCP = int.Parse(Console.ReadLine());
            UTC0 = tT - UTCT;
            int TP = UTC0 + UTCP;
            Console.WriteLine(TP);*/


            /*int A = int.Parse(Console.ReadLine()); int B = int.Parse(Console.ReadLine());
            int chet = 0, nechet = 0;
            
            if (B > A)
            {   
                for(int i = B; i >= A;  i--)
                {
                    if (i % 2 == 0) chet += i;
                    else nechet += i;
                }
                Console.Write(chet - nechet);
            }
            else
            {
                for (int j = A; j >= B; j--)
                {
                    if (j % 2 == 0) chet += j;
                    else nechet += j;
                }
                Console.Write(chet - nechet);
            } */
            /*int A = int.Parse(Console.ReadLine()), B = int.Parse(Console.ReadLine());
            int s1 = A * 2 + 1;
            if ((s1 + 1) % B == 0) Console.WriteLine(s1);
            else
            { int k = 3;
                while((s1 + 1) % B == 0)
                {
                    s1 = A * k + 1;
                    k++;
                }
                Console.WriteLine(s1);
            }*/


            string s = Console.ReadLine();
            char s1= s;
            for(int i = 0;  i< s.Length; i++)
            {
                for(int j = s.Length; j > 0; j--)
                {

                }
            }



            Console.ReadKey();
        }
    }
}
