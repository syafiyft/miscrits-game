using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleUnit : MonoBehaviour
{
    [SerializeField] PokemonBase _base; //reference to the PokemonBase
    [SerializeField] int level;
    [SerializeField] bool isPlayerUnit; //checks whether the pokemon is ours or enemy

    public Pokemon Pokemon { get; set; } //this property stores the pokemon . Properties usually have first letter capitalized

    public void Setup() //this creates monster from the base and level
    {
        Pokemon = new Pokemon(_base, level); //we are using the constructor of the pokemon class
        if (isPlayerUnit)
            GetComponent<Image>().sprite = Pokemon.Base.BackSprite;
        else
            GetComponent<Image>().sprite = Pokemon.Base.FrontSprite;

    }

}
