using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{

    protected Player playerRefrence;
    [SerializeField] protected float health = 100;
    public Player player;
    
    protected virtual void Start()
    {
        playerRefrence = FindObjectOfType<Player>();
    }

   
    protected virtual void Update()
    {
        //DetectPlayer();

        DealDamage(1f);


    }


    /*protected void DetectPlayer()
    {
        if (playerRefrence)
        {
            if (Vector2.Distance(transform.position, playerRefrence.transform.position) < 1)
            {

                Debug.Log("Found Player");
                

            }

        }

    }
    */


    protected virtual void DealDamage(float enemyDamage)
    {


        if (playerRefrence)
        {
            if (Vector2.Distance(transform.position, playerRefrence.transform.position) < 1)
            {
                player.playerHealth -= enemyDamage;

                Debug.Log("Player took damage!");
                Debug.Log("Player Health " + player.playerHealth);
                Debug.Log("Enemy Damage" + enemyDamage);


            }

        }


        
    }


}
