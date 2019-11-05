using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_2
{
    class Program
    {


        static void NoZeroBit(uint x1)
        {
            int k = 0;
            for (byte i = 0; i < 15; i++)
            {
                if ((x1 & (1 << i)) != (i << 1)) k++;
            }
            Console.WriteLine("1: {0}", k);
        }

        static void Converter(int x2)
        {
            Console.WriteLine("2: {0}", Convert.ToString(x2, 2));

        }
        static void Main(string[] args)
        {
            uint x1 = uint.Parse(Console.ReadLine()), n = uint.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            //1
            NoZeroBit(x1);

            //2
            Converter(x2);

            //3
            for(int i = 32; i > 1; i++)
            {

            }
            Console.ReadKey();
        }
    }
}
