using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedFoodSpawn : MonoBehaviour
{    
    public GameObject speedFoodPrefap;
    public float timer;
    public float spawnInterval = 5;
    public static bool isGameOver = false;

    void Update()
    {
        if (!isGameOver)
        {
            float randomX = spawnInterval;
            timer += Time.deltaTime;            
            if (timer >= randomX)
            {
                SpawnSpeedFood();
                timer = 0;
                randomX = 0;
            }
            if (randomX == 0)
            {
                spawnInterval = Random.Range(7f, 15f);
            }
        }
        
    }

    void SpawnSpeedFood()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPoint = new Vector3(randomX,6f,0f);
        Instantiate(speedFoodPrefap, spawnPoint,Quaternion.identity);
    }
    public static void SetGameOver()
    {
        isGameOver = true;
    }
}
