using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{

    public int damage = 20;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.isTrigger != true && col.CompareTag("deadly"))
        {
            col.SendMessageUpwards("Damage", damage);
        }
    }

}

