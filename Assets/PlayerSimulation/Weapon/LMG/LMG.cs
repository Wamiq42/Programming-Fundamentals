using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LMG : Weapons
{
    int magzineSize = 100;
    float bulletFired = 1;
    float damage;
    public override int MagazineSize()
    {
        return magzineSize;
    }

    public override float fireRate()
    {
        return bulletFired *= 3f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 2.5f;
        return (int)damage;
    }
   



}

