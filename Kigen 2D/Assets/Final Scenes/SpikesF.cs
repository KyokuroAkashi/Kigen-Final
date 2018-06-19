using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesF : MonoBehaviour
{
    private Player player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Die();
        }
    }
    void Die()
    {
        Application.LoadLevel(3);
    }

}