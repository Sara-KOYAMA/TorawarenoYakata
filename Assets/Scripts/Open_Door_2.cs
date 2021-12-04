using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door_2 : MonoBehaviour
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
        if (other.gameObject.tag == "Player")
        {
            openSoundSource.PlayOneShot(DoorSound);
        }

    }
}
