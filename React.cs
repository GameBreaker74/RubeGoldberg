using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class React : MonoBehaviour {

    public Rigidbody rb;
    public float multi = 500f;

    public void objectHit()
    {
        //rb.AddForce(Camera.main.transform.forward * multi);
        Destroy(gameObject);
    }
}
