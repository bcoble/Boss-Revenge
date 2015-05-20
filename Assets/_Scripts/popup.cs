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
		if (buttonName < 3) {

			hp.text = "Hp: 100";
			speed.text = "Moving Speed: 4";
			Update ();
		}
		else if (buttonName > 3 && buttonName < 6) {
			
			hp.text = "Hp: 200";
			speed.text = "Moving Speed: 4";
			Update ();
		} else {
			hp.text = "Hp: 300";
			speed.text = "Moving Speed: 6";
			Update ();
		}
	}
}
