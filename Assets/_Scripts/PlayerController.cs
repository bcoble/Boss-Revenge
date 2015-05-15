using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	//private Rigidbody rb;
	//public GameObject enemy;
	public GameObject player1 = null;
	//public float speed;
	private float moveHorizontal;
	private float moveVertical;
	private float yAxis;
	private Vector3 movement;
	private bool alive;
	//private int t;
	private GameObject house;
	private HouseScript healthScript;
	private bool atHouse;
	private ArrayList enemies;
	public bool waveSelected;
	private int numOfEnemies = 10;
	private bool wave1;
	private bool wave2;
	private bool wave3;
	private bool wave4;
	private bool wave5;
	public bool finalWaveCompleted;
	private int totalEnemies;
	
	void Start ()
	{
		totalEnemies = 50;
		waveSelected = false;
		enemies = new ArrayList ();
		atHouse = true;
		house = GameObject.Find("House");
		healthScript = (HouseScript)house.GetComponent (typeof(HouseScript));
		//rb = GetComponent<Rigidbody> ();
		moveHorizontal = -60;
		moveVertical = -4.5f;
		yAxis = 7;
		movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
		GetComponent<Rigidbody> ().position = movement;
		wave1 = false;
		wave2 = false;
		wave3 = false;
		wave4 = false;
		wave5 = false;
		finalWaveCompleted = false;
	}
	
	void FixedUpdate ()
	{

		movementOnPath ();
		checkingEnemies ();

	
	}



	GameObject addNewEnemy(){

		GameObject player1 = Instantiate(GameObject.Find ("Player"), new Vector3 (-60, 7, -4.5f), transform.rotation) as GameObject;
		player1.gameObject.SetActive (true);
		//yield return new WaitForSeconds(10);
		return player1;
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
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;
			//print ("4");
		} else
		if (moveHorizontal > -28 && moveVertical == -105) {
			moveHorizontal -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			//enemy.GetComponent<Rigidbody> ().position = movement;
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
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;
			//print ("7");
		} else 
		if (moveHorizontal == 160 && moveVertical > -200) {
			moveVertical -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;
			//print ("8");
		} else
		if (moveHorizontal > 80 && moveVertical == -200) {
			moveHorizontal -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;
			//print ("9");
		} else 
		if (moveHorizontal == 80 && moveVertical > -230) {
			moveVertical -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;
			//print ("10");
		} else
		if (moveHorizontal > 20 && moveVertical == -230) {
			moveHorizontal -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;
			//print ("11");
		} else 
		if (moveHorizontal == 20 && moveVertical < -205) {
			moveVertical += 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;
			//print ("12");
		} else
		if (moveHorizontal > 0 && moveVertical == -205) {
			moveHorizontal -= 0.5f;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;
			//print ("13");
		} else {
			if(atHouse){
				healthScript.healthdec();
				atHouse = false;
			}
			moveHorizontal+= 1;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			//enemy.GetComponent<Rigidbody> ().position = movement;
			GetComponent<Rigidbody> ().position = movement;

		}
	}
	public void waveSelector(int wave){
		waveSelected = true;
		if (wave == 1 && !wave1) {
			print ("wave 1");
			StartCoroutine( play(1*numOfEnemies));
		}else if(wave == 2 && !wave2){
			print ("wave 1 and 2");
			if(!wave1){
				StartCoroutine( play (2*numOfEnemies));
			}else{
				StartCoroutine( play (1*numOfEnemies));
			}
		}else if(wave == 3 && !wave3){
			print ("wave 1 and 2 and 3");
			if(!wave1){
				StartCoroutine( play (3*numOfEnemies));
			}else if(!wave1 && !wave2){
				StartCoroutine( play (2*numOfEnemies));
			}else{
				StartCoroutine( play (1*numOfEnemies));
			}
			//play (3*numOfEnemies);
		}else if(wave == 4 && !wave4){
			print ("wave 1 and 2 and 3 and 4");
			if(!wave1){
				StartCoroutine( play (4*numOfEnemies));
			}else if(!wave1 && !wave2){
				StartCoroutine( play (3*numOfEnemies));
			}else if(!wave1 && !wave2 && !wave3){
				StartCoroutine( play(2*numOfEnemies));
			}else{
				StartCoroutine( play (1*numOfEnemies));
			}
			//play (4*numOfEnemies);
		}else if(wave == 5 && !wave5){
			print ("wave 1 and 2 and 3 and 4 and 5");
			if(!wave1){
				StartCoroutine( play (5*numOfEnemies));
			}else if(!wave1 && !wave2){
				StartCoroutine( play (4*numOfEnemies));
			}else if(!wave1 && !wave2 && !wave3){
				StartCoroutine( play(3*numOfEnemies));
			}else if(!wave1 && !wave2 && !wave3 && !wave4){
				StartCoroutine( play(2*numOfEnemies));
			}else{
				StartCoroutine( play (1*numOfEnemies));
			}
		}
	
	}

	IEnumerator play(int numberOfEnemies){
		GameObject enemy;
		if (waveSelected) {
			print ("in play");
			for (int i = 0; i < numberOfEnemies; i++) {

				enemy = addNewEnemy();
				enemies.Add(enemy);
				yield return new WaitForSeconds(2);

			}

		}
	}
	public ArrayList getEnemies(){
		return enemies;
	}

	public void deleteEnemy(){
		totalEnemies -= 1;
	}
	void checkingEnemies(){
		if (numOfEnemies == 0) {
			finalWaveCompleted = true;
		}
	}

	void OnTriggerEnter(Collider obj) {
		var name = obj.gameObject.name;
	    var tag = obj.gameObject.tag;

	    // If it collided with a bullet
	    if (name == "bullet(Clone)") {
	        // Destroy itself (the enemy)
	        Destroy(gameObject);

	        // And destroy the bullet
	        Destroy(obj.gameObject);
	    }

	 	if (tag == "Projectile"){
	 		Destroy(gameObject);
	 		Destroy(obj.gameObject);
	 	}
	}
}
