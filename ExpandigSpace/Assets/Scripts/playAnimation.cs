using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour {

    public CollisionPopup collision;
    public Animator animate;
    public AudioSource lockopen;

    void OnTriggerEnter(Collider other) {
       // if (other.CompareTag("DoorBlue"))
        //{
            if (collision.bluekey == true && other.tag == "DoorBlue")
            {
                    animate.SetTrigger("DoorCanOpen");
                    lockopen.Play();
                    collision.bluekey = false;
            }
        //}

        //if (other.CompareTag("DoorGreen"))
        //{
            if (collision.greenkey == true)
            {
                animate.SetTrigger("GreenDoorOpen");
                lockopen.Play();
                collision.greenkey = false;
            }
        //}

        //if (other.CompareTag("DoorRed"))
        //{
            if (collision.redkey == true)
            {
                animate.SetTrigger("RedDoorOpen");
                lockopen.Play();
                collision.redkey = false;
            }
        //}
            
    }
}
