using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance; // Singleton instance

    public AudioSource oneShotSource; // AudioSource for one-shot sounds
    public AudioMixer masterMixer;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persist across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }

    public void ChangeMasterVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVolume", soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }
    public void ChangeMusicVolume(float soundLevel)
    {
        masterMixer.SetFloat("MusicVolume", soundLevel);
        PreferencesManager.SetMusicVolume(soundLevel);
    }
    public void ChangeSFXVolume(float soundLevel)
    {
        masterMixer.SetFloat("SFXVolume", soundLevel);
        PreferencesManager.SetSFXVolume(soundLevel);
    }

    public void PlayOneShot(AudioClip clip)
    {
        if (clip != null)
        {
            oneShotSource.PlayOneShot(clip);
        }
    }
}