using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveAnimation : MonoBehaviour
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
            anim.SetInteger("state", 1);
        }
        else
        {
            anim.SetInteger("state", 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("isrun", true);
        }
        else
        {
            anim.SetBool("isrun", false);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetInteger("state", 3);
        }
    }

    private void FixedUpdate()
    {
         
    }
}
