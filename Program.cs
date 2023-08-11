// LESSON 26

namespace Classes
{
    //     // Classes - are a bunch of related codes
    //     // Can be used as a blueprint for OOP
    class Program
    {
        static void Main(string[] args)
        {


            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }

    // class Messages
    // {
    //     // The static keyword ties the method to the class without it, 
    //     // one would need to create an object to access them

    //     static void Main(string[] args)
    //     {


    //         Messages.Hello();
    //         Messages.Waiting();
    //         Messages.Bye();

    //         Console.ReadKey();
    //     }

    //     static void Hello()
    //     {
    //         Console.WriteLine("Hello, How are you ?");
    //     }


    //     static void Waiting()
    //     {
    //         Console.WriteLine("I am waiting for something...");
    //     }


    //     static void Bye()
    //     {
    //         Console.WriteLine("Good Bye, Thank You For Visiting!");
    //     }
    // }

}
