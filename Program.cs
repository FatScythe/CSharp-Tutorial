// LESSON 35

namespace ObjectasArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Bugatti", "Blue");

            Car car2 = CopyCar(car1);

            ChangeCarColor(car1, "red");

            Console.WriteLine(car1.model);
            Console.WriteLine(car2.color);
            Console.WriteLine(car1.color);


            Console.ReadKey();
        }

        static void ChangeCarColor(Car car, string color)
        {
            car.color = color;
        }

        static Car CopyCar(Car car)
        {
            return new Car(car.model, car.color);
        }
    }

    class Car
    {
        public string? model;
        public string? color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }





}
