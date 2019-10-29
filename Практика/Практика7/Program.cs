﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика7
{
    class Program
    {      static void BezznDate()
        {
            byte a = 18, b = 10;
            byte b1 = (byte)~b, a1 = (byte)~a;
            Console.WriteLine($"  {a}\n  {b}\n &__\n   {a & b} \n");
            Console.WriteLine($"  {a}\t\n  {b}\t\n |__\t\n  {a | b} \t\n");
            Console.WriteLine($"  {a}\n  {b}\n ^__\n  {a ^ b} \n");
            Console.WriteLine($"  {a}\n ~__\n {~a1} \n");
            Console.WriteLine($"  {b}\n ~__\n {~b1} \n");
            Console.WriteLine($"  a<<1 = {a<<1}");
            Console.WriteLine($"  b>>2 = {b>>2}");
}

        static short ZnachenieBita(short X, short N)
        {
            short mask = (byte)(1 << N); 
            if ((mask & 1) == 0) return 1;
            else return 0;
        }
        static void Binary(byte N)
        {
            byte mask = (byte)(1 << N);
            for (byte i = 0; i < 8; i++)
            {
                if ((mask & 1) == 0) Console.Write(1);
                else Console.Write(0);
            }

        }
        static void Main(string[] args)
        {
            //short X = short.Parse(Console.ReadLine()), N = short.Parse(Console.ReadLine());
            byte N = byte.Parse(Console.ReadLine());
            Binary(N);
            Console.ReadKey();
                
        }
    }
}
