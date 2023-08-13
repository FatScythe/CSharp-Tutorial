// LESSON 33

namespace ArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array_of_Objects - 

            Car car1 = new Car("Bugatti", 380);
            Car car2 = new Car("Ferrari", 350);
            Car car3 = new Car("Audi", 300);
            Car car4 = new Car("Toyota", 250);

            // Car[] cars = new Car[] { car2, car3, car4 };
            // OR
            Car[] cars = { new Car("Bugatti", 380), new Car("Ferrari", 350), new Car("Audi", 300), new Car("Toyota", 250) }; // Anonymous objects
            // cars[3].Go();
            // cars[1].Go();

            cars[2] = car1;

            foreach (Car car in cars)
            {
                car.Go();
                car.Stop();
            }


            Console.ReadKey();
        }
    }

    class Car
    {
        string name;
        public int minSpeed = 0;
        public int maxSpeed;

        public Car(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }
        public void Go()
        {
            Console.WriteLine("The " + name + " is moving! at the speed of " + maxSpeed + "m/s");
        }

        public void Stop()
        {
            Console.WriteLine("The " + name + " is moving! at the speed of " + minSpeed + "m/s");
        }
    }

}
