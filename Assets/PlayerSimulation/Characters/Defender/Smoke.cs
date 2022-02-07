using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smoke : Defender
{
    public override void Ability(Character player)
    {
        Debug.Log("Used Toxic Babes on Ground\n Created Toxic Gas");
        player.health -= 100;
    }
}
