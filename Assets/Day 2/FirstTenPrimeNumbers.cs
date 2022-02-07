using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTenPrimeNumbers : MonoBehaviour
{
    public int number = 10;
    private int zeroOne = 0;
    
    void Start()
    {
            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                zeroOne++;
                }
            }
            if(zeroOne == 2)
                print("isPrime");
            if (zeroOne > 2)
                print("notPrime");
     }
}


   

