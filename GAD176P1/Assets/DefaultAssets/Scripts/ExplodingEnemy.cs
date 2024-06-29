using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnemy : BaseEnemy
{
    

    // Update is called once per frame
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

    protected void Explode() //explode function for ExplodingEnemy
    {
        Destroy(gameObject);
    }


    
}
