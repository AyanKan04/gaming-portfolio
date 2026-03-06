using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseControll : MonoBehaviour
{
    public static PauseControll instance;
    public GameObject pausePanel;
    public GameObject GameOverPanel;
    void Start()
    {
        MakeInstance();
    }
    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        HealthManager.health = HealthManager.saveHealth;
        AudioManager.instance.PlayMusic("Theme");
        ScoreManager.score = ScoreManager.saveScore;
        Time.timeScale = 1f;
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GameOver()
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
