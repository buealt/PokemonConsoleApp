// Represents a Pokémon of the Fire type, inheriting from the base Pokemon class
public class FirePokemon : Pokemon
{
    // List of specialized fire-type attacks
    public List<FireAttack> FireAttacks { get; set; }

    // Constructor initializes the FirePokemon with Fire type and given attacks
    public FirePokemon(int id, string name, string description, int level, int hp, List<FireAttack> fireAttacks)
        : base(id, name, description, "Fire", level, hp, new List<Attack>(fireAttacks)) // Pass fire attacks as generic Attack list
    {
        FireAttacks = fireAttacks ?? new List<FireAttack>();
    }

    // Executes a fire attack on the opponent by index in the FireAttacks list
    public void UseFireAttack(int index, Pokemon opponent)
    {
        // Validate attack index
        if (index < 0 || index >= FireAttacks.Count)
        {
            Console.WriteLine("Invalid fire attack index.");
            return;
        }

        var attack = FireAttacks[index];
        opponent.HP -= attack.Dmg;
        Console.WriteLine($"{Name} uses fiery {attack.Name} on {opponent.Name}!");

        // Attempt to apply burn status effect
        attack.TryBurn(opponent);
    }
}
