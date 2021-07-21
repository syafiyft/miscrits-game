using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new move")] //to create a path for creating new move 

public class MoveBase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] PokemonType type;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int pp; // pp is number of times a move can be performed

    //properties for each variables
    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }
    public PokemonType Type
    {
        get { return type; }
    }

    public int Power
    {
        get { return power; }
    }
    public int Accuracy
    {
        get { return accuracy; }
    }
    public int PP
    {
        get { return pp; }
    }
}
