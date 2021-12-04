using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Event : MonoBehaviour
{
    GameObject door;
    public AudioClip DoorSound;
    private AudioSource openSoundSource;
    

    // Start is called before the first frame update
    void Start()
    {
        this.door = GameObject.Find("Door");
        openSoundSource = GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Door")
        {
            openSoundSource.PlayOneShot(DoorSound);
            Debug.Log("Open");
        }
            

        if (other.gameObject.tag == "Warp")
        {
            SceneManager.LoadScene("Corridor");
        }

       

    }
}
