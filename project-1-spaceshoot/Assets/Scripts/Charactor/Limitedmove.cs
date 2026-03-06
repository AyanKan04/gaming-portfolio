using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limitedmove : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 bonus = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));

        minX = -bonus.x;
        maxX = bonus.x;
        minY = -bonus.y;
        maxY = bonus.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Moving.isStart)
        {
            Vector3 temp = transform.position;
            if (temp.x < minX)
            {
                temp.x = minX;
            }
            else if (temp.x > maxX)
            {
                temp.x = maxX;
            }
            if (temp.y < minY)
            {
                temp.y = minY;
            }
            else if (temp.y > maxY)
            {
                temp.y = maxY;
            }
            transform.position = temp;
        }
        
    }
}
