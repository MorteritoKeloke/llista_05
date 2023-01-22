using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
//here we put the [] because from the inspector we put as many as we want
public int[] integers;

    void Start()
    {
    //here we ask you to say what these three elements are
        Debug.Log($"First element={ integers[0]}");
        Debug.Log($"Third element={ integers[2]}");
        Debug.Log($"Fifth element={ integers[4]}");

    }
}
