using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarScore : MonoBehaviour
{
    public int Puntaje = 1;

    void OnDestroy()
    {
        GameControler.Score += Puntaje;   
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
