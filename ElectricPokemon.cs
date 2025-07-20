// A special Pokémon class for Electric-type Pokémon
public class ElectricPokemon : Pokemon{
    // Electric-specific attacks
    public List<ElectricAttack> ElectricAttacks { get; set; }

    // Constructor for Electric Pokémon
    public ElectricPokemon(int id, string name, string description, int level, int hp, List<Attack> attacks, List<ElectricAttack> electricAttacks)
        : base(id, name, description, "Electric", level, hp, attacks)
    {
        ElectricAttacks = electricAttacks ?? new List<ElectricAttack>();
    }

    // Executes a chosen electric attack against another Pokémon
    public void UseElectricAttack(int index, Pokemon opponent)
    {
        if (index < 0 || index >= ElectricAttacks.Count)
        {
            Console.WriteLine("Invalid electric attack index.");
            return;
        }

        var attack = ElectricAttacks[index];
        opponent.HP -= attack.Dmg;
        Console.WriteLine($"{Name} zaps {opponent.Name} with {attack.Name} for {attack.Dmg} damage!");
        attack.TryParalyze(opponent);
    }
}
