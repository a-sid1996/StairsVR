using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRigMovement : MonoBehaviour {
    public Transform capsule;

    private Vector3 a;
    
	// Update is called once per frame
	void Update () {
        a = new Vector3(0, capsule.position.y, 0) - new Vector3(0, transform.position.y, 0);
        transform.position += a;
	}
}
