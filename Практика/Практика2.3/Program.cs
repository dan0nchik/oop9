using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика2._3
{
    class Program
    {
        static void Main(string[] args)
        { 
           switch (Console.ReadLine())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                case "y":
                Console.Write("Vovel");
                    break;
         
                default:
                    Console.Write("Consonant");
                    break;
            }
            Console.ReadKey();
        }

    }
}
