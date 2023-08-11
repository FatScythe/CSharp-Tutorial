// LESSON 27

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object = An instance of a class
            //          A class can be used as a blueprint for creating OOP
            //          Objects can have field and methods i.e characteristics and actions


            Human human1 = new Human();
            human1.name = "Furqan";
            human1.age = 17;

            human1.Eating();
            human1.sleeping();

            Human human2 = new Human();
            human2.name = "Fahm";
            human2.age = 23;


            human2.Eating();
            human2.sleeping();

            Console.ReadKey();
        }
    }

    class Human
    {
        // Fields
        public string? name;
        public int age;

        // Actions or methods
        public void Eating()
        {
            Console.WriteLine(name + " is eating.");
        }

        public void sleeping()
        {
            Console.WriteLine($"{name}, {age} year old is sleeping.");
        }
    }

}
