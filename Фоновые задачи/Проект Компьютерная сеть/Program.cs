using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Проект_Компьютерная_сеть
{
    class Program
    {      
        
        static double Hosts(byte mask) 
        {
            
            double hosts = 0;
            
            for(int i = 0; i < 8; i++)
            {   
                if (((byte)(mask >> i) & 1) == 1) break;
                else
                hosts++;
            }
            hosts = Math.Pow(2, hosts) - 2; //возведение в степень для поиска количества компьютеров
            return hosts;
        }
        static int NumberInDecimal(byte ip, byte mask)
        {
            int zeros = 0;
            for (int i = 0; i < 8; i++)
            {
                if (((byte)(mask >> i) & 1) != 1)
                    zeros++;
                else break;
            }
            
            ip <<= 8 - zeros;
            ip >>= 8 - zeros;
            if (ip == 0) return 0;
            Console.Write(ip);
            return 0;
        }
        static int NumberInBinary(byte ip, byte mask)
        {
            int zeros = 0;
            for (int i = 0; i < 8; i++)
            {
                if (((byte)(mask >> i) & 1) != 1)
                    zeros++;
                else break;
            }

            ip <<= 8 - zeros;
            ip >>= 8 - zeros;
            if (ip == 0) return 0;
            Console.Write(Converter(ip));
            return 0;
        }
        static string Converter(byte a) 
           // перевод каждого элемента в бинарный код 
           //(можно сделать функцию типа void, но! тогда будет for в Main => громоздкое решение)
        {
            string s = "";
            for (int i = 7; i >= 0; i--)
            {
                if (((byte)(a >> i) & 1) == 1)
                    s += "1";
                else
                    s += "0";
            }
            return s;
            }

        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите маску:");
            byte m1 = byte.Parse(Console.ReadLine()), m2 = byte.Parse(Console.ReadLine()), m3 = byte.Parse(Console.ReadLine()), m4 = byte.Parse(Console.ReadLine()) ;
            Console.WriteLine("И еще ip:");
            byte p1 = byte.Parse(Console.ReadLine()), p2 = byte.Parse(Console.ReadLine()), p3 = byte.Parse(Console.ReadLine()), p4 = byte.Parse(Console.ReadLine()); 
            Console.WriteLine("Ваш адрес сети в десятичном коде: ");
            Console.Write("{0}.{1}.{2}.{3} \n",p1 & m1,p2 & m2,p3 & m3,p4 & m4);
            Console.WriteLine("Ваш адрес сети в двоичном коде: ");
            Console.Write("{0}.{1}.{2}.{3} \n", Converter((byte)(p1 & m1)), Converter((byte)(m2 & p2)), Converter((byte)(m3 & p3)), Converter((byte)(m4 & p4)));
            Console.Write("Количество компьютеров в сети: {0} \n", Hosts(m3) + Hosts(m4) + Hosts(m2), Hosts(m1));
            Console.Write("Номер данного компьютера в сети в десятичном и двоичном коде: ");
            NumberInDecimal(p1, m1);
            NumberInDecimal(p2, m2);
            NumberInDecimal(p3, m3);
            NumberInDecimal(p4, m4);
            Console.WriteLine("");
            NumberInBinary(p1, m1);
            NumberInBinary(p2, m2);
            NumberInBinary(p3, m3);
            NumberInBinary(p4, m4);
            Console.ReadKey();
        }
    }
}
