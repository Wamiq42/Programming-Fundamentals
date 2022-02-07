using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class programbasic : MonoBehaviour

{
    public int a = 353;
    private int lastdigit, firstdigit;
    // Start is called before the first frame update
    void Start()
    {
        //firstdigit = (a - (a % 100))/100;
        firstdigit = a / 100;
        lastdigit = a % 10;

        //print(firstdigit);
        //print(lastdigit);

        if (firstdigit == lastdigit)
        {
            print("is palindrome");
        }
        else
            print("Notpalindrome");




        /*
        string b = a.ToString();
        string checkVar = "";

        print(b);
        int c = b.Length;

        //print(b[0]);
      
            for (int j = b.Length - 1; j >= 0; j--)
            {
                  checkVar = checkVar +  b[j]; 
            }

        if (checkVar.Equals(b))
        {
            print("isPalindrome");
        }
        if(!checkVar.Equals(b))
        {
            print("notPalindrome");
        }*/
        
    }

    
}
