using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI totalScore;
    public static int score = 0;
    public static int saveScore;

    public static void UpdateScore(int amout)
    {
        score += amout;
    }
    private void Start()
    {
        saveScore = score;
        
    }
    // Update is called once per frame
    void Update()
    {
        textScore.text = $"Score: {score}";
        if (HealthManager.health<=0)
        {
            totalScore.text = $"Score: {score}";
            saveScore = 0;
        }
    }

}
