using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance; // Singleton instance

    public AudioSource oneShotSource; // AudioSource for one-shot sounds
    public AudioMixer masterMixer;
    public bool isMuted = false;
    public AudioClip mainMenu;
    public AudioClip sceneOne;
    public AudioClip sceneTwo;
    public AudioClip sceneThree;
    public AudioClip sceneFour;


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

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);

        if(scene.name == "Main Menu")
        {

        }
    }

    public void ChangeMasterVolume(float soundLevel)
    {
        masterMixer.SetFloat("MasterVolume", soundLevel);
        PreferencesManager.SetMasterVolume(soundLevel);
    }

    public void MuteAudio()
    {
       
        if (isMuted)
        {
            masterMixer.SetFloat("MasterVolume", PreferencesManager.GetMasterVolume());
            masterMixer.SetFloat("MusicVolume", PreferencesManager.GetMusicVolume());
            masterMixer.SetFloat("SFXVolume", PreferencesManager.GetSFXVolume());

            isMuted = false;
        }
        else
        {
            masterMixer.SetFloat("MasterVolume", -80);
            masterMixer.SetFloat("MusicVolume", -80);
            masterMixer.SetFloat("SFXVolume", -80);
            isMuted = true;
        }
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