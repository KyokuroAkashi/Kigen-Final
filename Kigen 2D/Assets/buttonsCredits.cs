using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonsCredits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Menu ()
    {
        Application.LoadLevel(0);
    }

    public void Boss()
    {
        Application.LoadLevel(2);
    }

}
