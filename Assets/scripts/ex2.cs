using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ex2 : MonoBehaviour
{
    public string username;
    public string password;
    
    void Start()
    {
        Login(username, password);
    }

    private bool Login (string username, string password)
    {
    //we put an if to make it possible, that if we are given the correct user and password values, it turns out that we have accessed
        if(password=="abccba" && username=="admin")
        {
        Debug.Log("You're in");
        return true;
    //here it states that if the user and password are not correct, it will give us an error
        }
            Debug.Log("The username or the password is incorrect");
            return false;
        
    }
}
