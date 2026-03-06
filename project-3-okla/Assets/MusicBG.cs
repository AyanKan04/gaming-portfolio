using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBG : MonoBehaviour
{
    private static bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        if (!isGameOver)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        }
    }
    public static void SetGameOver()
    {
        isGameOver = true;
    }
}
