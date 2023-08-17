// LESSON 39

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that rep. a list of objects that can be accesed by index.
            //        similar to an array, but can dynamically increase or decrease in size

            List<int> list = new List<int>();
            List<string> foods = new List<string>();

            // To add to the list
            foods.Add("Bread");
            foods.Add("Rice");
            foods.Add("Amala");
            foods.Add("Beans");
            foods.Add("Spaghetti");
            foods.Add("Bread");

            foods[2] = "Semo";
            Console.WriteLine(foods[2]);
            foods.Contains("Bread"); // Returns Boolean
            foods.LastIndexOf("Bread"); //  Get last index of item
            // foods.Clear(); // Clears the List
            foods.Count(); // Gets the length of the list
            foods.Remove("Beans"); //  Removes element from the list
            string[] items = foods.ToArray(); // Converts list to array
            // Console.WriteLine(items.GetType());

            foreach (string food in foods)
            {
                // Console.WriteLine(food);
            }
            Console.ReadKey();

        }

    }

}
