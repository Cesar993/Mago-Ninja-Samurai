public class Samurai : Human
{
    public Samurai(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, 200)
    {

    }

    public override int Attack(Human target)
    {

        if (target.Health <= 50)
        {
            Console.WriteLine($"{Name} attacked {target.Name} for {target.Health} damage! You are dead");
            target.Health = 0;
        }
        else
        {
            Console.WriteLine($"{Name} attacked {target.Name} but fail!");
        }
        return target.Health;
    }

    public int Meditate()
    {
        int newHealth = 200 - Health;
        Health = Health + newHealth;
        Console.WriteLine($"{Name} healed {newHealth}");
        return Health;
    }
}