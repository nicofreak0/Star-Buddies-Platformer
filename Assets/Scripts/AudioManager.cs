using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance; // Singleton instance

    public AudioSource oneShotSource; // AudioSource for one-shot sounds
    public AudioSource backgroundMusic;
    public AudioMixer masterMixer;
    public bool isMuted = false;
    public AudioClip mainMenu;
    public AudioClip sceneOne;
    public AudioClip sceneTwo;
    public AudioClip sceneThree;
    public AudioClip sceneFour;
    public AudioClip sceneFive;


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
    private void Start()
    {
        backgroundMusic.clip = mainMenu;
        backgroundMusic.Play();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);

        if(backgroundMusic != null)
            backgroundMusic.Stop();

        if(scene.name == "Main Menu")
        {
            backgroundMusic.clip = mainMenu;
        }

        if (scene.name == "Scene 1 Star Buddies")
        {
            backgroundMusic.clip = sceneOne;
        }

        if (scene.name == "Scene 2 Star Buddies")
        {
            backgroundMusic.clip = sceneTwo;
        }

        if (scene.name == "Scene 3 Star Buddies")
        {
            backgroundMusic.clip = sceneThree;
        }

        if (scene.name == "Scene 4 Star Buddies")
        {
            backgroundMusic.clip = sceneFour;
        }

        if (scene.name == "CreditsScene")
        {
            backgroundMusic.clip = sceneFive;
        }

        backgroundMusic.Play();
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