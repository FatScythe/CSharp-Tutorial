// LESSON 11

namespace Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch Statement is an efficient alternative to ifelse statement
            Console.WriteLine("What day of the week is it today?");
            String? day = Console.ReadLine()?.ToLower();

            switch (day)
            {
                case "sunday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "monday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "tuesday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "wednesday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "thursday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "friday":
                    Console.WriteLine("Today is " + day);
                    break;
                case "saturday":
                    Console.WriteLine("Today is " + day);
                    break;

                default:
                    Console.WriteLine(day + " is not a day of the week");
                    break;
            }
            Console.ReadKey();
        }
    }
}