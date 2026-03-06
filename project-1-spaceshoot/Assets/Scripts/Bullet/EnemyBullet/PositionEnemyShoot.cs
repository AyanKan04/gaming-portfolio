using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionEnemyShoot : MonoBehaviour
{
    public float speedShoot = 5f;
    public GameObject bullet;
    private bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        if (Moving.isStart)
        {
            if (canShoot)
            {
                StartCoroutine(Shoot());
            }
        }
    }
    IEnumerator Shoot()
    {
        canShoot = false;
        Instantiate(bullet, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(speedShoot);
        canShoot = true;
    }
}
