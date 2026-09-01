class Character
{
    protected string Name;
    protected int Health;

    public int CurrentHealth => Health;

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} attacks!");
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Health = 0;
            Console.WriteLine($"{Name} has died!");
        }
        else
        {
            Console.WriteLine($"{Name} Health: {Health}");
        }
    }
}

class Player : Character
{
    public int Level;

    public Player(string name, int health, int level)
        : base(name, health)
    {
        Level = level;
    }

    public void Attack(Character target)
    {
        int damage = 20;

        Console.WriteLine($"{Name} attacks with sword!");
        target.TakeDamage(damage);
    }

    public void Heal()
    {
        Health += 20;

        Console.WriteLine($"{Name} healed for 20.");
        Console.WriteLine($"{Name} Health: {Health}");
    }
}

class Enemy : Character
{
    public int Damage;

    public Enemy(string name, int health, int damage)
        : base(name, health)
    {
        Damage = damage;
    }

    public void Attack(Character target)
    {
        Console.WriteLine($"{Name} attacks with claws!");
        target.TakeDamage(Damage);
    }
}