using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {
	public int gold;
	// Use this for initialization

	void Start () {
		gold = 200;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Window (0, new Rect (300, 0, 200, 400), SideBarButtons, "Menu");
	}

	void SideBarButtons(int windowID){
		if (GUI.Button (new Rect (10, 30, 80, 20), "Menu")) {
			print("menu");
		}
		
	}





}
