using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneLink : MonoBehaviour {

    public Collider2D CP;

	// Use this for initialization
	void Start () {

        CP.enabled = true;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D CP)
    {
        if (CP.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel (1);
        }
    }
}
