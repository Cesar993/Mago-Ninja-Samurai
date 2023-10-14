public class Ninja : Human
{
    public Ninja (string name, int str, int intel, int dex, int hp) : base(name, str, intel, 75, hp){

    }

        // Build Attack method
    public override int Attack(Human target)
    {
        Random random = new Random();
        int randomNum = random.Next(1,6);
        int dmgCritic =0;
        if (randomNum == 1)
        {
             dmgCritic =10;
        }
        int dmg = target.Dexterity +dmgCritic;
        target.Health -= dmg;
        
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        
        return target.Health;
    }


        public void Steal(Human target)
    {
        target.Health -= 5;
        Health += 5;
        
        Console.WriteLine($"{Name} Heal 5hp and {target.Name} loose 5 hp!");
        
    }
}