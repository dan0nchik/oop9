using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Компьютерные_Сети
{
    class Program
    {
        static void Main()
        {
            uint mask = 0, aipi = 0;
            for (int i = 0; i < 4; i++)
            {
                mask += byte.Parse(Console.ReadLine());
                mask<<= 8;
            }
            for (int i = 0; i < 4; i++)
            {
                aipi += byte.Parse(Console.ReadLine());
                aipi<<= 8;
            }
            Console.WriteLine(aipi & mask);
            Console.ReadKey();
        }
    }
}