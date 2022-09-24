using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //Loads a scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //Quits the game
    public void quitGame()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
