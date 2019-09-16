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
                    Console.Write("Vovel");
                    break;
                case "e":
                    Console.Write("Vovel");
                    break;
                case "i":
                    Console.Write("Vovel");
                    break;
                case "o":
                    Console.Write("Vovel"); 
                    break;
                case "u":
                    Console.Write("Vovel");
                    break;
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
