using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySorting : MonoBehaviour
{
    private int[] unsortedArray;
    private int temp;
    void Start()
    {
        unsortedArray = new int[] { 20,1,2, 10, 7, 5, 9,8,22};
        for (int x = 0; x < unsortedArray.Length - 1; x++)
        {
            //if (unsortedArray[x] > unsortedArray[x + 1])
            //{
            //    temp = unsortedArray[x];
            //    unsortedArray[x] = unsortedArray[x + 1];
            //    unsortedArray[x + 1] = temp;
            //}
            //for (int y = 0; y < unsortedArray.Length - 1; y++)
            //{
            //    if (unsortedArray[y] > unsortedArray[y + 1])
            //    {
            //        temp = unsortedArray[y];
            //        unsortedArray[y] = unsortedArray[y + 1];
            //        unsortedArray[y + 1] = temp;
            //    }
            //}
            for (int y = x + 1; y < unsortedArray.Length; y++)
            {
                if (unsortedArray[x] > unsortedArray[y])
                {
                    temp = unsortedArray[y];
                    unsortedArray[y] = unsortedArray[x];
                    unsortedArray[x] = temp;
                }
            }
        }
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            print(unsortedArray[i]);
        }




        for (int z = 0; z < unsortedArray.Length - 1; z++)
        {
            if (unsortedArray[z] < unsortedArray[z + 1])
            {
                temp = unsortedArray[z];
                unsortedArray[z] = unsortedArray[z + 1];
                unsortedArray[z + 1] = temp;

            }

            for (int a = 0; a < unsortedArray.Length; a++)
            {
                if (temp > unsortedArray[a])
                {
                    temp = unsortedArray[a];
                }
            }


        }
        print("Smallest Number is = " + temp);



        for (int z = 0; z < unsortedArray.Length - 1; z++)
        {
            if (unsortedArray[z] > unsortedArray[z + 1])
            {
                temp = unsortedArray[z];
                unsortedArray[z] = unsortedArray[z + 1];
                unsortedArray[z + 1] = temp;

            }

            for (int a = 0; a < unsortedArray.Length; a++)
            {
                if (temp < unsortedArray[a])
                {
                    temp = unsortedArray[a];
                }
            }


        }
        print("Greater number is Number is = " + temp);

    }

}
