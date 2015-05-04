#pragma strict

function Start () {

}

function Update () {

}

// Function called when the enemy collides with another object
function OnTriggerEnter2D(obj : Collider2D) {  
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