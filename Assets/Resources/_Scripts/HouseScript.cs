using UnityEngine;
using System.Collections;

public class HouseScript : MonoBehaviour {
	private int healthPoints;

	// Use this for initialization
	void Start () {
		healthPoints = 20;
		
	}
	// Update is called once per frame
	void Update () {

	}
	public int getHealth(){
		return healthPoints;
	}
	
	public void healthdec(){
		healthPoints = healthPoints - 1;
	}

}
