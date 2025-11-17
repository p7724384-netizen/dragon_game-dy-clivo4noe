using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaerkotroler : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jampForce = 5f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        Move();
        jamp();


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platforms"))
        {
            this.transform.parent = collision.transform;    
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            anim.SetBool("jamp", false);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platforms"))
        {
            this.transform.parent = null;
        } 

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            anim.SetBool("jamp", true);
        }
    }
    private void Move()
    {
        float horiz = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horiz * moveSpeed, rb.velocity.y);
        anim.SetBool("wolk", horiz != 0);

        if (horiz > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (horiz < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
    private void jamp()
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jampForce, ForceMode2D.Impulse);
            
            
        }
    }

}




