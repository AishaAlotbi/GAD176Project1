using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float playerHealth; 
    public float playerMaxHealth = 100;
    [SerializeField] TMP_Text healthText;
    [SerializeField] TMP_Text deathText;


    void Start()
    {
        playerHealth = playerMaxHealth; //set player health at start

        Debug.Log("Player Health: " + playerHealth);
    }


    private void Update()
    {
        healthText.text = "Health " + playerHealth;

        if (playerHealth <= 0)
        {
            deathText.text = "You Died";
            Time.timeScale = 0;


        }
    }


}
