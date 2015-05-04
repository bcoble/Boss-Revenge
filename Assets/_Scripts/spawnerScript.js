#pragma strict
// Variable to store the enemy prefab
public var enemy : GameObject;
enemy.tag = "Enemy";

// Variable to know how fast we should create new enemies
public var spawnTime : float = 1;

function Start() {  
    // Call the 'addEnemy' function every 'spawnTime' seconds
    InvokeRepeating("addEnemy", spawnTime, spawnTime);
}

// New function to spawn an enemy
function addEnemy() {  
    // Variables to store the X position of the spawn object
    // See image below
    var y1 = transform.position.y - GetComponent.<Renderer>().bounds.size.y/2;
    var y2 = transform.position.y + GetComponent.<Renderer>().bounds.size.y/2;

    // Randomly pick a point within the spawn object
    var spawnPoint = new Vector2(transform.position.x-.5, Random.Range(y1, y2));

    // Create an enemy at the 'spawnPoint' position
    Instantiate(enemy, spawnPoint, Quaternion.identity);
}

function Update () {

}