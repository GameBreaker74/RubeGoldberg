using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullets : MonoBehaviour {

    // Use this for initialization
    [SerializeField] private GameObject bulletPrefab;
    private GameObject bullet;
    public GameObject crosshair;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            bullet = Instantiate(bulletPrefab, crosshair.transform.position, crosshair.transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;
            Destroy(bullet, 2.0f);
        }
	}
}
