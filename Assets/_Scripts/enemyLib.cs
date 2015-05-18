using UnityEngine;
using System.Collections;

public class enemyLib : MonoBehaviour {
	private ArrayList  enemies = new ArrayList();

	void Start(){
		Enemy enemy1 = new Enemy (100,10,10,10,10);
		this.enemies.Add(enemy1);
		Enemy enemy2 = new Enemy (200,15,10,10,10);
		this.enemies.Add(enemy2);
		Enemy enemy3 = new Enemy (300,20,10,10,10);
		this.enemies.Add(enemy3);
		Enemy enemy4 = new Enemy (350,25,10,10,10);
		this.enemies.Add(enemy4);
		Enemy enemy5 = new Enemy (370,30,10,10,10);
		this.enemies.Add(enemy5);
		Enemy enemy6 = new Enemy (380,35,10,10,10);
		this.enemies.Add(enemy6);
		Enemy enemy7 = new Enemy (390,50,10,10,10);
		this.enemies.Add(enemy7);
		Enemy enemy8 = new Enemy (400,60,10,10,10);
		this.enemies.Add(enemy8);
		Enemy enemy9 = new Enemy (410,70,10,10,10);
		this.enemies.Add(enemy9);
		Enemy enemy10 = new Enemy (420,80,10,10,10);
		this.enemies.Add(enemy10);
	}

	void Update(){}

	public Enemy GetOneEnemy(){
		Enemy enemy = (Enemy)this.enemies[0];
		return enemy;
	}



	
	
}

