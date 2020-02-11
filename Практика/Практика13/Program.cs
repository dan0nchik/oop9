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
                this.x += int.Parse(Console.ReadLine());
            }
            if (Console.ReadLine().Contains("y"))
            {
                this.y += int.Parse(Console.ReadLine());
            }
            if (Console.ReadLine().Contains("z"))
            {
                this.z += int.Parse(Console.ReadLine());
            }


        }
        public double Radius()
        { 
            return Math.Sqrt(Math.Pow (this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
        }
        public void Sum(Point3D obj)
        {
            this.x += obj.x;
            this.y += obj.y;
            this.z += obj.z;
        }
        public void Output()
        {
            Console.WriteLine($"Новые координаты: ({x},{y},{z})");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Point3D point;
            int x, y, z;
            Console.WriteLine("Выберите режим: стандартные оси(1) или заданные координаты(2); сложение 2х точек - 3, 4 - радиус: ");
            int input = int.Parse(Console.ReadLine());
            if (input == 2)
            {
                Console.Write("Введите нач. координату х: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату z: ");
                z = int.Parse(Console.ReadLine());
                point = new Point3D(x, y, z);
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
                
                Console.Write("Введите нач. координату х: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату z: ");
                z = int.Parse(Console.ReadLine());
                Point3D point2 = new Point3D(x, y, z);
                point.Sum(point2);
                point.Output();
            }
            if(input == 4)
            {
               Console.WriteLine("Радиус: " + point.Radius());
            }
            Console.ReadKey();
        }
    }
}
