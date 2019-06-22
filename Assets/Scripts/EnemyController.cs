using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	private  int gameModeNum;//0:Normal,1:endress
	public GameObject enemy;
	public List<EnemyItem>enemyList=new List<EnemyItem>();

	private float enemyDistance=50;
	public float appearTime;
	private float timeElased;
	public int enemylife;

	private int enemyCount=10;
	private int lastEnemyCount;

	private bool isClear;
	public Text enemyCountText;

	// Use this for initialization
	void Start () {
		isClear=false;
		gameModeNum=ModeSelectController.getMode();
		if(gameModeNum==0){
			StartNmode();
		}else{
			StartEndress();
		}
	}

	void StartNmode(){
		lastEnemyCount=enemyCount;
		UpdateEnemys();
	}
	void StartEndress(){
		lastEnemyCount=0;
		UpdateEnemysEndress();
	}
	
	// Update is called once per frame
	void Update () {
		timeElased+=Time.deltaTime;
		if(timeElased>=appearTime){
			if(gameModeNum==0){
				UpdateEnemys();
			}else{
				UpdateEnemysEndress();
			}
			
			timeElased=0.0f;
		}
		enemyCountText.text="Enemy : "+lastEnemyCount;
	}

	void UpdateEnemys(){
		if(enemyCount>0){
			GameObject newEnemy=GenerateEnemy();
			EnemyItem newEnemyItem=new EnemyItem(newEnemy,enemylife);
			enemyList.Add(newEnemyItem);
			enemyCount--;
		}else{
		}
	}

	void UpdateEnemysEndress(){
		GameObject newEnemy=GenerateEnemy();	
		EnemyItem newEnemyItem=new EnemyItem(newEnemy,enemylife);
		enemyList.Add(newEnemyItem);
	}

	GameObject GenerateEnemy(){
		float rotationE=Random.Range(0,360);
		GameObject newEnemy=(GameObject)Instantiate(
			enemy,
			new Vector3(enemyDistance*Mathf.Sin(rotationE*(Mathf.PI/180)),0,
			enemyDistance*Mathf.Cos(rotationE*(Mathf.PI/180))),
			Quaternion.identity
		);
		newEnemy.transform.Rotate(0,rotationE,0);
		return newEnemy;
	}

	public void DeleteEnemyByBullet(GameObject deleteEnemy){
		EnemyItem damageEnemy=getItem(deleteEnemy);
		damageEnemy.setLife(damageEnemy.getlife()-1);
		if(damageEnemy.getlife()<=0){
			enemyList.Remove(damageEnemy);
			Destroy(damageEnemy.getEnemy());
			if(gameModeNum==0){
				destroyAfter();
			}else{
				destroyAfterEternal();
			}
		}
	}

	void destroyAfter(){
		lastEnemyCount--;
			if(lastEnemyCount<=0){
				enemyCountText.text="Enemy : "+lastEnemyCount;
				isClear=true;
			}
	}
	void destroyAfterEternal(){
		lastEnemyCount++;
	}

	public void DeleteEnemy(GameObject deleteEnemy){
		enemyList.Remove(getItem(deleteEnemy));
		Destroy(deleteEnemy);
	}

	private EnemyItem getItem(GameObject go){
		foreach(EnemyItem item in enemyList){
			if(item.getEnemy().Equals(go)){
				return item;
			}
		}
		return null;
	}
	public bool getClear(){
		return isClear;
	}

	public int getEnemyCount(){
		if(gameModeNum==0){
			return 0;
		}else{
			return lastEnemyCount;
		}
	}
}
