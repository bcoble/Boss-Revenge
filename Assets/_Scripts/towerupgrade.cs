using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class towerupgrade : MonoBehaviour {
	public GameObject UpgradeCanvas;
	public bool wasClicked;

	Ray ray;
	RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	

	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			
			RaycastHit hitInfo = new RaycastHit();
			bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

			if (hit) 
			{
				Debug.Log("Hit " + hitInfo.transform.gameObject.name); 
				if (hitInfo.transform.gameObject.tag == "tower") //mouse click on the tower and give back true or flase.
				{ // hit =hitInfo;
					Debug.Log ("working!");
					UpgradeCanvas.SetActive(true);
					Debug.Log(UpgradeCanvas.activeInHierarchy);
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
	void view (){
		if (wasClicked) {
			UpgradeCanvas.SetActive(true);
	//		Destroy(gameObject.tag("tower");
			 
		}

	}
	public void GetTower(int towerUpgradeNumber){

	//	if (towerupgrade == 1) {
			
	//	}
	//	else if (towerupgrade == 2) {
	//	} 
	//	else {
	//	}
	}

}


