using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayAdd : MonoBehaviour
{
    private int[] array = { 1, 3, 5, 2, 9, 7, 10 };
    int number;
    void Start()
    {
      
            for (int x = 0; x < array.Length; x++)
            {
                number = array[x] + array[x];
                if(number == 11)
                {
                    print(array[x] + "\n");
                }
            }
               
    }

   
}
