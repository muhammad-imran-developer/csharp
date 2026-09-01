using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp;

class Program
{


    static void Main(string[] args)
    {
        Player player = new("Imran", 100, 5);
        Enemy enemy = new("Zombie", 50, 10);

        player.Attack(enemy);
        enemy.Attack(player);

        while (player.CurrentHealth > 0 && enemy.CurrentHealth > 0)
        {
            Console.WriteLine("\n=== Player Turn ===");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                player.Attack(enemy);
            }
            else if (choice == "2")
            {
                player.Heal();
            }
            else
            {
                Console.WriteLine("Invalid option!");
                continue;
            }

            if (enemy.CurrentHealth <= 0)
                break;

            Console.WriteLine("\n=== Enemy Turn ===");
            enemy.Attack(player);
        }


    }
}
