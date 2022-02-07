using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This class controls the selection of character and thier guns etc*/
public class Player 
{
    Character equipCharacter;
    public int health;
    public void intializePlayer(string playerName, int health, Weapons gun, Character character)
    {
        equipCharacter = new Character();
        equipCharacter.intializePlayer(playerName, health, gun, character);
        this.health = health;
    }

    public int getEnemyHealth()
    {
        return equipCharacter.enemyHealthGetter();
    }
    public Character returnCharacter()
    {
        return equipCharacter;
    }

    
    public void useAbility(Character target)
    {

        equipCharacter.useAbility(target);
    }
    public void Attack (Character target)
    {
        equipCharacter.AttackPlayer(target);
    }
    public void displayInfo()
    {
        equipCharacter.displayInfo();
    }
}
