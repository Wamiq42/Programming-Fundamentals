using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintingStars : MonoBehaviour
{
    public int numberOfStars = 5;
   
    // Start is called before the first frame update
    void Start()
    {
        /*
         *          *
         *          **
         *          ***
         *          ****
         *          *****
         */

        string stars = "";
        for (int y = 1; y <= numberOfStars; y++)
        {

            for (int x = 1; x <= y; x++)
            {
                stars += "*";
            }

            //stars += "*";
            stars += "\n";
            //print(stars);
        }
        print(stars);

        /*
        *          *
        *          **
        *          ***      but reverse
        *          ****
        *          *****
        */


        for (int k = 1; k <= numberOfStars; k++)
        {
            for (int j = 1; j <= numberOfStars - k; j++)
            {
                stars += " ";
            }
            for (int i = 1; i <= k; i++)
            {
                stars += "*";
            }

            stars += "\n";
        }
        print(stars);

        /*
         *      xxxxx
         *      x   x
         *      x   x
         *      x   x
         *      xxxxx
         */

        int row, colum;
        row = numberOfStars;
        colum = numberOfStars;

        for (int b = 1; b <= row; b++)
        {
            for (int a = 1; a <= colum; a++)
            {
                if (a == 1 || row == a || b == 1 || b == colum)
                {
                    stars += "x";
                }
                else
                {
                    stars += "  ";
                }
            }
            stars += "\n";

        }

        print(stars);


        /*
       *        x
       *        xx
       *        x x
       *        x  x
       *        xxxxx
       */
        for (int n = 1; n <= row; n++)
        {
            for (int m = 1; m <= n; m++)
            {
                if (m == 1 || m == n || n == row)
                {
                    stars += "*";
                }
                else
                {
                    stars += " ";
                }
            }
            stars += "\n";
        }
        print(stars);
    }

}
