using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NofiticationManager : MonoBehaviour
{
    public TextMeshProUGUI level;
    public TextMeshProUGUI keybControl;
    public GameObject keybPanel;
    private int indexLevel = 1;
    public static bool isBoss = false;
    //public static string currentScene = SceneManager.GetActiveScene().name;

    void Start()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        switch (currentScene)
        {
            case ("GamePlay1"): indexLevel = 1; break;
            case ("GamePlay2"): indexLevel = 2; break;
            case ("GamePlay3"): indexLevel = 3; break;
        }
        if (currentScene == "GamePlay1")
        {
            keybControl.text = "ADWS --- Moving";
            keybPanel.SetActive(true);
        }
        else
        {
            keybPanel.SetActive(false);
        }


        if (currentScene == "GamePlay4")
        {
            level.text = "Boss!!!";
            isBoss = true;
        }
        else
        {
            level.text = $"Level {indexLevel}";
            isBoss = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TimeStart());


        if (Moving.isStart)
        {
            level.gameObject.SetActive(false);
        }
    }
    
     private IEnumerator TimeStart()
    {
        yield return new WaitForSeconds(2f);
        if (!Moving.isStart)
        {
            keybPanel.SetActive(false);
            level.gameObject.SetActive(true);
        }        
    }

}
