using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	GameObject player;
	PlayerController playerController;
	public float enemySpeed;

	// Use this for initialization
	void Start () {
		player=GameObject.Find("Player");
		playerController=player.GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(0,0,-enemySpeed);
		if(!playerController.enabled){
			enabled=false;
		}
	}
}
