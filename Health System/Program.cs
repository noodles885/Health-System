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
            
            int health = 100;
            int healthstaus;
            int shield = 100;
            int lives = 3;
            

            Console.WriteLine("Health System v1.1");


            Console.WriteLine("Enter a username");
            string username = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("=====================");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("=====================");

            Console.ReadKey(true);
            Console.WriteLine();
            
            
            Takedamage(-50);
            

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        public static int Takedamage(int damage)
        {

            return damage;
        }
        
    }

}


