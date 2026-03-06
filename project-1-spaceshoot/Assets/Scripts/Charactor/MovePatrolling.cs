using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePatrolling : MonoBehaviour
{
    public float speed = 3f;
    private bool moveRight = false;

    // Start is called before the first frame update
    void Start()
    {
        moveRight = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 3)
        {
            moveRight = false;
        }
        else if (transform.position.x <= -1.5f)
        {
            moveRight = true;
        }
        if (moveRight)
        {
            transform.position += new Vector3(transform.position.x * speed * Time.deltaTime, transform.position.y, 0f);
        }
        else if (!moveRight)
        {
            transform.position += new Vector3(-transform.position.x * speed * Time.deltaTime, transform.position.y, 0f);
        }
    }
}
