using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReducedTimeSpawn : MonoBehaviour
{    
    public GameObject reducedTimePrefap;
    public float timer;
    public float spawnInterval = 13f;
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
                SpawnReducedTime();
                timer = 0;
                randomX = 0;
            }
            if (randomX == 0)
            {
                spawnInterval = Random.Range(6f, 10f);
            }

        }
    }

    void SpawnReducedTime()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPoint = new Vector3(randomX,6f,0f);
        Instantiate(reducedTimePrefap, spawnPoint,Quaternion.identity);
    }
    public static void SetGameOver()
    {
        isGameOver = true;
    }
}
