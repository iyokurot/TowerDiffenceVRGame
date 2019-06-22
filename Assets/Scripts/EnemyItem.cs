using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyItem : MonoBehaviour {
	private GameObject enemy;
	private int life;

	public EnemyItem(GameObject e,int HP){
		enemy=e;
		life=HP;
	}

	public int getlife(){
		return life;
	}
	public void setLife(int life){
		this.life=life;
	}

	public GameObject getEnemy(){
		return enemy;
	}

	public void setEnemy(GameObject enemy){
		this.enemy=enemy;
	}
}
