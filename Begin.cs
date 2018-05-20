using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begin : MonoBehaviour {

	public Button button;
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TaskOnClick()
	{
		Time.timeScale = 1;
		canvas.SetActive (false);
	}
}
