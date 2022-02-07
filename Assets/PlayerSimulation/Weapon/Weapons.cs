using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*this class controls the creation of guns*/
public class Weapons
{
    
    string gunType;
    int TotalnoOFBullets;
    int bulletsFired;
    float damage;
    

    public void Gun(string gunType)
    {
        
        this.gunType = gunType;
       

    }

    public virtual int MagazineSize()
    {
        return TotalnoOFBullets;
    }
    public virtual float fireRate()
    {
        Debug.Log("Using Knife");
        return bulletsFired;
    }
    public virtual int getDamage()
    {
        damage = fireRate() * 100f;
        return (int)damage;
    }
    public enum GunType {
        sniper,lmg,smg,ar,pistol,m249b,lmge,m1911,pmm,m4,m762,smg11,mp5,r900,m98b
    }
    
}
