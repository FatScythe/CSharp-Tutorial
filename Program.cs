// LESSON 32

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract CLasses- Usually precedes the class Keyword makes sure 
            //                   Such instances of that class cannot be created
            //                   It is a modifier that indicates missing components or incomplete implememntation

            Car car = new Car();
            Boat boat = new Boat();
            Bicycle bicycle = new Bicycle();
            // By preceeding the vehicle class with abstract
            // Now i can no longer create an instance of the class

            // Vehicle vehicle = new Vehicle(); // Err type abstract or interface


            Console.ReadKey();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void start()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
        public int maxSpeed = 40;
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        public int maxSpeed = 40;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
        public int maxSpeed = 40;
    }

}
