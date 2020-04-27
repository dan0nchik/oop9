using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public virtual int A{
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
        public virtual int B
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

        public virtual double Beta
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

                    beta = value;
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

        public virtual bool isSpecialCaseTriangle
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

        public virtual double Area()
        {
            return a * b * Math.Sin(ToRads(beta));
        }

        public virtual void Show()
        {
            Console.WriteLine($"a: {a} \n b: {b} \n beta: {beta}");
        }

        public virtual double Perimeter()
        {
            return a + b + StoronaC;
        }

    }

    class PrTriangle : Triangle
    {
        public PrTriangle():base()
        {
            beta = 90;
        }
            
        public PrTriangle(int a, int b) : base(a,b,90)
        {

        }

        public override bool isSpecialCaseTriangle
        {
            get
            {
                if (a == b) return true;
                return false;
            }
        }

        public override double Beta
        {
            get
            {
                return beta;
            }
            set
            {
                beta = 90; throw new Exception("Нельзя менять угол!"); }
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Треугольник прямоугльный");
        }

    }

    class RavnostorTriangle:Triangle
    {
        public RavnostorTriangle()
        {
            a = b;
            beta = 60;
        }

        public override double Beta
        {
            get
            {
                return 60;
            }
            set
            {
                beta = 60; throw new Exception("Угол нельзя менять!");
            }

        }

        public override int A
        {
            get
            {
                return a;
            } set
            {
                if(b != a) throw new Exception("У стороны б другое значение!");
            }
        }

        public override int B
        {
            get
            {
                return b;
            }
            set
            {
                if (a != b) throw new Exception("У стороны б другое значение!");
            }
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Треугольник равносторонний");
        }

        public override double Area()
        {
            return a*a*Math.Sqrt(3)/4;
        }

        public override double Perimeter()
        {
            return a*3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
