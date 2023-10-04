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
            int score = 0;
            int health = 100;
            int lives = 3;
            int pointsgained;
            int healthlost;

            Console.WriteLine("Health System v1.0");


            Console.WriteLine();
            Console.WriteLine("Press any key ");
            Console.ReadKey(true);
            Console.WriteLine();

            Console.WriteLine("Enter a username");
            string username = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("=====================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("=====================");

            Console.ReadKey(true);
            Console.WriteLine();

            pointsgained = 250;
            healthlost = 20;

            score = score + pointsgained;
            health = health - healthlost;

            Console.WriteLine("=====================");

            Console.WriteLine("In Battle the ");
            Console.WriteLine(username + " gained " + pointsgained + " points.");

            Console.WriteLine("In Battle ");
            Console.WriteLine(username + " lost " + healthlost + " health.");

            Console.WriteLine("=====================");

            Console.ReadKey(true);
            Console.WriteLine();

            Console.WriteLine("=====================");
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("=====================");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}


