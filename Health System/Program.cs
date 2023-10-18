using System;
using System.Diagnostics;


public class Program
{
    private static int health = 100;
    private static string healthStatus;
    private static int shield = 100;
    private static int lives = 3;
    private static int xp = 0;
    private static int level = 1;

    static void Main(string[] args)
    {
        UnitTestHealthSystem();
        //UnitTestXPSystem();

        Console.WriteLine("=====================");
        Console.WriteLine("Health System v1.0");
        Console.WriteLine("Nadim Yazbek");
        Console.WriteLine("=====================");

        ResetGame();
        ShowHUD();
        TakeDamage(190);
        ShowHUD();
        TakeDamage(25);
        ShowHUD();
        

        Console.WriteLine();
        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }

    public static void ShowHUD()
    {

        if (health <= 10)
            healthStatus = "Imminent Danger";
        else if (health <= 50)
            healthStatus = "Badly Hurt";
        else if (health <= 75)
            healthStatus = "Hurt";
        else if (health <= 90)
            healthStatus = "Healthy";
        else
            healthStatus = "Perfect Health";

        Console.WriteLine("=====================");
        Console.WriteLine("Stats");
        Console.WriteLine("Health: " + health + "%");
        Console.WriteLine("Shield: " + shield + "%");
        Console.WriteLine("Lives: " + lives);
        Console.WriteLine("Health Status: " + healthStatus);
        Console.WriteLine("XP: " + xp);
        Console.WriteLine("Level: " + level);
        Console.WriteLine("=====================");

    }



    private static void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Debug.WriteLine("Error: Negative damage value");
            return;
        }

        if (shield > 0)
        {
            if (shield > damage)
            {
                shield -= damage;
            }
            else
            {
                damage -= shield;
                shield = 0;
                health -= damage;

                if (health < 0)
                {
                    health = 0;
                    

                    //if (lives > 0)
                    //{
                    //    Revive();
                    //}
                }
            }
        }
        else
        {
            health -= damage;

            if (health < 0)
            {
                health = 0;
                

                //if (lives > 0)
                //{
                //    Revive();
                //}
            }
        }
    }

    private static void Heal(int hp)
    {
        if (hp < 0)
        {
            Debug.WriteLine("Error: Negative healing amount");
            return;
        }

            
        if (health == 100)
        {
            Debug.WriteLine("Warning: Health is already at maximum");
            return;
        }

            
        health += hp;

            
        if (health > 100)
        {
            health = 100;
        }
    }

    private static void RegenerateShield(int amount)
    {
        if (amount < 0)
        {
            Debug.WriteLine("Negative regeneration amount");
            return;
        }

           
        if (shield == 100)
        {
            Debug.WriteLine("Shield is already at maximum");
            return;
        }

            
        shield += amount;

            
        if (shield > 100)
        {
            shield = 100;
        }
    }


    private static void Revive()
    {
        if (lives <= 0)
        {
            Debug.WriteLine("No remaining lives you have lost");
            return;
        }
        else
        {
            health = 100;
            shield = 100;

            lives--;

        }
        

        Console.WriteLine("Player revived! Lives remaining: " + lives);
    }

    private static void ResetGame()
    {
        health = 100;
        shield = 100;
        lives = 3;
        xp = 0;
        level = 1;
    }

    private static void UnitTestHealthSystem()
    {

        Debug.WriteLine("Unit testing Health System started...");

        // TakeDamage()

        // TakeDamage() - only shield
        shield = 100;
        health = 100;
        lives = 3;
        TakeDamage(10);
        Debug.Assert(shield == 90);
        Debug.Assert(health == 100);
        Debug.Assert(lives == 3);

        // TakeDamage() - shield and health
        shield = 10;
        health = 100;
        lives = 3;
        TakeDamage(50);
        Debug.Assert(shield == 0);
        Debug.Assert(health == 60);
        Debug.Assert(lives == 3);

        // TakeDamage() - only health
        shield = 0;
        health = 50;
        lives = 3;
        TakeDamage(10);
        Debug.Assert(shield == 0);
        Debug.Assert(health == 40);
        Debug.Assert(lives == 3);

        // TakeDamage() - health and lives
        shield = 0;
        health = 10;
        lives = 3;
        TakeDamage(25);
        Debug.Assert(shield == 0);
        Debug.Assert(health == 0);
        Debug.Assert(lives == 3);

        // TakeDamage() - shield, health, and lives
        shield = 5;
        health = 100;
        lives = 3;
        TakeDamage(110);
        Debug.Assert(shield == 0);
        Debug.Assert(health == 0);
        Debug.Assert(lives == 3);

        // TakeDamage() - negative input
        shield = 50;
        health = 50;
        lives = 3;
        TakeDamage(-10);
        Debug.Assert(shield == 50);
        Debug.Assert(health == 50);
        Debug.Assert(lives == 3);

        // Heal()

        // Heal() - normal
        shield = 0;
        health = 90;
        lives = 3;
        Heal(5);
        Debug.Assert(shield == 0);
        Debug.Assert(health == 95);
        Debug.Assert(lives == 3);

        // Heal() - already max health
        shield = 90;
        health = 100;
        lives = 3;
        Heal(5);
        Debug.Assert(shield == 90);
        Debug.Assert(health == 100);
        Debug.Assert(lives == 3);

        // Heal() - negative input
        shield = 50;
        health = 50;
        lives = 3;
        Heal(-10);
        Debug.Assert(shield == 50);
        Debug.Assert(health == 50);
        Debug.Assert(lives == 3);

        // RegenerateShield()

        // RegenerateShield() - normal
        shield = 50;
        health = 100;
        lives = 3;
        RegenerateShield(10);
        Debug.Assert(shield == 60);
        Debug.Assert(health == 100);
        Debug.Assert(lives == 3);

        // RegenerateShield() - already max shield
        shield = 100;
        health = 100;
        lives = 3;
        RegenerateShield(10);
        Debug.Assert(shield == 100);
        Debug.Assert(health == 100);
        Debug.Assert(lives == 3);

        // RegenerateShield() - negative input
        shield = 50;
        health = 50;
        lives = 3;
        RegenerateShield(-10);
        Debug.Assert(shield == 50);
        Debug.Assert(health == 50);
        Debug.Assert(lives == 3);

        // Revive()

        // Revive()
        shield = 0;
        health = 0;
        lives = 2;
        Revive();
        Debug.Assert(shield == 100);
        Debug.Assert(health == 100);
        Debug.Assert(lives == 1);

        Debug.WriteLine("Unit testing Health System completed.");
        Console.Clear();
    }

    //private static void UnitTestXPSystem()
    //{
    //    // Implement XP / Level Up System unit tests
    //    // ...
    //}
}