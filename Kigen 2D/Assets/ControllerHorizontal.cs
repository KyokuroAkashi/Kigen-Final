using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerHorizontal : MonoBehaviour
{
    public int curHealth;

    public int maxHealth = 100;

    public float topSpeed = 10f;

    bool facingRight = true;

    Animator anim;

    bool grounded = false;

    bool running = false;

    public Transform groundCheck;

    public bool attack;

    float groundRadius = 0.2f;

    public float jumpForce = 700f;

    public LayerMask WwhatIsGround;

    void Start()
    {
        anim = GetComponent<Animator>();

        curHealth = maxHealth;
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

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        if (curHealth <= 0)
        {
            Die();
        }

    }

     void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, WwhatIsGround);

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
        if(Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.A)))
        {
            anim.SetBool("Running", true);
        }
        if(Input.GetKeyUp(KeyCode.D) || (Input.GetKeyUp(KeyCode.A)))
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Jump", false);
        }
    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);

    }
}


    

   