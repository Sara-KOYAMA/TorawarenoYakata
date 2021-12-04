using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class No_open : MonoBehaviour
{
    public AudioClip DoorSound;
    private AudioSource openSoundSource;

    // Start is called before the first frame update
    void Start()
    {
        openSoundSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        openSoundSource.PlayOneShot(DoorSound);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            openSoundSource.PlayOneShot(DoorSound);
        }
       
    }

}
