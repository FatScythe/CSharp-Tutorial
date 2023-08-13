// LESSON 31

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance - 1 or more child classes receiving fields, methods wtc from a common parent

            Car car = new Car();
            Boat boat = new Boat();
            Bicycle bicycle = new Bicycle();

            // now all this instances of the child classes have access to the fields and methos of the vehicle class

            Console.WriteLine(car.speed);
            boat.start();
            // While also having access to their own methods and fields
            Console.WriteLine(bicycle.wheels);
            Console.WriteLine(bicycle.speed);
            bicycle.start();

            Console.ReadKey();
        }
    }

    class Vehicle
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
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }

}
