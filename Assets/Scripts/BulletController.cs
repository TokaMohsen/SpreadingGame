using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
  public  float BulletSpeed=2f;
 public int bulletEect = 3;
    Rigidbody rb;
    Ray shootRay;                                   // A ray from the gun end forwards.
    RaycastHit shootHit;                            // A raycast hit to get information about what was hit.
    int shootableMask;
   // Bullet bullet;
    public string BulletTarget = "enemy";
    int TargetCurrentHealth;
    Renderer rend;
    Renderer Exprend;
     Transform ParabolicBulletTarget;
     float firingAngle = 60f;
     float gravity = 7f;
   // public AttackMode mode;
   // bool IsLinear = false;

	// Use this for initialization
	void Start ()
    {
        shootRay.direction = transform.forward;
        rb = this.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update ()
    {
       // rb.velocity=transform.forward* BulletSpeed*Time.deltaTime;
        //if(IsLinear){
            transform.Translate(Vector3.forward * BulletSpeed * Time.deltaTime, Space.Self);
       // }
       
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, out shootHit, 100f))
        {
            if (shootHit.collider.tag == BulletTarget)
            {
             
            }
            else {
               // Destroy(this.gameObject);
            
            }
            Debug.DrawRay(this.transform.position, fwd, Color.green,0);
            if (shootHit.distance<0.3f)
            {
               
                if (shootHit.collider.tag == BulletTarget)
                {
                    //explosion
					Debug.Log("hit detected ");
                   // shootHit.collider.gameObject.GetComponent<Health>().currentHealth -= bulletEect;
                  
//                    if (shootHit.collider.gameObject.GetComponent<Health>().currentHealth<=0)
//                    {
//                        //GameManager.EnemyKilled++;
//                    }
                   // this.gameObject.transform.GetChild(0).GetComponent<ParticleSystem>().Play();
                   // this.gameObject.transform.GetChild(0).gameObject.GetComponent<particleControl>().DetroyAfterTime();
                    
                    //this.gameObject.transform.GetChild(0).transform.parent = null;
              
                   // Destroy(this.gameObject);
                }
            }
            if (shootHit.distance < 0.3f)
            {
               // Destroy(this.gameObject);
            }
        }
	}

}
