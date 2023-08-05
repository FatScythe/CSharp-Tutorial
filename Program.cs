// LESSON 15

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a rectangle
            Console.WriteLine("How many row(s)? ");

            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many column(s)? ");
            int cols = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What symbol would you like to use ? ");


            string? symbol = Console.ReadLine();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

}