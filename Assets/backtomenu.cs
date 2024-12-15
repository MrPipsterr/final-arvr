using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class backtomenu : MonoBehaviour {

    public string SceneName;

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneName);
    }

}