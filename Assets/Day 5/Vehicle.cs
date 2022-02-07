using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Vehicle
{
    string RegNo, vehicleType;
    int health, damage, PositionX, PositionY;

    public void CreateVehicleObj(string RegNo, string vehicleType, int health, int PositionX, int PositionY, int damage)
    {
        this.RegNo = RegNo;
        this.vehicleType = vehicleType;
        this.health = health;
        this.PositionX = PositionX;
        this.PositionY = PositionY;
        this.damage = damage;

    }


    public void AttackVehicle(Vehicle Target)
    {
            Target.getDamage(this.damage);
    }
    public void ForwardUP()
    {
        PositionX++;
    }
    public void BackwardDown()
    {
        PositionX--;
    }
    public void GoRight()
    {
        PositionY++;
    }
    public void GoLeft()
    {
        PositionY--;
    }
    void getDamage(int damage)
    {
            health = health - damage;
    }
    public void DisplayInfo()
    {
        Debug.Log("Health of " + RegNo + " " + health);
        Debug.Log("position x of " + RegNo + " " + PositionX);
        Debug.Log("Position y of " + RegNo + " " + PositionY);
        Debug.Log("Attack power = " + damage);
    }

}