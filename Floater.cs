using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour {

    [SerializeField] private float fMultiplier = 15f;

    void OnTriggerStay(Collider col)
    {
      if (col.gameObject.name.Contains ("Enemy"))
        {
            col.attachedRigidbody.AddForce(Vector3.up * fMultiplier, ForceMode.Acceleration);
        }
    }
}
