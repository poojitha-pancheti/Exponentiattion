﻿using System;

namespace Exponentiation
{
    class Program
    {
        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1;
            return (x * Power(x, (n - 1)));
        }
        static void Main(string[] args)
        {
            double x;
            int n;
            Console.WriteLine("Enter values for x and n:");
            x = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(x + "^" + n + "=" + Power(x, n));

        }
    }
}
