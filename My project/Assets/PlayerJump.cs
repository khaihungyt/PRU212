using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private Rigidbody2D rb;
    public float force=10;
    private bool isGround = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isGround)
        {
            rb.velocity = new Vector2(rb.velocity.x,force);
            isGround = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
