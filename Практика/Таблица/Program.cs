using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Таблица_истинности
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine(" A \t B \t A & B\t A | B \n false \t false \t false \t false \n true \t false \t false \t true \n false \t true \t false \t true \n true \t true \t true \t true");
            Console.ReadKey();
        }
    }
}