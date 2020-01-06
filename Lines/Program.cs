using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Program
    {
        static List<int> Generation(int n) //TODO исправить
        {
            List<int> list = new List<int> {};
            var R = new Random();
            int rand = R.Next(0, 10);
            list.Add(rand);
               for(int i = 1; i < n; i++)
            {
                rand = R.Next(0, 10);
                while (list.Contains(rand))
                {
                    rand = R.Next(0, 10);
                }
                list.Add(rand);
            }
            return list;
        }
        
        static ConsoleColor CircleColor()
        {
            Random rand = new Random();
            ConsoleColor[] Colors = new ConsoleColor[7] { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.DarkGray, ConsoleColor.Cyan, ConsoleColor.Magenta };
            int index = rand.Next(Colors.Length);
            return Colors[index];
        }
       
        static int[,] Filling(int[,] field, int numOfCircles)
        {
            List<int> xList = Generation(numOfCircles);
            int x, y;
            List<int> yList = Generation(numOfCircles);
            for (int i = 0; i < numOfCircles; i++)
            {
                x = xList[i];
                y = yList[i];
                field[y, x] = 1;
            }
            return field;
        }
        static void Cout(int[,] field)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (field[i, j] == 0) Console.Write(" . ");
                    else
                    {
                        Console.ForegroundColor = CircleColor();
                        Console.Write(" 1 ");
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] field = new int[10,10];
            Console.Write("Enter the number of starter balls: ");
            int numOfCircles = int.Parse(Console.ReadLine());
            Filling(field, numOfCircles);
            Cout(field);   
            Console.ReadKey();
        }
    }
}
