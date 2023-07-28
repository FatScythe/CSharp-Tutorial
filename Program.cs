namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            int x; // Initialization 
            x = 123; // Declaration

            int y = 321; // Initialization + Declaration

            int z = x + y;

            // float height = 200.59; // Float is used for less precise decimals 
            double height = 200.59; // Float is used for precise decimals 
                                    // decimal height = 200.59; // Float is used for more precise decimals 

            string name = "Fahm"; // Stores Strings
            char symbol = '@'; // Stores Character
            bool isAlive = true; // Stores true or false
            string userName = symbol + name;


            Console.WriteLine(z);
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + isAlive);
            Console.WriteLine("Your username is: " + userName);


            Console.ReadKey();
        }
    }
}