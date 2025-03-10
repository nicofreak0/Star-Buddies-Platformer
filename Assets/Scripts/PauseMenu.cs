using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject playButton;
    public GameObject buttons;

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Pause() 
    { 
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        EventSystem.current.SetSelectedGameObject(playButton);
        buttons.SetActive(false);
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        buttons.SetActive(true);
    }
}
