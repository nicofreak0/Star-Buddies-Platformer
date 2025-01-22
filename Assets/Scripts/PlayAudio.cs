using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAudio : MonoBehaviour
{
    public AudioClip audioClip;
    public Slider masterSlider, musicSlider, sfxSlider;
    public void PlayUISound()
    {
        AudioManager.Instance.PlayOneShot(audioClip);
    }
    // Start is called before the first frame update
    void Start()
    {
       if(masterSlider !=null)
        {
            masterSlider.value = PreferencesManager.GetMasterVolume();
        }

        if (musicSlider != null)
        {
            musicSlider.value = PreferencesManager.GetMusicVolume();
        }

        if (sfxSlider != null)
        {
            sfxSlider.value = PreferencesManager.GetSFXVolume();
        }
    }

    public void ChangeMasterVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeMasterVolume(soundLevel);
    }
    public void ChangeMusicVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeMusicVolume(soundLevel);
    }
    public void ChangeSFXVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeSFXVolume(soundLevel);
    }

    public void MuteAudio()
    {
        AudioManager.Instance.MuteAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
