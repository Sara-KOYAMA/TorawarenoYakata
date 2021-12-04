using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private Animator animator;
    private bool input;
    private Vector2 lastMove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        input = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            input = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            input = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        animator.SetFloat("x", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("y", Input.GetAxisRaw("Vertical"));
        animator.SetBool("Input", input);
        animator.SetFloat("LastMove_X", lastMove.x);
        animator.SetFloat("LastMove_Y", lastMove.y);
    }


}
