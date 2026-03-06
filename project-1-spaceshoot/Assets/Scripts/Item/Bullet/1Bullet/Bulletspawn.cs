using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletspawn : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    private GameObject bulletSpawmRandom;
    public float timer;
    public float spawnInterval = 3;

    private void Start()
    {
        bulletSpawmRandom = bullet2;
    }
    void Update()
    {        
        if (Moving.isStart)
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
                spawnInterval = Random.Range(10f, 15f);
            }
        }
    }

    private void RandomSpawm()
    {
        int randomBullet = Random.Range(1, 2);
        switch (randomBullet)
        {
            case 1:
                bulletSpawmRandom = bullet2; break;
            case 2:
                bulletSpawmRandom = bullet3; break;

        }
    }
    void SpawnSpeedFood()
    {
        RandomSpawm();
        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPoint = new Vector3(randomX, 6f, 0f);
        Instantiate(bulletSpawmRandom, spawnPoint, Quaternion.identity);
    }
}
