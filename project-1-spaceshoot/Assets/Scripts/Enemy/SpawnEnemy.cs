using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject spawnEnemy;
    public float time;
    public float spawnInterval = 1f;
    public int maxEnemy;
    public Transform[] spawnTarget;
    private List<Transform> availableSpawnPoints;
    public static int amout; 


    void Start()
    {

        maxEnemy = spawnTarget.Length;
        amout = spawnTarget.Length;
        availableSpawnPoints = new List<Transform>(spawnTarget); // Copy spawnPoints to a list
    }

    // Update is called once per frame
    void Update()
    {
        if (Moving.isStart || NofiticationManager.isBoss)
        {
            time += Time.deltaTime;
            if (time >= spawnInterval)
            {
                if (maxEnemy > 0)
                {
                    maxEnemy -= 1;
                    EnemySpawner();
                    time = 0;
                }
            }

            if (EnemyMoving.destroyE || BossMoving.destroyE)
            {
                amout--;
                EnemyMoving.destroyE = false;
                BossMoving.destroyE = false;
            }
        }
        
    }
    void EnemySpawner()
    {

        float randomX = Random.Range(-8f, 8f);
        Vector3 spawnPoint = new Vector3(randomX, 6f, 0f);
        var enemySP = Instantiate(spawnEnemy, spawnPoint, Quaternion.identity);
        //random 1 position trong mang
        //int randomIndex = Random.Range(0, spawnTarget.Length);
        int randomIndex = Random.Range(0, availableSpawnPoints.Count);
        Transform randomPos = availableSpawnPoints[randomIndex];
        
        //lay vitri random
        //Transform randomPos = spawnTarget[randomIndex];
        availableSpawnPoints.RemoveAt(randomIndex);
        if (NofiticationManager.isBoss)
        {
            enemySP.GetComponent<BossMoving>().targetPositionBoss = randomPos;
        }
        else
        {
            enemySP.GetComponent<EnemyMoving>().targetPosition = randomPos;
        }
    }
}
