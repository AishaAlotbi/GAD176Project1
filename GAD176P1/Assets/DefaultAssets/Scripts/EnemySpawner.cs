using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] GameObject baseEnemyPrefab;
    [SerializeField] GameObject expEnemyPrefab;
    [SerializeField] Transform [] spawnPoint = new Transform [2];
    

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }


    private IEnumerator SpawnEnemy()
    {

        while (true)
        {
            Instantiate(baseEnemyPrefab, spawnPoint[0].position, Quaternion.identity);
            yield return new WaitForSeconds(1f);

            Instantiate(baseEnemyPrefab, spawnPoint[1].position, Quaternion.identity);
            yield return new WaitForSeconds(1f);

            Instantiate(baseEnemyPrefab, spawnPoint[2].position, Quaternion.identity);
            yield return new WaitForSeconds(1f);

            ///

            Instantiate(expEnemyPrefab, spawnPoint[0].position, Quaternion.identity);
            yield return new WaitForSeconds(2f);

            Instantiate(expEnemyPrefab, spawnPoint[1].position, Quaternion.identity);
            yield return new WaitForSeconds(2f);

            Instantiate(expEnemyPrefab, spawnPoint[2].position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
        

    }
}
