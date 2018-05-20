using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Video : MonoBehaviour {

	public Camera camera;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - camera.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = camera.transform.position + offset;
	}
}
