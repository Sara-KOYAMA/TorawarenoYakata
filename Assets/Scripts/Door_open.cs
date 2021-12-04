using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_open : MonoBehaviour
{
    float smoothTime = 3.5f;
    Vector3 velocity = Vector3.zero;
    bool flag;
    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 endPos = GameObject.Find("Door").transform.position;
        if (endPos.x >= -0.915f && flag == true)
        {
            Vector3 targetPos = transform.TransformPoint(new Vector3(-10f, 0, 0));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            flag = true;
        }
    }

}
