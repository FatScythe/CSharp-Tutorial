// LESSON 24

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Interpolation - offer a means to write string with variable
            // It works by preceding a string with '$' 
            // and when inputting a variable, place it in a `{}`- curly-bracket as opposed to the usual adding

            string firstName = "Scythe";
            string lastName = "Death";
            int age = 23;

            // The curly braces can accept a second value(number), 
            // it specifies the amount of space before(+ve) and after(-ve) the variable

            Console.WriteLine($"Your full name is {lastName} {firstName}");
            Console.WriteLine($"You are{age,3} years old");


            Console.ReadKey();
        }
    }

}