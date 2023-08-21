// LESSON 42

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {

            // enum = special 'class' that contains a set of named integer constant
            //        use enum when you have values that will not change
            //        to get interger value convert to int
            //        to get string value convert to to string


            // To store the name in a variable
            string name = Planets.Earth.ToString();
            int number = (int)Planets.Earth;
            Console.WriteLine("Planet " + name + "is number " + number);

            double Volume = GetVolume(PlanetRadius.Jupiter);
            Console.WriteLine("The volume of jupiter is " + Volume + "km^3");
            Console.ReadKey();
        }

        static double GetVolume(PlanetRadius radius)
        {
            double volume = 4 / 3 * Math.PI * Math.Pow((int)radius, 3);
            return volume;
        }
    }

    enum Planets
    {
        // Withut assigning a value to the names, mercury would automatically be zero
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Saturn = 5,
        Neptune = 6,
        Jupiter = 7,
        Uranus = 8,
        Pluto = 9
    }

    enum PlanetRadius
    {

        Mercury = 2334,
        Venus = 2878,
        Earth = 3671,
        Mars = 5902,
        Saturn = 5232,
        Neptune = 6223,
        Jupiter = 95032,
        Uranus = 8823,
        Pluto = 1232
    }
}
