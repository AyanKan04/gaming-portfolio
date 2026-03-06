using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpawn : MonoBehaviour
{    
    public GameObject deadPrefap;
    public float timer;
    public float spawnInterval = 5.5f;
    public static int spawnCount = 1;
    public static bool isGameOver = false;


    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            float randomX = spawnInterval;
            timer += Time.deltaTime;
            if (timer >= randomX)
            {
                SpawnDead();
                timer = 0;
                randomX = 0;
            }
            if (randomX == 0)
            {
                spawnInterval = Random.Range(5f, 7f);
            }

        }
    }
   
    void SpawnDead()
    {
        int randomPointX = spawnCount;
        float randomY = Random.Range(-3.5f, -1f);
        Vector3 spawnPoint;
        if (randomPointX % 2 != 0)
        {
            spawnPoint = new Vector3(10f, randomY, 0f);
        }
        else
        {
            spawnPoint = new Vector3(-10f, randomY, 0f);
        }
        Instantiate(deadPrefap, spawnPoint, Quaternion.identity);
        spawnCount = Random.Range(1, 4);
    }
    public static void SetGameOver()
    {
        isGameOver = true;
    }
}
