// LESSON 22

namespace Conditionaloperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // A shorter way to write an if/else statement
            // (condition) ? x : y;

            double temp = 25;
            string messsage;

            messsage = temp > 25 ? "It's warm outside" : "It's cold outside";

            Console.WriteLine(messsage);

            Console.ReadKey();
        }
    }

}