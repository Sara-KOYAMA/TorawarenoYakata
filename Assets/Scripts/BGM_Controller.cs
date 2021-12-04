using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGM_Controller : MonoBehaviour
{
    public bool DontDestroyEnabled = true;

    // Start is called before the first frame update
    private void Awake()
    {
        int num = FindObjectsOfType<BGM_Controller>().Length;
        if (num > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
