// LESSON 7
using System;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.99;
            double y = 5;

            // double a = Math.Pow(x, 3);
            // double b = Math.Sqrt(x);
            // double c = Math.Abs(x); // How far a number is from zero
            // double d = Math.Round(x, 1); // Round down to 1 d.p
            // double e = Math.Ceiling(x); // Rounds Up
            // double f = Math.Floor(x); // Rounds Down
            double g = Math.Max(x, y); // The highest numeber between 2 digits

            Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}