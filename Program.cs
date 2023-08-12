// LESSON 30

namespace OverlodedConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors - Technique to create multiple constructors,
            //                            with different set of parameters.   
            //                            name + parameters = signature

            Breakfast food1 = new Breakfast("Agege", "Ewagoyin", "Tea", "Orange");
            Breakfast food2 = new Breakfast("Sliced", "FriedEgg", "Chocolate Milk");
            Breakfast food3 = new Breakfast("Whole", "Stew");
            Breakfast food4 = new Breakfast("Flat");

            food1.RecipeList();

            food2.RecipeList();

            food3.RecipeList();

            food4.RecipeList();

            Console.ReadKey();
        }
    }

    class Breakfast
    {
        string bread;
        string topping;
        string beverage;
        string fruit;

        public Breakfast(string bread)
        {
            this.bread = bread;
        }

        public Breakfast(string bread, string topping)
        {
            this.bread = bread;
            this.topping = topping;

        }

        public Breakfast(string bread, string topping, string beverage)
        {
            this.bread = bread;
            this.topping = topping;
            this.beverage = beverage;
        }

        public Breakfast(string bread, string topping, string beverage, string fruit)
        {
            this.bread = bread;
            this.topping = topping;
            this.beverage = beverage;
            this.fruit = fruit;
        }

        public void RecipeList()
        {
            if (bread != null) Console.WriteLine($"- {bread} bread");
            if (topping != null) Console.WriteLine($"- Topping: {topping}");
            if (beverage != null) Console.WriteLine($"- Beverage: {beverage} ");
            if (fruit != null) Console.WriteLine($"- Fruit - {fruit}");
            Console.WriteLine();
        }
    }
}
