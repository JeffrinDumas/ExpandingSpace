using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour {

    public GravityAttractor attractor;
    private Transform myTransform;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;
        myTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        attractor.Attract(myTransform);
	}
}
