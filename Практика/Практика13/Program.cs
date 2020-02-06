using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика13
{
    public class Point3D
    {
        public int x;
        public int y;
        public int z;
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
            Console.Write("Введите расстояние по оси х: ");
            x += int.Parse(Console.ReadLine());
            Console.Write("Введите расстояние по оси y: ");
            y += int.Parse(Console.ReadLine());
            Console.Write("Введите расстояние по оси z: ");
            z += int.Parse(Console.ReadLine());
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
            Console.WriteLine("Выберите режим: стандартные оси(1) или заданные координаты(2): ");
            if (int.Parse(Console.ReadLine()) == 2)
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
                point.Move();
                point.Output();
            }
            Console.ReadKey();
        }
    }
}
