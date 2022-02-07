using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : Character
{
    public override void Ability(Character player)
    {
        Debug.Log("Default Player has no Ability");
    }
  

    public enum DefenderSelect { smoke,rook,mute,kapkan,bandit}
}
