using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPBar : MonoBehaviour
{
    public Image hpEnemy;
    public EnemyMoving enemySource;


    // Update is called once per frame
    void Update()
    {
        hpEnemy.fillAmount = enemySource.GetHpPercent();
    }
}
