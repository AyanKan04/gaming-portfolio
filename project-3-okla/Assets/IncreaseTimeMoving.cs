using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class IncreaseTimeMoving : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D increaseTime;
    // Update is called once per frame
    private void Start()
    {
        increaseTime = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (IncreaseTimeSpawn.isGameOver)
        {
            increaseTime.bodyType = RigidbodyType2D.Static;
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
