using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameObject1 = GameObject.FindGameObjectWithTag("Text");
        Debug.Log("gameObject1: " + gameObject1.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
