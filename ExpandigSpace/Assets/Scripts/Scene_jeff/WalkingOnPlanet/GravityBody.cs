using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour {
    public PlayerController player;
    public GravityAttractor attractor;
    private Transform myTransform;
    private GameObject target;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gravity")
        {
            attractor.gravity = 10;
        }

        if (other.tag == "SpeedBoost")
        {
            player.maxSpeed = 30;
            player.moveSpeedcurrent *= 1.3f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Gravity")
        {
            attractor.gravity = -3;
        }

        if (other.tag == "SpeedBoost")
        {
            player.maxSpeed = 15;
        }
    }

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
