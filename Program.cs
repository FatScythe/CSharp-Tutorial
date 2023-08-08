// LESSON 21

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            // Params Keyword = a method parameter that takes a variable number
            //                  of arguments
            //                  The parameters type must be a single - dimensional array  

            double Total = CheckoutTotal(15.34, 1.00, 6.00, 24.00, 89, 15.50);

            Console.WriteLine("Total amount of cart items: " + "$" + Total);

            Console.ReadKey();
        }

        static double CheckoutTotal(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }

}