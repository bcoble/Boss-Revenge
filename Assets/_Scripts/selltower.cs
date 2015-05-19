using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class selltower : MonoBehaviour {
	public bool wasClicked;
	private start global;
	Ray ray;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
		this.global = GameObject.FindObjectOfType<start> ();
	}
	
	
	void Update () {
		if (Input.GetMouseButtonDown(0)&&wasClicked)
		{
			
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			
			if (hit) 
			{
				Debug.Log("Hit " + hitInfo.transform.gameObject.name); 
				if ((hitInfo.transform.gameObject.tag == "tower")||(hitInfo.transform.gameObject.tag == "TowerIce")||(hitInfo.transform.gameObject.tag == "TowerFire")||(hitInfo.transform.gameObject.tag == "TowerPoin")) //mouse click on the tower and give back true or flase.
				{ // hit =hitInfo;
					Destroy(hitInfo.transform.gameObject);
					Debug.Log ("working!");
					if (hitInfo.transform.gameObject.tag == "tower")
					{global.gold+=25;
					}
					else{
						global.gold+=50;
					}
					wasClicked=false;

				} else {
					Debug.Log ("nop");
				}
			} else {
				Debug.Log("No hit");
			}
			Debug.Log("Mouse is down");
		} 
	}
	//create new tower and delet old one using for upgrade

	public void sellT(){
		wasClicked = true;
	}
}


