using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpawn1 : MonoBehaviour
{    
    public GameObject deadPrefap;
    public float timer;
    public float spawnInterval = 5.5f;
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
        
        float randomY = Random.Range(-3.5f, -1f);
        Vector3 spawnPoint = new Vector3(-10f, randomY, 0f);
        Instantiate(deadPrefap, spawnPoint,Quaternion.identity);
    }
    public static void SetGameOver()
    {
        isGameOver = true;
    }
}
