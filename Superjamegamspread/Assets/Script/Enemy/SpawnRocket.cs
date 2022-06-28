using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4, spawnPoint5, spawnPoint6;
    private int random;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1.0f, 1.0f);
        InvokeRepeating("Spawn", 1.5f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void Spawn()
    {
        random = Random.Range(1, 7);
        if (random == 1)
        {
            Instantiate(enemyPrefab, spawnPoint1.transform.position, enemyPrefab.transform.rotation);
        }
        else if (random == 2)
        {
            Instantiate(enemyPrefab, spawnPoint2.transform.position, enemyPrefab.transform.rotation);
        }
        else if (random == 3)
        {
            Instantiate(enemyPrefab, spawnPoint3.transform.position, enemyPrefab.transform.rotation);
        }
        else if (random == 4)
        {
            Instantiate(enemyPrefab, spawnPoint4.transform.position, enemyPrefab.transform.rotation);
        }
        else if (random == 5)
        {
            Instantiate(enemyPrefab, spawnPoint5.transform.position, enemyPrefab.transform.rotation);
        }
        else if (random == 6)
        {
            Instantiate(enemyPrefab, spawnPoint6.transform.position, enemyPrefab.transform.rotation);
        }
    }
}
