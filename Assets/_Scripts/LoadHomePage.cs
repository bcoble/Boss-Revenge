using UnityEngine;
using System.Collections;

public class LoadHomePage : MonoBehaviour {
	public GameObject loadingImage;
	
	public void LoadScene(int Scene) 
	{	
	
			loadingImage.SetActive (true);
			Application.LoadLevel (Scene);
	}
	public void StopAllCoroutines(){
		Application.Quit ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
