using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
//here we put the three numbers for do the mean
    public float num1;
    public float num2;
    public float num3;

    void Start()
    {
        CRAM(num1, num2, num3);
    }

    private float CRAM(float num1, float num2, float num3)
    {
    //here we put the formula to calculate arithmetic mean
        float mean=(num1 + num2 + num3) / 3;
        Debug.Log($"the arithmetic mean of {num1}, {num2}, {num3} it's {mean}");
        return mean;
    }
}
