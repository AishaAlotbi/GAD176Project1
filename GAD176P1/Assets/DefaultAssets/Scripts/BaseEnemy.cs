using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{

    protected Player playerRefrence;
    [SerializeField] protected float enemyHealth;
    public Player player;
    
   
    protected virtual void Start()
    {
        enemyHealth = 10f;
        Debug.Log("BaseEnemy HP " + enemyHealth);
        playerRefrence = FindObjectOfType<Player>();
        
    }

   
    protected virtual void Update()
    {
        


        FollowPlayer(1.5f);
        

    }


    


    protected virtual void DealDamage(float enemyDamage) //basic damage dealt by enemies, alter for different enemies 
    {

        player.playerHealth -= enemyDamage;

       
        Debug.Log("Player Health " + player.playerHealth);
        Debug.Log("Enemy Damage" + enemyDamage);
       



    }



    private void OnCollisionEnter2D(Collision2D collision) //damage dealt when player collides with enemy 
    {
        if (collision.collider.CompareTag("Player"))
        {
            
            DealDamage(1f);


        }

        
    }

    

    protected virtual void FollowPlayer(float moveSpeed) //follow the player, movement speed altered based on enemy 
    {
        if(player == null)
        {
            return; 
        }


        Vector2 direction = (player.transform.position - transform.position).normalized;
        transform.position += new Vector3(direction.x, direction.y, 0) * moveSpeed * Time.deltaTime;

       
    }


    public void TakeDamage(float bulletDamage)
    {
        enemyHealth -= bulletDamage;
        Debug.Log("enemy health " + enemyHealth);
        if (enemyHealth<= 0)
        {

            Destroy(gameObject);

        }

    }

}
