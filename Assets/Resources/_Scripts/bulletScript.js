#pragma strict

// Public variable 
public var speed : int = 6;// how faste bullet move in sence 

// Gets called once when the bullet is created
function Start () {  
    // Set the Y velocity to make the bullet move upward
    //GetComponent.<Rigidbody2D>().velocity.x = speed;
}

function Update () {
	transform.Translate(Vector3.forward * speed);
}

function SpaceFire(){
    GetComponent.<Rigidbody2D>().velocity.x = speed;
}


// Gets called when the object goes out of the screen
function OnBecameInvisible() {  
    // Destroy the bullet 
    Destroy(gameObject);
}

// Function called when the enemy collides with another object
function OnTriggerEnter2D(obj : Collider2D) {  
    var name = obj.gameObject.name;

    // // If it collided with a bullet
    // if (name == "bullet(Clone)") {
    //     // Destroy itself (the enemy)
    //     Destroy(gameObject);

    //     // And destroy the bullet
    //     Destroy(obj.gameObject);
    // }

}