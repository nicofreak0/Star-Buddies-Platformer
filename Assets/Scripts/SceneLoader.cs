using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int sceneIndex;
    public void CallLoadScene()
    {
        Invoke("LoadScene", .3f);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
