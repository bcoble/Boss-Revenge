﻿using UnityEngine;
using System.Collections;

public class start3 : MonoBehaviour {
	public  int gold;
	public static PlayerController3 playerScript;
	public PlayerController3 script;
	private GameObject house;
	private int health;
	private HouseScript healthScript;
	private GameObject player;
	private int currentLevel;
	// Use this for initialization
	
	void Start () {
		currentLevel = 0;
		house = GameObject.Find("House");
		healthScript = (HouseScript)house.GetComponent (typeof(HouseScript));
		health = healthScript.getHealth ();
		gold = 200;
		playerScript = script;
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
		//GUI.Window (0, new Rect (450, 0, 220, 100), SideBarButtons, "Menu");
		if (health == 0) {
			GUI.Window (2, new Rect (900, 400, 200, 60), GameOver, "Game Over");
			
		}
		if (playerScript.finalWaveCompleted) {
			GUI.Window (3, new Rect (900, 400, 200, 60), newLevel, "Level" +currentLevel+ " Finished");
		}
		GUI.Window (1, new Rect (500, 0, 1000, 100), WaveButtons, "Menu");
		
	}
	
	void SideBarButtons(int windowID){
		GUI.TextField (new Rect (1000, 20, 150 , 20), "Health Points " + health);
		GUI.TextField (new Rect (1000, 50, 150, 20), "Gold Available " + gold);
		
		/*	GUI.TextArea(new Rect (10, 130, 180, 250), "Information");
		
		if (GUI.Button (new Rect (60, 90, 80, 20), "Build")) {
			print("build");
		}
		
		if (GUI.Button (new Rect (60, 400, 80, 20), "Menu")) {
			print("menu");
		}
	*/	
		
	}
	
	void newLevel(int windowID){
		if (GUI.Button (new Rect (60, 30, 80, 20), "Next Level!")) {
			//print ("new level");
			currentLevel += 1;
			Application.LoadLevel("HomePage");
		}

	}
	
	void GameOver(int windowID) {
		if (GUI.Button (new Rect (10, 30, 80, 20), "Restart!")) {
			//print ("restart");
			Application.LoadLevel("HomePage");
		}
		if (GUI.Button (new Rect (100, 30, 80, 20), "Quit!")) {
			print ("quit");
			Application.Quit ();
		}
	}
	void WaveButtons(int windowID){
		if (GUI.Button (new Rect (0, 30, 80, 50), "Wave 1")) {
			//playerScript.waveSelector(1,currentLevel);
			playerScript.waveSelector(1);
		}
		if (GUI.Button (new Rect (80, 30, 80, 50), "Wave 2")) {
			//playerScript.waveSelector(2,currentLevel);
			playerScript.waveSelector(2);
		}
		if (GUI.Button (new Rect (160, 30, 80, 50), "Wave 3")) {
			//playerScript.waveSelector(3,currentLevel);
			playerScript.waveSelector(3);;
		}
		if (GUI.Button (new Rect (240, 30, 80, 50), "Wave 4")) {
			//playerScript.waveSelector(4,currentLevel);
			playerScript.waveSelector(4);
		}
		if (GUI.Button (new Rect (320, 30, 80, 50), "Wave 5")) {
			//playerScript.waveSelector(5,currentLevel);
			playerScript.waveSelector(5);
		}
		GUI.TextField (new Rect (500, 20, 150 , 20), "Health Points " + health);
		GUI.TextField (new Rect (500, 50, 150, 20), "Gold Available " + gold);
	}
	
	
}
