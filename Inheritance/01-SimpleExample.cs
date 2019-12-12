using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace sandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer player1 = new AdvancedPlayer();

            IPlayer player2 = new Admin(); // Age, Name, Password
            Admin player3 = new Admin(); // Age, Name, Password, Insert
            Player player4 = new Player(); // Age, Name, Password

            //player4 = (Admin)player3; // InvalidCastException

            Console.WriteLine(player1.GetType().Name); // AdvancedPlayer
            Console.WriteLine(player2.GetType().Name); // Admin


        }
    }

    public interface IPlayer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Password { get; set; }
    }

    public class Player : IPlayer
    {
        public Player()
            :base()
        {
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
    }

    public class AdvancedPlayer : Player
    {
        public string Item { get; set; }
        public AdvancedPlayer()
            :base()
        {
        }
    }

    public class Admin : Player
    {
        public Admin()
            :base()
        {
        }

        public void Insert()
        {

        }
    }
}
