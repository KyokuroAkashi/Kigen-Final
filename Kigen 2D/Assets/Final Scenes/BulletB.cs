using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletB : MonoBehaviour {

    public Collider2D col;
    private float TimeEx = 0;
    private float MaxTime = 0;
    private float TimePassed = 0;

    // Use this for initialization
    void Start () {

        MaxTime = Time.time - TimePassed;
        TimePassed = TimeEx;
		
	}
	
	// Update is called once per frame
	void Update () {
        col.enabled = true;
	}
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Enemy"))
        {

            Destroy(col.gameObject);
            Destroy(gameObject);

        }
    }
}
