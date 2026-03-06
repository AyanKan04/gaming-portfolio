using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEffectMoving : MonoBehaviour
{
    public float speed= 5f;

    // Update is called once per frame
    void Update()
    {
        if (Moving.IsWin())
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.down * speed * Time.deltaTime, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"Va cham {other.name}");
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Boder"))
        {
            Debug.Log($"Va cham {other.name}");
            Destroy(gameObject);
        }
    }
}
