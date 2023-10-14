public class Mago : Human
{



    public Mago(string name, int str, int intel, int dex, int hp) : base(name, 25, intel, dex, 50)
    {

    }

    // Build Attack method
    public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -= dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"{Name} Helead by {dmg}!");
        return target.Health;
    }

    public int Heal(Human target)
    {
        int curacion = Intelligence * 3;
        target.Health += curacion;
        Console.WriteLine($"{Name} Heal {target.Name} for {curacion}!");
        return target.Health;

    }
}