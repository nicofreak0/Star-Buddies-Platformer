using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void CallPlayGame()
    {
        Invoke("PlayGame", .3f);
    }

    public void PlayGame()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
