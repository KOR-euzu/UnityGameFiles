using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField]
    public float movePower = 1f;
    //[SerializeField]
    //public float jumpPower = 3f;
    private Rigidbody2D characterRigidbody;


    Vector3 movement;
    bool isJumping = false;

    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
        }*/
    }

    private void FixedUpdate()
    {
        float inspeed = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.LeftShift)) // keycode ¼öÁ¤ÇØ¾ßµÊ
        {
            transform.position += new Vector3(4 * inspeed * movePower * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position += new Vector3(inspeed * movePower * Time.deltaTime, 0, 0);
        }

        characterRigidbody.velocity = Vector2.zero;

        /*if (isJumping)
        {
            characterRigidbody.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        }

        isJumping = false;*/
    }
}
