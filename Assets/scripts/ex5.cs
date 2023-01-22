using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
public int[] integers;
    void Start()
    {
    //here we say that they must give us 5 elements for it to work
        if(integers.Length >= 5)
        {
        Debug.Log($"First element={ integers[0]}");
        Debug.Log($"Third element={ integers[2]}");
        Debug.Log($"Fifth element={ integers[4]}");
        }
        else
        {
    //here we make it so that if it does not reach five elements it will give us an error
            Debug.Log("Missing elements");
        }
    }
}
