using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	public float speed = 1f;
	public GameObject t;
	private bool isTracking = false;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (this.isTracking == true && this.t == null)
			Destroy (this);
		else {
			Vector3 tPos = this.t.transform.position;
			Vector3 bPos = this.transform.position;
			float x_delta = tPos.x - bPos.x;
			float y_delta = tPos.y - bPos.y;
			float x_speed = this.speed * Mathf.Atan (x_delta / y_delta);
			float y_speed = this.speed * (Mathf.PI / 4 - Mathf.Atan (x_delta / y_delta));
			this.transform.Rotate (new Vector3 (x_delta, 0, y_delta));
			this.transform.Translate(Vector3.forward * speed);
			this.transform.Translate (new Vector3 (x_speed, 0, y_speed));
			this.transform.Rotate(new Vector3 (0,0,0));
		}
	}
	
	void SpaceFire(){
		GetComponent<Rigidbody> ().velocity = new Vector2 (this.speed, GetComponent<Rigidbody> ().velocity.y);
	}
	
	public void SetTarget(GameObject t){
		this.t = t;
		this.isTracking = true;
	}
	
	// Gets called when the object goes out of the screen
	void OnBecameInvisible() {  
		// Destroy the bullet 
		Destroy(gameObject);
	}
	
	// Function called when the enemy collides with another object
	void OnTriggerEnter2D(Collider2D obj) {  
		var name = obj.gameObject.name;
		
		// // If it collided with a bullet
		// if (name == "bullet(Clone)") {
		//     // Destroy itself (the enemy)
		//     Destroy(gameObject);
		
		//     // And destroy the bullet
		//     Destroy(obj.gameObject);
		// }
		
	}
}

