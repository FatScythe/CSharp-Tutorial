// LESSON 10

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("You are too old for this site!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You can Sign up");
            }
            else
            {
                Console.WriteLine("You can not Sign up!");
            }

            Console.WriteLine("Please enter your name:");
            String? name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("Welcome " + name + ",");

            }
            else
            {
                Console.WriteLine("Please provide a name");
            }

            Console.ReadKey();
        }
    }
}