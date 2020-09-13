using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Test : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 50;
        array[4] = 40;

        for (int i = 0; i < array.Length; i++)
        {
            UnityEngine.Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            UnityEngine.Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}