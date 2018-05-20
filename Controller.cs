using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private GameObject cubePrefab;
    private GameObject enemy;
	
	// Update is called once per frame
	void Update () {
		if(enemy==null)
        {
            enemy = Instantiate(cubePrefab) as GameObject;
            enemy.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 4f;
        }
	}
}
