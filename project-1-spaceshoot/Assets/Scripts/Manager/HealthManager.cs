using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static int health = 5;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;
    public static int saveHealth;
    public static int setupHealth;

    private void Awake()
    {
        saveHealth = health;
    }

    //void Start()
    //{
    //    saveHealth = health;
    //    health = saveHealth;
    //}
    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHearts;
            }
            else
            {
                hearts[i].sprite = emptyHearts;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    public static bool IsGameOver()
    {
        if (health <= 0)
        {
            return true;
        }
        else return false;
    }
}
