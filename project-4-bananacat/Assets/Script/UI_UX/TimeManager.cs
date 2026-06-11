using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float timeRemaining = 30f;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private PlayerController player;

    [Header("GameOver UI")]
    [SerializeField] private GameObject gameOverPanel; // GameOverPanel

    // tham chiếu đến Joystick/ GameObject chứa Joystick
    [SerializeField] private GameObject joystickObject;

    private bool timerStarted = false;
    private bool isGameOver = false;

    void Update()
    {
        if (isGameOver) return;

        if (!timerStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                timerStarted = true;
            }
            return;
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            UpdateTimerDisplay(0);
            GameOver();
        }
    }

    void UpdateTimerDisplay(float timeToDisplay)
    {
        int seconds = Mathf.FloorToInt(timeToDisplay);
        int miliseconds = Mathf.FloorToInt((timeToDisplay - seconds) * 100);
        timeText.text = string.Format("{0:00}:{1:00}", seconds, miliseconds);
    }

    void GameOver()
    {
        isGameOver = true;

        if (player != null)
        {
            player.SetCanMove(false);
        }

        // TẮT JOYSTICK NGAY LẬP TỨC
        if (joystickObject != null)
        {
            joystickObject.SetActive(false);
        }

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
        // ---------------------

        timeText.color = Color.red;
        AudioSource bgm = GameObject.Find("MusicSource").GetComponent<AudioSource>();
        bgm.volume = 0.2f;
    }
}