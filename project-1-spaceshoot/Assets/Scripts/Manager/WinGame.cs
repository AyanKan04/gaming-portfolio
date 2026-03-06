using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    public TextMeshProUGUI winGameText;
    public TextMeshProUGUI thanksText;
    public TextMeshProUGUI scoreText;
    private bool isEnd = false;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = $"HightScore: {ScoreManager.score}";
    }

    IEnumerator TimeText()
    {
        yield return new WaitForSeconds(3f);
        winGameText.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(false);
        thanksText.gameObject.SetActive(true);
        isEnd = true;
    }
    IEnumerator Menu()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
    }
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TimeText());
        if (isEnd)
        {
            StartCoroutine(Menu());
        }
    }
}
