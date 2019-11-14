using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Проект_Компьютерная_сеть
{
    class Program
    {      
        
        static double Hosts(byte mask) // должен вывести 14 и в степень
        {
            //ПЕРЕДЕЛАТЬ!!!!!!!!!!!!
            double hosts = 0;
            
            for(int i = 7; i >= 0; i--)
            {   
                if (((byte)(mask << i) & 1) == 1) break;
                else
                hosts++;
            }
            Console.WriteLine(Convert.ToString(mask,2));
            //hosts = Math.Pow(2, hosts) - 2; //возведение в степень для поиска количества компьютеров
            return hosts;
            

        }
        static int Number(byte ip, byte mask) //должен вывести 8
        {
            int num = 0;
            for (int i = 1; i <= 8; i++)
            {   
                if (((byte)(1 << i) & mask) != 1)
                {
                    if (((ip >> i) | (mask >> i)) == 1) num++;
                }
                
            }
            return num;
        }

        static string DotMaker() //точки в десятичном вывод адреса сети (можно было сделать и без отдельной функции)
        {
            for (int k = 0; k < 8; k++)
            {
                if (k == 3 || k == 7) return ".";
            }
            return "";
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
            Console.WriteLine("Введите маску пожалуйста :");
            byte m1 = byte.Parse(Console.ReadLine()), m2 = byte.Parse(Console.ReadLine()), m3 = byte.Parse(Console.ReadLine()), m4 = byte.Parse(Console.ReadLine()) ;
            Console.WriteLine("И еще ip, если не сложно:");
            byte p1 = byte.Parse(Console.ReadLine()), p2 = byte.Parse(Console.ReadLine()), p3 = byte.Parse(Console.ReadLine()), p4 = byte.Parse(Console.ReadLine()); 
            Console.WriteLine("Ваш адрес сети в деятичном коде: ");
            Console.Write("{0}.{1}.{2}.{3} \n",p1 & m1,p2 & m2,p3 & m3,p4 & m4);
            
            Console.WriteLine("Ваш адрес сети в двоичном коде: ");
            Console.Write("{0}.{1}.{2}.{3} \n", Converter((byte)(p1 & m1)), Converter((byte)(m2 & p2)), Converter((byte)(m3 & p3)), Converter((byte)(m4 & p4)));
            Console.Write("Количество компьютеров в сети: {0} \n", Hosts(m3));
            Console.Write("Номер данного компьютера в сети: {0}", Number(p4, m4), Number(p3, m3), Number(p2, m2), Number(p1, m1));

            Console.ReadKey();
        }
    }
}
