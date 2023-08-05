// LESSON 14

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // ForLoop - repeats as code for a finite amount of time
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Happy New Year!!!");

            Console.ReadKey();
        }
    }

}