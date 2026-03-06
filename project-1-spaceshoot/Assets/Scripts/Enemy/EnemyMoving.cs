using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
   
    public float enemySpeed = 3f;
    public Transform targetPosition;
    public Rigidbody2D rb;
    public int index = 5;
    public static bool destroyE = false;
    private float maxHPEnemy;

    // Start is called before the first frame update
    void Start()
    {
        maxHPEnemy = index;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.transform.position, enemySpeed * Time.deltaTime);
        //rb.velocity = new Vector2(0f,-enemySpeed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("ShieldEffect"))
        {
            index -= 1;
            if (index <= 0)
            {

                Destroy(gameObject);
                destroyE = true;
                ScoreManager.UpdateScore(120);
            }

        }

    }
    public float GetHpPercent()
    {
        return index / maxHPEnemy;
    }

}
