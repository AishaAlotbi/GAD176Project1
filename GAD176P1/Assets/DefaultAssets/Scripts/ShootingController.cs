using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject spawnPoint;
    

    
    void Start()
    {
       
    }

    
    void Update()
    {
        FireBullet();
    }


    void FireBullet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, spawnPoint.transform.position, spawnPoint.transform.rotation);
            

            
   

        }

    }








}
