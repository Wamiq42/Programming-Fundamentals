using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ash : Attacker
{

    public override void Ability(Character target)
    {
        Debug.Log("Used Breach Round on SOFT WALLS\n Breached Soft Walls");
        target.health -= 12;
    }
}
