// LESSON 19

namespace Return
{
    class Program
    {
        static void Main(string[] args)
        {
            // Return Keyword - returns data back to where a method is invoked
            double x;
            double y;
            double result;

            Console.WriteLine("----------------");
            Console.WriteLine("Program to show case the Return keyword");
            Console.WriteLine("----------------");

            Console.Write("Enter first Number:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second Number:");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);

            Console.WriteLine($"Result = {result}");

            Console.ReadKey();
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }

}