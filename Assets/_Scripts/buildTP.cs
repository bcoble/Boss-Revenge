using UnityEngine;
using System.Collections;

public class buildTP: MonoBehaviour {
	public GameObject prefab;
	public bool build;
	private start global;
	Ray ray;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
		this.global = GameObject.FindObjectOfType<start> ();
	}
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		
		if ((Physics.Raycast (ray, out hit)&&build)&&(global.gold>=100)) {
			if (Input.GetKey(KeyCode.Mouse0))
			{
				GameObject obj =Instantiate(prefab,new Vector3( hit.point.x,hit.point.y,hit.point.z),Quaternion.Euler(90,0,0)) as GameObject;
				obj.SetActive(true);
				global.gold-=100;
				build=false;
			}
		}
	}
	
	public void buildnewTP(){
		build = true;
	}
	
	
}
