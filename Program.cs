// LESSON 38

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface = defines a contract that all classes inheriting from should follow
            //             It declares what a class should have
            //             Inheriting class defines how it should do it
            //             Benefits = security + multiple inheritance + "Plug and Play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            // Implemented Prey 
            rabbit.flee("Wolves");
            // Implemented Predator
            hawk.Hunt("chicks");
            // Implemented Prey and Predator
            fish.flee("Shark");
            fish.Hunt("Tilapia");

        }

    }

    interface IPrey
    {
        void flee(string predator);
    }

    interface IPredator
    {
        string Hunt(string prey);
    }

    class Rabbit : IPrey
    {
        public void flee(string predator)
        {
            Console.WriteLine("The Rabbit flee from the" + predator);
        }
    }

    class Hawk : IPredator
    {
        public string Hunt(string prey)
        {
            Console.WriteLine("The Hawk hunts the " + prey);

            return prey;
        }
    }

    class Fish : IPrey, IPredator
    {
        public void flee(string predator)
        {
            Console.WriteLine("The Fish flee from the " + predator);
        }
        public string Hunt(string prey)
        {
            Console.WriteLine("The Shark hunts the " + prey);

            return prey;
        }
    }

}
