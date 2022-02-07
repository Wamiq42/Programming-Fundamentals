using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimeNumberLogic : MonoBehaviour
{
    public int number = 7;
    private int zeroOne = 0,halfNumber;
    //private bool trueOrFalse;
    // Start is called before the first frame update
    void Start()
    {
        halfNumber = 7 / 2;
        if (number <= 3)
        {
            print("isPrime");
        }
        if(number > 3)
        {
            for (int i = 2; i <= halfNumber; i++)
            {

                if (number % i == 0)
                {
                    zeroOne = 1;
                    i = halfNumber;
                }
            }

            if (zeroOne == 1)
            {
                print("notPrime");
            }
            if (zeroOne == 0)
            {
                print("isPrime");
            }
        }
        


    }

}
