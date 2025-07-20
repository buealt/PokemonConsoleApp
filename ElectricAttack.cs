// Represents an electric attack that can potentially paralyze the target
public class ElectricAttack : Attack
{
    public int ParalyzeChance { get; set; }

    public ElectricAttack(string name, int dmg, string type, int paralyzeChance)
        : base(name, dmg, type)
    {
        ParalyzeChance = paralyzeChance;
    }

    // Try to paralyze the opponent based on chance
    public void TryParalyze(Pokemon target)
    {
        Random rng = new Random();
        if (rng.Next(100) < ParalyzeChance)
        {
            Console.WriteLine($"{target.Name} is paralyzed by {Name}!");
            // Optionally: set a status effect here
        }
    }
}
