using System;
using System.Text;

namespace Практика2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int x = int.Parse(Console.ReadLine());
            if (x == 29) { Console.WriteLine("ПОПАЛ!"); }
            if (x >= 30) { Console.WriteLine("ПЕРЕЛЕТ"); }
            else if (x >= 0) {
                Console.WriteLine("НЕДОЛЕТ!"); 
         
            }
            if (x <= 0) { Console.WriteLine("Не бей по своим!"); } 
            Console.ReadKey();
        }
    }
}