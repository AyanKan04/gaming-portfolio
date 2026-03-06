using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomSpawn : MonoBehaviour
{    
    public GameObject boomPrefap;
    public float timer;
    public float spawnInterval = 10f;
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
                SpawnBoom();
                timer = 0;
                randomX = 0;
            }
            if (randomX == 0)
            {
                spawnInterval = Random.Range(6f, 10f);
            }

        }
    }

    void SpawnBoom()
    {
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPoint = new Vector3(randomX,6f,0f);
        Instantiate(boomPrefap, spawnPoint,Quaternion.identity);
    }
    public static void SetGameOver()
    {
        isGameOver = true;
    }
}
