using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoMoving : MonoBehaviour
{
    public float meteoSpeed= 5f;
    
    public int index = 5;


    // Update is called once per frame
    void Update()
    {
        if (Moving.IsWin())
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector3.down * meteoSpeed * Time.deltaTime, 0f);
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
        if (other.gameObject.CompareTag("Bullet"))
        {
            index -= 1;
            if (index <= 0)
            {
                Debug.Log($"va cham {other.name} va huy {gameObject.name}");
                Destroy(gameObject);
                ScoreManager.UpdateScore(50);
            }

        }
        if (other.gameObject.CompareTag("ShieldEffect"))
        {
            Destroy(gameObject);
        }
    }
}
