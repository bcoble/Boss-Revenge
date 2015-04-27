using UnityEngine;
using System.Collections;

public class HouseScript : MonoBehaviour {
	private int healthPoints;
	private bool gameOver;
	public Rect windowRect;
	
	// Use this for initialization
	void Start () {
		healthPoints = 100;
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
	
	void OnCollisionEnter(Collision collision) {
		print ("collision outside");
		//if(collision.gameObject.CompareTag("Enemy")){
			healthPoints -= 1;
			print ("collsion");
		//}
		
	}
	
	void OnGUI(){
		if (gameOver) {
			GUI.Window (0, new Rect (190, 200, 200, 60), GameOverButtons, "Game Over");
			
		}
		
	} 
	
	void GameOverButtons(int windowID) {
		if (GUI.Button (new Rect (10, 30, 80, 20), "Restart!")) {
			Application.LoadLevel(0);
		}
		if (GUI.Button (new Rect (100, 30, 80, 20), "Quit!")) {
			Application.Quit ();
		}
	}
	
	public int getHealth(){
		return healthPoints;
	}
	
	public void healthdec(){
		//healthPoints = healthPoints - 1;
	}
	
	
	
}
