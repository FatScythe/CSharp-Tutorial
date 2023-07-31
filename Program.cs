// LESSON 9

namespace StringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Methods
            String fullName = "Bro Fahm";
            // String phoneNumber = "+234-703-657-3306";

            // UPPERCASE
            // Console.WriteLine(fullName.ToUpper());
            // // lowercase
            // Console.WriteLine(fullName.ToLower());

            // // Replace
            // phoneNumber = phoneNumber.Replace("-", "");
            // Console.WriteLine(phoneNumber);

            //Insert
            String userName = fullName.Insert(0, "@");
            Console.WriteLine(userName);

            // Length, this is not a method but a property
            Console.WriteLine(fullName.Length);

            // SubString (start, length)
            String firstName = fullName.Substring(4, 4);
            String lastName = fullName.Substring(0, 3);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            Console.ReadKey();
        }
    }
}