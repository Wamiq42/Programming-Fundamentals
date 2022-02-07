using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thermite : Attacker
{
    public override void Ability(Character target)
    {
        Debug.Log("Used Thermite Charge on Renforced WALLS\n Breached Renforced Walls");
        target.health -= 100;
    }
}
