// LESSON 25

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ParkingLot = {
                    { "Tesla", "Honda", "Benz" } ,
                    { "Hyundai", "Ford", "Mitsubishi" },
                    { "Ferrari", "Lexus", "Toyota" }
                };

            // Query : ParkingLot[row, col];
            // Console.WriteLine(ParkingLot[0, 1]); // Honda

            // Reassign 
            ParkingLot[1, 0] = "Bugatti";
            // Console.WriteLine(ParkingLot[1, 0]); // Bugatti

            /* foreach (string car in ParkingLot)
            {
                Console.WriteLine(car);
            } */
            // ParkingLot.GetLength(0); // x-axis or row in 2d
            // ParkingLot.GetLength(1); // y-axis or col in 2d

            for (int i = 0; i < ParkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < ParkingLot.GetLength(1); j++)
                {
                    Console.Write(ParkingLot[i, j] + " | ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }

}