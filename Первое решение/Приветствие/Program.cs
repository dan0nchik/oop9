using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Приветствие
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Здравствуйте, введите Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine(@"**************************************************
****  работает первое приложение Дани Хромова ****
**************************************************");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello, {0}!", name);
            Console.ReadKey();
            

        }
    }
}
