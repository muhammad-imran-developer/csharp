using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyApp;

class Program



{

    // delegate void Action();

    static void TakeDamage(int damage)
    {
        if (damage <= 0)
        {
            throw new ArgumentException("Damage must be greater than zero.");
        }

        Console.WriteLine($"Player took {damage} damage.");
    }

    static void Main(string[] args)
    {
        /*
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

                Console.WriteLine($"Total Players: {players.Count}");

                players.Remove(player1);


                foreach (var p in players)
                {

                     if (p.Health > 100)
                     {
                        Console.WriteLine($"Player Name: {p.Name}, Health: {p.Health}");

                     }

                 }

                 Player player = new(100, "Imran");
                player.Name = "Imran";
                player.Health = 100;
                player.Level = 5;
                player.Attack();

                Enemy enemy = new(50, "Zombie");
                enemy.Name = "Zombie";
                enemy.Health = 50;
                enemy.Damage = 20;
                enemy.Attack();  */


        /* =========================================

                        Polymorphism                      

        ========================================= 

        Character character = new Enemy(50, "Zombie");
        character.Attack();

        Character character1 = new Player(100, "Imran");
        character1.Attack();


        List<Character> characters = new();

        characters.Add(new Player(200, "Imran"));
        characters.Add(new Enemy(80, "Zombie"));
        characters.Add(new Player(100, "Ali"));
        characters.Add(new Enemy(50, "Skeleton"));

        foreach (Character character in characters)
        {
         character.Attack();
         } */


        /* =========================================

                       Interfaces                    

       ========================================= 

        Player player = new(100, "Imran");
        player.Attack();
        Enemy enemy = new(50, "Zombie");
        enemy.Attack();

        IAttackable attackable = new Player(100, "Imran");
        attackable.Attack();
        IAttackable attackable2 = new Enemy(80, "Imran");
        attackable2.Attack();

        List<IAttackable> attackables = new();
        attackables.Add(new Player(100, "Imran"));
        attackables.Add(new Enemy(80, "Zombie"));
        attackables.Add(new Player(200, "Ali"));
        attackables.Add(new Enemy(50, "Skeleton"));

        foreach (IAttackable attackable in attackables)
        {
            attackable.Attack();
        } */


        /*
    /* =========================================

                       Generic Class                    

       ========================================= 


                Box<int> box1 = new();
                box1.Value = 100;

                Box<string> box2 = new();
                box2.Value = "Imran";

                Console.WriteLine(box1.Value);
                Console.WriteLine(box2.Value); 
        Player player = new(100, "Imran");
        Box<Player> playerbox = new();
        playerbox.Value = player;
        Console.WriteLine(playerbox.Value);
        playerbox.Value.Attack();
        static void Show<T>(T value)
        {
             Console.WriteLine($"Value: {value}");
         }

         Show(100);
         Show("Imran");
         Show(50.5);

         Player player = new(100, "Imran");

        Show(player);


        static void Show<T>(T value)
         {
             Console.WriteLine($"Value {value}");
         }
         Player player = new(100, "IMRAN");

        Show(100);
        Show("IMRAN");
         Show(player);

        static void AttackCharacter<T>(T character) where T : Character
        {
            character.Attack();
        }

        AttackCharacter(new Player(100, "Imran"));
        AttackCharacter(new Enemy(50, "Zombie"));  */


        // static void Attack()
        // {
        //     Console.WriteLine("Player attacks!");
        // }
        // static void Heal()
        // {
        //     Console.WriteLine("Player heals!");
        // }

        // static void Enemy()
        // {
        //     Console.WriteLine("Enemy Attack!");

        // }



        // Action action = Attack;
        // action();
        // action = Heal;
        // action();
        // action = Enemy;
        // action();
        // static void ExecuteAction(Action action)
        // {
        //     action();
        // }
        // ExecuteAction(Attack);
        // ExecuteAction(Heal);
        // ExecuteAction(Enemy);

        // static void Attack(int damage, string name)
        // {
        //     Console.WriteLine($"{name} deals {damage} damage!");
        // }

        // Action<int, string> action = Attack;
        // action(50, "Imran");

        // static int CalculateDamage(int attack, int bonus)
        // {
        //     return attack + bonus;
        // }

        // Func<int, int, int> calculate = CalculateDamage;
        // int damage = calculate(50, 20);
        // Console.WriteLine(damage);


        // static int CalculateDamage(int damage, int weaponbonus)
        // {
        //     return damage + weaponbonus;
        // }

        // Func<int, int, int> DamageCalculater = CalculateDamage;

        // int damagedone = DamageCalculater(40, 60);
        // Console.WriteLine(damagedone);

        // Func<int, int, int> DamageCalculater = (damage, weaponbonus) => damage + weaponbonus;
        // int damagedone = DamageCalculater(40, 60);

        // Console.WriteLine(damagedone);

        // Func<int, int, int> DamageCalulater = (int damage, int weaponbonus) => damage + weaponbonus;

        // int DamageDone = DamageCalulater(20, 20);
        // Console.WriteLine(DamageDone);

        // List<Player> players = new()
        // {
        //     new Player(100, "Imran"),
        //     new Player(200, "Ali"),
        //     new Player(50, "Enemy"),
        //     new Player(500, "Boss")
        // };

        // var strongPlayers = players.Where(player => player.Health > 100);
        // players.ForEach(p => Console.WriteLine($"{p.Name} : {p.Health}"));

        // var names = players.Select(player => player.Name);
        // foreach (var name in names)
        // {
        //     Console.WriteLine(name);
        // }


        // var SortedPlayers = players.OrderBy(player => player.Health);

        // foreach (var sortedPlayer in SortedPlayers)
        // {
        //     Console.WriteLine($"{sortedPlayer.Name} : {sortedPlayer.Health}");
        // }

        // var strongPlayers = players
        // .Where(player => player.Health > 100)
        // .OrderByDescending(player => player.Health);

        // foreach (var player in strongPlayers)
        // {
        //     Console.WriteLine($"{player.Name} : {player.Health}");
        // }



        // foreach (var player in strongPlayers)
        // {
        //     Console.WriteLine($"{player.Name}: {player.Health}");
        // }


        // var strongPlayers = players.Where(player => player.Health < 100);

        // foreach (var p in strongPlayers)
        // {
        //     Console.WriteLine($"{p.Name}: {p.Health}");

        // }

        // Player? player = players.Find(player => player.Name == "Boss");

        // Console.WriteLine(player?.Name);




        /* =========================================

                       Exception Handling                    

       ========================================= */

        // int health = 100;
        // int damage = 0;

        // int result = health / damage;

        // try
        // {
        //     int health = 100;
        //     int damage = 0;

        //     int result = health / damage;
        // }
        // catch (DivideByZeroException)
        // {
        //     Console.WriteLine("Damage cannot be zero!");

        // }



        try
        {
            TakeDamage(0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}
