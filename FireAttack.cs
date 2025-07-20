// Represents a fire-type attack with a chance to burn the opponent
public class FireAttack : Attack
{
    // Probability (in percentage) to inflict a burn status effect
    public int BurnChance { get; set; }

    // Constructor initializes the FireAttack with name, damage, and optional burn chance
    public FireAttack(string name, int dmg, int burnChance = 0)
        : base(name, dmg, "Fire") // Sets the type to "Fire"
    {
        BurnChance = burnChance;
    }

    // Attempts to apply burn status effect to the target based on BurnChance
    public void TryBurn(Pokemon target)
    {
        Random rng = new Random();
        if (rng.Next(100) < BurnChance)
        {
            Console.WriteLine($"{target.Name} is burned by {Name}!");
            // Optionally, here you could set a burned status on the target
        }
    }
}