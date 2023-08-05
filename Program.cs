// LESSON 16

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays - are variables that can store multiple values, there have fixed length

            // Method 1
            //  As no length, might cause an error when accesing an element that doesnot exist
            // string[] cars = { "Benz", "Audi", "Lexus" };

            //Method 2
            // As Length, No errors
            // string[] cars = new string[4];

            // cars[0] = "Benz";
            // cars[1] = "Audi";
            // cars[2] = "Lexus";

            // Method 3
            //  As no length, might cause an error when accesing an element that doesnot exist
            // Exception error - Index out of range
            string[] cars = new string[] { "Benz", "Audi", "Lexus" };

            Console.WriteLine(cars[3]);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            Console.ReadKey();
        }
    }

}