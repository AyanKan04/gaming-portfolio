using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DieMoving : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D die;
    // Update is called once per frame
    private void Start()
    {
        die = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (DieSpawn.isGameOver)
        {
            die.bodyType = RigidbodyType2D.Static;
            return;
        }
        if (DieSpawn.spawnCount % 2 != 0 )
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.Translate(Vector3.left * speed * Time.deltaTime, 0f);
            if (transform.localPosition.x < -10)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.Translate(Vector3.right * speed * Time.deltaTime, 0f);
            if (transform.localPosition.x > 10)
            {
                Destroy(gameObject);
            }
        }



    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log($"Va cham {other.name}");
            Destroy(gameObject);
            Debug.Log($"Huy {gameObject.name}");
        }        
    }
}
