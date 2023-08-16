// LESSON 36

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString method = return a string representation of an object
            Car car = new Car("Tesla", "Model X", 2020);

            // To see the representation in string format: 
            Console.WriteLine(car.ToString());

            // OR

            Console.WriteLine(car);

            Console.ReadKey();
        }


    }
    class Car
    {
        string name;
        string model;

        int year;

        public Car(string name, string model, int year)
        {
            this.name = name;
            this.model = model;
            this.year = year;
        }
        public override string ToString()
        {
            return "This is a " + name + " car, model: " + model + " , production-year: " + year;
        }
    }
}
