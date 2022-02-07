using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This class controls the damage and equiping of guns to specific character*/
public class EquippedGun
{
    int health;
    string playerName;
    float damage;
    int bulletsRemaining;
    bool isDead = false;
    Weapons equipGun;

    public void EquipGun(string playerName, int health, Weapons Gun)
    {
        equipGun = Gun;
        equipGun.MagazineSize();
        this.health = health;
        this.playerName = playerName;
        this.equipGun = Gun;
    }
    public float Damage()
    {
        return damage = equipGun.getDamage();
    }

    public void playerDead()
    {
        Debug.LogError("****************" + playerName + " is DEAD****************");
    }
}
