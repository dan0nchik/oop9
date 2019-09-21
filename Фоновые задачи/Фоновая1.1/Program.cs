using System;

namespace _1Фоновая
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //7
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            double U = 0.0;
            //проверка левой четверти
            if (x <= 0.0)
                if (x >= -1.0)
                    if (y >= 0.0)
                        if (y <= 1.0)
                            // U = Math.Sqrt(Math.Abs(2.0 * y + x));
                            Console.WriteLine("Yes");


                        else

                            //U = x / Math.Pow(y, 2.0);
                            Console.WriteLine("No");
          


            //проверка правой четверти с вырезом
            if (x >= 0.0)
     
                if (x <= 1)
                    if (y >= 0.3)
                        if (y <= 1.0)
                            //U = Math.Sqrt(Math.Abs(2.0 * y + x));
                Console.WriteLine("Yes");
         

            else
            
                // U = x / Math.Pow(y, 2.0);
                Console.WriteLine("No");
            

            Console.WriteLine("{0:G3}", U);

            Console.ReadKey();
=======
             Console.Write("a:");
             int a = int.Parse(Console.ReadLine());
             double a1 = (double)a;
             Console.Write("b:");
             int b = int.Parse(Console.ReadLine());
             double b1 = (double)b;
             Console.Write("c:");
             int c = int.Parse(Console.ReadLine());
             double c1 = (double)c;
            double result = Math.Pow((c + b), 1.0 / 3) + Math.Sin(a / 4) + Math.Sqrt((a + b + 4.0) / 2) + Math.Pow(c, 2);
             Console.WriteLine("{0:F}", result);
             Console.ReadKey(); 
>>>>>>> a8198b8c5626c5740c8e8d2f7799e1bc048ce552
        }
    }
}
