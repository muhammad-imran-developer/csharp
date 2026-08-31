class Player
{
    public string? Name { get; set; }

    public int Health { get; private set; }

    public int Level { get; set; }

    public Player(int health)
    {
        Health = health;
    }

    public void Attack()
    {
        Console.WriteLine($"{Name} is attacking!");
    }

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{Name} took {damage}.");

        Health -= damage;

        if (Health <= 0)
        {
            Health = 0;
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"{Name} died!");
        }
        else
        {
            Console.WriteLine($"Health: {Health}");
        }
    }
}