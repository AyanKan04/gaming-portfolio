using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpawn : MonoBehaviour
{    
    public GameObject goldPrefap;
    public float timePast;
    public float timer;
    public float spawnInterval = 3f;
    public static bool isGameOver = false;
    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            timePast += Time.deltaTime;
            timer += Time.deltaTime;

            if (timePast >= 5)
            {
                if (spawnInterval > 1)
                {
                    spawnInterval -= 0.5f;
                }
                timePast = 0;
            }

            if (timer >= spawnInterval)
            {
                SpawnGold();
                timer = 0;
            }
        }
        
    }

    void SpawnGold()
    {

        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPoint = new Vector3(randomX,6f,0f);
        Instantiate(goldPrefap,spawnPoint,Quaternion.identity);
    }
    public static void SetGameOver()
    {
        isGameOver = true;
    }
}
