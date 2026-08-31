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

        List<Player> players = new();
        Player player = new(100);
        player.Name = "Imran";
        players.Add(player);

        Player player1 = new(80);
        player1.Name = "Enemy";
        players.Add(player1);

        Player player2 = new(500);
        player2.Name = "Boss";
        players.Add(player2);




    }
}
