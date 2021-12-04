using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Stage_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Warp")
        {
            SceneManager.LoadScene("End_Stage_2");
        }

        if (other.gameObject.tag == "Warp_2")
        {
            SceneManager.LoadScene("Stage2_3");
        }
    }
}
