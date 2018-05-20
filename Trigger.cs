using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

    // Use this for initialization
   void OnTriggerExit(Collider col)
    {
        Destroy(col.gameObject);
    }
}
