using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSinEnemy : MonoBehaviour
{
    private static SpawnSinEnemy instance;
    public static SpawnSinEnemy Instance { get => instance; }

    public GameObject spawnEnemy;
    public float time;
    public float timer;
    public float spawnTime = 5f;
    public float spawnInterval = 1f;
    public int maxEnemy = 4;
    public int amoutEnemy;
    public int amout;
    private bool start = false;
    public Transform[] posionSpawn;


    private void Start()
    {
        amoutEnemy = maxEnemy;
        amout = maxEnemy;
        start = false;
    }

    // Update is called once per frame    
    void Update()
    {
        if (Moving.isStart)
        {
            if (!start)
            {
                timer += Time.deltaTime;
                if (timer >= spawnTime)
                {
                    start = true;
                }

            }
            else if (start)
            {
                if (amoutEnemy > 0)
                {
                    time += Time.deltaTime;
                    if (time >= spawnInterval)
                    {
                        if (amoutEnemy > 0)
                        {
                            amoutEnemy -= 1;
                            EnemySpawner();
                            time = 0;
                        }
                    }
                }
                if (SinMove.destroy)
                {
                    amout--;
                    if (amout <= 0)
                    {
                        StartCoroutine(Revice());
                    }
                    SinMove.destroy = false;
                }
            }
            
            
        }

    }
    private IEnumerator Revice()
    {
        yield return new WaitForSeconds(5f);
        amoutEnemy = maxEnemy;
        amout = maxEnemy;
        start = false;
        timer = 0;
    }
    void EnemySpawner()
    {
        for (int i = 0; i < posionSpawn.Length; i++)
        {
            Vector3 pos = posionSpawn[i].transform.position;
            Vector3 spawnPoint = new Vector3(pos.x, pos.y, 0f);
            Instantiate(spawnEnemy, spawnPoint, Quaternion.identity);
        }
           
    }
}
