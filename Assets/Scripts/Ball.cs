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
    }

    // Update is called once per frame

    void Update()
	{
		if (lifeTime > 0) {
			lifeTime -= Time.deltaTime;
			if (lifeTime <= 0) {
				Destruction ();
			}
		} else {
			//transform.RotateAround (Camera.main.transform.position, Vector3.up, 30f * Time.deltaTime);
		}

		if (transform.position.y <= -20)
		{
			Destruction();
		}
	}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.name == "destroyer")
		{
			Destruction();
		}
	}

	void Destruction()
	{
		Destroy(this.gameObject);

	}

	public void InstantiateFromThisKind(GameObject spawnPos)
	{
		for(int i =0 ;i< 3 ; i++)
		{
		Vector3 randomVec = (Random.insideUnitSphere * 2.0f) + spawnPos.transform.position;
		//randomVec = GetRandomVector(spawnPoints[randomIntTwo].transform.position);
			GeneratedObj=	Instantiate(this.gameObject, randomVec, this.transform.rotation);
			GeneratedObj.GetComponent<Ball> ().lifeTime = childLifeTime;
			GeneratedObj.GetComponent<Orbit> ().SetAtack ();
		}
	}
}
