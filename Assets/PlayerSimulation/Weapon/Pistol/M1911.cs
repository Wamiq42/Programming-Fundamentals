using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1911 : Pistol
{
    int magzineSize = 11;
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
        damage = fireRate() * 29f;
        return (int)damage;
    }
}
