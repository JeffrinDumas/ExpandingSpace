using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float Yspeed;
 
    float rotX;
    float rotY;
    

    public float moveSpeed = 15;
    private Vector3 moveDir;
	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
      
       
    if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -Yspeed, 0));
        }

        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, Yspeed, 0));
        }

    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir * moveSpeed * Time.deltaTime));

    }
}
