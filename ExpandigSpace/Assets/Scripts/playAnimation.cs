using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour {

    public CollisionPopup collision;
    public Animation animate;

    void OnTriggerEnter(Collider other) { 
		if(collision.bluekey == true)
        {
            animate.Play("Main");
        }
	}
}
