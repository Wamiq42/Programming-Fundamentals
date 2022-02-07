using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodProgramming : MonoBehaviour
{
    int g;
    int h;
    // Start is called before the first frame update
    void Start()
    {
        g = 6;
        h = 3;
        sum(g, h);
        print(g);

    }

    void sum(int a, int b)
    { 
        int temp = a;
        a = b;
        b = temp;
        this.g = a;
        this.h = b;
    }
}
