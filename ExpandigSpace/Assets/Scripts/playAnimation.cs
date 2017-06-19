using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour {

    public CollisionPopup collision;
    public Animator animate;

    void OnTriggerEnter(Collider other) { 
		if(collision.bluekey == true)
        {
            animate.SetTrigger("DoorCanOpen");
        }
        if (collision.greenkey == true)
        {
            animate.SetTrigger("GreenDoorOpen");
        }
        if (collision.redkey == true)
        {
            animate.SetTrigger("RedDoorOpen");
        }
    }
}
