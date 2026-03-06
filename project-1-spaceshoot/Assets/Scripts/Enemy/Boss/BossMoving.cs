using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossMoving : MonoBehaviour
{
    public Animator animator;
    public float enemySpeed = 5f;
    public Transform targetPositionBoss;
    public Rigidbody2D rb;
    public int index = 500;
    public static bool destroyE = false;
    private float maxHPEnemy;

    // Start is called before the first frame update
    void Start()
    {
        maxHPEnemy = index;
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPositionBoss.transform.position, enemySpeed * Time.deltaTime);
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
                ScoreManager.UpdateScore(15000);
            }

        }

    }
    public float GetHpPercent()
    {
        return index / maxHPEnemy;
    }
}
