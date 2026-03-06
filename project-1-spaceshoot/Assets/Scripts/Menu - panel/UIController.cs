using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;

    public void ToggleMusic()
    {
        AudioManager.instance.ToggleMusic();
    }
    public void ToggleSFX()
    {
        AudioManager.instance.ToggleFSX();
    }
    public void MusicVolume(float volume)
    {
        AudioManager.instance.MucsicVolume(volume);
    }
    public void FSXVolume(float volume)
    {
        AudioManager.instance.SFXVolume(volume);
    }
}
