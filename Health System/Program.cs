using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Health System v1.1");

            Player player = new Player();
            string username = player.GetUsername();

            player.HUD(username);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

    internal class Player
    {
        int health = 100;
        string healthStatus;
        int shield = 100;
        int lives = 3;
        int xp = 0;
        int level = 1;

        public string GetUsername()
        {
            Console.WriteLine("Enter a username");
            string username = Console.ReadLine();
            Console.WriteLine();
            return username;
        }

        public void HUD(string username)
        {
            Console.WriteLine("=====================");
            Console.WriteLine(username + " Stats");
            Console.WriteLine("Health: " + health + "%");
            Console.WriteLine("Health Status: " + GetHealthStatus());
            Console.WriteLine("Shield: " + shield + "%");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("XP: " + xp);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("=====================");
        }

        private string GetHealthStatus()
        {
            if (health <= 10)
                return "Imminent Danger";
            else if (health <= 50)
                return "Badly Hurt";
            else if (health <= 75)
                return "Hurt";
            else if (health <= 90)
                return "Healthy";
            else
                return "Perfect Health";
        }
    }
}