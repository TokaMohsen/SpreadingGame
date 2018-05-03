using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float lifeTime = 10f;
    public bool inWindZone = false;
	GameObject GeneratedObj;
	float childLifeTime=5f;
   // public GameObject windZone;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
	//	rb.AddForce (transform.up*2000f);
    }

    // Update is called once per frame
//
//    void Update()
//	{
//		if (lifeTime > 0) {
//			lifeTime -= Time.deltaTime;
//			if (lifeTime <= 0) {
//				Destruction ();
//			}
//		} else {
//			//transform.RotateAround (Camera.main.transform.position, Vector3.up, 30f * Time.deltaTime);
//		}
//
//		if (transform.position.y <= -20)
//		{
//			Destruction();
//		}
//	}
//
//	void OnCollisionEnter(Collision coll)
//	{
//		if (coll.gameObject.name == "destroyer")
//		{
//			Destruction();
//		}
//	}
//
//	void Destruction()
//	{
//		Destroy(this.gameObject);
//
//	}
//
	public void InstantiateFromThisKind(GameObject spawnPos)
	{
		for(int i =0 ;i< 8; i++)
		{
			Vector3 randomVec = (Random.insideUnitCircle * 2.0f) ;//+  new Vector2 (spawnPos.transform.position.x,spawnPos.transform.position.z);
		//randomVec = GetRandomVector(spawnPoints[randomIntTwo].transform.position);
			GeneratedObj=	Instantiate(this.gameObject, this.transform.position, this.transform.rotation);
			float  RandomScale = Random.Range (0.9f,2.0f);
			//GeneratedObj.GetComponent<Orbit>().enabled=false;

			GeneratedObj.gameObject.transform.localScale = new Vector3 (RandomScale,RandomScale,RandomScale);
			//GeneratedObj.gameObject.GetComponent<Rigidbody> ().AddForce (transform.up*2000f);
			GeneratedObj.GetComponent<Ball> ().lifeTime = childLifeTime;
			GeneratedObj.GetComponent<Orbit> ().SetAtack ();
		}
	}
}
