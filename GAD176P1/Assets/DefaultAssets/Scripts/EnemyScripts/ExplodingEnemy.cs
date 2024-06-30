using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnemy : BaseEnemy
{
    [SerializeField] protected ParticleSystem deathEffect;

    protected override void Start()
    {
        GameObject playerRefrence = GameObject.FindGameObjectWithTag("Player");
        if (playerRefrence != null)
        {
            player = playerRefrence.GetComponent<Player>();
        }

        enemyHealth = 20f;

        Debug.Log("Exploding Enemy HP " + enemyHealth);
    }


    protected override void Update()
    {
        FollowPlayer(2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player")) //if an enemy collides with the player run the explode funtion then deal damage. 
        {
            Explode();
            DealDamage(10f);


        }
    }




    private void Explode() //explode function for ExplodingEnemy
    {
        Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }


    
}
