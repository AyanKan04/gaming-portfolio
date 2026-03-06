using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionShoot : MonoBehaviour
{
    public float speedShoot = 0.2f;
    public GameObject bullet;
    private bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        if (Moving.isStart)
        {
            if (!Moving.IsWin())
            {
                if (canShoot)
                {
                    AudioManager.instance.PlaySFX("Shoot");
                    StartCoroutine(Shoot());
                }
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
