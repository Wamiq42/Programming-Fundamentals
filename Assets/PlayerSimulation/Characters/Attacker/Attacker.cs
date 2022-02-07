using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : Character
{
    public override void Ability(Character character)
    {
        Debug.Log("Default Player has no Ability");
    }
    public enum AttackerSelect { ash, thermite, slegde, glaz, iq }
}
