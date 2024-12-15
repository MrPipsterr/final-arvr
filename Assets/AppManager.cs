using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    public string SceneName;
    
    public void MulaiGame()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void KeluarAplikasi()
    {
        Application.Quit();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

}
