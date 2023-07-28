// LESSON 3

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            /* To make a variable constant through out
            it's lifecycle add the 'const' keyword b4
            the declaration of a variable */

            const double pi = 3.1423;
            // Now reassigning it would no longer work
            // pi = 22;


            Console.WriteLine(pi);
            Console.ReadKey();
        }
    }
}