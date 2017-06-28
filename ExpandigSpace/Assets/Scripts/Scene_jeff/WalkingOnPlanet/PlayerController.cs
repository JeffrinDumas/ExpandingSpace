using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    [SerializeField]
    private float Yspeed;
 
    float rotX;
    float rotY;

    float x;
    float z;



    float SpeederX;
    float SpeederZ;


    //private int minSpeed = 2;
    public float inputwaarde = 0;
    public float moveSpeed;
    public float moveSpeedforward = 0.05f;
    public float moveSpeedbackward = 0.05f;
    public int maxSpeed = 15;
    private float decreasefactor = 0.96f;
    public float cooldownforward = 0;
    public float cooldownbackward = 0;
    public float moveSpeedcurrent;
    public float moveSpeedcurrent2;
    private Vector3 moveDir;
	// Use this for initialization
	void Start () {
        moveSpeed = 0.05f;
    }
	
	// Update is called once per frame
	void Update () {/*

        if(moveSpeedforward <= 0){
        moveSpeedbackward += 0.5f;
        moveSpeed += 0.5f;
        } else if(moveSpeedbackward <= 0){
        moveSpeedforward += 0.5f;
        moveSpeed += 0.5f;
        } else{

        }
        */

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) && cooldownforward == 0)
            {
                if(!(moveSpeedcurrent2 >= maxSpeed))
                { 
                    moveSpeedcurrent2 += moveSpeedforward;
                }

                if (cooldownbackward == 0)
                {
                    cooldownforward = 2;
                    inputwaarde = 1;
                }
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow) && cooldownbackward == 0)
            {
                if (!(moveSpeedcurrent2 >= maxSpeed))
                {
                    moveSpeedcurrent2 += moveSpeedbackward;
                }

                if (cooldownforward == 0)
                {
                    cooldownbackward = 2;
                    inputwaarde = -1;
                }                
            }
            moveSpeedcurrent += moveSpeed;
            if(moveSpeedcurrent >= maxSpeed)
            {
                moveSpeedcurrent = maxSpeed;
            }
            
        }
        else
        { 
            if(cooldownbackward > 0) {
                cooldownbackward -= 0.1f;
            }
            if (cooldownbackward < 0)
            {
                cooldownbackward = 0;
            }
            if (cooldownforward > 0)
            {
                cooldownforward -= 0.1f;
            }
            if(cooldownforward < 0)
            {
                cooldownforward = 0;
            }
            inputwaarde *= decreasefactor;
            moveSpeedcurrent *= decreasefactor;
            if (moveSpeedcurrent >= -moveSpeed && moveSpeedcurrent <= moveSpeed)
            {
                moveSpeedcurrent = 0;
            }
            if(inputwaarde >= -0.1 && inputwaarde <= 0.1)
            {
                inputwaarde = 0;
            }
        }
        moveDir = new Vector3(0, 0, inputwaarde);

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
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir * moveSpeedcurrent * Time.deltaTime));
    }
}
