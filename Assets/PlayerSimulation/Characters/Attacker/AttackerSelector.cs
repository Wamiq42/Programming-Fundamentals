using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AttackerSelector
{
   public static Character attackerSelect(Attacker.AttackerSelect type)
    {
        switch (type)
        {
            case Attacker.AttackerSelect.ash:
                return new Ash();
            case Attacker.AttackerSelect.glaz:
                return new Glaz();
            case Attacker.AttackerSelect.thermite:
                return new Thermite();
            case Attacker.AttackerSelect.slegde:
                return new Sledge();
            case Attacker.AttackerSelect.iq:
                return new IQ();
            default:
                return new Attacker();
        }
    }
}
