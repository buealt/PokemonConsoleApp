using System;
using System.Collections.Generic;

// Represents a basic Pokémon with properties and behavior
public class Pokemon
{
    // Fields for basic Pokémon data
    private int _id;
    private string _name;
    private string _description;
    private string _type;
    private int _level;
    private int _hp;
    private List<Attack> _attack;

    // Default constructor
    public Pokemon()
    {
        _attack = new List<Attack>();
    }

    // Full constructor to initialize all fields
    public Pokemon(int id, string name, string description, string type, int level, int hp, List<Attack> attack)
    {
        _id = id;
        _name = name;
        _description = description;
        _type = type;
        _level = level;
        _hp = hp;
        _attack = attack;
    }

    // Properties (Getters and Setters)
    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public string Type { get => _type; set => _type = value; }
    public int Level { get => _level; set => _level = value; }
    public int HP { get => _hp; set => _hp = value; }
    public List<Attack> Attack { get => _attack; set => _attack = value; }

    // Basic attack method – uses first attack in the list
    public void fightOpponent(Pokemon opponent)
    {
        Attack firstAttack = _attack[0];
        int dmg = firstAttack.Dmg;
        opponent.HP -= dmg;
        Console.WriteLine($"{Name} attacks {opponent.Name} with {firstAttack.Name}!");
    }
}
