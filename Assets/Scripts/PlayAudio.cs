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
       if(masterSlider.gameObject.activeInHierarchy)
        {
            masterSlider.value = PreferencesManager.GetMasterVolume();
        }

        if (musicSlider.gameObject.activeInHierarchy)
        {
            musicSlider.value = PreferencesManager.GetMusicVolume();
        }

        if (sfxSlider.gameObject.activeInHierarchy)
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
