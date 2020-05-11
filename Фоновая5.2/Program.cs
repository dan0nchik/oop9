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
            b = 4;
            beta = 30;
        }

        public Triangle(int a, int b, double beta)
        {

                this.a = a;
                this.b = a;
                this.b = a;


        }

        public virtual int A
        {
            get { return a; }
            set
            {
                try
                {
                    if (value < 0 || b + StoronaC < value)
                    {
                        throw new Exception("Сторона либо меньше 0, либо больше суммы 2х других сторон!");
                    }
                    a = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public virtual int B
        {
            get { return b; }
            set
            {
                try
                {
                    if (value < 0 || a + StoronaC < value)
                    {
                        throw new Exception("Сторона либо меньше 0, либо больше суммы 2х других сторон!");
                    }

                    b = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public virtual double Beta
        {
            get { return b; }
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public double ToRads(double beta) => beta * Math.PI / 180;

        public double StoronaC
        {
            get { return Math.Sqrt(a * a + b * b - a * b * Math.Cos(ToRads(beta))); }
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
            get { return a / 2; }
        }

        public virtual double Area()
        {
            return a * b * Math.Sin(ToRads(beta));
        }

        public virtual void Show()
        {
            Console.WriteLine($"a: {a}\nb: {b}\nbeta: {beta}");
        }

        public virtual double Perimeter()
        {
            return a + b + StoronaC;
        }

    }

    class PrTriangle : Triangle
    {
        public PrTriangle() : base(1,1,90)
        {
           
        }

        public PrTriangle(int a, int b) : base(a, b, 90)
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
            get { return beta; }
        }

        public override void Show()
        {
            Console.WriteLine("Треугольник прямоугльный");
            base.Show();
            
        }

    }

    class RavnostorTriangle : Triangle
    {
        public RavnostorTriangle():base(3,3,60)
        {

        }

        public RavnostorTriangle(int a, double beta) : base(a,a,beta)
        {

        }

        public override double Beta
        {
            get { return 60; }


        }

        public override int A
        {
            get { return a; }
            set
            {
                a = b = value;
                
            }
        }

        public override int B
        {
            get { return b; }
            set
            {
                b = a = value;
            }
        }

        public override void Show()
        {
            Console.WriteLine("Треугольник равносторонний");
            base.Show();
            
        }

        public override double Area()
        {
            return a * a * Math.Sqrt(3) / 4;
        }

        public override double Perimeter()
        {
            return a * 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tri = new Triangle[3];
            tri[0] = new Triangle();
            tri[1] = new RavnostorTriangle();
            tri[2] = new PrTriangle();
            foreach (var i in tri)
            {
                i.Show();
                Console.WriteLine($"Площадь: {i.Area()}");
                Console.WriteLine($"Периметр: {i.Perimeter()}");
                Console.WriteLine($"Равнобедренный: {i.isSpecialCaseTriangle}\n");
            }
            Console.ReadKey();
        }
    }
}