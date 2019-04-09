using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour {

    public Transform camera;

    public float x;
    private Vector3 a = new Vector3(0,0,-0.1f);

	// Use this for initialization
	void Start () {

        x = camera.position.y;

    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(camera.position.x, transform.position.y, camera.position.z);
    }
}
