using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCOntroller : MonoBehaviour {
	public Camera camera;
	public GameObject bullet;
	public List<GameObject>generatedBulletList=new List<GameObject>();

	public float bulletTime;
	private float timeElapsed;
	public int deleteLength;
	public EnemyController enemyController;

	// Use this for initialization
	void Start () {
		UpdateBullets();
	}
	
	// Update is called once per frame
	void Update () {
		//一定秒数後生成
		timeElapsed+=Time.deltaTime;
		if(timeElapsed>=bulletTime){
			UpdateBullets();
			timeElapsed=0.0f;
		}
	}
	IEnumerator GenerateByTimeBullet(){
		yield return new WaitForSeconds(5.0f);
		UpdateBullets();
	}


	void UpdateBullets(){
		GameObject bulletObject=GenerateBullet();
		//カメラのRotate取得&カメラの向きから方向確定
		float cameraRotateY=camera.transform.localEulerAngles.y;
		bulletObject.transform.Rotate(0,cameraRotateY,0);
		bulletObject.transform.Translate(0,0,1);
		generatedBulletList.Add(bulletObject);

		//一定個数以上の弾丸を削除
		while(generatedBulletList.Count > deleteLength){
			DestroyBullet();
		}
		
		

	}
	GameObject GenerateBullet(){
		GameObject bulletObject=(GameObject)Instantiate(
			bullet,
			new Vector3(0,0,0),
			Quaternion.identity
		);
		return bulletObject;
	}

	void DestroyBullet(){
		GameObject oldBullet=generatedBulletList[0];
		generatedBulletList.RemoveAt(0);
		Destroy(oldBullet);
	}

	public void DestroyBulletByObject(GameObject deleteBullet){
		generatedBulletList.Remove(deleteBullet);
		Destroy(deleteBullet);
	}
/*
	void OnCollisionEnter(Collision hit){
		generatedBulletList.Remove(gameObject);
		Destroy(gameObject);

		enemyController.DeleteEnemy(hit.gameObject);
	}
	*/

}
