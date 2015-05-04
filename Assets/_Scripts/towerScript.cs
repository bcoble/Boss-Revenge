using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class towerScript : MonoBehaviour {

	public Rigidbody2D bullet;
	public GameObject target;
	public int targetAquisitionDelay;
	public int bulletSpeed;
	public int count;

	// Use this for initialization
	void Start () {
		targetAquisitionDelay = 30;
		bulletSpeed = 6;
		count = 0;
		target = null;
	}
	
	// Update is called once per frame
	void Update () {
		//Transform t;
		GameObject g;
		//Rigidbody2D clone;
		
		if (Input.GetKeyDown("space")) {
	        //t = (Transform) Instantiate(bullet, transform.position, Quaternion.identity);
	        //g = t.gameObject;
	        //clone = g.GetComponent<Rigidbody2D>();

	        g = (GameObject) Instantiate(bullet, transform.position, Quaternion.identity);
	        g.tag = "Projectile";
	        g.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, g.GetComponent<Rigidbody2D>().velocity.y);


	        //clone.velocity = new Vector2(bulletSpeed, clone.velocity.y);
	    }
	    //print(count);
	    if(count < targetAquisitionDelay){
	    	count++;
	    } else {
	    	count = 0;
	    	// locate enemies
			if (target == null){ // get target
				target = getTarget();
				print("Found target");
			} else { // shoot at target
				print("Current Target " + target.tag);
				ShootProjectile(target);
				target = null;
			}
	    }
	    
	}

	// Find a target with a tag - for enemies
	GameObject getTarget(){
		//IComparer ByDistance = new DistanceComparer();
		GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
		//List list = List<GameObject>(array);

		//array.Sort(ByDistance);
		//Sort<GameObject>(array, ByDistance);
		Array.Sort(array, ByDistance);
		if(array == null || array.Length == 0){
			return null;
		} else {
			return array[0];
		}

	}

	// Shoots a projectile at a target
	void ShootProjectile(GameObject t){
		GameObject g;

		var diffX = t.transform.position.x - transform.position.x;
		var diffY = t.transform.position.y - transform.position.y;
		var angle = Mathf.Atan2(diffY, diffX);

		print("Firing");

        g = (GameObject) Instantiate(bullet, transform.position, Quaternion.identity);
        //g.transform.LookAt(t.transform);
        g.tag = "Projectile";
        g.transform.Rotate(Vector3.forward * angle);
        g.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed*diffX, bulletSpeed*diffY);
        //g.GetComponent<Rigidbody2D>().AddForce(Vector2.one * bulletSpeed);
	}

	int ByDistance(GameObject a, GameObject b){
		var dstToA = Vector2.Distance(transform.position, a.transform.position);
		var dstToB = Vector2.Distance(transform.position, b.transform.position);
		return dstToA.CompareTo(dstToB);
	}

}

//public class DistanceComparer: IComparer {
	//int IComparer.Compare(Object a, Object b){
	//	var dstToA = Vector2.Distance(transform.position, a.transform.position);
	//	var dstToB = Vector2.Distance(transform.position, b.transform.position);
	//	return dstToA.CompareTo(dstToB);
	//}
//}