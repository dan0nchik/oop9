using System;

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

        /*static void Converter(int x2)
         {
             Console.Write("2: ");

             bool check = false;
             for (int i = 0x8000000; i >= 0; i>>=1)
             {
                 if (((x2 >> i) & 1) != 0)
                 {
                    Console.Write("1"); check = true;
                 }
                 if(check == true)
                     Console.Write("0");
             }


         }*/

            /*for (int i = 7; i >= 0; i--)
            {
                if (((byte)(a >> i) & 1) == 1)
                    Console.Write("1");
                else
                    Console.Write("0");
            }
*/

            static int KolichestvoJ(uint x1)
        {
            int j = 0;
            for(int i = 31; i >= 0; i--)
            {
                if (((x1 >> i) & 1) == 1)
                {
                    break;
                }
                j++;
            }   
                return j;
        }
        static void Sdvig(uint x1, uint n)
        {
            uint mask = 0;
            uint mask2 = 0b00000000000000000000000000000001;
            
            for (int i = 0; i < n; i++)
            {
                if ((mask2 & x1) == 1)
                { 
                    Console.Write("1");
                }
                else Console.Write("0");
                x1 >>= 1;
            }
            int j;
            for (j = KolichestvoJ(x1); j >= 0; j--)
            {
                if (((byte)(x1 >> j) & 1) == 1)
                    Console.Write("1");
                else
                    Console.Write("0");
            }
                
        }
        static void Main(string[] args)
        {
            uint x1 = uint.Parse(Console.ReadLine()), n = uint.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            //1
            ZeroBit(x1);

            //2
            //Converter(x2);

            //3
            Sdvig(x1, n);
            
            Console.ReadKey();
           
        }
    }
}
