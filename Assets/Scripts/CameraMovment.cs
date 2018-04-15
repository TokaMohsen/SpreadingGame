using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour {

	//Camera mycam;
	// Use this for initialization
	public Camera myMainCamera;
	CameraShaker CameraShakerscript;

	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;

	void Start()
	{
		myMainCamera = Camera.main;
	}
	void Update () {
		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
	}

	void OnCollisionEnter(Collision coll) {
		if(coll.gameObject.tag == "enemy") {
			Debug.Log ("enemy hitted "+ coll.gameObject.name);
			CameraShakerscript = myMainCamera.GetComponent<CameraShaker>();
			CameraShakerscript.shouldShake = true;
			Destruction(coll.gameObject);
		}
	}

	void Destruction(GameObject destObj) {
		Destroy(destObj);
	}
}
