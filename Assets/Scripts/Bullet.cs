using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	Vector3 dir;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		if (lifeTime > 0) {
//			lifeTime -= Time.deltaTime;
//			if (lifeTime <= 0) {
//				Destruction ();
//			}
//		}
		if(dir!=null){
			this.gameObject.transform.Translate (dir);


		}
	}
	public void setDir(Vector3 dir){

		this.dir = dir;

	}
}
