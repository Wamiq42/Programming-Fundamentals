using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Weapons
{
    int magzineSize = 32;
    int bulletFired =  1;
    float damage;
    
    public override int MagazineSize()
    {
        return magzineSize;
    }

    public override float fireRate()
    {
        return bulletFired * 3.8f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 2f;
        return (int)damage;
    }
   
}

