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
            /*public TheIlluminati(double h, double l)
            {
                this.h = h;
                this.l = l;
            }*/
            public void Output()
            {
                Console.WriteLine($"Высота пирамиды: {h} см");
                Console.WriteLine($"Основание пирамиды: {l} см");
            }
            public double Perimeter
            {
                get
                {
                    return 4 * l;
                }
            }
            public double Size
            {
                get
                {
                    return (h * Math.Pow(l, 2)) / 3;
                }
            }
            public double GetHeight
            {
                get
                {
                    return h;
                }
                set
                {
                    try
                    {
                        if (value < 0) throw new Exception("Основание меньше 0!");
                        h = value;
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
            }
            public double GetGround
            {
                get
                {
                    return l;
                }
                set
                {
                    try
                    {
                        if (value < 0) throw new Exception("Основание меньше 0!");
                        l = value;
                    }
                    catch(Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                }
            }
            public double SquareOFGround
            {
                get
                {
                   return l * l;
                }
            }
            public double Apofem
            {
                get
                {
                    return Math.Sqrt(h * h + Math.Pow(l / (2 * Math.Tan(45.0)),2));
                }
            }
            public double SqrtOfWall
            {
                get
                {
                    return (Perimeter / 2) * Apofem;
                }
            }
            public double GroundDiagonal
            {
                get
                {
                    return GetGround * Math.Sqrt(2);
                }
            }
            public double Rib
            {
                get
                {
                    return Math.Sqrt(h * h + Math.Pow(l / (2 * Math.Sin(45.0)), 2));
                }
            }
            public double PyramidSquare
            {
                get
                {
                    return SqrtOfWall + SquareOFGround;
                }
            }
        }
        
        
        static void Main(string[] args)
        {
            TheIlluminati pyramid = new TheIlluminati();
            Console.WriteLine("Создать объект со своими значениями - введите 1, или нажмите 2");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {   
                Console.Write("Введите высоту: ");
                pyramid.GetHeight = double.Parse(Console.ReadLine());
                Console.Write("Введите основание: ");
                pyramid.GetGround = double.Parse(Console.ReadLine());
                
            }
                Console.WriteLine($"Высота пирамиды: {pyramid.GetHeight} см");
                Console.WriteLine($"Основание пирамиды: {pyramid.GetGround} см");
                Console.WriteLine($"Периметр пирамиды: {pyramid.Perimeter} см");
                Console.WriteLine($"Объём пирамиды: {pyramid.Size} см в квадрате");
                Console.WriteLine($"Площадь основания пирамиды: {pyramid.SquareOFGround} см в квадрате");

            Console.ReadKey();
        }
    }
}
