using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator anim;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Horizontal"))
        {
            spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }

        if(Input.GetButton("Horizontal"))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetInteger("state", 2);
            }
            else
            {
                anim.SetInteger("state", 1);
            }
        }
        else
        {
            anim.SetInteger("state", 0);
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            anim.SetInteger("state", 5);
        }
    }

    private void FixedUpdate()
    {
         
    }
}
