using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerHealth; 
    public float playerMaxHealth = 100;

    
    void Start()
    {
        playerHealth = playerMaxHealth; //set player health at start

        Debug.Log("Player Health: " + playerHealth);
    }

    
    
}
