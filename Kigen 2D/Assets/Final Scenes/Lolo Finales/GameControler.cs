using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControler : MonoBehaviour
{
    public static int Score = 0;
    public string ScoreString = "Score";


    public Text textScore;

    public static GameControler Gamecontroller;

    void Awake()
    {
        Gamecontroller = this;  
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (textScore != null)
        {
            textScore.text = ScoreString + Score.ToString();
        }
	}
}
