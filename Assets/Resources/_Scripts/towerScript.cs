using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class towerScript : MonoBehaviour {
	
	public GameObject bullet;
	public GameObject target;
	public int targetAquisitionDelay;
	public int bulletSpeed;
	public int count;
	
	// Use this for initialization
	void Start () {
		targetAquisitionDelay = 30;
		bulletSpeed = 10;
		count = 0;
		target = null;
	}
	
	// Update is called once per frame
	void Update () {
		//Transform t;
		GameObject g;
		//Rigidbody2D clone;
		
		
		//print(count);
		if(count < targetAquisitionDelay){
			count++;
		} else {
			count = 0;
			// locate enemies
			if (target == null){ // get target
				target = getTarget();
				//print("Found target");
			} else { // shoot at target
				//print("Current Target " + target.tag);
				// check if target is too far away - TODO
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
		
		//var diffX = t.transform.position.x - transform.position.x;
		//var diffY = t.transform.position.y - transform.position.y;
		//var diffZ = t.transform.position.z - transform.position.z;
		
		//var angle = Mathf.Atan2(diffZ, diffX);
		
		//print("Firing");
		//print(diffZ);
		//print(diffY);
		GameObject g;
		
		g = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
		
		g.tag = "Projectile";
		
		g.transform.rotation = Quaternion.Euler(90, 0, 0);
		g.transform.LookAt(t.transform);
		
		//g.transform.Rotate(Vector3.forward * angle); //- fix this
		g.GetComponent<Rigidbody>().transform.Translate(Vector3.forward * bulletSpeed);
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