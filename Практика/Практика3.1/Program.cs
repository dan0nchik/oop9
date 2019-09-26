using System;

namespace Практика3
{
    internal class Program
    {
        private static void PifagorTable()
        {
            Console.Write("\t");
            for (int n = 2; n <= 9; n++)
            {
                Console.Write($"{n}\t");
            }
            Console.WriteLine("\n\n");
            for (int i = 2; i <= 9; i++)
            {
                Console.Write($"{i} \t");
                for (int j = 2; j <= 9; j++)
                {
                    int k = i * j;
                    Console.Write($"{k}\t");
                }

                Console.WriteLine($"\n");
            }
        }

        private static void _2()
        {
            for (int a = 1; a <= 7; a++)
            {
                for (int b = 2; b <= 8; b++)
                {
                    for (int c = 3; c <= 9; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                        
                    }
                    
                }
                /*тут должны увеличиваться a и b на 1, но 
                он не дает их увеличить потому что они относятся к for'ам, 
                возможно это ограничение c#. Я пробовал с while в for, и просто несколько while, 
                но тогда он выводит только с 123 по 129*/
               
            }

            }

        private static void _3()
        {
           

        }

        private static void Main()
        {
            //PifagorTable();
            _2();
            Console.ReadKey();
        }
    }
}