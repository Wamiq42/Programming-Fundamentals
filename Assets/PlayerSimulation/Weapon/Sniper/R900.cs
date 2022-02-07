using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R900 : Sniper
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
        damage = fireRate() * 88f;
        return (int)damage;
    }
}
