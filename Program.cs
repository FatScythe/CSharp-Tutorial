// LESSON 18

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // method - performs a section of code whenever it's called "invoked",
            //          benefits - Reuse codes without rewriting it
            string name = "Scythe";
            int age = 99;

            SingHappyBirthday(name, age);
            SingHappyBirthday(name, age);
            SingHappyBirthday(name, age);
            Console.ReadKey();
        }
        static void SingHappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine("Happy Birthday to you");
            Console.WriteLine("Happy Birthday dear " + name);

            Console.WriteLine("Happy Birthday");
            Console.WriteLine("Happy Birthday");

            Console.WriteLine("Happy Birthday to you");

            Console.WriteLine("How old are you now?");
            Console.WriteLine("How old are you now?");

            Console.WriteLine("How old are you?, Dear " + name);
            Console.WriteLine("I am " + age + " years old");

            Console.WriteLine("");
            Console.WriteLine("");

        }
    }

}