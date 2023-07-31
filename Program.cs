// LESSON 8
using System;

namespace RandomNum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generating Random Number
            Random random = new Random();
            // .Next() returns a random integer number btw
            // Btw 0 - >2billion

            // int num = random.Next();

            // Passing 2values in it limit its value

            // Random 3 number from 3 die;
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int die3 = random.Next(1, 7);

            // .NextDouble() returns a random number >= 0,  <1
            double num2 = random.NextDouble();

            Console.WriteLine(die1); ;
            Console.WriteLine(num2 * 100);
            Console.ReadKey();
        }
    }
}