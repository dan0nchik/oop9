using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая4
{
    class Program
    {
        class TheIlluminati
        {
            private double h;
            private double l;
            public TheIlluminati()
            {
                h = 5;
                l = 7;
            }
            public TheIlluminati(double h, double l)
            {
                this.h = h;
                this.l = l;
            }
            public void Output()
            {
                Console.WriteLine($"Высота пирамиды: {h} см");
                Console.WriteLine($"Основание пирамиды: {l} см");
            }
            public double Perimeter()
            {
                return 4 * l;
            }
            public double Size()
            {
                return (h * Math.Pow(l, 2)) / 3;
            }
            public double GetHeight()
            {
                return h;
            }
            public double GetGround()
            {
                return l;
            }
        }
        
        
        static void Main(string[] args)
        {
            TheIlluminati pyramid = new TheIlluminati();
            double hight, ground;
            Console.WriteLine("Совершить действия со своими значениями - введите 1, или нажмите 2");

            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.Write("Введите высоту: ");
                hight = double.Parse(Console.ReadLine());
                Console.Write("Введите основание: ");
                ground = double.Parse(Console.ReadLine());
                pyramid = new TheIlluminati(hight, ground);
            }
            
                Console.WriteLine($"Высота пирамиды: {pyramid.GetHeight()} см");
                Console.WriteLine($"Основание пирамиды: {pyramid.GetGround()} см");
                Console.WriteLine($"Периметр пирамиды: {pyramid.Perimeter()} см");
                Console.WriteLine($"Объём пирамиды: {pyramid.Size()} см в квадрате");
                Console.ReadKey();
        }
    }
}
