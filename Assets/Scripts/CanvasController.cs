using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ShowMenu(true);
	}

	private void ShowMenu(bool isShow) {

        var canvas = transform.Find("Canvas");
        if (isShow) {
            // 自分の目の前に持ってくる(角度はすこしずらす)
            Vector3 menuLocalPos = Quaternion.Euler(0f, -30f, 0f) * Vector3.forward * 0.2f;
            Vector3 menuWorldPos = Camera.main.transform.TransformPoint( menuLocalPos ); 
            transform.position = menuWorldPos;
            // こっちを向かせる(角度調整あり)
            //transform.LookAt(Camera.main.transform.position); // ……だと何故かイベントが効かなくなる
            Vector3 menuAngle = Camera.main.transform.eulerAngles;
            transform.eulerAngles = new Vector3(menuAngle.x, menuAngle.y - 30f, menuAngle.z);
            canvas.gameObject.SetActive(true);
        } else {
            canvas.gameObject.SetActive(false);
        }

    }
}
