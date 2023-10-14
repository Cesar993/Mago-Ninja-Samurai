


Human humano1 = new Human("Cachupin", 1,1,1,40);



Mago mago1 = new Mago("cachulo",1,2,0,0);
Ninja ninja1 = new Ninja("cachuloNinja",1,2,1,100);
Samurai samurai1 = new Samurai("samsam",1,2,1,100);


mago1.Attack(humano1);

Console.WriteLine("-------------------------");
Console.WriteLine(mago1.Attack(humano1));
Console.WriteLine(mago1.Health);

Console.WriteLine("-------------------------");
Console.WriteLine(ninja1.Dexterity);
Console.WriteLine(ninja1.Attack(humano1));
ninja1.Steal(mago1);
Console.WriteLine("-------------------------");
Console.WriteLine(samurai1.Health);
Console.WriteLine(samurai1.Attack(humano1));

Console.WriteLine("-------------------------");
Console.WriteLine(ninja1.Attack(samurai1));
Console.WriteLine(samurai1.Meditate());
