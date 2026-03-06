using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPositionMoving : MonoBehaviour
{
    public float speed = 2f;
    public GameObject[] positionLimit;
    private bool isRight = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bossPos = transform.position;
        if (bossPos.x >= positionLimit[1].transform.position.x)
        {
            isRight = false;
        }
        else if (bossPos.x <= positionLimit[0].transform.position.x)
        {
            isRight = true;
        }

        if (isRight)
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
        else
        {
            transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
        }
    }
}
