using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public int life;
	public EnemyController Econtroller;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision hit){
		if(hit.gameObject.tag=="Enemy"){
			Econtroller.DeleteEnemy(hit.gameObject);
			life--;
		}
	}

	public int GetLife(){
		return life;
	}
}
