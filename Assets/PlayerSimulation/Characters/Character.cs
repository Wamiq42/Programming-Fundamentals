using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This class controls the creation of a character.*/
public class Character
{

    public int health;
    string playerName;
    int enemyHealth;
    float damage;
    EquippedGun equipGun;
    Character equipedCharacter;

  


    public void intializePlayer(string playerName, int health, Weapons gun, Character character)
    {

        equipGun = new EquippedGun();
        equipGun.EquipGun(playerName, health, gun);
        this.health = health;
        this.playerName = playerName;
        this.damage = equipGun.Damage();
        equipedCharacter = character;
     
        
    }

    public int enemyHealthGetter()
    {
        return enemyHealth;
    }
    public void useAbility(Character target)
    {
        equipedCharacter.Ability(target);
    }


    public virtual void Ability(Character target)
    {

        Debug.Log("Default Player has no Ability");

    }
  


    public void AttackPlayer(Character target)
    {
        if (target.health > 1)
        {
            target.health -= (int)damage;
            enemyHealth = target.health;
        }
           
        if (target.health < 1)
            target.equipGun.playerDead();
    }

    public void displayInfo()
    {

        Debug.Log("################" + playerName + "##################");
        Debug.Log("Damage of " + playerName + "'s gun = " + damage);
        Debug.Log("remaining Health" + health);
    }
}
