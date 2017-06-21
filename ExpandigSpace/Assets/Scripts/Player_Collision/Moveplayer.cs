using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour {
    public int speed;
    private int maxSpeed;
    private float accelspeed;

    private Rigidbody _rigidbody;
    private Vector3 _inputDirection;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        _inputDirection = new Vector3(x, 0, z);
    }

    void FixedUpdate()
    {
        if(speed != maxSpeed)
        {

            _rigidbody.AddForce(_inputDirection * (speed * accelspeed));
        }

        
        
    }
}
