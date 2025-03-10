using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PauseManager : MonoBehaviour
{

    public PauseMenu pauseMenu;


    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnPause(InputValue value)
    {
        pauseMenu.Pause();
        Debug.Log("anything");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
