using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
    public float speed = 3.0f;
    public float obstacleRange = 2.0f;
    public float lookAtDistance = 5.0f;

    private float playerDistance;

    Renderer myRend;
    public GameObject playerObject;

	// Use this for initialization
	void Start () {
        myRend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed * Time.deltaTime);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.SphereCast (ray, 0.75f, out hit))
        {
            if (hit.distance < obstacleRange && hit.transform.gameObject.name != "Player")
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }

        playerDistance = Vector3.Distance(playerObject.transform.position, transform.position);
        if(playerDistance < lookAtDistance)
        {
            myRend.material.color = Color.red;
            LookAtPlayer();
        } else
        {
            myRend.material.color = Color.white;
        }
	}

    void LookAtPlayer()
    {
        Quaternion rot = Quaternion.LookRotation(playerObject.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, speed * Time.deltaTime);
    }
}
