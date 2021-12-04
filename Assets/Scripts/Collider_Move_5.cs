using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Move_5 : MonoBehaviour
{
    bool flag;
    float smoothTime = 3.5f;
    Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 endPos = GameObject.Find("door_collider_2").transform.position;
        if (endPos.x <= 2.5f && flag == true)
        {
            Debug.Log("b");
            Vector3 targetPos = transform.TransformPoint(new Vector3(20f, 0, 0));
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            flag = true;
            Debug.Log("a");
        }
    }
}
