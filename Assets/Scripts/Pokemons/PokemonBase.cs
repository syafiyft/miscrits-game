using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new pokemon")] //to create a path for creating new pokemon /CHARACTER/
public class PokemonBase : ScriptableObject
{

    [SerializeField] string name;

    [TextArea] 
    [SerializeField] string description;


    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    // Base stats
    [SerializeField] int maxHP;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int spAttack;
    [SerializeField] int spDefense; //sp is special
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;  //like array but mostly like predefined function

    //properties @ Capital Letter 
    public string Name 
    {
        get { return name; }
    }

    public string Description 
    {
        get { return description; }

    }

    public Sprite FrontSprite //this one is the most problematic XD . gotta add this to define for Battleunit.base.sprite
    { 
        get { return frontSprite;  } 
    
    }

    public Sprite BackSprite
    {
        get { return backSprite;  }

    }
    public int MaxHp 
    {
        get { return maxHP; }

    }
    public int Attack
    {
        get { return attack; }

    }
    public int Defense
    {
        get { return defense; }

    }
    public int SpAttack
    {
        get { return spAttack; }

    }

    public int SpDefense
    {
        get { return spDefense; }

    }
    public int Speed
    {
        get { return speed; }

    }

    public List<LearnableMove> LearnableMoves
    {
        get { return learnableMoves; }
    }
}

//for moves @ skills

[System.Serializable] //to make it appear on inspector
public class LearnableMove //basically to set at which level the pokemon will learn that move
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level; // at what level will the move use @variables

    public MoveBase Base
    {
        get { return moveBase; }
    }

    public int Level
    {
        get { return level; }
    }
}
//types of pokemon
public enum PokemonType
{
    None,
    Normal,
    Bug,
    Dark,
    Dragon,
    Electric,
    Fairy,
    Fighting,
    Fire,
    Flying,
    Ghost,
    Grass,
    Ground,
    Ice,
    Poison,
    Psychic,
    Rock,
    Steel,
    Water,
}