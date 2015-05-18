using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {
	public GameObject loadingImage;

	public void LoadScene(int Scene) 
	{	
//		loadingImage.SetActive (true);
		Application.LoadLevel (Scene);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
