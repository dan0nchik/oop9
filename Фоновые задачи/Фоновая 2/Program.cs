using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_2
{
    class Program
    {


        static void ZeroBit(uint x1)
        {
            int k = 0;
            for (byte i = 0; i < 15; i++)
            {
                if ((x1 & (1 << i)) != (i << 1)) k++;
            }
            Console.WriteLine("1: {0}", k);
        }

        static void Converter(long x2)
        {
            

        }
        static void Sdvig(uint x1, uint n)
        {
            
            byte mask = 0b_00000000000000000000000000000001;
            
            for(byte i = 0, x = 0; i < n; i++)
            {
                if ((x1 & mask) == 0) x += 1;
                x1 = x1 >> 1;
                x1 = x & x1;
            }
            
            Console.WriteLine("3: {0}", x1);
        }
        static void Main(string[] args)
        {
            uint x1 = uint.Parse(Console.ReadLine()), n = uint.Parse(Console.ReadLine());
            long x2 = long.Parse(Console.ReadLine());
            //1
            ZeroBit(x1);

            //2
            Converter(x2);

            //3
            Sdvig(x1, n);
            Console.ReadKey();
        }
    }
}
