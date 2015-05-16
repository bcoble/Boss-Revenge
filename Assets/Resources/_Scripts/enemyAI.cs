using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {
	public GameObject enemy = null;
	public GameObject way1;
	public GameObject way2;
	public GameObject way3;
	public GameObject way4;
	public GameObject way5;
	public GameObject way6;
	public GameObject way7;
	public GameObject way8;
	public GameObject way9;
	public GameObject way10;
	public GameObject way11;
	public GameObject way12;
	public GameObject way13;
	public State state;
	public float time;
	public float rotationSpeed;
	public float moveSpeed;
	private GameObject house;
	private HouseScript healthScript;
	private float x;
	private float y;
	private float z;



	public enum State{
		Idle,
		Way1,
		Way2,
		Way3,
		Way4,
		Way5,
		Way6,
		Way7,
		Way8,
		Way9,
		Way10,
		Way11,
		Way12,
		Way13
	}
	// Use this for initialization
	void Start () {
		house = GameObject.Find("House");
		healthScript = (HouseScript)house.GetComponent (typeof(HouseScript));
		state = State.Way1;
		x = -65;
		y = 2;
		z = -4.5f;

	}
	
	// Update is called once per frame
	void Update () {
		switch (state) {
		case State.Idle:
			Idle();
			break;
		case State.Way1:
			Way1();
			break;
		case State.Way2:
			Way2();
			break;
		case State.Way3:
			Way3();
			break;
		case State.Way4:
			Way4();
			break;
		case State.Way5:
			Way5();
			break;
		case State.Way6:
			Way6();
			break;
		case State.Way7:
			Way7();
			break;
		case State.Way8:
			Way8();
			break;
		case State.Way9:
			Way9();
			break;
		case State.Way10:
			Way10();
			break;
		case State.Way11:
			Way11();
			break;
		case State.Way12:
			Way12();
			break;
		case State.Way13:
			Way13();
			break;
			
		}

	
	}
	void Idle(){
		healthScript.healthdec();
		DestroyImmediate(enemy);
	}
	void Way1(){
	
		float distance = Vector3.Distance(enemy.transform.position, way1.transform.position);
		x++;
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <= 5) {
			state = State.Way2;
		}
	}
	void Way2(){
		float distance = Vector3.Distance(enemy.transform.position, way2.transform.position);
		z--;
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=4) {
			state = State.Way3;
		}
	}
	void Way3(){
		float distance = Vector3.Distance(enemy.transform.position, way3.transform.position);
		x++;
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way4;
		}
	}
	void Way4(){
		float distance = Vector3.Distance(enemy.transform.position, way4.transform.position);
		z--;
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way5;
		}
	}void Way5(){
		float distance = Vector3.Distance(enemy.transform.position, way5.transform.position);
		x--; 
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way6;
		}
	}void Way6(){
		float distance = Vector3.Distance(enemy.transform.position, way6.transform.position);
		z--;
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way7;
		}
	}void Way7(){
		float distance = Vector3.Distance(enemy.transform.position, way7.transform.position);
		x++; 
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way8;
		}
	}void Way8(){
		float distance = Vector3.Distance(enemy.transform.position, way8.transform.position);
		z--;
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way9;
		}
	}void Way9(){
		float distance = Vector3.Distance(enemy.transform.position, way9.transform.position);
		x--; 
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way10;
		}
	}void Way10(){
		float distance = Vector3.Distance(enemy.transform.position, way10.transform.position);
		z--;
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way11;
		}
	}void Way11(){
		float distance = Vector3.Distance(enemy.transform.position, way11.transform.position);
		x--; 
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way12;
		}
	}void Way12(){
		float distance = Vector3.Distance(enemy.transform.position, way12.transform.position);
		z++;
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		if (distance <=5) {
			state = State.Way13;
		}
	}void Way13(){
		float distance = Vector3.Distance(enemy.transform.position, way13.transform.position);
		x--; 
		enemy.GetComponent<Rigidbody> ().position = new Vector3 (x, y, z);
		print (distance);
		if (distance <= 5) {
			state = State.Idle;
		}
	}









}
