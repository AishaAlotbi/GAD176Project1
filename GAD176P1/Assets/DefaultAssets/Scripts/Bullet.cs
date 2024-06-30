using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }

    
  

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {

        BaseEnemy enemy = hitInfo.GetComponent<BaseEnemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(5f);


            Destroy(gameObject);

        }

        



    }
  

}
