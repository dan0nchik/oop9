using System;
class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()), l = int.Parse(Console.ReadLine()), N = int.Parse(Console.ReadLine());
        
        if (a <= 0 || b <= 0 || l <= 0 || N <= 0) Console.WriteLine("Number < 0");
        int s = a + a * 2 * (N - 1) + b * (N - 1) * 2 + l * 2;
        Console.WriteLine(s);
    }
}

