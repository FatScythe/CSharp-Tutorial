// LESSON 42

namespace AutoGetters_Setters
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Mercedes", 299303972);

            Console.WriteLine(car.Model);
            Console.WriteLine(car.Speed);
            Console.ReadKey();
        }
    }

    class Car
    {
        private int speed;
        // This a shorter way of writing getters and setters when there are no additional function/ conditions
        // it removes the need for defining a field
        public string Model { get; set; }

        public Car(string model, int speed)
        {
            // this.Speed = speed;
            // this.Model = model;
            // OR Since the getter and setters are hoisted to the top
            Speed = speed;
            Model = model;
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}
