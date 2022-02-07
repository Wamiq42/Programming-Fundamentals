using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vehicle vehicle1 = new Vehicle();
        Vehicle vehicle2 = new Vehicle();
 
        vehicle1.CreateVehicleObj("Wamiq's Car", "car", 100, 0, 0, 15);
        vehicle1.DisplayInfo();
        vehicle2.CreateVehicleObj("Wamiq's Bus", "car", 100, 0, 0,20);
        vehicle2.DisplayInfo();
        //vehicle1.DisplayInfo();


        vehicle1.ForwardUP();
        vehicle1.ForwardUP();
        vehicle1.ForwardUP();
        vehicle1.ForwardUP();
       // vehicle1.DisplayInfo();

        vehicle2.BackwardDown();
        vehicle2.BackwardDown();
        vehicle2.BackwardDown();
        vehicle2.BackwardDown();
        //vehicle2.DisplayInfo();

        vehicle1.GoLeft();
        vehicle1.GoLeft();
        vehicle1.GoLeft();
        vehicle1.GoLeft();
        //vehicle1.DisplayInfo();

        vehicle2.GoRight();
        vehicle2.GoRight();
        vehicle2.GoRight();
        vehicle2.GoRight();
        //vehicle2.DisplayInfo();

        vehicle2.AttackVehicle(vehicle1);
        vehicle1.DisplayInfo();
        vehicle2.AttackVehicle(vehicle1);
        vehicle1.DisplayInfo();
        vehicle2.AttackVehicle(vehicle1);
        vehicle1.DisplayInfo();
        vehicle2.AttackVehicle(vehicle1);
        vehicle1.DisplayInfo();
        vehicle2.AttackVehicle(vehicle1);
        vehicle1.DisplayInfo();


    }
}
