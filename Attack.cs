// Represents a generic attack that any Pokémon can use
public class Attack
{
    // Name of the attack (e.g., "Tackle", "Thunderbolt")
    public string Name { get; set; }

    // Damage value of the attack
    public int Dmg { get; set; }

    // Type of the attack (e.g., "Electric", "Physical")
    public string Type { get; set; }

    // Constructor to initialize all properties of the attack
    public Attack(string name, int dmg, string type)
    {
        Name = name;
        Dmg = dmg;
        Type = type;
    }
}