using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
 private int counter;
    void Update()
    {
    //Here we put the key we want to add
        if(Input.GetKeyDown(KeyCode.A))
        {
            AddOneToCounter();
            GameOver();
        }
    }

private void AddOneToCounter()
{
//here let's add 1 to the counter
    counter++;
    
}
private bool GameOver()
{
//here it means that if the counter reaches 10 it is over
    if(counter==10)
    {
        Debug.Log("GameOver");
        return true;
    }
    return false;
}



}
