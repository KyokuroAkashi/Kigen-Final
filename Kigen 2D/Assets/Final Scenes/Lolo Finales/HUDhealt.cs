using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDhealt : MonoBehaviour {

    public Sprite[] HeartSprites;

    public Image katanKigen;

    public Player player;
    
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        katanKigen.sprite = HeartSprites[player.currentHealth];
		
	}
}
