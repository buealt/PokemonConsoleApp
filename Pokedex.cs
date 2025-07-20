// Represents a simple Pokédex that stores a list of Pokémon
public class Pokedex
{
    // Internal list to hold all Pokémon entries
    private List<Pokemon> _pokemons = new List<Pokemon>();

    // Adds a new Pokémon to the Pokédex
    public void AddPokemon(Pokemon pokemon)
    {
        // Prevents adding null entries
        if (pokemon == null)
        {
            Console.WriteLine("Details missing – no Pokémon added.");
            return;
        }

        _pokemons.Add(pokemon);
        Console.WriteLine($"{pokemon.Name} was added to the Pokédex!");
    }

    // Displays all Pokémon currently stored in the Pokédex
    public void ShowAll()
    {
        if (_pokemons.Count == 0)
        {
            Console.WriteLine("Pokédex is empty.");
            return;
        }

        Console.WriteLine("=== All Pokémon in the Pokédex ===");

        foreach (var pokemon in _pokemons)
        {
            Console.WriteLine($"Name: {pokemon.Name}");
            Console.WriteLine($"Type: {pokemon.Type}");
            Console.WriteLine($"Level: {pokemon.Level}");
            Console.WriteLine($"HP: {pokemon.HP}");
            Console.WriteLine($"Description: {pokemon.Description}");
            Console.WriteLine(new string('-', 30)); // separator line
        }
    }
}
