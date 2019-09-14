using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            float r = 64.100F, p1 = 7.8932597F, pr = 100000000000f, f1 = 3.20000F;
            decimal dec = 18500.5M;
            int s1 = 4, p = 16;
            string s = "AMD";
            Console.Write("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.Write("Введите дробное число:");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.WriteLine("Привет, {0}!", name);
            Console.WriteLine(@"*********************************
*       Я твой компьютер!       *
*********************************
У меня следующие характеристики:
");

            
            Console.WriteLine(@"Процессор               {0} c разрядностью {1:F2}GHz
Моя память              {2}Gb (доступно {3:F0}%)
Жесткий диск            {4}Tb 
Тип системы             {5:F0}-разрядная ОС


Моя производительность  {6:F0} оп / сек 
Индекс произв-ти        {7:F0} 
Моя стоимость           {8:F2} ₽", s, f1, p, p1, s1, r, pr, f, dec);


Console.ReadKey();

        }
    }
}
