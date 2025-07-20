// Entry point for the Pokémon battle simulation
public class Program
{
    public static void Main(string[] args)
    {
        // Create a new Pokédex
        Pokedex pokedex = new Pokedex();

        // Create Pikachu
        ElectricPokemon pikachu = new ElectricPokemon(
            001,
            "Pikachu",
            "This Pokémon generates electricity to shock its opponents.",
            10,
            100,
            new List<Attack> {
                new Attack("Quick Attack", 30, "Physical")
            },
            new List<ElectricAttack> {
                new ElectricAttack("Thunder Shock", 40, "Electric", 30),
                new ElectricAttack("Thunderbolt", 90, "Electric", 50)
            }
        );

        // Create Eevee
        Pokemon eevee = new Pokemon()
        {
            Id = 002,
            Name = "Eevee",
            Description = "The versatile Pokémon that can evolve into many forms.",
            Type = "Normal",
            Level = 10,
            HP = 100,
            Attack = new List<Attack>
            {
                new Attack("Tackle", 35, "Physical"),
                new Attack("Tail Whip", 30, "Physical")
            }
        };

        // Add Pokémon to the Pokédex
        pokedex.AddPokemon(pikachu);
        pokedex.AddPokemon(eevee);

        // Start the battle
        Console.WriteLine($"{pikachu.Name} and {eevee.Name} enter the battle!");

        pikachu.UseElectricAttack(0, eevee);
        eevee.fightOpponent(pikachu);

        // Show all entries in the Pokédex
        Console.WriteLine();
        pokedex.ShowAll();
    }
} 
