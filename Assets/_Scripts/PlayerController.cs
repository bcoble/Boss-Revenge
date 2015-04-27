using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	private Rigidbody rb;
	public GameObject player;
	//public float speed;
	private float moveHorizontal;
	private float moveVertical;
	private float yAxis;
	private Vector3 movement;
	//private bool alive;
	private int t;
	//private int numOfEnemies = 5;

	void Start ()
	{
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
		player = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		player.transform.position = new Vector3 (-60, 7, -4.5f);
		player.AddComponent<Rigidbody> ();
		player.AddComponent<PlayerController> ();
		player.transform.localScale = new Vector3 (10, 10, 10);
		player.gameObject.SetActive (true);
	}

	void movementOnPath ()
	{
		if (moveHorizontal < 15 && moveVertical == -4.5f) {
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
			moveHorizontal+= 1;
			movement = new Vector3 (moveHorizontal, yAxis, moveVertical);
			GetComponent<Rigidbody> ().position = movement;
		}
	}

}
