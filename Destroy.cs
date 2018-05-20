using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public GameObject floor;
 void OnTriggerEnter(Collider other)
    {
        Destroy(floor);
        Destroy(gameObject);
    }
}

