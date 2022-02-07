using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : Weapons
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
        damage = fireRate() * 73f;
        return (int)damage;
    }
   
    //    public void displayinfo()
    //    {
    //        Debug.Log(getDamage());
    //    }
}
