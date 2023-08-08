// LESSON 22

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exception - erro that occur during execution

            // try - try some code that is considered dangerous
            // catch - catches and handles exception when they occur
            // finally - always executes regardless if exception occurs or not

            int x;
            int y;
            int result;

            try
            {
                Console.WriteLine("Enter a first Number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a 2nd Number: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("The result is:" + result);

            }
            catch (FormatException)
            {
                Console.WriteLine("Only Numbers PLEASE!!!");
            }
            catch (DivideByZeroException)
            {
                // This exception only works with integer values
                Console.WriteLine("You cannot divide by ZERO!");
            }
            catch (System.Exception)
            {
                // Should not be used, except only after defining other 
                // anticipated exceptions
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Written by Scythe");
            }


            Console.ReadKey();
        }
    }

}