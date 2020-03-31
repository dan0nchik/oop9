using System;

namespace Практика13
{
    public class Point3D
    {
        private int x;
        private int y;
        private int z;

        public static Point3D CreateFor5(int x, int y, int z)
        {
            try
            {
                if (x % 5 != 0 || y % 5 != 0 || z % 5 != 0)
                {
                    throw new Exception("Введена координата, не кратная 5, вызывается конструктор по умолчанию");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Ошибка: {0}", error.Message);
                return new Point3D();
            }
            return new Point3D(x, y, z);
        }

        public Point3D()
        {
            x = 5;
            y = 5;
            z = 5;
        }

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //overload
        public static Point3D operator +(Point3D point1, Point3D point2)
        {
            point1.x += point2.x;
            point1.y += point2.y;
            point1.z += point2.z;
            return point1;
        }

        public static Point3D operator -(Point3D point1, Point3D point2)
        {
            point1.x -= point2.x;
            point1.y -= point2.y;
            point1.z -= point2.z;
            return point1;
        }

        public static Point3D operator ++(Point3D point)
        {
            point.x += 1;
            point.y += 1;
            point.z += 1;
            return point;
        }

        public static Point3D operator --(Point3D point)
        {
            point.x -= 1;
            point.y -= 1;
            point.z -= 1;
            return point;
        }

        public static bool operator >=(Point3D point1, Point3D point2)
        {
            return point1.x >= point2.x && point1.y >= point2.y && point1.z >= point2.z ? true : false;
        }

        public static bool operator <=(Point3D point1, Point3D point2)
        {
            return point1.x <= point2.x && point1.y <= point2.y && point1.z <= point2.z ? true : false;
        }

        public static string operator &(Point3D point1, Point3D point2)
        {
            return (point1.x > 0 && point1.y > 0 && point1.z > 0) & (point2.x > 0 && point2.y > 0 && point2.z > 0) ? "И 1 и 2 точки > 0" : "Одна из точек < 0";
        }

        public static string operator |(Point3D point1, Point3D point2)
        {
            return (point1.x > 0 && point1.y > 0 && point1.z > 0) | (point2.x > 0 && point2.y > 0 && point2.z > 0) ? "Хотя бы одна точка > 0" : "Обе точки меньше 0";
        }

        public static bool operator true(Point3D point)
        {
            return point.x >= 0 && point.y <= 0 && point.z <= 0 ? true : false;
        }

        public static bool operator false(Point3D point)
        {
            return !(point.x >= 0 && point.y <= 0 && point.z <= 0) ? true : false;
        }

        public void Move()
        {
            //тут конечно не очень красиво, но функция маленькая очень
            Console.WriteLine("Введите ось, по которой будем сдвигать (x,y или z): ");
            string s = Console.ReadLine();
            if (s.Contains("x"))
            {
                Console.Write("Введите число, на которое будем сдвигать: ");
                x += int.Parse(Console.ReadLine());
            }
            if (s.Contains("y"))
            {
                Console.Write("Введите число, на которое будем сдвигать: ");
                y += int.Parse(Console.ReadLine());
            }
            if (s.Contains("z"))
            {
                Console.Write("Введите число, на которое будем сдвигать: ");
                z += int.Parse(Console.ReadLine());
            }
        }

        public double Radius()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
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

    internal class Program
    {
        private static void Main(string[] args)
        {
            Point3D point;
            int x, y, z;
            Console.WriteLine("Выберите режим: стандартные оси (1) или заданные координаты (2); действия с 2мя точками - 3, 4 - радиус, 5 - создание точки кратной 5: ");
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
                point.Move();
                point.Output();
            }

            if (input == 3)
            {
                Console.WriteLine("Первая точка будет создана по умолчанию (1) или сами введете (2)?");
                int choosed = int.Parse(Console.ReadLine());
                if (choosed == 1) { point = new Point3D(); point.Output(); }
                else
                {
                    Console.Write("Введите нач. координату х: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Введите нач. координату y: ");
                    y = int.Parse(Console.ReadLine());
                    Console.Write("Введите нач. координату z: ");
                    z = int.Parse(Console.ReadLine());
                    point = new Point3D(x, y, z);
                }
                Console.Write("Введите нач. координату х другой точки: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату y другой точки: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату z другой точки: ");
                z = int.Parse(Console.ReadLine());
                Point3D point2 = new Point3D(x, y, z);

                Console.Write("Режим: сложение 2х точек - 1, сложение точки с целым числом - 2, сравнение точек - 3, бинарный оператор & - 4, бинарный оператор | - 5, инкремент точки - 6, декремент точки - 7,  вычитание точек - 8, проверка точки на истинность - 9");
                input2 = int.Parse(Console.ReadLine());
                if (input2 == 1)
                {
                    point += point2;
                    point.Output();
                }
                if (input2 == 2)
                {
                    Console.Write("Введите число: ");
                    num = int.Parse(Console.ReadLine());
                    point.Sum(num);
                    point.Output();
                }
                if (input2 == 3)
                {
                    if (point >= point2) Console.WriteLine("Первая точка больше второй");
                    else Console.WriteLine("Вторая точка больше первой");
                }
                if (input2 == 4) Console.WriteLine($"Применение & к координатам точек. Результат: {point & point2}");

                if (input2 == 5) Console.WriteLine($"Применение | к координатам точек. Результат: {point | point2}");

                if (input2 == 6)
                {
                    Console.Write("Выберите точку для увеличения на 1 (1 или 2): ");
                    choosed = int.Parse(Console.ReadLine());
                    if (choosed == 1) Console.WriteLine($"Новое значение {point++}");
                    else Console.WriteLine($"Новое значение {point2++}");
                }
                if (input2 == 7)
                {
                    Console.Write("Выберите точку для уменьшения на 1 (1 или 2): ");
                    choosed = int.Parse(Console.ReadLine());
                    if (choosed == 1) Console.WriteLine($"Новое значение {point--}");
                    else Console.WriteLine($"Новое значение {point2--}");
                }
                if (input2 == 8)
                {
                    Console.WriteLine($"Результат вычитания: {point -= point2}");
                }
                if (input2 == 9)
                {
                    if (point) Console.WriteLine("Первая точка истинна"); else Console.WriteLine("Первая точка ложна");
                    if (point2) Console.WriteLine("Вторая точка истинна"); else Console.WriteLine("Вторая точка ложна");
                }
            }

            point = new Point3D();

            if (input == 4)
            {
                Console.WriteLine("Радиус: " + point.Radius());
            }
            if (input == 5)
            {
                Console.Write("Введите нач. координату х: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Введите нач. координату z: ");
                z = int.Parse(Console.ReadLine());
                Point3D.CreateFor5(x, y, z);
            }

            Console.ReadKey();
        }
    }
}