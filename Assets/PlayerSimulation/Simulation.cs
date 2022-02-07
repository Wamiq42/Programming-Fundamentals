using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulation : MonoBehaviour
{
    Player playerAR1, playerAR2;
  
    Weapons lightMachineGun;

  
    private void Start()
    {


        playerAR1 = new Player();
        playerAR2 = new Player();
        playerAR1.intializePlayer("Creep", 100, WeaponSelector.selector(Weapons.GunType.ar, Weapons.GunType.m4),
            AttackerSelector.attackerSelect(Attacker.AttackerSelect.ash));
        playerAR2.intializePlayer("Thermite", 100, WeaponSelector.selector(Weapons.GunType.ar, Weapons.GunType.m762),
            AttackerSelector.attackerSelect(Attacker.AttackerSelect.thermite));


        playerAR1.displayInfo();
        playerAR2.displayInfo();



        playerAR1.Attack(playerAR2.returnCharacter());
        playerAR2.displayInfo();

        playerAR1.useAbility(playerAR2.returnCharacter());
        playerAR2.displayInfo();

    }
}
