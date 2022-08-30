using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_Interaction : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float speed_horizontal;
    public float speed_vertical;
    public static Animator anim;
    private bool idle_back_bool;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Flip();
        AnimationWalk();
    }

    void Flip()
    {
        if (Input.GetAxis("Horizontal") < 0)
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        if (Input.GetAxis("Horizontal") > 0)
            transform.localRotation = Quaternion.Euler(0, 180, 0);
    }

    void Move()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed_horizontal,
                   Input.GetAxis("Vertical") * speed_vertical);
    }

    void AnimationWalk()
    {
        if (Input.GetAxis("Horizontal") == 0)
            anim.SetInteger("state", 1);
        else if ((Input.GetAxis("Horizontal") != 0) && (speed_horizontal != 0))
            anim.SetInteger("state", 2);
        if ((Input.GetAxis("Vertical") < 0f) && (speed_vertical != 0))
        {
            anim.SetInteger("state", 3);
        }
        else if ((Input.GetAxis("Vertical") > 0f) && (speed_vertical != 0))
            anim.SetInteger("state", 4);
    }
}
