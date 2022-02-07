using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WeaponSelector 
{
    public static Weapons selector(Weapons.GunType type , Weapons.GunType type2)
    {
        switch (type)
        {
            case Weapons.GunType.sniper:
                switch (type2)
                {
                    case Weapons.GunType.r900:
                        return new R900();
                    case Weapons.GunType.m98b:
                        return new M98B();
                    default:
                        return new Sniper();
                }
            case Weapons.GunType.lmg:
                switch (type2)
                {
                    case Weapons.GunType.m249b:
                        return new M249B();
                  case Weapons.GunType.lmge:
                       return new LMGE();
                    default:
                        return new LMG();
                }
            case Weapons.GunType.smg:
                switch (type2)
                {
                    case Weapons.GunType.smg11:
                        return new SMG11();
                    case Weapons.GunType.mp5:
                           return new MP5();
                    default:
                        return new SMG();
                }
            case Weapons.GunType.ar:
                switch (type2)
                {
                    case Weapons.GunType.m4:
                        return new M4();
                    case Weapons.GunType.m762:
                        return new M762();
                    default:
                        return new LMG();
                }
            case Weapons.GunType.pistol:
                switch (type2)
                {
                    case Weapons.GunType.m1911:
                        return new M1911();
                    case Weapons.GunType.pmm:
                        return new Pmm();
                    default:
                        return new Pistol();
                }
            default:
                return new Weapons();
        }

    }
}
