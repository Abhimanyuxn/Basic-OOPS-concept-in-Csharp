using System;
using System.Collections.Generic;
namespace name
{
    class program
    {
        static void Main(string[]args)
        {
            List<Player> players =new List<Player>(); 
            Player p1 = new Player("chad");
            Player p2 = new Player("kyle");

            players.Add(p1);
            players.Add(p2);

            foreach(Player player in players)
            {
                Console.WriteLine(player.username);
            }


             }
    }
    class Player
    {
        public string username;
        public Player(string username)
        {
            this.username=username;
        }
    }
}
