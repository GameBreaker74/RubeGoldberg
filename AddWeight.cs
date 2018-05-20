using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddWeight : MonoBehaviour {

    public float mass;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            rb = GetComponent<Rigidbody>();
            rb.mass = mass;
        }
    }
}
