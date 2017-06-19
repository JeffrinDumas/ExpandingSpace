using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
    [SerializeField]
    private Gun gun;

    void Start()
    {
        gun.clipSize = 12;
        gun.currentAmmo = gun.clipSize;
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(gun.currentAmmo != 0) { 
                gun.Shoot();
                Debug.Log(gun.currentAmmo);
            }
            else
            {
                Debug.Log("Out of Ammo");
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            gun.Reload();
            Debug.Log(gun.currentAmmo);
        }
       
	}
}
