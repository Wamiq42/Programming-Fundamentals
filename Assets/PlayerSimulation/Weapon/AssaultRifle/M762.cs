using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M762 : AssaultRifle
{
    int magzineSize = 32;
    int bulletFired = 1;
    float damage;

    public override int MagazineSize()
    {
        return magzineSize;
    }

    public override float fireRate()
    {
        return bulletFired * 4.8f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 2.6f;
        return (int)damage;
    }
}
