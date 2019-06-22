using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControllScene : MonoBehaviour {

	private bool counter;
	private float time;

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
				if(gameObject.transform.name=="TopButton"){
					//SceneManager.LoadScene("Title");
					SceneManager.LoadScene("ModeSelect");
				}else
				if(gameObject.transform.name=="RetryButton"){
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

}
