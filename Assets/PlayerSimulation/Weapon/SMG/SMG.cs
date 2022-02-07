using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMG :  Weapons
{
    int magzineSize = 31;
    float bulletFired = 1;
    float damage;
    
    public override int MagazineSize()
    {
        return magzineSize;
    }

    public override float fireRate()
    {
        return bulletFired *= 4.5f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 2.0f;
        return (int)damage;
    }
   
}
