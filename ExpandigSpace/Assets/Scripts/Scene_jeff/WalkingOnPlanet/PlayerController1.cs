using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {
    
    [SerializeField]
    private float Yspeed;
 
    public float inputwaarde = 0;
    public float moveSpeed;
    public float moveSpeedforward = 0.05f;
    public float moveSpeedbackward = -0.05f;
    public int maxSpeed = 15;
    private float decreasefactor = 0.96f;
    public float moveSpeedcurrent;
    private Vector3 moveDir;

	void Start () {
        moveSpeed = 1;
    }
	
	void Update () {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                inputwaarde = 1;
                moveSpeedcurrent += moveSpeedforward;
                if(moveSpeedcurrent >= maxSpeed)
                {
                    moveSpeedcurrent = maxSpeed;
                }
                
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                inputwaarde = 1;
                moveSpeedcurrent += moveSpeedbackward;
                if (moveSpeedcurrent <= -maxSpeed)
                {
                    moveSpeedcurrent = -maxSpeed;
                }
            }
            
        }
        else
        {
            if ((!(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))) && moveSpeedcurrent == 0)
            {
                inputwaarde = 0;
            }
            moveSpeedcurrent *= decreasefactor;
            if (moveSpeedcurrent >= -moveSpeed && moveSpeedcurrent <= moveSpeed)
            {
                moveSpeedcurrent = 0;
            }
        }


        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -Mathf.Abs(Yspeed * (moveSpeedcurrent / maxSpeed)), 0));
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, Mathf.Abs(Yspeed * (moveSpeedcurrent / maxSpeed)), 0));
        }


        moveDir = new Vector3(0, 0, inputwaarde);
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir * moveSpeedcurrent * Time.deltaTime));
    }
}
