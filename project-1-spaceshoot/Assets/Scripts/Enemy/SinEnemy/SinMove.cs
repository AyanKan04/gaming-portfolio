using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove : MonoBehaviour
{
    public int index = 3;
    public float speed = 5f;
    public static bool destroy = false; 

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, -90);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, 0f);
        if (Moving.IsWin())
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            index--;
            if (index <= 0)
            {
                Destroy(gameObject);
                ScoreManager.UpdateScore(150);
            }
        }
        if (other.gameObject.CompareTag("Boder"))
        {
            Destroy(gameObject);
            destroy = true;
        }
    }
}
