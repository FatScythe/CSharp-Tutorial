// LESSON 17

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop- It is a simpler way to iterate over an array, but it's is less flexible

            string[] cars = new string[4] { "Benz", "Lexus", "Bugatti", "Ferari" };

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }

}