using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class TitleController : MonoBehaviour {
	void Start(){
		XRSettings.enabled=false;
	}
	public void OnStartButtonClicked(){
		XRSettings.enabled=true;
		Application.LoadLevel("ModeSelect");
	}
}
