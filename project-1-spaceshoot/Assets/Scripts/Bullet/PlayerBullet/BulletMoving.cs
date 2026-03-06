using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoving : MonoBehaviour
{
    public float speedBullet;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0f, speedBullet);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy")|| other.gameObject.CompareTag("Meteo") || other.gameObject.CompareTag("Boder") || other.gameObject.CompareTag("Boss"))
        {
            //Debug.Log($"va cham {other.name} va huy {gameObject.name}");
            Destroy(gameObject);
        }        
    }
}
