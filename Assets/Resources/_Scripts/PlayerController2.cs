using UnityEngine;
using System.Collections;

public class PlayerController2 : MonoBehaviour
{
	public GameObject enemy;
	public GameObject enemy2;
	private bool waveSelected;
	private int numOfEnemies = 10;
	private bool wave1;
	private bool wave2;
	private bool wave3;
	private bool wave4;
	private bool wave5;
	public bool finalWaveCompleted;
	private int totalEnemies;
	
	
	
	
	public void Start ()
	{
		totalEnemies = 150;
		waveSelected = false;
		wave1 = false;
		wave2 = false;
		wave3 = false;
		wave4 = false;
		wave5 = false;
		finalWaveCompleted = false;
		
		
		
	}
	
	void Update ()
	{
		checkingEnemies ();	
	}
	
	
	
	IEnumerator addNewEnemy(){
		
		GameObject e = Instantiate (enemy, transform.position, transform.rotation) as GameObject;
		e.gameObject.SetActive (true);
		e.transform.rotation = Quaternion.Euler(90, 0, 0);
		yield return new WaitForSeconds(2);
		GameObject e2 = Instantiate (enemy2, transform.position, transform.rotation) as GameObject;
		e2.gameObject.SetActive (true);
		e2.transform.rotation = Quaternion.Euler(90, 0, 0);
		
	}
	
	
	public void waveSelector(int wave){
		waveSelected = true;
		
		if (wave == 1 && !wave1) {
			wave1 = true;
			
			StartCoroutine (play (1 * numOfEnemies));
		} else if (wave == 2 && !wave2) {
			
			if (!wave1) {
				StartCoroutine (play (2 * numOfEnemies));
			} else {
				StartCoroutine (play (1 * numOfEnemies));
			}
			wave1 = true;
			wave2 = true;
		} else if (wave == 3 && !wave3) {
			
			if (!wave1) {
				StartCoroutine (play (3 * numOfEnemies));
			} else if (!wave2) {
				StartCoroutine (play (2 * numOfEnemies));
			} else {
				StartCoroutine (play (1 * numOfEnemies));
			}
			wave1 = true;
			wave2 = true;
			wave3 = true;
		} else if (wave == 4 && !wave4) {
			
			if (!wave1) {
				StartCoroutine (play (4 * numOfEnemies));
			} else if (!wave2) {
				StartCoroutine (play (3 * numOfEnemies));
			} else if (!wave3) {
				StartCoroutine (play (2 * numOfEnemies));
			} else {
				StartCoroutine (play (1 * numOfEnemies));
			}
			wave4 = true;
			wave1 = true;
			wave2 = true;
			wave3 = true;
		} else if (wave == 5 && !wave5) {
			if (!wave1) {
				StartCoroutine (play (5 * numOfEnemies));
			} else if (!wave2) {
				StartCoroutine (play (4 * numOfEnemies));
			} else if (!wave3) {
				StartCoroutine (play (3 * numOfEnemies));
			} else if (!wave4) {
				StartCoroutine (play (2 * numOfEnemies));
			} else {
				StartCoroutine (play (1 * numOfEnemies));
			}
			wave5 = true;
			wave4 = true;
			wave1 = true;
			wave2 = true;
			wave3 = true;
		}
		
		
	}
	IEnumerator play(int numberOfEnemies){
		if (waveSelected) {
			for (int i = 0; i < numberOfEnemies; i++) {
				StartCoroutine(addNewEnemy());
				yield return new WaitForSeconds(5);
			}
			
		}
	}
	public void deleteEnemy(){
		totalEnemies -= 1;
	}
	void checkingEnemies(){
		if (totalEnemies == 0) {
			finalWaveCompleted = true;
		}
	}
	void OnTriggerEnter(Collider obj){
		var name = obj.gameObject.name;
		var tag = obj.gameObject.tag;
		if (tag == "Projectile") {
			Destroy(gameObject);
			Destroy(obj.gameObject);
		}
	}
}
