using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    public PokemonBase Base { get; set; } //function when we start developing battle system
    public int Level { get; set; }

    public int HP { get; set; }

    public List<Move> Moves { get; set; } //where we store our move
    public Pokemon(PokemonBase pBase, int plevel) //'constructor' we need to use to generate all moves based on level.
    {

        Base = pBase;
        Level = plevel;
        HP = MaxHp;


        // Generate
        Moves = new List<Move>();
        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <= Level) //initially
                Moves.Add(new Move(move.Base)); //constructor

            if (Moves.Count >= 4) //bigger than 4 moves
                break;
        }
    }


    //properties
    public int Attack { 
        get { return Mathf.FloorToInt((Base.Attack * Level) / 100f) + 5; }
    } 
    public int Defense { 
        get { return Mathf.FloorToInt((Base.Defense * Level) / 100f) + 5; }
   
    } public int SpAttack { 
        get { return Mathf.FloorToInt((Base.SpAttack * Level) / 100f) + 5; }
    
    } public int SpDefense { 
        get { return Mathf.FloorToInt((Base.SpDefense * Level) / 100f) + 5; }
    
    } public int Speed { 
        get { return Mathf.FloorToInt((Base.Speed * Level) / 100f) + 5; }
    
    } public int MaxHp { 
        get { return Mathf.FloorToInt((Base.MaxHp * Level) / 100f) + 10; } //for MaxHP the value is 10 because its different @ reference on Bulbapedia
    } 
}
