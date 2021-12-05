using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Stage : MonoBehaviour
{
    
    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
        Debug.Log("Start");
    }

    public void EndGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        Debug.Log("End");
    }

}
