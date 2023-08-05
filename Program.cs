// LESSON 13

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop - repeats a code while a condition remains true

            string? name = "";

            while (name == "")
            {
                Console.WriteLine("What is your name ?");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hi " + name);

            Console.ReadKey();
        }
    }
}