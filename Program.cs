// LESSON 29

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static - modifier to declare a static member, which belongs to the class itself
            //          rather than a specific object 

            Car car1 = new Car("Bugatti");
            Car car2 = new Car("Ferrari");
            Car car3 = new Car("Mercedes");

            Car.GetReady();

            Car.Go();

            Car.Finish();



            Console.ReadKey();
        }
    }

    class Car
    {
        string? model;
        static int numberOfCars;

        static List<string> cars = new List<string>();

        public Car(string model)
        {
            this.model = model;
            cars.Add(model);
            numberOfCars++;
        }
        public static void GetReady()
        {
            Console.WriteLine("The race is about to begin, there are " + numberOfCars + " cars currently on the track, the cars are:");

            for (int i = 0; i < cars?.Count(); i++)
            {
                Console.WriteLine(i + 1 + ") " + cars?[i]);
            }

            Console.WriteLine();
        }

        public static void Go()
        {
            Console.WriteLine("3");
            Console.WriteLine("2");
            Console.WriteLine("1");
            Console.WriteLine("Go Go Go!!!");
            Console.WriteLine("Racing....");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void Finish()
        {

            Random random = new Random();
            int winner = random.Next(0, cars.Count());
            Console.WriteLine("The winner is " + cars[winner]);
        }

    }

}
