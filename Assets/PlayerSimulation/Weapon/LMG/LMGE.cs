using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LMGE : LMG
{

    int magzineSize = 250;
    float bulletFired = 1;
    float damage;
    public override int MagazineSize()
    {
        return magzineSize;
    }

    public override float fireRate()
    {
        return bulletFired = bulletFired * 3.4f;
    }
    public override int getDamage()
    {
        damage = fireRate() * 2.8f;
        return (int)damage;
    }
  


}
