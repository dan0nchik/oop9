using System;

namespace Binary_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            string s = "";
            while(x != 0)
            {
                if (x % 2 == 0) 
                    s += "0";
                    x /= 2;
                    Console.WriteLine(s);

                if (x % 2 != 0)
                s += "1";
                x -= 1;
                x /= 2;
                Console.WriteLine(s);
           
            }
            s += "1";
            char[] k = s.ToCharArray();
            Array.Reverse(k);
            Console.WriteLine("");
            Console.WriteLine(k);


            //tests
            int a = 345, b = 2;
            int c = a / b;
            Console.WriteLine(a%b == 0 ? true : false);
            Console.ReadKey();
        }

    }
}
