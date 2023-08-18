// LESSON 41

/* 
git add . 
git commit -m "Getters and Setters" 
git push --set-upstream origin 41-Getters-Setters
*/
namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car("Tesla", 250);

            // GettersSetters = at times you might want to prevent access to certain data
            // e.g in this case I dont want the speed to be above 500
            // I could use the 'Private' keyword to prevent this but i would no longer have access to the data
            // Getter & Setter adds security to fields by encapsulation
            // It also combine the aspect of fields and methods
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value gotten from the constructor

            // I should not be able to this
            // car.speed = 100000000;
            // I could make the the variable private 
            // But if i need to change it i would have no way to
            // Without creating a new instance of the class
            car.Speed = 200000000;
            // WIth Setter i can now set condition to prevent this
            // Should i need to read what speed is, as it is private
            // I can access the getters Speed
            Console.WriteLine(car.Speed);
            // Console.WriteLine(car);

            Console.ReadKey();
        }
    }

    class Car
    {
        private string name;
        private int speed;

        public Car(string name, int speed)
        {
            this.name = name;
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; } // reed
            set
            {
                if (value > 500)
                {
                    speed = 200;
                }
                else
                {
                    speed = value;
                }
            } // write
        }

        public override string ToString()
        {
            return $"This ia a {name}, with a speed of {speed}";
        }

    }
}
