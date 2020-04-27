using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая5._2
{

    class Triangle
    {
        protected int a, b;
        protected double beta;

        public Triangle()
        {
            a = 3;
            b = 3;
            beta = 30;
        }

        public Triangle(int a, int b, double beta)
        {
            try
            {
                if (a < 0 || b < 0 || a > b + StoronaC || b > a + StoronaC || beta < 0 || b > 180) throw new Exception("Неправильная сторона или угол!");
                else
                {
                        this.a = a;
                        this.b = a;
                        this.b = a;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public int A{
            get
            {
                return a;
            }
            set
            {
                try
                {
                    if(value < 0 || b+StoronaC < value)
                    {
                        throw new Exception("Сторона либо меньше 0, либо больше суммы 2х других сторон!");
                    }
                    else
                    {
                        a = value;
                    }
                }
                catch(Exception e) { Console.WriteLine(e.Message);}
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                try
                {
                    if (value < 0 || a + StoronaC < value)
                    {
                        throw new Exception("Сторона либо меньше 0, либо больше суммы 2х других сторон!");
                    }
                    else
                    {
                        b = value;
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }

        public double Beta
        {
            get
            {
                return b;
            }
            set
            {
                try
                {
                    if (value < 1 || value > 180)
                    {
                        throw new Exception("Угол либо меньше 0, либо больше 180!");
                    }
                    else
                    {
                        beta = value;
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }
        }
        public double ToRads(double beta) => beta * Math.PI / 180;
        public double StoronaC
        {
            get
            {
                return Math.Sqrt(a * a + b * b - a * b * Math.Cos(ToRads(beta)));
            }
        }

        public bool isSpecialCaseTriangle
        {
            get
            {
                if (a == b || b == StoronaC || a == StoronaC) return true;
                return false;
            }
        }

        public int MiddleLine
        {
            get
            {
                return a / 2;
            }
        }

        public double Area()
        {
            return a * b * Math.Sin(ToRads(beta));
        }

        public void Show()
        {
            Console.WriteLine($"a: {a} \n b: {b} \n beta: {beta}");
        }

        public double Perimeter()
        {
            return a + b + StoronaC;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
