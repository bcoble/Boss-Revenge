using UnityEngine;
using System.Collections;

public class Enemy {
	public int health;
	public int damage;
	public int amor;
	public int resist;
	public int movingspeed;	

	public Enemy(int hp, int dps,int ar, int rs, int ms)
	{
		health = hp;
		damage=dps;
		amor = ar;
		resist = rs;
		movingspeed = ms;
	}


}
