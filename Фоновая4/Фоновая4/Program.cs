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
                h = 7;
                l = 5;
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
                    return SqrtOfWall / (2 * l);
                }
            }
            public double SqrtOfWall
            {
                get
                {
                    return (Math.Sqrt( Math.Pow(h,2) + Math.Pow(l/2,2)) * 4 * l) / 2;
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
                    return Math.Sqrt(h*h+Math.Pow( GroundDiagonal/2,2));
                }
            }
            public double PyramidSquare
            {
                get
                {
                    return SqrtOfWall + SquareOFGround;
                }
            }
            public double GoldenRatio
            {
                get
                {
                    return 0;
                }
            }
        }
        
        
        static void Main(string[] args)
        {
            TheIlluminati pyramid;
            Console.WriteLine("Создать объект со своими значениями - введите 1, или нажмите 2");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            { 
                Console.Write("Введите высоту: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Введите основание: ");
                double ground = double.Parse(Console.ReadLine());
                pyramid = new TheIlluminati(height, ground);
            }
            else pyramid = new TheIlluminati(); 

                Console.WriteLine($"Высота пирамиды: {pyramid.GetHeight:f2} см");
                Console.WriteLine($"Основание пирамиды: {pyramid.GetGround:f2} см");
                Console.WriteLine($"Периметр пирамиды: {pyramid.Perimeter:f2} см");
                Console.WriteLine($"Объём пирамиды: {pyramid.Size:f2} см в квадрате");
                Console.WriteLine($"Площадь основания пирамиды: {pyramid.SquareOFGround:f2} см в квадрате");
                Console.WriteLine($"Площадь боковой поверхности: {pyramid.SqrtOfWall:f2} см в квадрате");
                Console.WriteLine($"Площадь поверхности: {pyramid.PyramidSquare:f2} см в квадрате");
                Console.WriteLine($"Площадь основания пирамиды: {pyramid.SquareOFGround:f2} см в квадрате");
                Console.WriteLine($"Диагональ основания: {pyramid.GroundDiagonal:f2} см");
                Console.WriteLine($"Апофема: {pyramid.Apofem:f2} см");
                Console.WriteLine($"Ребро: {pyramid.Rib:f2} см");
                Console.Write($"Изменить высоту: ");
            pyramid.GetHeight = double.Parse(Console.ReadLine());
                Console.Write($"Изменить основание: ");
            pyramid.GetGround = double.Parse(Console.ReadLine());
            Console.Write($"Новая высота {pyramid.GetHeight} / Новое основание {pyramid.GetGround}");

                Console.ReadKey();
        }
    }
}
