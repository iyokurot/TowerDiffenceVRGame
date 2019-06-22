using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour {

	GameObject enemy;
	EnemyController script;
     
	GameObject Bullets;
	BulletCOntroller bulletController;

	// Use this for initialization
	void Start () {
		
		enemy=GameObject.Find("Enemys");
		script=enemy.GetComponent<EnemyController>();
		Bullets=GameObject.Find("Bullets");
		bulletController=Bullets.GetComponent<BulletCOntroller>();
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(0,0,0.03f);
		if(this.transform.position.z>60){
			bulletController.DestroyBulletByObject(this.gameObject);
		}
		
	}

	void OnCollisionEnter(Collision hit){
		Destroy(this.gameObject);
		script.DeleteEnemyByBullet(hit.gameObject);
	}
}
