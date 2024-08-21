using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour
{
    private Rigidbody2D characterRigidbody;

    bool isonAir;

    [SerializeField]
    float PointSec = 1.0f;
    float NextSec = 0.0f;

    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Time.time > NextSec)
        {
            NextSec = Time.time + PointSec;

            if (isonAir)
            {
                characterRigidbody.gravityScale += 9.8f;
            }
            else { characterRigidbody.gravityScale = 9.8f; }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isonAir = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isonAir = true;
    }
}
