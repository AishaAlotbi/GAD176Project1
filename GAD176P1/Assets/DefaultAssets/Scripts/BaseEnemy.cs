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


        FollowPlayer(1.5f);

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

        player.playerHealth -= enemyDamage;

        Debug.Log("Player took damage!");
        Debug.Log("Player Health " + player.playerHealth);
        Debug.Log("Enemy Damage" + enemyDamage);



    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            
            DealDamage(1f);


        }
    }


    protected virtual void FollowPlayer(float moveSpeed)
    {
        if(player == null)
        {
            return; 
        }


        Vector2 direction = (player.transform.position - transform.position).normalized;
        transform.position += new Vector3(direction.x, direction.y, 0) * moveSpeed * Time.deltaTime;

       
    } 

}
