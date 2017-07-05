using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour {

    public CollisionPopup collision;
    public Animator animate;
    public AudioSource lockopen;
    private int greenDoorCounter = 0;
    private int blueDoorCounter = 0;
    private int redDoorCounter = 0;

    void OnTriggerEnter(Collider other) {
        if(blueDoorCounter == 0)
        {
            if (collision.bluekey == true)
            {
                animate.SetTrigger("DoorCanOpen");
                lockopen.Play();
                blueDoorCounter++;
            }
        }
        if (greenDoorCounter == 0)
        {
            if (collision.greenkey == true)
            {
                animate.SetTrigger("GreenDoorOpen");
                lockopen.Play();
                greenDoorCounter++;
            }
        }
        if (redDoorCounter == 0)
        {
            if (collision.redkey == true) { 
                animate.SetTrigger("RedDoorOpen");
                lockopen.Play();
                redDoorCounter++;
            }
        }
            
    }
}
