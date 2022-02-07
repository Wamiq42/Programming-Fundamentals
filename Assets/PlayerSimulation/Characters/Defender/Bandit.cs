using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandit : Defender
{
    public override void Ability(Character player)
    {
        Debug.Log("Electrified renforced walls");
        player.health -= 5;
    }
}
