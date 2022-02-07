using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : Defender
{
    public override void Ability(Character player)
    {
         Debug.Log("Dropped Armor\n Gave every Defender extra 20 hp");
         player.health += 20;
    }
    
}
