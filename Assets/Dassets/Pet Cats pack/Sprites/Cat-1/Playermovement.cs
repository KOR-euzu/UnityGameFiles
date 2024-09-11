using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField]
    public float movePower = 1f;
    [SerializeField]
    public float sprintProportion =2f;
    [SerializeField]
    public float jumpPower = 6f;
    private Rigidbody2D characterRigidbody;


    Vector3 movement;
    bool isJumping = false;

    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float inspeed = Input.GetAxis("Horizontal");

        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += new Vector3(sprintProportion * inspeed * movePower * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position += new Vector3(inspeed * movePower * Time.deltaTime, 0, 0);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (!isJumping)
            {
                characterRigidbody.AddForce(Vector2.up * jumpPower * 10, ForceMode2D.Impulse);
                isJumping = true;
                Debug.Log("isjumping == true");
            }
        }

        //characterRigidbody.velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Floor"))
        {
            isJumping = false;
            Debug.Log("isjumping == false");
        }
    }
}
