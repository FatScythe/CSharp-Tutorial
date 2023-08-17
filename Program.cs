// LESSON 40

namespace ListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that rep. a list of objects that can be accesed by index.
            //        similar to an array, but can dynamically increase or decrease in size

            List<Player> players = new List<Player>();

            Player player1 = new Player("Korede");
            Player player2 = new Player("Gbenga");
            Player player3 = new Player("Okiki");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(new Player("Ola"));// or you can add them as anonymous object

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
            Console.ReadKey();

        }

    }

    class Player
    {
        public string username;
        public Player(string username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }

}
