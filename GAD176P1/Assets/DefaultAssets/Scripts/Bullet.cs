using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 5f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float moveby = speed * Time.deltaTime;
        transform.position += transform.up * moveby;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            BaseEnemy enemy = collision.GetComponent<BaseEnemy>();

            enemy.TakeDamage(5f);
            Debug.Log("enemy took damage!");

            Destroy(gameObject);

        }




    }






}
