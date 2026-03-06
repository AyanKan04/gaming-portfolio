using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsPanel;

    private void Start()
    {
        AudioManager.instance.PlayMusic("Menu");
    }
    public void PlayButton()
    {

        HealthManager.health = 5;
        ScoreManager.score = 0;
        SceneManager.LoadScene("GamePlay1");
        Moving.setupGun = 1;
        Time.timeScale = 1f;
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void SettingsButton()
    {
        settingsPanel.SetActive(true);
    }
    public void BackButton()
    {
        settingsPanel.SetActive(false);
    }
}
