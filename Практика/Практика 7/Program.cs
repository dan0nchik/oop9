using System;

namespace Практика_4
{
    internal class Program
    {
        static double Min(double x, double y, double z)
        {
            double min;
            min = x;
            if (y < min)
            {
                min = y;
            }
            else
            {
                if (min > z)
                    min = z;
            }
            return min;
        }

        static double Max(double x, double y)
        {
            double max;
            max = x;
            if (max < y)
                max = y;
            else
            {
                max = x;
            }
            return max;
        }

        private static void Main(string[] args)
        { 

            double a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());

            //Max(a, b);
            double resultFromMin = Min(a, b + 1.0, Math.Abs(a) + 1.0);
            double result = Max(Math.Sqrt(resultFromMin), Max(a, b + Min(a, b, 0.0))) - Min(Math.Sqrt(a+1.0), (b+5.0)/(2.0+a*a),a+b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}