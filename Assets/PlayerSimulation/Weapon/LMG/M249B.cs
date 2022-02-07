using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M249B : LMG
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
        return bulletFired *= 2.8f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 3.2f;
        return (int)damage;
    }
   

}
