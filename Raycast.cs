using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {

    // Use this for initialization

    private Camera camera;
	void Start () {
        camera = GetComponent<Camera>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Vector3 point = new Vector3(camera.pixelWidth/2, camera.pixelHeight/2, 0f);
            Vector3 point = Input.mousePosition;
            Ray ray = camera.ScreenPointToRay(point);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Hit: " + hit.collider.gameObject.name);

                GameObject hitTarget = hit.collider.gameObject;
                React target = hitTarget.GetComponent<React>();

                if (target!=null)
                {
                    target.objectHit();
                }
            }

            
        }
    }
}
