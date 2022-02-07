using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numAndPow : MonoBehaviour
{
    public int number, power;
    private int result = 1;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i <= power; i++)
        {
            result = result * number;
        }
        print(result);
    }

}
