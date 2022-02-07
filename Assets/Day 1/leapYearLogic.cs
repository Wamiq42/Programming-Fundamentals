using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leapYearLogic : MonoBehaviour
{
    public int year;
    void Start()
    {
        if(year%4 == 0)
        {
            if(year%100 == 0)
            {
                if(year%400 == 0)
                {
                    print("is Leap Year");
                }
                else
                {
                    print("is not leap year");
                }
            }
            else
            {
                print("is Leap year");
            }
        }
        else
        {
            print("not Leap Year");
        }
    }
}
