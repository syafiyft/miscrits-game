using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleUnit playerUnit;
    [SerializeField] BattleUnit enemyUnit;
    [SerializeField] BattleHud playerHud;
    [SerializeField] BattleHud enemyHud;


    private void Start()
    {
        SetupBattle(); //at start
    }

    public void SetupBattle() //function to start the battle
    {
        playerUnit.Setup(); //setup player unit @ will create player pokemon
        enemyUnit.Setup(); //enemy
        playerHud.SetData(playerUnit.Pokemon); //data pokemon
        enemyHud.SetData(enemyUnit.Pokemon); //enemy

    }

}
