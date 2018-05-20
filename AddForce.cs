using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour {

    public float forceApplied = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision col)
    {
       if (col.gameObject.tag == "Enemy")
        {
            GetComponent<Rigidbody>().AddForce(0, 0, forceApplied);
        }
    }
}
