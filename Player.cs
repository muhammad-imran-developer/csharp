/* class Player
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
     {         Console.WriteLine($"{Name} took {damage}.");

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

 } */


//==============================
//   INHERITANCE
//==============================
class Character
{

    public string Name;
    public int Health;
    public Character(int health, string name)
    {
        Name = name;
        Health = health;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name} is attacking!");
    }


}

interface IAttackable
{
    void Attack();
}


class Player : Character, IAttackable
{
    public Player(int health, string name) : base(health, name)
    {
        // Console.WriteLine(Name);
        // Console.WriteLine(Health);
    }

    // public void Attack()
    // {
    //     Console.WriteLine($"{Name} attacks With sword!");
    // }

    // public int Level;

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks With sword!");
    }



}

class Enemy : Character, IAttackable
{

    public Enemy(int health, string name) : base(health, name)
    {
        // Console.WriteLine(Name);
        // Console.WriteLine(Health);
    }

    // public void Attack()
    // {
    //     Console.WriteLine($"{Name} attacks With claws!");
    // }
    // public int Damage;

    public override void Attack()
    {
        Console.WriteLine($"{Name} attacks with claws!");
    }



}



// class Box<T>
// {
//     public T? Value;
// };

