using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

    void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }

        Destroy(gameObject);
	}
}
