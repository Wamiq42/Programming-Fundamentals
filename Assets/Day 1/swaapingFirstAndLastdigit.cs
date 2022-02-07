using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swaapingFirstAndLastdigit : MonoBehaviour
{
    public int number = 12345, totaldigits = 1;
    private int firstDigit, lastDigit;
    private string swappingNumber;

    void Start()
    {
      
        if (number < 10)
        { firstDigit = number; }
        else if (number < 100)
        { firstDigit = number / 10; }
        else if (number < 1000)
        { firstDigit = number / 100; }
        else if (number < 10000)
        { firstDigit = number / 1000; }
        else if (number < 100000)
        { firstDigit = number / 10000; }
        else if (number < 1000000)
        { firstDigit = number / 100000; }
        else if (number < 10000000)
        { firstDigit = number / 1000000; }
        else if (number < 100000000)
        { firstDigit = number / 10000000; }
        else if (number < 1000000000)
        { firstDigit = number / 100000000; }
        else
        {
            firstDigit = number / 1000000000;
        }

        lastDigit = number % 10;
       


        
        swappingNumber = number.ToString();
        string ld = lastDigit.ToString(); //dtring last digit
        string fd = firstDigit.ToString();//string first digit

        string middleNumber = swappingNumber.Substring(1, swappingNumber.Length - 2);

        //print(middleNumber);
        //print(ld);
        //print(fd);

        int swappedNumber = int.Parse(ld + middleNumber + fd);
        print(swappedNumber);
      
        

    }
}
