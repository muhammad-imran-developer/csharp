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
        Player player = new(100);

        player.Name = "Imran";
        player.Level = 5;

        Console.WriteLine($"Name: {player.Name}");
        Console.WriteLine($"Health: {player.Health}");
        Console.WriteLine($"Level: {player.Level}");

        player.Attack();

        player.TakeDamage(30);
        player.TakeDamage(80);

    }
}
