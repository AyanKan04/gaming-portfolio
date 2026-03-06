using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleMoving1 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D apple;
    private void Start()
    {
        apple = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (AppleScoreSpawn.isGameOver)
        {
            apple.bodyType = RigidbodyType2D.Static;
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
