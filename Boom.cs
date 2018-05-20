using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {

	public GameObject explode;
	public GameObject implode;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Torch") 
		{
			Destroy (explode);
			Destroy (implode);
			Destroy (gameObject);
		}
	}
}
