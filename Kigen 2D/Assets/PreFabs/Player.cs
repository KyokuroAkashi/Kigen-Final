using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float topSpeed = 10f;

    bool facingRight = true;

    Animator anim;

    bool grounded = false;

    bool running = false;

    public Transform groundCheck;

    float groundRadius = 0.2f;

    public float jumpForce = 700f;

    public LayerMask WhatIsGround;

    public int currentHealth;
    public int maxHealth = 5;

    public Collider2D CP;



    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    void Update()
    {

        Running();

        Jumping();

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Ground", false);


            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            Die();
        }

    }

    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, WhatIsGround);

        anim.SetBool("Ground", grounded);

        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

        float move = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * topSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    private void Running()
    {
        if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.A)))
        {
            anim.SetBool("Running", true);
        }
        if (Input.GetKeyUp(KeyCode.D) || (Input.GetKeyUp(KeyCode.A)))
        {
            anim.SetBool("Running", false);
        }
    }

    private void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("Jump", false);
        }
    }

    public void OnCollisionEnter2D(Collision2D CP)
    {
        if (CP.gameObject.CompareTag("Finish"))
        {
            Application.LoadLevel(1);
        }
    }
}




    

   