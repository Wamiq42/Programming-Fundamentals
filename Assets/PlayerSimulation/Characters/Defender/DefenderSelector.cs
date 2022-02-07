using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSelector
{
    public static Character DefenderSelect(Defender.DefenderSelect type)
    {
        switch (type)
        {
            case Defender.DefenderSelect.mute:
                return new Mute();
            case Defender.DefenderSelect.bandit:
                return new Bandit();
            case Defender.DefenderSelect.kapkan:
                return new Kapkan();
            case Defender.DefenderSelect.rook:
                return new Rook();
            case Defender.DefenderSelect.smoke:
                return new Smoke();
            default:
                return new Defender();
        }
    }
}
