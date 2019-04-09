using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public Transform capsule;
    
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, capsule.position.y, transform.position.z);
    }
}
