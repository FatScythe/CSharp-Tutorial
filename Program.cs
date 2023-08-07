// LESSON 20

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method Overloading = methods can have the same name 
            //                      but only differs with their parameters
            //                      name + parameters = signature
            //                      methods with same name must have a unique signature 
            double total;

            // total = Multiply(2,3);
            total = Multiply(2, 3, 5);

            Console.ReadKey();
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Multiply(double x, double y, double z)
        {
            return x * y * z;
        }
    }

}