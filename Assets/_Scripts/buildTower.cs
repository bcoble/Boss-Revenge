using UnityEngine;
using System.Collections;

public class buildTower : MonoBehaviour {
	public GameObject prefab;
	public bool build;
	Ray ray;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast (ray, out hit)&&build) {
			if (Input.GetKey(KeyCode.Mouse0))
			{
				GameObject obj =Instantiate(prefab,new Vector3( hit.point.x,hit.point.y,hit.point.z),Quaternion.Euler(90,0,0)) as GameObject;
				obj.SetActive(true);
				build=false;
			}
		}
	}
	public void buildTB(){
		build = true;
	}




}
