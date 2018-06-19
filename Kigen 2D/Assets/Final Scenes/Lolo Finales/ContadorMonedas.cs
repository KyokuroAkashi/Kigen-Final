using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorMonedas : MonoBehaviour
{
    public static int Monedas = 0;
    public string monedasString = "monedas";

    public Text TextMonedas;
    public static ContadorMonedas contadorMonedas;

    void Awake()
    {
        contadorMonedas = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (TextMonedas != null)
        {
            TextMonedas.text = monedasString + Monedas.ToString ();
        }
	}
}
