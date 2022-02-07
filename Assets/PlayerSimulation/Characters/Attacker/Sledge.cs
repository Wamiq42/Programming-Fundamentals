using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sledge : Attacker
{
    public override void Ability(Character player)
    {
        Debug.Log("Used Slegde Hammer on SOFT WALLS\n Made a Hole Soft Walls");
        player.health = 0;
    }
}
