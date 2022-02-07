using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glaz : Attacker
{
    public override void Ability(Character player)
    {
        Debug.Log("Uses thermal scope can kill in smoke");
        AttackPlayer(player);
    }
}
