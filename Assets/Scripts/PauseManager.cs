using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PauseManager : MonoBehaviour
{

    public PauseMenu pauseMenu;
    public GameObject onScreenControls;


    // Start is called before the first frame update
    void Start()
    {
    }

    public void EnableDisableOnScreenControls(bool newValue)
    {
        onScreenControls.SetActive(newValue);
    }

    public void OnPause(InputValue value)
    {
        pauseMenu.Pause();
        EnableDisableOnScreenControls(false);
        Debug.Log("anything");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
