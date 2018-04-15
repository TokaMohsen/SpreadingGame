using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {

	//public float xSpread;
	//public float zSpread;
	//public float yOffset;
	//public Transform centerPoint;

	//public float rotSpeedMax;
	//public float rotSpeedMin;

	float rotSpeed=5f;
	public bool rotateClockwise;
	int RandomDir=0;
	 bool Attack=false;
	//float timer = 0;

	void Start(){
		
		rotSpeed =Random.Range (5f,30f);
		RandomDir=	Random.Range (0,2);
		Debug.Log ("RandomDir"+RandomDir);
		if (RandomDir == 0) {

			rotSpeed *= -1;
		} else {
		
			rotSpeed = Mathf.Abs (rotSpeed);
		}

	}
	// Update is called once per frame
	void Update () {
		//timer += Time.deltaTime * rotSpeed;
		if (Attack) {
			StartAttack ();
		} else {
			Rotate();		

		}
	}

	void Rotate() {

			transform.RotateAround (Camera.main.transform.position, Vector3.up, rotSpeed * Time.deltaTime);

	}
	public	void SetAtack(){
		Attack = true;
	}
	void StartAttack(){
	
	//attack
		this.transform.position= Vector3.MoveTowards(this.transform.position, Camera.main.transform.position,(rotSpeed*Time.deltaTime)/15);

	}
}















