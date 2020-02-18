using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика13
{
    public class Point3D
    {
        private int x;
        private int y;
        private int z;
        public Point3D()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void Move()
        {
            Console.WriteLine("Введите ось: ");
            if (Console.ReadLine().Contains("x"))
            {
                x += int.Parse(Console.ReadLine());
            }
            if (Console.ReadLine().Contains("y"))
            {
                y += int.Parse(Console.ReadLine());
            }
            if (Console.ReadLine().Contains("z"))
            {
                z += int.Parse(Console.ReadLine());
            }


        }
        public double Radius()
        { 
            return Math.Sqrt(Math.Pow (this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }
        public void Sum(Point3D obj)
        {
            x += obj.x;
            y += obj.y;
            z += obj.z;
        }
        public void Sum(int num)
        {
            x += num;
            y += num;
            z += num;
        }
        public void Output()
        {
            Console.WriteLine($"Новые координаты: ({x},{y},{z})");
        }
        public int X
        {
            set
            {
                if (value >= 0) x = value;
            }
        }
        public int Y
        {
            set
            {
                if (value >= 0 && value < 100) y = value;
                else y = 100;
            }
        }
        public int Z
        {
            get
            {
                return z;
            }
            set
            {
                if (value <= x + y) z = value;
                else
                {
                    Console.WriteLine("Превышение!");
                }
            }
        }
        public int Multi
        {
            set
            {
                x *= value;
                y *= value;
                z *= value;
            }
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Point3D point;
            int x, y, z;
            Console.WriteLine("Выберите режим: стандартные оси(1) или заданные координаты(2); сложение 2х точек - 3, 4 - радиус: ");
            int input = int.Parse(Console.ReadLine()), input2, num;
            if (input == 2)
            {
                Console.Write("Введите нач. координату х: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату z: ");
                z = int.Parse(Console.ReadLine());
                point = new Point3D(x, y, z);
                point.X = x;
                point.Y = y;
                point.Z = z;
                point.Move();
                point.Output();
               
            }
            else
            {
                point = new Point3D();
                point.Output();
            }
            
            if(input == 3)
            {
                Console.Write("Режим: сложение 2х точек - 1, сложение точки с целым числом - 2: ");
                input2 = int.Parse(Console.ReadLine());
                if (input2 == 1)
                {
                    Console.Write("Введите нач. координату х другой точки: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Введите нач. координату y другой точки: ");
                    y = int.Parse(Console.ReadLine());
                    Console.Write("Введите нач. координату z другой точки: ");
                    z = int.Parse(Console.ReadLine());
                    Point3D point2 = new Point3D(x, y, z);
                    point.Sum(point2);
                    point.Output();
                }
                if(input2 == 2)
                {
                    Console.Write("Введите число: ");
                    num = int.Parse(Console.ReadLine());
                    point.Sum(num);
                    point.Output();
                }
            }
            if(input == 4)
            {
               Console.WriteLine("Радиус: " + point.Radius());
            }
            
            Console.ReadKey();
        }
    }
}
