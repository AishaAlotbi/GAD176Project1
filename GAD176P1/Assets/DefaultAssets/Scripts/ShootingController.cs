using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject spawnPoint;
   
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
             
    }


    void FireBullet()
    {

       Instantiate(bulletPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);

    }

}
