using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlanet : MonoBehaviour
{

    [SerializeField]
    private float Xspeed;
    [SerializeField]
    private float Zspeed;
   
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-Xspeed, 0, 0));
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(Xspeed, 0, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, Zspeed));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, -Zspeed));
        }
    }
}
