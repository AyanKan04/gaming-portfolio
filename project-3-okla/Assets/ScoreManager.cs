using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score = 0;
    public static float remainingTime;
    public static int missScore = 0;

    private static bool isDead = false;
    public GameObject panelGameOver;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI endGameScoreText;

    private void Start()
    {
        remainingTime = 30f;
        StartCoroutine(CountdownTimer());
    }
    private IEnumerator CountdownTimer()
    {
        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(1f);
            remainingTime--;
        }
        if (remainingTime <= 0)
        {
            GameOver();
        }
        
    }
    public static void MissScore(int amount)
    {
        missScore += amount;
    }
    public static void AddScore(int amount)
    {
        score += amount;
    }
    void Update()
    {
        if (isDead)
        {
            remainingTime = 0;
        }
        if (remainingTime < 0)
        {
            remainingTime = 0;
        }  
        scoreText.text = $"Score: {score} | Time: {Mathf.CeilToInt(remainingTime)}";
    }
    private void SetGameOver()
    {
        Moving.SetGameOver();
        GoldSpawn.SetGameOver();
        SpeedFoodSpawn.SetGameOver();
        MusicBG.SetGameOver();
        BoomSpawn.SetGameOver();
        AppleScoreSpawn.SetGameOver();
        GoldScoreUp.SetGameOver();
        DeadSpawn.SetGameOver();
        ReducedTimeSpawn.SetGameOver();
        IncreaseTimeSpawn.SetGameOver();
        DeadSpawn.SetGameOver();
        DieSpawn.SetGameOver();
    }
    public static void SetTime(int amount)
    {
        remainingTime += amount;
    }
    public static void IsDead()
    {
        isDead = true;
    }
    public void GameOver()
    {
        float toTal = score - missScore;
        if (toTal <= 0)
        {
            toTal = 0;
        }
        panelGameOver.SetActive(true);
        gameOverText.text = "Game Over!";
        endGameScoreText.text = $"Score: {score}\nMiss: {missScore}\n------------------------------------------\nTotal score: {toTal}";
        SetGameOver();
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
