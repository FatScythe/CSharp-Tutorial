﻿// LESSON 5

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name ?");

            string? name = Console.ReadLine();

            Console.WriteLine("What is your age ?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine($"You are {age} year old");


            Console.ReadKey();
        }
    }
}