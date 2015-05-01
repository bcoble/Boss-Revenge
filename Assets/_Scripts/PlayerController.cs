using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	private Rigidbody rb;
	public GameObject player;
	public GameObject player1=null;
	//public float speed;
	private float moveHorizontal;
	private float moveVertical;
	private float yAxis;
	private Vector3 movement;
	private bool alive;
	private int t;
	private GameObject house;
	private HouseScript healthScript;
	private bool atHouse;
	private GameObject[] wave1;
	private GameObject[] wave2;
	private GameObject[] wave3;
	private GameObject[] wave4;
	private GameObject[] wave5;
	private bool waveSelected;
	private int numOfEnemies = 10;
	
	void Start ()
	{
		waveSelected = false;
		wave1 = new GameObject[numOfEnemies];
		wave2 = new GameObject[numOfEnemies*2];
		wave3 = new GameObject[numOfEnemies*3];
		wave4 = new GameObject[numOfEnemies*4];
		wave5 = new GameObject[numOfEnemies*5];
		atHouse = true;
		house = GameObject.Find("House");
		healthScript = (HouseScript)house.GetComponent (typeof(HouseScript));
		rb = GetComponent<Rigidbody> ();
		moveHorizontal = -60;
		moveVertical = -4.5f;
		yAxis = 7;
		movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
		GetComponent<Rigidbody> ().position = movement;
		t = 0;
	}
	
	void FixedUpdate ()
	{

		movementOnPath ();
		if (t == 100) {
			addNewEnemy ();
		}
		t++;
	
	}



	void addNewEnemy(){
		
		GameObject player1 = Instantiate(GameObject.Find ("Player"), new Vector3 (-60, 7, -4.5f), transform.rotation) as GameObject;
		player1.gameObject.SetActive (true);
	}
	
	void movementOnPath ()
	{
		if (moveHorizontal < 15 && moveVertical == -4.5f) {
			//atHouse = true;
			moveHorizontal += 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("1");
		} else
		if (moveHorizontal == 15 && moveVertical > -52) {
			moveVertical -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("2");
		} else
		if (moveHorizontal < 85 && moveVertical == -52) {
			moveHorizontal += 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("3");
		} else 
		if (moveHorizontal == 85 && moveVertical > -105) {
			moveVertical -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("4");
		} else
		if (moveHorizontal > -28 && moveVertical == -105) {
			moveHorizontal -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("5");
		} else
		if (moveHorizontal == -28 && moveVertical > -150 && moveVertical != -4.5) {
			moveVertical -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("6");
		} else 
		if (moveHorizontal < 160 && moveVertical == -150) {
			moveHorizontal += 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("7");
		} else 
		if (moveHorizontal == 160 && moveVertical > -200) {
			moveVertical -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("8");
		} else
		if (moveHorizontal > 80 && moveVertical == -200) {
			moveHorizontal -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("9");
		} else 
		if (moveHorizontal == 80 && moveVertical > -230) {
			moveVertical -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("10");
		} else
		if (moveHorizontal > 20 && moveVertical == -230) {
			moveHorizontal -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("11");
		} else 
		if (moveHorizontal == 20 && moveVertical < -205) {
			moveVertical += 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("12");
		} else
		if (moveHorizontal > 0 && moveVertical == -205) {
			moveHorizontal -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
			//print ("13");
		} else {
			if(atHouse){
				healthScript.healthdec();
				atHouse = false;
			}
			moveHorizontal+= 1;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;

		}
	}
	public void waveSelector(int wave){
		waveSelected = true;
		if (wave == 1) {
			print ("wave 1");
			play (wave1,numOfEnemies * wave);
		}else if(wave == 2){
			print ("wave 1 and 2");
			play (wave2,numOfEnemies * wave);
		}else if(wave == 3){
			print ("wave 1 and 2 and 3");
			play (wave3,numOfEnemies * wave);
		}else if(wave == 4){
			print ("wave 1 and 2 and 3 and 4");
			play (wave4,numOfEnemies * wave);
		}else if(wave == 5){
			print ("wave 1 and 2 and 3 and 4 and 5");
			play (wave5,numOfEnemies * wave);
		}
	
	}
	void play(GameObject[] wave,int numberOfEnemies){
		if (waveSelected) {
			GameObject selector;
			for (int i = 0; i < numberOfEnemies; i++) {
				GameObject go = Instantiate(GameObject.Find ("Player"), new Vector3 (-60, 7, -4.5f), transform.rotation) as GameObject;
				wave [i] = go;
				wave[i].gameObject.SetActive (true);
				movementOnPath();
				wave[i].transform.position = new Vector3 (moveHorizontal, yAxis, moveVertical);
			}

		}
	}
	
}
