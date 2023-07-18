// See https://aka.ms/new-console-template for more information
// dotnet new console -o app
// dutnet run
// dotnet build


// LESSON 1

namespace Output
{
    class Program
    {
        static void Main(string[] args)
        {
            // ESCAPE SEQUENCES
            // New Line 
            /* Also the method Write()
             on the Console Object is for 
            in line while the WriteLine() 
            is for a creating a line 
            for each output */

            Console.Write("Hello\nWorld");
            Console.Write("Hello\nDunya");

            // Backspace
            Console.WriteLine("Hello\bDunya");

            // Form Feed
            Console.WriteLine("Name:\fFahm");

            // Carriage Return
            Console.WriteLine("Hello\rDunya");


            // Single and double quote
            Console.WriteLine("\"Hello\" \'Dunya\'");

            // Vertical Tab and Horizontal Tab
            Console.WriteLine("Hello \v You");
            Console.WriteLine("Hello \t You");

            Console.Beep();
            Console.ReadKey();
        }
    }
}
