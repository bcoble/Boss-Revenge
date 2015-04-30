using UnityEngine;
using System.Collections;

public class HouseScript : MonoBehaviour {
	private int healthPoints;
	private bool gameOver;
	public Rect windowRect;
	
	// Use this for initialization
	void Start () {
		healthPoints = 2;
		windowRect = new Rect (20, 20, 120, 50);
		gameOver = false;
		print ("start " + healthPoints);
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (healthPoints <= 0) {
			gameOver = true;
		}
	}
	public int getHealth(){
		return healthPoints;
	}
	
	public void healthdec(){
		healthPoints = healthPoints - 1;
	}



	//void OnGUI(){
	//	if (gameOver) {
	//		GUI.Window (0, new Rect (190, 200, 200, 60), GameOver, "Game Over");
			
	//	}
		
	//} 
	
	//void GameOver(int windowID) {
	//	if (GUI.Button (new Rect (10, 30, 80, 20), "Restart!")) {
	//		print ("restart");
	//		Application.LoadLevel(0);
	//	}
	//	if (GUI.Button (new Rect (100, 30, 80, 20), "Quit!")) {
	//		print ("quit");
	//		Application.Quit ();
	//	}
	//}
	

	
	
	
}
