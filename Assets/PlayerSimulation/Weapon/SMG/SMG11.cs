using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMG11 : SMG
{
    int magzineSize = 17;
    float bulletFired = 1;
    float damage;

    public override int MagazineSize()
    {
        return magzineSize;
    }

    public override float fireRate()
    {
        return bulletFired *= 7.5f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 1.8f;
        return (int)damage;
    }
}
