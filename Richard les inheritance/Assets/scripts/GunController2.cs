using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController2 : MonoBehaviour
{
    [SerializeField]
    private Gun2 gun2;
     

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            gun2.Shoot();
        } 
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            gun2.Reload();
        }

    }
}
