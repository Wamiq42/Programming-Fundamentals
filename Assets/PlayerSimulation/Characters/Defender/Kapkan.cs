using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kapkan : Defender
{
    public override void Ability(Character player)
    {
        Debug.Log("Placed Traps on doors and windows");
        player.health -= 100;
    }
}
