using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class popup : MonoBehaviour {
	public GameObject optionsCanvas;
	public Text hp;
	public Text Damage;
	public Text Amor;
	public Text resist;
	public Text speed;
	public Image image;
	int number;

	// Use this for initialization
	void Start () {
	
	}


	void Update(){


	}
	// Update is called once per frame
	public void Option () {
		optionsCanvas.SetActive (!optionsCanvas.activeInHierarchy);

	}
	public void GetButton(int buttonName){

		hp.text= "Hp: ";
		Damage.text= "Damage: "  + buttonName;
		Amor.text= "Amor: "  + buttonName;
		resist.text= "Resist: "  + buttonName;
		speed.text= "Speed: "  + buttonName;
		Update ();

	}
}
