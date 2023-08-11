// LESSON 28

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructors = A special method in a class
            //          same name as the class name
            //          Can be used to assign arguments to field when creating an object

            Car car1 = new Car("Tesla", 2020, "X");
            Car car2 = new Car("Bugatti", 2021, "Veyron");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }

    class Car
    {
        string? name;
        int year;
        string model;

        public Car(string name, int year, string model)
        {
            this.name = name;
            this.year = year;
            this.model = model;
        }

        public void Drive()
        {
            Console.WriteLine($"{name}, made in the year {year}, of the model {model} is currently driving");
        }
    }


}
