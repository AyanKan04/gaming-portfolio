using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class EnemyBulletMoving : MonoBehaviour
{
    public float speedBullet;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        if (NofiticationManager.isBoss)
        {
            speedBullet = 7f;
        }
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0f, -speedBullet);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("ShieldEffect"))
        {
            //Debug.Log($"va cham {other.name} va huy {gameObject.name}");
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Boder"))
        {
            //Debug.Log($"va cham {other.name} va huy {gameObject.name}");
            Destroy(gameObject);
        }
        
    }
}