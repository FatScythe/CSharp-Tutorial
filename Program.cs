// LESSON 4

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // TypeCasting - When converting a data type 
            // to another data type
            // Useful - When receiving input 
            // or when you need to use a different data type
            double a = 123 + 0.223;
            int b = Convert.ToInt32(a);


            String c = "$";
            char d = Convert.ToChar(c);

            String e = "true"; // string --> Boolean "true" === True, "false" === False
            bool f = Convert.ToBoolean(e);

            int g = 0; // int --> Boolean 0 === false, >0 =true
            bool h = Convert.ToBoolean(g);
            Console.WriteLine(h);

            // Console.WriteLine(b.GetType());
            // Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType());
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}