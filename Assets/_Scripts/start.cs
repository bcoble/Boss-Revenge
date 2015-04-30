using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {
	public int gold;
	private GameObject house;
	private int health;
	private HouseScript healthScript;
	// Use this for initialization
	
	void Start () {
		house = GameObject.Find("House");
		healthScript = (HouseScript)house.GetComponent (typeof(HouseScript));
		health = healthScript.getHealth ();
		gold = 200;
	}
	
	// Update is called once per frame
	void Update () {
		if (healthScript.getHealth () > 0) {
			health = healthScript.getHealth ();
		} else {
			health = 0;
		}
	}
	
	void OnGUI(){
		GUI.backgroundColor = Color.black;
		GUI.Window (0, new Rect (450, 0, 200, 450), SideBarButtons, "Menu");
		if (health == 0) {
			GUI.Window (0, new Rect (190, 200, 200, 60), GameOver, "Game Over");
			
		}

	}
	
	void SideBarButtons(int windowID){
		GUI.TextField (new Rect (10, 20, 150 , 20), "Health Points " + health);
		GUI.TextField (new Rect (10, 50, 150, 20), "Gold Available " + gold);
		
		GUI.TextArea(new Rect (10, 150, 150, 200), "Information");
		
		if (GUI.Button (new Rect (60, 100, 80, 20), "Build")) {
			print("build");
		}
		
		if (GUI.Button (new Rect (60, 400, 80, 20), "Menu")) {
			print("menu");
		}
		
		
	}
	

	void GameOver(int windowID) {
		if (GUI.Button (new Rect (10, 30, 80, 20), "Restart!")) {
			print ("restart");
			Application.LoadLevel(0);
		}
		if (GUI.Button (new Rect (100, 30, 80, 20), "Quit!")) {
			print ("quit");
			Application.Quit ();
		}
	}
	
	
	
}
