using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelectController : MonoBehaviour {

	private bool counter;
	private float time;

	public static int gameMode;

	// Use this for initialization
	void Start () {
		counter=false;
		time=0;
	}
	
	// Update is called once per frame
	void Update () {
		if(counter){
			time+=Time.deltaTime;
			if(time>=2){
				if(gameObject.transform.name=="Normal"){
					gameMode=0;
					SceneManager.LoadScene("Game");
				}else
				if(gameObject.transform.name=="Endress"){
					gameMode=1;
					SceneManager.LoadScene("Game");
				}else{

				}
			}
		}
	}

	public void enterPointer(){
		Debug.Log("Enter Pointer");
		counter=true;
	}

	public void exitPointer(){
		Debug.Log("Exit POinter");
		counter=false;
		time=0;
	}

	public static int getMode(){
		return gameMode;
	}
}
