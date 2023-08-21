// LESSON 43

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics = "not specific to a particular data type"
            //             add <T> to classes method and field;
            //             allows for code reusability for different data types

            // With methods
            string[] StringValues = new string[4] { "1", "2", "3", "4" };
            int[] IntergerValues = new int[] { 1, 2, 3, 4 };
            double[] DoubleValues = { 1.2, 2.3, 3.4, 4.5, 5.6, 7.5 };

            // ListValues(StringValues);
            // ListValues(IntergerValues);
            // ListValues(DoubleValues);

            // With classes
            Cart<Product> cart = new Cart<Product>();

            cart.addToCart(new Product("Product 1"), new Product("Bag"), new Product("Gele"));

            foreach (Product item in Cart<Product>.CartItems)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }

        // WIth methods
        static void ListValues<T>(T[] values)
        {
            foreach (T item in values)
            {
                Console.WriteLine(item);
            }
        }

        static void Something<T, U>()
        {
            // Generics can be more than one
        }


    }

    // With Classes

    class Cart<T>
    {
        public static List<T> CartItems = new List<T>();

        public void addToCart(params T[] products)
        {
            foreach (T item in products)
            {
                CartItems.Add(item);
            }

        }
    }

    class Product
    {
        string name;
        public Product(string productname)
        {
            Name = productname;
        }

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                name = value;
            }
        }

        public override string ToString()
        {
            return $"Product name: {name}";
        }
    }


}
