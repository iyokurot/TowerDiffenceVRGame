using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreController : MonoBehaviour {
	public Text highscoreLabel;

	// Use this for initialization
	void Start () {
		highscoreLabel.text="High Score : "+PlayerPrefs.GetInt("HighScore");		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
