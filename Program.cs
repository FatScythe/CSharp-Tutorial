// LESSON 35

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            //             There are 3 ways to overide a Method - using the overide and virtual keyword (Modifiers)
            //             cat.Speak();
            //             - using the new keyword (Modifiers) this the best the parent class don't need modifiers
            //             dog.Speak();
            //             - or using the abstract keyword
            //             - basically the parent class as to be abstract and the method as will not have a body +
            //             the children method must have the override keyword, Honestly the new keyword is better
            //             But by default it seem the version of .NET i have overrides it by default with a little warning though

            //             NB: the new keyword cannot be used in polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();
        }


    }
    /*abstract*/
    class Animal
    {
        virtual public void Speak()
        {
            Console.WriteLine("The animal *brrr*");
        }
    }

    class Dog : Animal
    {
        new public void Speak()
        {
            Console.WriteLine("The Dog goes *woof woof*");

        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The Cat goes *meow meow*");
        }
    }





}
