using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    private Player player;

    private bool attacking = true;

    private float attackTimer = 0;
    private float attackCd = 0.3f;

    public bool attack;

    public Collider2D attackTrigger;
    public Collider2D col;

    Animator anim;

    // Use this for initialization
    void Awake () {
        anim = gameObject.GetComponent<Animator>();
        attackTrigger.enabled = false;
        col.enabled = true;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.F) && !attacking)
        {
            attacking = true;
            attackTimer = attackCd;

            attackTrigger.enabled = true;
        }
        if (attacking)
        {
            if (attackTimer > 0)
            {
                attackTimer -= Time.deltaTime;
            }
            else
            {
                attacking = false;
                attackTrigger.enabled = false;
            }
        }

        anim.SetBool("Attack", attacking);
	}
    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {
            if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                Destroy(col.gameObject);
            }
            if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Jump Attack"))
            {
                Destroy(col.gameObject);
            }
            else
            {
                Die();
            }
        }
        if (col.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
        }
    }
}

