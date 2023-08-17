// LESSON 37

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism = Have many forms
            //              - Object can be identified by more than one type
            //                 E.g - A car, a boat and a bicycle are ALL VEHICLES

            Car car = new Car();
            Boat boat = new Boat();
            Bicycle bike = new Bicycle();

            Vehicle[] vehicles = { car, boat, bike };
            // We can put them in array of Vehicle data types because they are children of vehicles

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }


            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {

        }

    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car has started moving");
        }
    }

    class Boat : Vehicle
    {

        public override void Go()
        {
            Console.WriteLine("The boat has started moving");
        }
    }

    class Bicycle : Vehicle
    {

        public override void Go()
        {
            Console.WriteLine("The bicycle has started moving");
        }
    }
}
