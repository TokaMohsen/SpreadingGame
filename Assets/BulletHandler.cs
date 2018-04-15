using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandler : MonoBehaviour {

	//public GameObject bullet;

	Ray shootRay;                                   // A ray from the gun end forwards.
	RaycastHit shootHit;                            // A raycast hit to get information about what was hit.
	int shootableMask;
	// Bullet bullet;
	public string BulletTarget = "enemy";
	public Ball ballscript;
	//public Ball ballscript;

	// Use this for initialization
	void Start () {
		//ballscript = this.GetComponent<Ball>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			Vector3 fwd = transform.forward;
			//SpawnBullet (fwd);
		
			if (Physics.Raycast (transform.position, fwd, out shootHit, 100f)) {
				if (shootHit.collider.tag == BulletTarget) {
					Debug.Log ("" + shootHit.collider.name);
					//Destroy (shootHit.collider.gameObject);
					//collision detection
					ballscript = shootHit.collider.gameObject.GetComponent<Ball>();
						ballscript.InstantiateFromThisKind(shootHit.collider.gameObject);


				}

				Debug.DrawRay (this.transform.position, fwd, Color.green, 20);

			}
		}
	}

//	void SpawnBullet(Vector3 vecDir) {
//		//Vector3 pos = RandomCircle(center, 5.0f);
//		//Quaternion rot = Quaternion.FromToRotation(Vector3.forward, transform.position);
//		//Instantiate(prefab, pos, rot);
//		//Instantiate(bullet, transform.position, rot);
//		GameObject instantiatedProjectile = Instantiate(bullet,transform.position,transform.rotation) as GameObject;
//		instantiatedProjectile.GetComponent<Bullet> ().setDir (vecDir);
//		//instantiatedProjectile.GetComponent<Rigidbody>().AddForce(this.transform.forward*10f);
////		instantiatedProjectile.transform.position = transform.position;
////		instantiatedProjectile.transform.rotation = transform.rotation;
////		instantiatedProjectile.rigidbody.AddForce (transform.forward * 200f);
//		//instantiatedProjectile.gameObject.transform.Translate (this.transform.forward);
//		//instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,5f));
//	
//	}
}
