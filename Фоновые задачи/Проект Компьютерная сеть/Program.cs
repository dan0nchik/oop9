using System;

namespace Проект_Компьютерная_сеть
{
    class Program
    {      //ДОДЕЛАТЬ ТОЧКИ В ДВОИЧНОМ АДРЕСЕ СЕТИ
        static double Hosts(byte a)
        {
            int k = 0, i = 0;
            double hosts = 0;
            while ((a << i & a) != 1 && k < 8 && i < 8)
            {
                hosts++;
                k++;
                i++;
            }
            return hosts;
            //Math.Pow(2, hosts) - 2; 

        }

        static string DotMaker() //точки в десятичном вывод адреса сети
        {
            for (int k = 0; k < 8; k++)
            {
                if (k == 3 || k == 7) return ".";
            }
            return "";
        }

        static void Converter(byte a) // перевод в бинарный код
        {

            for (int i = 7; i >= 0; i--)
            {
                if (((byte)(a >> i) & 1) == 1)
                    Console.Write("1");
                else
                    Console.Write("0");
            }


        }

        static void Main(string[] args)

        {
            byte[] ip = new byte[4]; // массив ip
            byte[] mask = new byte[4]; // массив маска
            double zeros = 0;
            for (int i = 0; i < mask.Length; i++) // ввод маски
            {
                mask[i] = byte.Parse(Console.ReadLine());
            }
            for (int i = 0; i < ip.Length; i++) // ввод ip
            {
                ip[i] = byte.Parse(Console.ReadLine());
            }

            for (int i = 0, j = 0; i < ip.Length && j < mask.Length; i++, j++) // вывод десятичного адреса сети
            {
                Console.Write((byte)(ip[i] & mask[j]) + DotMaker());
            }
            Console.WriteLine("");
            for (int i = 0, j = 0, k = 0; i < ip.Length && j < mask.Length && k < 32; i++, j++, k++) // вывод двоичного адреса сети
            {
                Converter((byte)(ip[i] & mask[j]));
                zeros += Hosts(mask[j]);
            }
            Console.WriteLine("");
            Console.WriteLine(zeros);

            Console.ReadKey();
        }
    }
}
