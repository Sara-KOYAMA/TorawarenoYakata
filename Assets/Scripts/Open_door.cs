using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_door : MonoBehaviour
{
    private Animator animator;
    public AudioClip DoorSound;
    private AudioSource openSoundSource;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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
            animator.SetBool("open", true);
            openSoundSource.PlayOneShot(DoorSound);
        }
            
    }
}
