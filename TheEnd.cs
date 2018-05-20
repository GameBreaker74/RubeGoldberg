using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour {

	public GameObject wick;
	public GameObject canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnDestroy()
	{
		if (wick == null) {
			canvas.SetActive (true);
			Time.timeScale = 0;
		}
	}
}
