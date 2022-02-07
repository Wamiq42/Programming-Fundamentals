using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4 : AssaultRifle
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
        return bulletFired * 5f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 2f;
        return (int)damage;
    }
}
