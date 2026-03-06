using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldMoving : MonoBehaviour
{
    public float speedShield= 5f;
    
    // Update is called once per frame
    void Update()
    {
        if (Moving.IsWin())
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.down * speedShield * Time.deltaTime, 0f);
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
