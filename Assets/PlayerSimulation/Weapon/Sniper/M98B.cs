using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M98B : Sniper
{
    int magzineSize = 7;
    float bulletFired = 1;
    float damage;
    public override int MagazineSize()
    {

        return magzineSize;
    }

    public override float fireRate()
    {
        return bulletFired *= 1.0f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 110f;
        return (int)damage;
    }
}
