using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomMoving : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D boom;
    private void Start()
    {
        boom = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (BoomSpawn.isGameOver)
        {
            boom.bodyType = RigidbodyType2D.Static;
            return;
        }
        transform.Translate(Vector3.down * speed * Time.deltaTime, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"Va cham {other.name}");
            Destroy(gameObject);
            Debug.Log($"Huy {gameObject.name}");
            
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log($"Va cham {other.name}");
            Destroy(gameObject);
            Debug.Log($"Huy {gameObject.name}");
        }
    }
}
