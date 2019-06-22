using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public Camera playerCamera;
	public PlayerController player;
	public EnemyController enemy;
	public BulletCOntroller bullets;

    public GameObject countDownPanel;
	public GameObject gameOverText;

	public GameObject RetryCanvas;

	public GameObject ClearCanvas;
	public Text countDown;

	public GameObject gunModel;

	float distance=7;

	private float counttime=5;

	// Use this for initialization
	void Start () {
		gameOverText.SetActive(false);
		RetryCanvas.SetActive(false);
		ClearCanvas.SetActive(false);
		enemy.enabled=false;
		bullets.enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
		if(countDownPanel.activeSelf){
			if(counttime<0){
				countDownPanel.SetActive(false);
			}
			countDown.text=""+(int)counttime;
			counttime-=Time.deltaTime;
		}else{
			enemy.enabled=true;
			bullets.enabled=true;
		}
		
		if(player.GetLife()<=0){
			player.enabled=false;
			enemy.enabled=false;
			bullets.enabled=false;
			gameOverText.SetActive(true);
			RetryCanvas.SetActive(true);
			SetTextPosition();
			saveScore();
		}
		if(enemy.getClear()){
			player.enabled=false;
			enemy.enabled=false;
			bullets.enabled=false;
			ClearCanvas.SetActive(true);
		}
		SetGunPosition();
	}

	void SetTextPosition(){
		float cameraRotation=playerCamera.transform.localEulerAngles.y;
		gameOverText.transform.position=new Vector3(distance*Mathf.Sin(cameraRotation*(Mathf.PI/180)),
		 1.4f,
		 distance*Mathf.Cos(cameraRotation*(Mathf.PI/180)));
		 gameOverText.transform.LookAt(playerCamera.transform);
		 gameOverText.transform.Rotate(0,180,0);
	}

	void SetGunPosition(){
		float nowPosition=0.65f;
		float cameraRotation=playerCamera.transform.localEulerAngles.y;
		gunModel.transform.position=new Vector3(nowPosition*Mathf.Sin(cameraRotation*(Mathf.PI/180)),
		 -0.3f,
		 nowPosition*Mathf.Cos(cameraRotation*(Mathf.PI/180)));
		 gunModel.transform.LookAt(playerCamera.transform);
		 gunModel.transform.Rotate(0,-90,-45);
	}

	void saveScore(){
		if(ModeSelectController.getMode()==0){
		}else{
			int ecount=enemy.getEnemyCount();
			if(PlayerPrefs.GetInt("HighScore")<ecount){
				PlayerPrefs.SetInt("HighScore",ecount);
			}
		}
	}
}
